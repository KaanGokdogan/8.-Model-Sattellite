namespace Ground_Station_v5._0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labUydu = new System.Windows.Forms.Label();
            this.labPaket = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.labSaat = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labHata = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labYaw = new System.Windows.Forms.Label();
            this.labYukseklik2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labYukseklik1 = new System.Windows.Forms.Label();
            this.labBasinc1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labHiz = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labBasinc2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labTakim = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.labGPS1lat = new System.Windows.Forms.Label();
            this.labGPS1long = new System.Windows.Forms.Label();
            this.labRoll = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.labPitch = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.labGPS1alti = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.labSicaklik = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labPil = new System.Windows.Forms.Label();
            this.labIrtifa = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butStop = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CanliVideo = new System.Windows.Forms.PictureBox();
            this.AnaPort = new System.IO.Ports.SerialPort(this.components);
            this.glControl1 = new OpenTK.GLControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.butAnaEkran = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labGorselIrtifa = new System.Windows.Forms.Label();
            this.butTelemetri = new System.Windows.Forms.Button();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.butGrafikler = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.VideoDosyaAcma = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel13 = new System.Windows.Forms.Panel();
            this.graHiz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.graSicaklik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.graYukseklik1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.graBasinc1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.graYukseklik2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel10 = new System.Windows.Forms.Panel();
            this.graBasinc2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labUP = new System.Windows.Forms.Label();
            this.VideoBar = new System.Windows.Forms.ProgressBar();
            this.labUydu2 = new System.Windows.Forms.Label();
            this.labVideo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labPilYuzde = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.labPil2 = new System.Windows.Forms.Label();
            this.PilBar = new System.Windows.Forms.ProgressBar();
            this.butVideoSend = new System.Windows.Forms.Button();
            this.butVideo = new System.Windows.Forms.Button();
            this.butMUY = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ARAS2 = new System.Windows.Forms.PictureBox();
            this.ARAS5 = new System.Windows.Forms.PictureBox();
            this.ARAS4 = new System.Windows.Forms.PictureBox();
            this.ARAS3 = new System.Windows.Forms.PictureBox();
            this.ARAS1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grafikler1 = new Ground_Station_v5._0.Grafikler();
            this.telemetri1 = new Ground_Station_v5._0.Telemetri();
            ((System.ComponentModel.ISupportInitialize)(this.CanliVideo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graHiz)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graSicaklik)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graYukseklik1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graBasinc1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graYukseklik2)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graBasinc2)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS1)).BeginInit();
            this.SuspendLayout();
            // 
            // labUydu
            // 
            this.labUydu.AutoSize = true;
            this.labUydu.BackColor = System.Drawing.Color.Transparent;
            this.labUydu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labUydu.ForeColor = System.Drawing.Color.Snow;
            this.labUydu.Location = new System.Drawing.Point(494, 923);
            this.labUydu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labUydu.Name = "labUydu";
            this.labUydu.Size = new System.Drawing.Size(0, 23);
            this.labUydu.TabIndex = 448;
            // 
            // labPaket
            // 
            this.labPaket.AutoSize = true;
            this.labPaket.BackColor = System.Drawing.Color.Transparent;
            this.labPaket.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labPaket.ForeColor = System.Drawing.Color.Snow;
            this.labPaket.Location = new System.Drawing.Point(289, 923);
            this.labPaket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPaket.Name = "labPaket";
            this.labPaket.Size = new System.Drawing.Size(0, 23);
            this.labPaket.TabIndex = 449;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Fuchsia;
            this.label14.Location = new System.Drawing.Point(428, 902);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 23);
            this.label14.TabIndex = 450;
            this.label14.Text = "<UYDU  STATÜSÜ>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Fuchsia;
            this.label11.Location = new System.Drawing.Point(230, 902);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 23);
            this.label11.TabIndex = 451;
            this.label11.Text = "<PAKET NUMARASI>";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.Color.Fuchsia;
            this.label32.Location = new System.Drawing.Point(525, 953);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(145, 23);
            this.label32.TabIndex = 447;
            this.label32.Text = "<PİL GERİLİMİ>";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.ForeColor = System.Drawing.Color.Fuchsia;
            this.label33.Location = new System.Drawing.Point(686, 953);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(164, 23);
            this.label33.TabIndex = 446;
            this.label33.Text = "<GPS1 LATITUDE>";
            // 
            // labSaat
            // 
            this.labSaat.AutoSize = true;
            this.labSaat.BackColor = System.Drawing.Color.Transparent;
            this.labSaat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSaat.ForeColor = System.Drawing.Color.Snow;
            this.labSaat.Location = new System.Drawing.Point(765, 923);
            this.labSaat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSaat.Name = "labSaat";
            this.labSaat.Size = new System.Drawing.Size(0, 23);
            this.labSaat.TabIndex = 471;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Fuchsia;
            this.label17.Location = new System.Drawing.Point(969, 902);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 23);
            this.label17.TabIndex = 470;
            this.label17.Text = "<BASINÇ1>";
            // 
            // labHata
            // 
            this.labHata.AutoSize = true;
            this.labHata.BackColor = System.Drawing.Color.Transparent;
            this.labHata.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labHata.ForeColor = System.Drawing.Color.Snow;
            this.labHata.Location = new System.Drawing.Point(645, 923);
            this.labHata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labHata.Name = "labHata";
            this.labHata.Size = new System.Drawing.Size(0, 23);
            this.labHata.TabIndex = 473;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Fuchsia;
            this.label16.Location = new System.Drawing.Point(768, 902);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 23);
            this.label16.TabIndex = 468;
            this.label16.Text = "<GÖNDERME SAATİ>";
            // 
            // labYaw
            // 
            this.labYaw.AutoSize = true;
            this.labYaw.BackColor = System.Drawing.Color.Transparent;
            this.labYaw.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labYaw.ForeColor = System.Drawing.Color.Snow;
            this.labYaw.Location = new System.Drawing.Point(1420, 976);
            this.labYaw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labYaw.Name = "labYaw";
            this.labYaw.Size = new System.Drawing.Size(0, 23);
            this.labYaw.TabIndex = 469;
            // 
            // labYukseklik2
            // 
            this.labYukseklik2.AutoSize = true;
            this.labYukseklik2.BackColor = System.Drawing.Color.Transparent;
            this.labYukseklik2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labYukseklik2.ForeColor = System.Drawing.Color.Snow;
            this.labYukseklik2.Location = new System.Drawing.Point(1379, 923);
            this.labYukseklik2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labYukseklik2.Name = "labYukseklik2";
            this.labYukseklik2.Size = new System.Drawing.Size(0, 23);
            this.labYukseklik2.TabIndex = 458;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Fuchsia;
            this.label15.Location = new System.Drawing.Point(614, 902);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 23);
            this.label15.TabIndex = 466;
            this.label15.Text = "<HATA  KODU>";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.ForeColor = System.Drawing.Color.Fuchsia;
            this.label42.Location = new System.Drawing.Point(1509, 953);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(119, 23);
            this.label42.TabIndex = 455;
            this.label42.Text = "<TAKIM NO>";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Fuchsia;
            this.label21.Location = new System.Drawing.Point(263, 953);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 23);
            this.label21.TabIndex = 457;
            this.label21.Text = "<İNİŞ HIZI>";
            // 
            // labYukseklik1
            // 
            this.labYukseklik1.AutoSize = true;
            this.labYukseklik1.BackColor = System.Drawing.Color.Transparent;
            this.labYukseklik1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labYukseklik1.ForeColor = System.Drawing.Color.Snow;
            this.labYukseklik1.Location = new System.Drawing.Point(1235, 923);
            this.labYukseklik1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labYukseklik1.Name = "labYukseklik1";
            this.labYukseklik1.Size = new System.Drawing.Size(0, 23);
            this.labYukseklik1.TabIndex = 460;
            // 
            // labBasinc1
            // 
            this.labBasinc1.AutoSize = true;
            this.labBasinc1.BackColor = System.Drawing.Color.Transparent;
            this.labBasinc1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labBasinc1.ForeColor = System.Drawing.Color.Snow;
            this.labBasinc1.Location = new System.Drawing.Point(972, 923);
            this.labBasinc1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBasinc1.Name = "labBasinc1";
            this.labBasinc1.Size = new System.Drawing.Size(0, 23);
            this.labBasinc1.TabIndex = 464;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Fuchsia;
            this.label12.Location = new System.Drawing.Point(1090, 902);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 23);
            this.label12.TabIndex = 472;
            this.label12.Text = "<BASINÇ2>";
            // 
            // labHiz
            // 
            this.labHiz.AutoSize = true;
            this.labHiz.BackColor = System.Drawing.Color.Transparent;
            this.labHiz.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labHiz.ForeColor = System.Drawing.Color.Snow;
            this.labHiz.Location = new System.Drawing.Point(278, 976);
            this.labHiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labHiz.Name = "labHiz";
            this.labHiz.Size = new System.Drawing.Size(0, 23);
            this.labHiz.TabIndex = 456;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Fuchsia;
            this.label19.Location = new System.Drawing.Point(1357, 902);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 23);
            this.label19.TabIndex = 461;
            this.label19.Text = "<YÜKSEKLİK2>";
            // 
            // labBasinc2
            // 
            this.labBasinc2.AutoSize = true;
            this.labBasinc2.BackColor = System.Drawing.Color.Transparent;
            this.labBasinc2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labBasinc2.ForeColor = System.Drawing.Color.Snow;
            this.labBasinc2.Location = new System.Drawing.Point(1097, 923);
            this.labBasinc2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBasinc2.Name = "labBasinc2";
            this.labBasinc2.Size = new System.Drawing.Size(0, 23);
            this.labBasinc2.TabIndex = 462;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Fuchsia;
            this.label18.Location = new System.Drawing.Point(1211, 902);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 23);
            this.label18.TabIndex = 465;
            this.label18.Text = "<YÜKSEKLİK1>";
            // 
            // labTakim
            // 
            this.labTakim.AutoSize = true;
            this.labTakim.BackColor = System.Drawing.Color.Transparent;
            this.labTakim.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labTakim.ForeColor = System.Drawing.Color.Snow;
            this.labTakim.Location = new System.Drawing.Point(1534, 976);
            this.labTakim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTakim.Name = "labTakim";
            this.labTakim.Size = new System.Drawing.Size(0, 23);
            this.labTakim.TabIndex = 467;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.ForeColor = System.Drawing.Color.Fuchsia;
            this.label34.Location = new System.Drawing.Point(866, 953);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(178, 23);
            this.label34.TabIndex = 452;
            this.label34.Text = "<GPS1 LONGITUDE>";
            // 
            // labGPS1lat
            // 
            this.labGPS1lat.AutoSize = true;
            this.labGPS1lat.BackColor = System.Drawing.Color.Transparent;
            this.labGPS1lat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGPS1lat.ForeColor = System.Drawing.Color.Snow;
            this.labGPS1lat.Location = new System.Drawing.Point(715, 976);
            this.labGPS1lat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGPS1lat.Name = "labGPS1lat";
            this.labGPS1lat.Size = new System.Drawing.Size(0, 23);
            this.labGPS1lat.TabIndex = 453;
            // 
            // labGPS1long
            // 
            this.labGPS1long.AutoSize = true;
            this.labGPS1long.BackColor = System.Drawing.Color.Transparent;
            this.labGPS1long.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGPS1long.ForeColor = System.Drawing.Color.Snow;
            this.labGPS1long.Location = new System.Drawing.Point(902, 976);
            this.labGPS1long.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGPS1long.Name = "labGPS1long";
            this.labGPS1long.Size = new System.Drawing.Size(0, 23);
            this.labGPS1long.TabIndex = 443;
            // 
            // labRoll
            // 
            this.labRoll.AutoSize = true;
            this.labRoll.BackColor = System.Drawing.Color.Transparent;
            this.labRoll.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labRoll.ForeColor = System.Drawing.Color.Snow;
            this.labRoll.Location = new System.Drawing.Point(1337, 976);
            this.labRoll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRoll.Name = "labRoll";
            this.labRoll.Size = new System.Drawing.Size(0, 23);
            this.labRoll.TabIndex = 459;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.ForeColor = System.Drawing.Color.Fuchsia;
            this.label41.Location = new System.Drawing.Point(1424, 953);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 23);
            this.label41.TabIndex = 454;
            this.label41.Text = "<YAW>";
            // 
            // labPitch
            // 
            this.labPitch.AutoSize = true;
            this.labPitch.BackColor = System.Drawing.Color.Transparent;
            this.labPitch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labPitch.ForeColor = System.Drawing.Color.Snow;
            this.labPitch.Location = new System.Drawing.Point(1240, 976);
            this.labPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPitch.Name = "labPitch";
            this.labPitch.Size = new System.Drawing.Size(0, 23);
            this.labPitch.TabIndex = 444;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.ForeColor = System.Drawing.Color.Fuchsia;
            this.label40.Location = new System.Drawing.Point(1337, 953);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 23);
            this.label40.TabIndex = 439;
            this.label40.Text = "<ROLL>";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.ForeColor = System.Drawing.Color.Fuchsia;
            this.label35.Location = new System.Drawing.Point(1060, 953);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(164, 23);
            this.label35.TabIndex = 442;
            this.label35.Text = "<GPS1 ALTITUDE>";
            // 
            // labGPS1alti
            // 
            this.labGPS1alti.AutoSize = true;
            this.labGPS1alti.BackColor = System.Drawing.Color.Transparent;
            this.labGPS1alti.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGPS1alti.ForeColor = System.Drawing.Color.Snow;
            this.labGPS1alti.Location = new System.Drawing.Point(1096, 976);
            this.labGPS1alti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGPS1alti.Name = "labGPS1alti";
            this.labGPS1alti.Size = new System.Drawing.Size(0, 23);
            this.labGPS1alti.TabIndex = 441;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.ForeColor = System.Drawing.Color.Fuchsia;
            this.label39.Location = new System.Drawing.Point(1240, 953);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 23);
            this.label39.TabIndex = 440;
            this.label39.Text = "<PITCH>";
            // 
            // labSicaklik
            // 
            this.labSicaklik.AutoSize = true;
            this.labSicaklik.BackColor = System.Drawing.Color.Transparent;
            this.labSicaklik.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSicaklik.ForeColor = System.Drawing.Color.Snow;
            this.labSicaklik.Location = new System.Drawing.Point(415, 976);
            this.labSicaklik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSicaklik.Name = "labSicaklik";
            this.labSicaklik.Size = new System.Drawing.Size(0, 23);
            this.labSicaklik.TabIndex = 474;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Fuchsia;
            this.label22.Location = new System.Drawing.Point(399, 953);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 23);
            this.label22.TabIndex = 475;
            this.label22.Text = "<SICAKLIK>";
            // 
            // labPil
            // 
            this.labPil.AutoSize = true;
            this.labPil.BackColor = System.Drawing.Color.Transparent;
            this.labPil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labPil.ForeColor = System.Drawing.Color.Snow;
            this.labPil.Location = new System.Drawing.Point(563, 976);
            this.labPil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPil.Name = "labPil";
            this.labPil.Size = new System.Drawing.Size(0, 23);
            this.labPil.TabIndex = 445;
            // 
            // labIrtifa
            // 
            this.labIrtifa.AutoSize = true;
            this.labIrtifa.BackColor = System.Drawing.Color.Transparent;
            this.labIrtifa.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labIrtifa.ForeColor = System.Drawing.Color.Snow;
            this.labIrtifa.Location = new System.Drawing.Point(1528, 923);
            this.labIrtifa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labIrtifa.Name = "labIrtifa";
            this.labIrtifa.Size = new System.Drawing.Size(0, 23);
            this.labIrtifa.TabIndex = 476;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Fuchsia;
            this.label20.Location = new System.Drawing.Point(1504, 902);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 23);
            this.label20.TabIndex = 477;
            this.label20.Text = "<İRTİFA FARKI>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Location = new System.Drawing.Point(72, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 31);
            this.panel2.TabIndex = 14;
            // 
            // butStop
            // 
            this.butStop.BackColor = System.Drawing.Color.Red;
            this.butStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butStop.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butStop.Location = new System.Drawing.Point(1425, 60);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(150, 50);
            this.butStop.TabIndex = 479;
            this.butStop.Text = "BİTİR";
            this.butStop.UseVisualStyleBackColor = false;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.Color.Lime;
            this.butStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butStart.Location = new System.Drawing.Point(1270, 60);
            this.butStart.Margin = new System.Windows.Forms.Padding(2);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(150, 50);
            this.butStart.TabIndex = 478;
            this.butStart.Text = "BAŞLA";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(575, 856);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 492;
            // 
            // CanliVideo
            // 
            this.CanliVideo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CanliVideo.Location = new System.Drawing.Point(560, 541);
            this.CanliVideo.Margin = new System.Windows.Forms.Padding(2);
            this.CanliVideo.Name = "CanliVideo";
            this.CanliVideo.Size = new System.Drawing.Size(550, 350);
            this.CanliVideo.TabIndex = 481;
            this.CanliVideo.TabStop = false;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(749, 216);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(335, 322);
            this.glControl1.TabIndex = 493;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Fuchsia;
            this.panel4.Location = new System.Drawing.Point(72, 168);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 31);
            this.panel4.TabIndex = 14;
            // 
            // butAnaEkran
            // 
            this.butAnaEkran.BackColor = System.Drawing.Color.Navy;
            this.butAnaEkran.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAnaEkran.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butAnaEkran.ForeColor = System.Drawing.Color.Snow;
            this.butAnaEkran.Location = new System.Drawing.Point(638, 21);
            this.butAnaEkran.Margin = new System.Windows.Forms.Padding(2);
            this.butAnaEkran.Name = "butAnaEkran";
            this.butAnaEkran.Size = new System.Drawing.Size(305, 60);
            this.butAnaEkran.TabIndex = 495;
            this.butAnaEkran.Text = "Ana Ekran";
            this.butAnaEkran.UseVisualStyleBackColor = false;
            this.butAnaEkran.Click += new System.EventHandler(this.butAnaEkran_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labGorselIrtifa);
            this.panel1.Location = new System.Drawing.Point(575, 214);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 324);
            this.panel1.TabIndex = 482;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(44, 184);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 131);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 105);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // labGorselIrtifa
            // 
            this.labGorselIrtifa.AutoSize = true;
            this.labGorselIrtifa.BackColor = System.Drawing.Color.Transparent;
            this.labGorselIrtifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labGorselIrtifa.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labGorselIrtifa.ForeColor = System.Drawing.Color.Snow;
            this.labGorselIrtifa.Location = new System.Drawing.Point(40, 138);
            this.labGorselIrtifa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGorselIrtifa.Name = "labGorselIrtifa";
            this.labGorselIrtifa.Size = new System.Drawing.Size(0, 23);
            this.labGorselIrtifa.TabIndex = 14;
            // 
            // butTelemetri
            // 
            this.butTelemetri.BackColor = System.Drawing.Color.Snow;
            this.butTelemetri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butTelemetri.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butTelemetri.Location = new System.Drawing.Point(793, 85);
            this.butTelemetri.Margin = new System.Windows.Forms.Padding(2);
            this.butTelemetri.Name = "butTelemetri";
            this.butTelemetri.Size = new System.Drawing.Size(150, 50);
            this.butTelemetri.TabIndex = 494;
            this.butTelemetri.Text = "Telemetri ";
            this.butTelemetri.UseVisualStyleBackColor = false;
            this.butTelemetri.Click += new System.EventHandler(this.butTelemetri_Click);
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Snow;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(6, 541);
            this.Map.Margin = new System.Windows.Forms.Padding(2);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 2;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(550, 350);
            this.Map.TabIndex = 491;
            this.Map.Zoom = 0D;
            // 
            // butGrafikler
            // 
            this.butGrafikler.BackColor = System.Drawing.Color.Snow;
            this.butGrafikler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGrafikler.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGrafikler.Location = new System.Drawing.Point(639, 85);
            this.butGrafikler.Margin = new System.Windows.Forms.Padding(2);
            this.butGrafikler.Name = "butGrafikler";
            this.butGrafikler.Size = new System.Drawing.Size(150, 50);
            this.butGrafikler.TabIndex = 496;
            this.butGrafikler.Text = "Grafikler";
            this.butGrafikler.UseVisualStyleBackColor = false;
            this.butGrafikler.Click += new System.EventHandler(this.butGrafikler_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(37, -39);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(497, 281);
            this.pictureBox3.TabIndex = 480;
            this.pictureBox3.TabStop = false;
            // 
            // VideoDosyaAcma
            // 
            this.VideoDosyaAcma.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.graHiz);
            this.panel13.Location = new System.Drawing.Point(1112, 212);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(400, 225);
            this.panel13.TabIndex = 490;
            // 
            // graHiz
            // 
            this.graHiz.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.graHiz.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.ForeColor = System.Drawing.Color.Silver;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.graHiz.Legends.Add(legend1);
            this.graHiz.Location = new System.Drawing.Point(1, 1);
            this.graHiz.Name = "graHiz";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Silver;
            series1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.LabelForeColor = System.Drawing.Color.Silver;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Fuchsia;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Hız (m/s)";
            this.graHiz.Series.Add(series1);
            this.graHiz.Size = new System.Drawing.Size(398, 223);
            this.graHiz.TabIndex = 497;
            this.graHiz.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.graSicaklik);
            this.panel5.Location = new System.Drawing.Point(1514, 212);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 225);
            this.panel5.TabIndex = 497;
            // 
            // graSicaklik
            // 
            this.graSicaklik.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.graSicaklik.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend2.ForeColor = System.Drawing.Color.Silver;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.graSicaklik.Legends.Add(legend2);
            this.graSicaklik.Location = new System.Drawing.Point(1, 1);
            this.graSicaklik.Name = "graSicaklik";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Silver;
            series2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.LabelForeColor = System.Drawing.Color.Silver;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Fuchsia;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Sıcaklık (°C)";
            this.graSicaklik.Series.Add(series2);
            this.graSicaklik.Size = new System.Drawing.Size(398, 223);
            this.graSicaklik.TabIndex = 497;
            this.graSicaklik.Text = "chart2";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.graYukseklik1);
            this.panel6.Location = new System.Drawing.Point(1514, 439);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 225);
            this.panel6.TabIndex = 499;
            // 
            // graYukseklik1
            // 
            this.graYukseklik1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.graYukseklik1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend3.ForeColor = System.Drawing.Color.Silver;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.graYukseklik1.Legends.Add(legend3);
            this.graYukseklik1.Location = new System.Drawing.Point(1, 1);
            this.graYukseklik1.Name = "graYukseklik1";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Silver;
            series3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series3.LabelForeColor = System.Drawing.Color.Silver;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Fuchsia;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Yükseklik1 (m)";
            this.graYukseklik1.Series.Add(series3);
            this.graYukseklik1.Size = new System.Drawing.Size(398, 223);
            this.graYukseklik1.TabIndex = 497;
            this.graYukseklik1.Text = "chart3";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.graBasinc1);
            this.panel8.Location = new System.Drawing.Point(1112, 439);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(400, 225);
            this.panel8.TabIndex = 498;
            // 
            // graBasinc1
            // 
            this.graBasinc1.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.graBasinc1.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.DockedToChartArea = "ChartArea1";
            legend4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend4.ForeColor = System.Drawing.Color.Silver;
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.graBasinc1.Legends.Add(legend4);
            this.graBasinc1.Location = new System.Drawing.Point(1, 1);
            this.graBasinc1.Name = "graBasinc1";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Silver;
            series4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series4.LabelForeColor = System.Drawing.Color.Silver;
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.Fuchsia;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Basınç1 (Pa)";
            this.graBasinc1.Series.Add(series4);
            this.graBasinc1.Size = new System.Drawing.Size(398, 223);
            this.graBasinc1.TabIndex = 497;
            this.graBasinc1.Text = "chart4";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.graYukseklik2);
            this.panel9.Location = new System.Drawing.Point(1514, 666);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 225);
            this.panel9.TabIndex = 501;
            // 
            // graYukseklik2
            // 
            this.graYukseklik2.BackColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea5.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.LineWidth = 2;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisY.LineWidth = 2;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.graYukseklik2.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.DockedToChartArea = "ChartArea1";
            legend5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend5.ForeColor = System.Drawing.Color.Silver;
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.graYukseklik2.Legends.Add(legend5);
            this.graYukseklik2.Location = new System.Drawing.Point(1, 1);
            this.graYukseklik2.Name = "graYukseklik2";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Silver;
            series5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series5.LabelForeColor = System.Drawing.Color.Silver;
            series5.Legend = "Legend1";
            series5.MarkerColor = System.Drawing.Color.Fuchsia;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Yükseklik2 (m)";
            this.graYukseklik2.Series.Add(series5);
            this.graYukseklik2.Size = new System.Drawing.Size(398, 223);
            this.graYukseklik2.TabIndex = 497;
            this.graYukseklik2.Text = "chart5";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.graBasinc2);
            this.panel10.Location = new System.Drawing.Point(1112, 666);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 225);
            this.panel10.TabIndex = 500;
            // 
            // graBasinc2
            // 
            this.graBasinc2.BackColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea6.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisX.LineWidth = 2;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea6.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisY.LineWidth = 2;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.graBasinc2.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.DockedToChartArea = "ChartArea1";
            legend6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend6.ForeColor = System.Drawing.Color.Silver;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.graBasinc2.Legends.Add(legend6);
            this.graBasinc2.Location = new System.Drawing.Point(1, 1);
            this.graBasinc2.Name = "graBasinc2";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Silver;
            series6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series6.LabelForeColor = System.Drawing.Color.Silver;
            series6.Legend = "Legend1";
            series6.MarkerColor = System.Drawing.Color.Fuchsia;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Basınç2 (Pa)";
            this.graBasinc2.Series.Add(series6);
            this.graBasinc2.Size = new System.Drawing.Size(398, 223);
            this.graBasinc2.TabIndex = 497;
            this.graBasinc2.Text = "chart6";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.labUP);
            this.panel11.Controls.Add(this.VideoBar);
            this.panel11.Controls.Add(this.labUydu2);
            this.panel11.Controls.Add(this.labVideo);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.label24);
            this.panel11.Controls.Add(this.labPilYuzde);
            this.panel11.Controls.Add(this.label25);
            this.panel11.Controls.Add(this.labPil2);
            this.panel11.Controls.Add(this.PilBar);
            this.panel11.Controls.Add(this.butVideoSend);
            this.panel11.Controls.Add(this.butVideo);
            this.panel11.Controls.Add(this.butMUY);
            this.panel11.Location = new System.Drawing.Point(31, 360);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(480, 170);
            this.panel11.TabIndex = 502;
            // 
            // labUP
            // 
            this.labUP.AutoSize = true;
            this.labUP.BackColor = System.Drawing.Color.Transparent;
            this.labUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labUP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labUP.ForeColor = System.Drawing.Color.Snow;
            this.labUP.Location = new System.Drawing.Point(9, 116);
            this.labUP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labUP.Name = "labUP";
            this.labUP.Size = new System.Drawing.Size(0, 23);
            this.labUP.TabIndex = 402;
            // 
            // VideoBar
            // 
            this.VideoBar.Location = new System.Drawing.Point(136, 95);
            this.VideoBar.Margin = new System.Windows.Forms.Padding(2);
            this.VideoBar.Name = "VideoBar";
            this.VideoBar.Size = new System.Drawing.Size(272, 25);
            this.VideoBar.TabIndex = 401;
            // 
            // labUydu2
            // 
            this.labUydu2.AutoSize = true;
            this.labUydu2.BackColor = System.Drawing.Color.Transparent;
            this.labUydu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labUydu2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labUydu2.ForeColor = System.Drawing.Color.Snow;
            this.labUydu2.Location = new System.Drawing.Point(132, 8);
            this.labUydu2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labUydu2.Name = "labUydu2";
            this.labUydu2.Size = new System.Drawing.Size(0, 23);
            this.labUydu2.TabIndex = 400;
            // 
            // labVideo
            // 
            this.labVideo.AutoSize = true;
            this.labVideo.BackColor = System.Drawing.Color.Transparent;
            this.labVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labVideo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labVideo.ForeColor = System.Drawing.Color.Snow;
            this.labVideo.Location = new System.Drawing.Point(416, 93);
            this.labVideo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labVideo.Name = "labVideo";
            this.labVideo.Size = new System.Drawing.Size(0, 23);
            this.labVideo.TabIndex = 398;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 399;
            this.label2.Text = "Uydu Statüsü:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Snow;
            this.label13.Location = new System.Drawing.Point(53, 93);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 23);
            this.label13.TabIndex = 396;
            this.label13.Text = "Yükleme:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.Snow;
            this.label24.Location = new System.Drawing.Point(34, 66);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 23);
            this.label24.TabIndex = 394;
            this.label24.Text = "Pil Gerilimi:";
            // 
            // labPilYuzde
            // 
            this.labPilYuzde.AutoSize = true;
            this.labPilYuzde.BackColor = System.Drawing.Color.Transparent;
            this.labPilYuzde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPilYuzde.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labPilYuzde.ForeColor = System.Drawing.Color.Snow;
            this.labPilYuzde.Location = new System.Drawing.Point(416, 37);
            this.labPilYuzde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPilYuzde.Name = "labPilYuzde";
            this.labPilYuzde.Size = new System.Drawing.Size(0, 23);
            this.labPilYuzde.TabIndex = 397;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.Snow;
            this.label25.Location = new System.Drawing.Point(33, 38);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 23);
            this.label25.TabIndex = 390;
            this.label25.Text = "Pil Yüzdesi:";
            // 
            // labPil2
            // 
            this.labPil2.AutoSize = true;
            this.labPil2.BackColor = System.Drawing.Color.Transparent;
            this.labPil2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPil2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labPil2.ForeColor = System.Drawing.Color.Snow;
            this.labPil2.Location = new System.Drawing.Point(129, 66);
            this.labPil2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPil2.Name = "labPil2";
            this.labPil2.Size = new System.Drawing.Size(0, 23);
            this.labPil2.TabIndex = 395;
            // 
            // PilBar
            // 
            this.PilBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PilBar.Location = new System.Drawing.Point(136, 36);
            this.PilBar.Margin = new System.Windows.Forms.Padding(2);
            this.PilBar.Name = "PilBar";
            this.PilBar.Size = new System.Drawing.Size(272, 25);
            this.PilBar.Step = 5;
            this.PilBar.TabIndex = 391;
            this.PilBar.Tag = "";
            // 
            // butVideoSend
            // 
            this.butVideoSend.BackColor = System.Drawing.Color.GhostWhite;
            this.butVideoSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butVideoSend.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butVideoSend.Location = new System.Drawing.Point(229, 126);
            this.butVideoSend.Margin = new System.Windows.Forms.Padding(2);
            this.butVideoSend.Name = "butVideoSend";
            this.butVideoSend.Size = new System.Drawing.Size(87, 30);
            this.butVideoSend.TabIndex = 388;
            this.butVideoSend.Text = "Gönder";
            this.butVideoSend.UseVisualStyleBackColor = false;
            this.butVideoSend.Click += new System.EventHandler(this.butVideoSend_Click);
            // 
            // butVideo
            // 
            this.butVideo.BackColor = System.Drawing.Color.GhostWhite;
            this.butVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butVideo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butVideo.Location = new System.Drawing.Point(136, 126);
            this.butVideo.Margin = new System.Windows.Forms.Padding(2);
            this.butVideo.Name = "butVideo";
            this.butVideo.Size = new System.Drawing.Size(87, 30);
            this.butVideo.TabIndex = 387;
            this.butVideo.Text = "Video Seç";
            this.butVideo.UseVisualStyleBackColor = false;
            this.butVideo.Click += new System.EventHandler(this.butVideo_Click);
            // 
            // butMUY
            // 
            this.butMUY.BackColor = System.Drawing.Color.GhostWhite;
            this.butMUY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butMUY.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butMUY.Location = new System.Drawing.Point(321, 126);
            this.butMUY.Margin = new System.Windows.Forms.Padding(2);
            this.butMUY.Name = "butMUY";
            this.butMUY.Size = new System.Drawing.Size(87, 30);
            this.butMUY.TabIndex = 386;
            this.butMUY.Text = "MUY Ayır";
            this.butMUY.UseVisualStyleBackColor = false;
            this.butMUY.Click += new System.EventHandler(this.butMUY_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ARAS2);
            this.panel3.Controls.Add(this.ARAS5);
            this.panel3.Controls.Add(this.ARAS4);
            this.panel3.Controls.Add(this.ARAS3);
            this.panel3.Controls.Add(this.ARAS1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(88, 174);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 177);
            this.panel3.TabIndex = 504;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(87, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 48);
            this.label9.TabIndex = 24;
            this.label9.Text = "2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 48);
            this.label8.TabIndex = 23;
            this.label8.Text = "1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(288, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 48);
            this.label7.TabIndex = 22;
            this.label7.Text = "5";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(221, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 48);
            this.label4.TabIndex = 21;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(154, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 48);
            this.label3.TabIndex = 20;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ARAS2
            // 
            this.ARAS2.BackColor = System.Drawing.Color.Red;
            this.ARAS2.Location = new System.Drawing.Point(87, 109);
            this.ARAS2.Margin = new System.Windows.Forms.Padding(2);
            this.ARAS2.Name = "ARAS2";
            this.ARAS2.Size = new System.Drawing.Size(65, 48);
            this.ARAS2.TabIndex = 19;
            this.ARAS2.TabStop = false;
            // 
            // ARAS5
            // 
            this.ARAS5.BackColor = System.Drawing.Color.Red;
            this.ARAS5.Location = new System.Drawing.Point(288, 109);
            this.ARAS5.Margin = new System.Windows.Forms.Padding(2);
            this.ARAS5.Name = "ARAS5";
            this.ARAS5.Size = new System.Drawing.Size(65, 48);
            this.ARAS5.TabIndex = 18;
            this.ARAS5.TabStop = false;
            // 
            // ARAS4
            // 
            this.ARAS4.BackColor = System.Drawing.Color.Red;
            this.ARAS4.Location = new System.Drawing.Point(221, 109);
            this.ARAS4.Margin = new System.Windows.Forms.Padding(2);
            this.ARAS4.Name = "ARAS4";
            this.ARAS4.Size = new System.Drawing.Size(65, 48);
            this.ARAS4.TabIndex = 17;
            this.ARAS4.TabStop = false;
            // 
            // ARAS3
            // 
            this.ARAS3.BackColor = System.Drawing.Color.Red;
            this.ARAS3.Location = new System.Drawing.Point(154, 109);
            this.ARAS3.Margin = new System.Windows.Forms.Padding(2);
            this.ARAS3.Name = "ARAS3";
            this.ARAS3.Size = new System.Drawing.Size(65, 48);
            this.ARAS3.TabIndex = 16;
            this.ARAS3.TabStop = false;
            // 
            // ARAS1
            // 
            this.ARAS1.BackColor = System.Drawing.Color.Red;
            this.ARAS1.Location = new System.Drawing.Point(20, 109);
            this.ARAS1.Margin = new System.Windows.Forms.Padding(2);
            this.ARAS1.Name = "ARAS1";
            this.ARAS1.Size = new System.Drawing.Size(65, 48);
            this.ARAS1.TabIndex = 15;
            this.ARAS1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(66, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Arayüz Alarm Sistemi";
            // 
            // grafikler1
            // 
            this.grafikler1.BackColor = System.Drawing.Color.Transparent;
            this.grafikler1.Location = new System.Drawing.Point(0, 171);
            this.grafikler1.Name = "grafikler1";
            this.grafikler1.Size = new System.Drawing.Size(1920, 840);
            this.grafikler1.TabIndex = 506;
            // 
            // telemetri1
            // 
            this.telemetri1.BackColor = System.Drawing.Color.Transparent;
            this.telemetri1.Location = new System.Drawing.Point(0, 171);
            this.telemetri1.Name = "telemetri1";
            this.telemetri1.Size = new System.Drawing.Size(1920, 840);
            this.telemetri1.TabIndex = 505;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 1011);
            this.Controls.Add(this.grafikler1);
            this.Controls.Add(this.telemetri1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CanliVideo);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.butAnaEkran);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butTelemetri);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.butGrafikler);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labIrtifa);
            this.Controls.Add(this.labUydu);
            this.Controls.Add(this.labPaket);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.labSaat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labHata);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labYaw);
            this.Controls.Add(this.labYukseklik2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.labYukseklik1);
            this.Controls.Add(this.labBasinc1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labHiz);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.labBasinc2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labTakim);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.labGPS1lat);
            this.Controls.Add(this.labGPS1long);
            this.Controls.Add(this.labRoll);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.labPitch);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.labGPS1alti);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.labSicaklik);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.labPil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Yer Istasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CanliVideo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graHiz)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graSicaklik)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graYukseklik1)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graBasinc1)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graYukseklik2)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graBasinc2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUydu;
        private System.Windows.Forms.Label labPaket;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label labSaat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labHata;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labYaw;
        private System.Windows.Forms.Label labYukseklik2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labYukseklik1;
        private System.Windows.Forms.Label labBasinc1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labHiz;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labBasinc2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labTakim;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label labGPS1lat;
        private System.Windows.Forms.Label labGPS1long;
        private System.Windows.Forms.Label labRoll;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label labPitch;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label labGPS1alti;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label labSicaklik;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labPil;
        private System.Windows.Forms.Label labIrtifa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox CanliVideo;
        public System.IO.Ports.SerialPort AnaPort;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butAnaEkran;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labGorselIrtifa;
        private System.Windows.Forms.Button butTelemetri;
        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.Button butGrafikler;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog VideoDosyaAcma;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DataVisualization.Charting.Chart graHiz;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart graSicaklik;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart graYukseklik1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart graBasinc1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart graYukseklik2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataVisualization.Charting.Chart graBasinc2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ProgressBar VideoBar;
        private System.Windows.Forms.Label labUydu2;
        private System.Windows.Forms.Label labVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labPilYuzde;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labPil2;
        public System.Windows.Forms.ProgressBar PilBar;
        private System.Windows.Forms.Button butVideoSend;
        private System.Windows.Forms.Button butVideo;
        private System.Windows.Forms.Button butMUY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ARAS2;
        private System.Windows.Forms.PictureBox ARAS5;
        private System.Windows.Forms.PictureBox ARAS4;
        private System.Windows.Forms.PictureBox ARAS3;
        private System.Windows.Forms.PictureBox ARAS1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labUP;
        private Telemetri telemetri1;
        private Grafikler grafikler1;
    }
}

