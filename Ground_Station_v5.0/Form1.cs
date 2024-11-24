using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using GMap.NET.MapProviders;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.FFMPEG;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using Accord.IO;

namespace Ground_Station_v5._0
{
    public partial class Form1 : Form
    {
        double pitch = 0, roll = 0, yaw = 0;
        long minm = -3, maksm = 5;
        public string Video_Adi;
        public string Username;
        public string Filename;
        public string Fullname;
        public string Server;
        public string Password;
        public string path;
        public string localdest;
        public bool start;
        public Form1()
        {
            InitializeComponent();
            AnaPort.BaudRate = 9600;
            AnaPort.PortName = "COM28";
            // XBee için COM parametresi
            /*AnaPort.DataBits = 8;
            AnaPort.Parity = Parity.None;
            AnaPort.StopBits = StopBits.One;*/
            telemetri1.Visible = false;
            grafikler1.Visible = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            /*using (StreamWriter writer = System.IO.File.AppendText("C:\\Users\\MONSTER\Desktop\\B-Dispate\\TMUY2023_160269_TLM.csv"))
            {
                writer.WriteLine("PAKET NUMARASI;UYDU STATUSU;HATA KODU;GONDERME SAATI;BASINC1;BASINC2;YUKSEKLIK1;YUKSEKLIK2;IRTIFA FARKI;INIS HIZI;SICAKLIK;PIL GERILIMI;GPS1 LATITUDE;GPS1 LONGITUDE;GPS1 ALTITUDE;PITCH;ROLL;YAW;TAKIM NO");
            }*/
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        VideoFileWriter videoFileWriter;
        private bool kayıt;

        private void butStart_Click(object sender, EventArgs e)
        {
            start = true;
            butStart.Enabled = false;
            butStop.Enabled = true;
            comboBox1.Visible = false;

            if (AnaPort.IsOpen == false)
            {
                AnaPort.Open();
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            var dialog = new SaveFileDialog();
            dialog.FileName = "TMUY2023_160269_VIDEO";
            dialog.DefaultExt = ".avi";
            dialog.AddExtension = true;
            var dialogresult = dialog.ShowDialog();
            if (dialogresult == 0)
            {
                return;
            }
            firstframe = null;
            videoFileWriter = new VideoFileWriter();
            videoFileWriter.Open(dialog.FileName, (int)Math.Round(640.0, 0), (int)Math.Round(480.0, 0));
            kayıt = true;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (kayıt)
            {
                if (firstframe != null)
                {
                    videoFileWriter.WriteVideoFrame(eventArgs.Frame, DateTime.Now - firstframe.Value);
                }
                else
                {
                    videoFileWriter.WriteVideoFrame(eventArgs.Frame);
                    firstframe = DateTime.Now;
                }
            }
            CanliVideo.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            start = false;
            butStart.Enabled = true;
            butStop.Enabled = false;

            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Upload Method.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(Username, Password);
            Stream ftpstream = request.GetRequestStream();
            FileStream fs = File.OpenRead(Fullname);

            // Method to calculate and show the progress.
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;
            do
            {
                byteRead = fs.Read(buffer, 0, 1024);
                ftpstream.Write(buffer, 0, byteRead);
                read += (double)byteRead;
                double percentage = read / total * 100;
                backgroundWorker1.ReportProgress((int)percentage);
            }
            while (byteRead != 0);
            fs.Close();
            ftpstream.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labVideo.Text = $"%{e.ProgressPercentage}";
            labVideo.Update();
            VideoBar.Value = e.ProgressPercentage;
            VideoBar.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labUP.Text = "Video Yüklendi!";
            labUP.Visible = false;
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            float step = 1.0f;
            float topla = step;
            float radius = 5.0f;
            float dikey1 = radius, dikey2 = -radius;

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
            Matrix4 lookat = Matrix4.LookAt(25, 0, 0, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            GL.Rotate(pitch, 1.0, 0.0, 0.0); //ONEHLÍ
            GL.Rotate(roll, 0.0, 1.0, 0.0);
            GL.Rotate(yaw, 0.0, 0.0, 1.0);

            silindir(step, topla, radius, 3, -5);
            koni(0.01f, 0.01f, radius, 3.0f, 3, 5);
            koni(0.01f, 0.01f, radius, 2.0f, -5.0f, -10.0f);

            GL.End();
            glControl1.SwapBuffers();
        }

        private void butAnaEkran_Click(object sender, EventArgs e)
        {
            telemetri1.Visible = false;
            grafikler1.Visible = false;
            butAnaEkran.BackColor = Color.Navy;
            butAnaEkran.ForeColor = Color.Snow;
            butTelemetri.BackColor = Color.Snow;
            butTelemetri.ForeColor = Color.Black;
            butGrafikler.BackColor = Color.Snow;
            butGrafikler.ForeColor = Color.Black;
        }

        private void butGrafikler_Click(object sender, EventArgs e)
        {
            telemetri1.Visible = false;
            grafikler1.Visible = true;
            butGrafikler.BackColor = Color.Navy;
            butGrafikler.ForeColor = Color.Snow;
            butTelemetri.BackColor = Color.Snow;
            butTelemetri.ForeColor = Color.Black;
            butAnaEkran.BackColor = Color.Snow;
            butAnaEkran.ForeColor = Color.Black;
        }

        private void butTelemetri_Click(object sender, EventArgs e)
        {
            telemetri1.Visible = true;
            grafikler1.Visible = false;
            butTelemetri.BackColor = Color.Navy;
            butTelemetri.ForeColor = Color.Snow;
            butAnaEkran.BackColor = Color.Snow;
            butAnaEkran.ForeColor = Color.Black;
            butGrafikler.BackColor = Color.Snow;
            butGrafikler.ForeColor = Color.Black;
        }

        private void butVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "All Files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    Username = "bdispate";
                    Password = "bdispate";
                    Server = "ftp://192.168.1.5";
                    Filename = fi.Name;
                    Fullname = fi.FullName;
                }
            }
        }

        private void butVideoSend_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();  //the most important command to start the background worker
        }

        private void butMUY_Click(object sender, EventArgs e)
        {
            AnaPort.Write("m");
            AnaPort.DiscardOutBuffer();
        }

        private DateTime? firstframe;

        private void Form1_Load(object sender, EventArgs e)
        {
            AnaPort.DataReceived += new SerialDataReceivedEventHandler(AnaPort_DataReceived);
            GL.ClearColor(Color.Black);
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                comboBox1.Items.Add(filterInfo.Name);
            comboBox1.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void AnaPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (start == true)
            {
                string data, ARAS;
                string[] paket;
                //Portdan gelen veriyi ayrıştırma işlemi
                data = AnaPort.ReadLine();
                paket = data.Split(';');
                using (StreamWriter writer = System.IO.File.AppendText("C:\\Users\\kaan_\\OneDrive\\Masaüstü\\TMUY2023_160269_TLM.csv"))
                {
                    writer.Write(data);
                }
                telemetri1.textBox1.Text += data + "\n";

                //Grafikleri Ekrana Yazma-----------------------------------------------------
                graBasinc1.ChartAreas[0].AxisX.Minimum = minm;
                graBasinc1.ChartAreas[0].AxisX.Maximum = maksm;
                graBasinc1.ChartAreas[0].AxisX.Interval = 1;
                graBasinc1.ChartAreas[0].AxisY.Interval = 50;
                graBasinc1.ChartAreas[0].AxisY.Minimum = 900;
                graBasinc1.ChartAreas[0].AxisY.Maximum = 1200;
                graBasinc1.Series[0].Points.AddXY(((minm + maksm) / 2), paket[4]);

                graBasinc2.ChartAreas[0].AxisX.Minimum = minm;
                graBasinc2.ChartAreas[0].AxisX.Maximum = maksm;
                graBasinc2.ChartAreas[0].AxisX.Interval = 1;
                graBasinc2.ChartAreas[0].AxisY.Interval = 50;
                graBasinc2.ChartAreas[0].AxisY.Minimum = 900;
                graBasinc2.ChartAreas[0].AxisY.Maximum = 1200;
                graBasinc2.Series[0].Points.AddXY(((minm + maksm) / 2), paket[5]);

                graYukseklik1.ChartAreas[0].AxisX.Minimum = minm;
                graYukseklik1.ChartAreas[0].AxisX.Maximum = maksm;
                graYukseklik1.ChartAreas[0].AxisX.Interval = 1;
                graYukseklik1.ChartAreas[0].AxisY.Interval = 100;
                graYukseklik1.ChartAreas[0].AxisY.Minimum = 0;
                graYukseklik1.ChartAreas[0].AxisY.Maximum = 750;
                graYukseklik1.Series[0].Points.AddXY(((minm + maksm) / 2), paket[6]);

                graYukseklik2.ChartAreas[0].AxisX.Minimum = minm;
                graYukseklik2.ChartAreas[0].AxisX.Maximum = maksm;
                graYukseklik2.ChartAreas[0].AxisX.Interval = 1;
                graYukseklik2.ChartAreas[0].AxisY.Interval = 100;
                graYukseklik2.ChartAreas[0].AxisY.Minimum = 0;
                graYukseklik2.ChartAreas[0].AxisY.Maximum = 750;
                graYukseklik2.Series[0].Points.AddXY(((minm + maksm) / 2), paket[7]);

                graHiz.ChartAreas[0].AxisX.Minimum = minm;
                graHiz.ChartAreas[0].AxisX.Maximum = maksm;
                graHiz.ChartAreas[0].AxisX.Interval = 1;
                graHiz.ChartAreas[0].AxisY.Interval = 5;
                graHiz.ChartAreas[0].AxisY.Minimum = 0;
                graHiz.ChartAreas[0].AxisY.Maximum = 30;
                graHiz.Series[0].Points.AddXY(((minm + maksm) / 2), paket[9]);

                graSicaklik.ChartAreas[0].AxisX.Minimum = minm;
                graSicaklik.ChartAreas[0].AxisX.Maximum = maksm;
                graSicaklik.ChartAreas[0].AxisX.Interval = 1;
                graSicaklik.ChartAreas[0].AxisY.Interval = 10;
                graSicaklik.ChartAreas[0].AxisY.Minimum = 0;
                graSicaklik.ChartAreas[0].AxisY.Maximum = 50;
                graSicaklik.Series[0].Points.AddXY(((minm + maksm) / 2), paket[10]);
                //------------------------------------------------------------------------------

                //Telemetri Paketini Ana Ekrana Yazma--------
                labPaket.Text = paket[0];
                labUydu2.Text = paket[1];
                labUydu.Text = paket[1];
                labHata.Text = paket[2];
                ARAS = paket[2];
                labSaat.Text = paket[3];
                labBasinc1.Text = paket[4] + " Pa";
                labBasinc2.Text = paket[5] + " Pa";
                labYukseklik1.Text = paket[6] + " m";
                labYukseklik2.Text = paket[7] + " m";
                labIrtifa.Text = paket[8] + " m";
                labGorselIrtifa.Text = paket[8] + " m";
                labHiz.Text = paket[9] + " m/s";
                labSicaklik.Text = paket[10] + " °C";
                labPil.Text = paket[11] + " V";
                labPil2.Text = paket[11] + " V";

                String pil = Convert.ToString(((Convert.ToDouble(paket[11]) - 11.1) * 100) / 1.5); //Pil değeri gerekli 
                pil = pil.Substring(0, 2);
                if (Convert.ToInt32(pil) < 0)
                {
                    labPilYuzde.Text = "%0";
                    PilBar.Value = 0;
                }
                else
                { 
                labPilYuzde.Text = "%" + pil;
                PilBar.Value = Convert.ToInt32(pil);
                }

                labGPS1lat.Text = paket[12];
                labGPS1long.Text = paket[13];
                labGPS1alti.Text = paket[14] + " m";
                labPitch.Text = paket[16] + "°";
                labRoll.Text = paket[15] + "°";
                labYaw.Text = paket[17] + "°";
                labTakim.Text = paket[18];
                //--------------------------------------------

                //ARAS---------------------------------
                if (Convert.ToString(ARAS[0]) == "1")
                    ARAS1.BackColor = Color.Red;
                else
                    ARAS1.BackColor = Color.Lime;
                if (Convert.ToString(ARAS[1]) == "1")
                    ARAS2.BackColor = Color.Red;
                else
                    ARAS2.BackColor = Color.Lime;
                if (Convert.ToString(ARAS[2]) == "1")
                    ARAS3.BackColor = Color.Red;
                else
                    ARAS3.BackColor = Color.Lime;
                if (Convert.ToString(ARAS[3]) == "1")
                    ARAS4.BackColor = Color.Red;
                else
                    ARAS4.BackColor = Color.Lime;
                if (Convert.ToString(ARAS[4]) == "1")
                    ARAS5.BackColor = Color.Red;
                else
                    ARAS5.BackColor = Color.Lime;
                //---------------------------------------

                //Gyro eksen verisi--------------------
                pitch =   Convert.ToDouble(paket[15]);
                roll = -1 * Convert.ToDouble(paket[17]);
                yaw = -1 * Convert.ToDouble(paket[16]);
                glControl1.Invalidate();
                //-------------------------------------

                //GPS ---------------------------------------------------------------
                double lat, lon;

                lat = Convert.ToDouble(paket[12]);
                lon = Convert.ToDouble(paket[13]);

                Map.MapProvider = GMapProviders.GoogleMap;

                Map.Position = new GMap.NET.PointLatLng(lat, lon);
                Map.MinZoom = 5;
                Map.MaxZoom = 100;
                Map.Zoom = 17;
                //-------------------------------------------------------------------

                //Grafikleri Panele Yazma---------------------------------------------------------------------
                grafikler1.graBasinc1.ChartAreas[0].AxisX.Minimum = minm;
                grafikler1.graBasinc1.ChartAreas[0].AxisX.Maximum = maksm;
                grafikler1.graBasinc1.ChartAreas[0].AxisX.Interval = 1;
                grafikler1.graBasinc1.ChartAreas[0].AxisY.Interval = 50;
                grafikler1.graBasinc1.ChartAreas[0].AxisY.Minimum = 850;
                grafikler1.graBasinc1.ChartAreas[0].AxisY.Maximum = 1200;
                grafikler1.graBasinc1.Series[0].Points.AddXY(((minm + maksm) / 2), paket[4]);

                grafikler1.graBasinc2.ChartAreas[0].AxisX.Minimum = minm;
                grafikler1.graBasinc2.ChartAreas[0].AxisX.Maximum = maksm;
                grafikler1.graBasinc2.ChartAreas[0].AxisX.Interval = 1;
                grafikler1.graBasinc2.ChartAreas[0].AxisY.Interval = 50;
                grafikler1.graBasinc2.ChartAreas[0].AxisY.Minimum = 850;
                grafikler1.graBasinc2.ChartAreas[0].AxisY.Maximum = 1200;
                grafikler1.graBasinc2.Series[0].Points.AddXY(((minm + maksm) / 2), paket[5]);

                grafikler1.graYukseklik1.ChartAreas[0].AxisX.Minimum = minm;
                grafikler1.graYukseklik1.ChartAreas[0].AxisX.Maximum = maksm;
                grafikler1.graYukseklik1.ChartAreas[0].AxisX.Interval = 1;
                grafikler1.graYukseklik1.ChartAreas[0].AxisY.Interval = 100;
                grafikler1.graYukseklik1.ChartAreas[0].AxisY.Minimum = 0;
                grafikler1.graYukseklik1.ChartAreas[0].AxisY.Maximum = 750;
                grafikler1.graYukseklik1.Series[0].Points.AddXY(((minm + maksm) / 2), paket[6]);

                grafikler1.graYukseklik2.ChartAreas[0].AxisX.Minimum = minm;
                grafikler1.graYukseklik2.ChartAreas[0].AxisX.Maximum = maksm;
                grafikler1.graYukseklik2.ChartAreas[0].AxisX.Interval = 1;
                grafikler1.graYukseklik2.ChartAreas[0].AxisY.Interval = 100;
                grafikler1.graYukseklik2.ChartAreas[0].AxisY.Minimum = 0;
                grafikler1.graYukseklik2.ChartAreas[0].AxisY.Maximum = 750;

                grafikler1.graYukseklik2.Series[0].Points.AddXY(((minm + maksm) / 2), paket[7]);
                grafikler1.graHiz.ChartAreas[0].AxisX.Minimum = minm;
                grafikler1.graHiz.ChartAreas[0].AxisX.Maximum = maksm;
                grafikler1.graHiz.ChartAreas[0].AxisX.Interval = 1;
                grafikler1.graHiz.ChartAreas[0].AxisY.Interval = 5;
                grafikler1.graHiz.ChartAreas[0].AxisY.Minimum = 0;
                grafikler1.graHiz.ChartAreas[0].AxisY.Maximum = 30;
                grafikler1.graHiz.Series[0].Points.AddXY(((minm + maksm) / 2) + 1, paket[9]);

                grafikler1.graSicaklik.ChartAreas[0].AxisX.Minimum = minm;
                grafikler1.graSicaklik.ChartAreas[0].AxisX.Maximum = maksm;
                grafikler1.graSicaklik.ChartAreas[0].AxisX.Interval = 1;
                grafikler1.graSicaklik.ChartAreas[0].AxisY.Interval = 10;
                grafikler1.graSicaklik.ChartAreas[0].AxisY.Minimum = 0;
                grafikler1.graSicaklik.ChartAreas[0].AxisY.Maximum = 50;
                grafikler1.graSicaklik.Series[0].Points.AddXY(((minm + maksm) / 2) + 1, paket[10]);

                grafikler1.graPilGerilimi.ChartAreas[0].AxisX.Minimum = minm;
                grafikler1.graPilGerilimi.ChartAreas[0].AxisX.Maximum = maksm;
                grafikler1.graPilGerilimi.ChartAreas[0].AxisX.Interval = 1;
                grafikler1.graPilGerilimi.ChartAreas[0].AxisY.Interval = 0.25;
                grafikler1.graPilGerilimi.ChartAreas[0].AxisY.Minimum = 11.1;
                grafikler1.graPilGerilimi.ChartAreas[0].AxisY.Maximum = 12.6;
                grafikler1.graPilGerilimi.Series[0].Points.AddXY(((minm + maksm) / 2) + 1, paket[11]);
                //-------------------------------------------------------------------------------------------
                maksm += 1;
                minm += 1;
                //Telemetri Paneli-------------------------------
                telemetri1.labPaket.Text = paket[0];
                telemetri1.labUydu.Text = paket[1];
                telemetri1.labHata.Text = paket[2];
                telemetri1.labSaat.Text = paket[3];
                telemetri1.labBasinc1.Text = paket[4] + " Pa"; ;
                telemetri1.labBasinc2.Text = paket[5] + " Pa"; ;
                telemetri1.labYukseklik1.Text = paket[6] + " m"; ;
                telemetri1.labYukseklik2.Text = paket[7] + " m"; ;
                telemetri1.labIrtifa.Text = paket[8] + " m"; ;
                telemetri1.labHiz.Text = paket[9] + " m"; ;
                telemetri1.labSicaklik.Text = paket[10] + " °C";
                telemetri1.labPil.Text = paket[11] + " V"; ;
                telemetri1.labGPS1lat.Text = paket[12];
                telemetri1.labGPS1long.Text = paket[13];
                telemetri1.labGPS1alti.Text = paket[14] + " m"; ;
                telemetri1.labPitch.Text = paket[16] + "°"; ;
                telemetri1.labRoll.Text = paket[17] + "°"; ;
                telemetri1.labYaw.Text = paket[15] + "°"; ;
                telemetri1.labTakim.Text = paket[18];
                //----------------------------------------------
               
                AnaPort.DiscardInBuffer();
            }
        }
        private void silindir(float step, float topla, float radius, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Quads); // Gövde
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 0, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(255, 255, 255));


                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 2) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 2) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
        }
        private void koni(float step, float topla, float radius1, float radius2, float dikey1, float dikey2)
        {

            float eski_step = 0.1f;
            GL.Begin(BeginMode.Lines);//Kapak ve gövde birleşme
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 90)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 135)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 180)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 225)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 270)
                    GL.Color3(1.0, 0.0, 0.0);
                else if (step < 315)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 360)
                    GL.Color3(1.0, 0.0, 0.0);

                float ciz1_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();

            GL.Begin(BeginMode.Lines); //kapaklar
            step = eski_step;
            topla = step;
            while (step <= 180)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 1, 1));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));

                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            GL.End();
        }
    }
}