namespace Conn_PLC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.btnOffCam = new System.Windows.Forms.Button();
            this.btnOnCam = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lcButton1 = new LCToolbox.LCTool.LCButton();
            this.stdStatusConn = new SymbolFactoryDotNet.StandardControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnPLC = new System.Windows.Forms.Button();
            this.btnDisConnPLC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptbCapture = new System.Windows.Forms.PictureBox();
            this.lbOkNG = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbVideo = new System.Windows.Forms.PictureBox();
            this.timerPLC = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.txtNG = new System.Windows.Forms.TextBox();
            this.txtOk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.libAlarm = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPLCConn = new System.Windows.Forms.Label();
            this.timerCamera = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdStatusConn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCapture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVideo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCamera
            // 
            this.cbCamera.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(65, 536);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(187, 25);
            this.cbCamera.TabIndex = 3;
            // 
            // btnOffCam
            // 
            this.btnOffCam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOffCam.Location = new System.Drawing.Point(371, 533);
            this.btnOffCam.Name = "btnOffCam";
            this.btnOffCam.Size = new System.Drawing.Size(68, 31);
            this.btnOffCam.TabIndex = 2;
            this.btnOffCam.Text = "OFF";
            this.btnOffCam.UseVisualStyleBackColor = true;
            this.btnOffCam.Click += new System.EventHandler(this.btnOffCam_Click);
            // 
            // btnOnCam
            // 
            this.btnOnCam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOnCam.Location = new System.Drawing.Point(285, 533);
            this.btnOnCam.Name = "btnOnCam";
            this.btnOnCam.Size = new System.Drawing.Size(68, 31);
            this.btnOnCam.TabIndex = 2;
            this.btnOnCam.Text = "ON";
            this.btnOnCam.UseVisualStyleBackColor = true;
            this.btnOnCam.Click += new System.EventHandler(this.btnOnCam_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lcButton1);
            this.groupBox3.Controls.Add(this.stdStatusConn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtIP);
            this.groupBox3.Controls.Add(this.btnConnPLC);
            this.groupBox3.Controls.Add(this.btnDisConnPLC);
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 162);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONNECT TO PLC";
            // 
            // lcButton1
            // 
            this.lcButton1.BackColor = System.Drawing.Color.Lime;
            this.lcButton1.BackgroundColor = System.Drawing.Color.Lime;
            this.lcButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lcButton1.BorderRadius = 10;
            this.lcButton1.BorderSize = 0;
            this.lcButton1.FlatAppearance.BorderSize = 0;
            this.lcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lcButton1.ForeColor = System.Drawing.Color.White;
            this.lcButton1.Location = new System.Drawing.Point(329, 17);
            this.lcButton1.Name = "lcButton1";
            this.lcButton1.Size = new System.Drawing.Size(19, 19);
            this.lcButton1.TabIndex = 9;
            this.lcButton1.TextColor = System.Drawing.Color.White;
            this.lcButton1.UseVisualStyleBackColor = false;
            // 
            // stdStatusConn
            // 
            this.stdStatusConn.AnalogIntValue1 = ((short)(0));
            this.stdStatusConn.AnalogValue1 = 0D;
            this.stdStatusConn.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.stdStatusConn.BackColor = System.Drawing.Color.Transparent;
            this.stdStatusConn.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.stdStatusConn.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Lime, "Band1"));
            this.stdStatusConn.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Red, "Band2"));
            this.stdStatusConn.BlinkColor = System.Drawing.Color.Red;
            this.stdStatusConn.Category = "1Btn.cat2";
            this.stdStatusConn.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("stdStatusConn.DebugData"));
            this.stdStatusConn.FillColor = System.Drawing.Color.Lime;
            this.stdStatusConn.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.stdStatusConn.Location = new System.Drawing.Point(329, 17);
            this.stdStatusConn.Name = "stdStatusConn";
            this.stdStatusConn.Size = new System.Drawing.Size(20, 20);
            this.stdStatusConn.SymbolHandle = ((long)(842488176));
            this.stdStatusConn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIP.Location = new System.Drawing.Point(142, 54);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(129, 25);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnPLC
            // 
            this.btnConnPLC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConnPLC.Location = new System.Drawing.Point(60, 104);
            this.btnConnPLC.Name = "btnConnPLC";
            this.btnConnPLC.Size = new System.Drawing.Size(100, 31);
            this.btnConnPLC.TabIndex = 2;
            this.btnConnPLC.Text = "CONNECT";
            this.btnConnPLC.UseVisualStyleBackColor = true;
            this.btnConnPLC.Click += new System.EventHandler(this.btnConnPLC_Click);
            // 
            // btnDisConnPLC
            // 
            this.btnDisConnPLC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDisConnPLC.Location = new System.Drawing.Point(171, 104);
            this.btnDisConnPLC.Name = "btnDisConnPLC";
            this.btnDisConnPLC.Size = new System.Drawing.Size(100, 31);
            this.btnDisConnPLC.TabIndex = 2;
            this.btnDisConnPLC.Text = "DISCONNECT";
            this.btnDisConnPLC.UseVisualStyleBackColor = true;
            this.btnDisConnPLC.Click += new System.EventHandler(this.btnDisConnPLC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptbCapture);
            this.groupBox2.Controls.Add(this.lbOkNG);
            this.groupBox2.Location = new System.Drawing.Point(1485, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULT 1";
            // 
            // ptbCapture
            // 
            this.ptbCapture.Image = global::Conn_PLC.Properties.Resources.ok;
            this.ptbCapture.Location = new System.Drawing.Point(6, 17);
            this.ptbCapture.Name = "ptbCapture";
            this.ptbCapture.Size = new System.Drawing.Size(373, 234);
            this.ptbCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCapture.TabIndex = 0;
            this.ptbCapture.TabStop = false;
            // 
            // lbOkNG
            // 
            this.lbOkNG.BackColor = System.Drawing.Color.Lime;
            this.lbOkNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOkNG.Location = new System.Drawing.Point(16, 255);
            this.lbOkNG.Name = "lbOkNG";
            this.lbOkNG.Size = new System.Drawing.Size(356, 38);
            this.lbOkNG.TabIndex = 5;
            this.lbOkNG.Text = "OK";
            this.lbOkNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.ptbVideo);
            this.groupBox1.Controls.Add(this.cbCamera);
            this.groupBox1.Controls.Add(this.btnOnCam);
            this.groupBox1.Controls.Add(this.btnOffCam);
            this.groupBox1.Location = new System.Drawing.Point(398, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 709);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DISPLAY CAMERA 1";
            // 
            // ptbVideo
            // 
            this.ptbVideo.Location = new System.Drawing.Point(6, 19);
            this.ptbVideo.Name = "ptbVideo";
            this.ptbVideo.Size = new System.Drawing.Size(504, 466);
            this.ptbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbVideo.TabIndex = 0;
            this.ptbVideo.TabStop = false;
            this.ptbVideo.Click += new System.EventHandler(this.ptbVideo_Click);
            // 
            // timerPLC
            // 
            this.timerPLC.Tick += new System.EventHandler(this.timerPLC_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Location = new System.Drawing.Point(12, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(135, 262);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CONTROL";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(19, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStop.Location = new System.Drawing.Point(19, 121);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 31);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.Location = new System.Drawing.Point(19, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCycle);
            this.groupBox5.Controls.Add(this.txtNG);
            this.groupBox5.Controls.Add(this.txtOk);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(154, 317);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 262);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RESULT";
            // 
            // txtCycle
            // 
            this.txtCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCycle.Location = new System.Drawing.Point(92, 211);
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Size = new System.Drawing.Size(100, 26);
            this.txtCycle.TabIndex = 6;
            // 
            // txtNG
            // 
            this.txtNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNG.Location = new System.Drawing.Point(91, 148);
            this.txtNG.Name = "txtNG";
            this.txtNG.Size = new System.Drawing.Size(100, 26);
            this.txtNG.TabIndex = 6;
            // 
            // txtOk
            // 
            this.txtOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOk.Location = new System.Drawing.Point(92, 83);
            this.txtOk.Name = "txtOk";
            this.txtOk.Size = new System.Drawing.Size(100, 26);
            this.txtOk.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(19, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "CYCLE:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotal.Location = new System.Drawing.Point(92, 20);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(19, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "NG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "OK:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.libAlarm);
            this.groupBox6.Location = new System.Drawing.Point(12, 583);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(357, 309);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ALARM";
            // 
            // libAlarm
            // 
            this.libAlarm.FormattingEnabled = true;
            this.libAlarm.Location = new System.Drawing.Point(8, 20);
            this.libAlarm.Name = "libAlarm";
            this.libAlarm.Size = new System.Drawing.Size(343, 277);
            this.libAlarm.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbPLCConn);
            this.panel1.Location = new System.Drawing.Point(12, 910);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 25);
            this.panel1.TabIndex = 6;
            // 
            // lbPLCConn
            // 
            this.lbPLCConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPLCConn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPLCConn.Location = new System.Drawing.Point(3, 1);
            this.lbPLCConn.Name = "lbPLCConn";
            this.lbPLCConn.Size = new System.Drawing.Size(169, 23);
            this.lbPLCConn.TabIndex = 7;
            this.lbPLCConn.Text = "PLC Connected";
            this.lbPLCConn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCamera
            // 
            this.timerCamera.Interval = 500;
            this.timerCamera.Tick += new System.EventHandler(this.timerCamera_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(400, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "UPPER SURFACE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Location = new System.Drawing.Point(939, 147);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(515, 604);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DISPLAY CAMERA 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(504, 466);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 533);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(290, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOnCam_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(376, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOffCam_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(941, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(513, 43);
            this.label7.TabIndex = 8;
            this.label7.Text = "BELOW SURFACE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pictureBox3);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(1485, 457);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(385, 294);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "RESULT 2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Conn_PLC.Properties.Resources.ok;
            this.pictureBox3.Location = new System.Drawing.Point(6, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(373, 234);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Lime;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(16, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 38);
            this.label8.TabIndex = 5;
            this.label8.Text = "OK";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1792, 60);
            this.label9.TabIndex = 8;
            this.label9.Text = "BEARING CLASSIFICATION SYSTEM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Conn_PLC.Properties.Resources.logo_dai_hoc_cong_nghiep_ha_noi_inkythuatso_01_21_15_51_20;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(285, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "TEST";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VISION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdStatusConn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCapture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVideo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Button btnOffCam;
        private System.Windows.Forms.Button btnOnCam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnPLC;
        private System.Windows.Forms.Button btnDisConnPLC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptbCapture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbVideo;
        private SymbolFactoryDotNet.StandardControl stdStatusConn;
        private System.Windows.Forms.Timer timerPLC;
        private System.Windows.Forms.Label lbOkNG;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCycle;
        private System.Windows.Forms.TextBox txtNG;
        private System.Windows.Forms.TextBox txtOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox libAlarm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPLCConn;
        private System.Windows.Forms.Timer timerCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private LCToolbox.LCTool.LCButton lcButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
    }
}

