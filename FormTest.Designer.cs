namespace ATMC.App.SealerInspection {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.layoutRecentResult = new LotusAPI.Controls.LinearLayout();
            this.graphProfile = new LotusAPI.Controls.Graph.GraphView();
            this.btSetting = new LotusAPI.Controls.Button();
            this.imgCurrent = new LotusAPI.Controls.ImageView();
            this.imgVisualize = new LotusAPI.Controls.ImageView();
            this.logo = new System.Windows.Forms.PictureBox();
            this.linearLayout1 = new LotusAPI.Controls.LinearLayout();
            this.robotName = new ATMC.Controls.LabeledContentView();
            this.modelName = new ATMC.Controls.LabeledContentView();
            this.daqView = new ATMC.HW.DIOView();
            this.logView = new LotusAPI.Controls.LogView();
            this.linearLayout2 = new LotusAPI.Controls.LinearLayout();
            this.lbl_ServerIP = new LotusAPI.Controls.Label();
            this.systemMemoryView1 = new ATMC.Controls.SystemMemoryView();
            this.realtimeClockView1 = new ATMC.Controls.RealtimeClockView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.currentResult = new LotusAPI.Controls.Label();
            this.resultCounter = new ATMC.Controls.ResultCounterView();
            this.btAutoManual = new ATMC.Controls.ToggleButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_InspectionCount = new LotusAPI.Controls.Label();
            this.lbl_ContNGCount = new LotusAPI.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVisualize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.linearLayout1.SuspendLayout();
            this.linearLayout2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutRecentResult
            // 
            this.layoutRecentResult.BackColor = System.Drawing.SystemColors.Control;
            this.layoutRecentResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layoutRecentResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRecentResult.EnableAutoArrange = true;
            this.layoutRecentResult.FixedSize = 50;
            this.layoutRecentResult.Location = new System.Drawing.Point(3, 3);
            this.layoutRecentResult.Margin = new System.Windows.Forms.Padding(0);
            this.layoutRecentResult.Name = "layoutRecentResult";
            this.layoutRecentResult.Orientation = LotusAPI.Controls.LayoutOrientation.Vertical;
            this.layoutRecentResult.ShowPlaceHolder = false;
            this.layoutRecentResult.Size = new System.Drawing.Size(566, 199);
            this.layoutRecentResult.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.layoutRecentResult.Spacing = 3;
            this.layoutRecentResult.TabIndex = 37;
            // 
            // graphProfile
            // 
            this.graphProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphProfile.BorderWidth = 1F;
            this.graphProfile.Color = System.Drawing.Color.White;
            this.graphProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphProfile.ForeColor = System.Drawing.Color.White;
            this.graphProfile.LegendFont = new System.Drawing.Font("Arial", 12F);
            this.graphProfile.LegendLineLength = 50;
            this.graphProfile.LegendSpacingX = 20;
            this.graphProfile.LegendSpacingY = 6;
            this.graphProfile.Location = new System.Drawing.Point(3, 3);
            this.graphProfile.Name = "graphProfile";
            this.graphProfile.ShowLegend = true;
            this.graphProfile.Size = new System.Drawing.Size(566, 199);
            this.graphProfile.TabIndex = 35;
            this.graphProfile.TitleFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            // 
            // btSetting
            // 
            this.btSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSetting.BackColor = System.Drawing.Color.Transparent;
            this.btSetting.BorderColor = System.Drawing.Color.Gray;
            this.btSetting.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.btSetting.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btSetting.BorderRadius = 10;
            this.btSetting.BorderWidth = 0;
            this.btSetting.ColorActivate = System.Drawing.Color.Gray;
            this.btSetting.ColorHover = System.Drawing.Color.Cyan;
            this.btSetting.ColorNormal = System.Drawing.Color.Silver;
            this.btSetting.ContentBackColor = System.Drawing.Color.Silver;
            this.btSetting.ContentForeColor = System.Drawing.Color.Navy;
            this.btSetting.FixedSize = 50;
            this.btSetting.Font = new System.Drawing.Font("12LotteMartDreamBold", 24F);
            this.btSetting.FontSize = 24F;
            this.btSetting.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btSetting.ForeColor = System.Drawing.Color.Navy;
            this.btSetting.Location = new System.Drawing.Point(1193, 2);
            this.btSetting.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(68, 85);
            this.btSetting.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.btSetting.TabIndex = 27;
            this.btSetting.Text = "설정";
            this.btSetting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSetting.Load += new System.EventHandler(this.btSetting_Load);
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // imgCurrent
            // 
            this.imgCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCurrent.BackColor = System.Drawing.Color.Gray;
            this.imgCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCurrent.Location = new System.Drawing.Point(3, 627);
            this.imgCurrent.Name = "imgCurrent";
            this.imgCurrent.Size = new System.Drawing.Size(406, 331);
            this.imgCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCurrent.TabIndex = 0;
            this.imgCurrent.TabStop = false;
            // 
            // imgVisualize
            // 
            this.imgVisualize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgVisualize.BackColor = System.Drawing.Color.Gray;
            this.imgVisualize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgVisualize.Location = new System.Drawing.Point(3, 90);
            this.imgVisualize.Name = "imgVisualize";
            this.imgVisualize.Size = new System.Drawing.Size(1016, 534);
            this.imgVisualize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVisualize.TabIndex = 0;
            this.imgVisualize.TabStop = false;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Image = global::ATMC.App.SealerInspection.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(746, 85);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 28;
            this.logo.TabStop = false;
            // 
            // linearLayout1
            // 
            this.linearLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linearLayout1.BackColor = System.Drawing.Color.Transparent;
            this.linearLayout1.Controls.Add(this.robotName);
            this.linearLayout1.Controls.Add(this.modelName);
            this.linearLayout1.EnableAutoArrange = true;
            this.linearLayout1.FixedSize = 50;
            this.linearLayout1.Location = new System.Drawing.Point(752, 2);
            this.linearLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.linearLayout1.Name = "linearLayout1";
            this.linearLayout1.Orientation = LotusAPI.Controls.LayoutOrientation.Vertical;
            this.linearLayout1.ShowPlaceHolder = false;
            this.linearLayout1.Size = new System.Drawing.Size(267, 85);
            this.linearLayout1.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout1.Spacing = 3;
            this.linearLayout1.TabIndex = 24;
            // 
            // robotName
            // 
            this.robotName.BackColor = System.Drawing.Color.Transparent;
            this.robotName.BorderColor = System.Drawing.Color.Navy;
            this.robotName.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.robotName.BorderRadius = 10;
            this.robotName.BorderWidth = 1;
            this.robotName.ContentColor = System.Drawing.Color.Navy;
            this.robotName.ContentFontSize = 24F;
            this.robotName.ContentFontType = LotusAPI.Controls.FontType.LotteBold;
            this.robotName.ContentText = "ROBOT_1";
            this.robotName.ContentTextColor = System.Drawing.Color.White;
            this.robotName.EnableAutoArrange = true;
            this.robotName.FixedSize = 200;
            this.robotName.LabelColor = System.Drawing.Color.Purple;
            this.robotName.LabelFixedSize = 75;
            this.robotName.LabelFontSize = 22F;
            this.robotName.LabelFontType = LotusAPI.Controls.FontType.LotteBold;
            this.robotName.LabelText = "로봇";
            this.robotName.LabelTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.robotName.Location = new System.Drawing.Point(0, 0);
            this.robotName.Margin = new System.Windows.Forms.Padding(0);
            this.robotName.Name = "robotName";
            this.robotName.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.robotName.ShowPlaceHolder = false;
            this.robotName.Size = new System.Drawing.Size(267, 41);
            this.robotName.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.robotName.Spacing = -1;
            this.robotName.TabIndex = 23;
            // 
            // modelName
            // 
            this.modelName.BackColor = System.Drawing.Color.Transparent;
            this.modelName.BorderColor = System.Drawing.Color.Navy;
            this.modelName.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.modelName.BorderRadius = 10;
            this.modelName.BorderWidth = 1;
            this.modelName.ContentColor = System.Drawing.Color.Navy;
            this.modelName.ContentFontSize = 24F;
            this.modelName.ContentFontType = LotusAPI.Controls.FontType.LotteBold;
            this.modelName.ContentText = "MODEL_1";
            this.modelName.ContentTextColor = System.Drawing.Color.White;
            this.modelName.EnableAutoArrange = true;
            this.modelName.FixedSize = 40;
            this.modelName.LabelColor = System.Drawing.Color.Purple;
            this.modelName.LabelFixedSize = 75;
            this.modelName.LabelFontSize = 22F;
            this.modelName.LabelFontType = LotusAPI.Controls.FontType.LotteBold;
            this.modelName.LabelText = "모델";
            this.modelName.LabelTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.modelName.Location = new System.Drawing.Point(0, 44);
            this.modelName.Margin = new System.Windows.Forms.Padding(0);
            this.modelName.Name = "modelName";
            this.modelName.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.modelName.ShowPlaceHolder = false;
            this.modelName.Size = new System.Drawing.Size(267, 41);
            this.modelName.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.modelName.Spacing = -1;
            this.modelName.TabIndex = 23;
            // 
            // daqView
            // 
            this.daqView.BackColor = System.Drawing.SystemColors.Control;
            this.daqView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daqView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daqView.EnableAutoArrange = true;
            this.daqView.EnableManualMode = false;
            this.daqView.FixedSize = 50;
            this.daqView.ItemColor = System.Drawing.Color.Silver;
            this.daqView.ItemFontSize = 12;
            this.daqView.ItemFontType = LotusAPI.Controls.FontType.LotteBold;
            this.daqView.ItemHeight = 22;
            this.daqView.ItemTextColor = System.Drawing.Color.White;
            this.daqView.LedBorderWidth = 1;
            this.daqView.LedMargin = 1;
            this.daqView.Location = new System.Drawing.Point(3, 3);
            this.daqView.Margin = new System.Windows.Forms.Padding(0);
            this.daqView.Name = "daqView";
            this.daqView.Orientation = LotusAPI.Controls.LayoutOrientation.Vertical;
            this.daqView.ShowPlaceHolder = false;
            this.daqView.Size = new System.Drawing.Size(566, 199);
            this.daqView.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.daqView.Spacing = 0;
            this.daqView.TabIndex = 17;
            this.daqView.TitleFontType = LotusAPI.Controls.FontType.Conthrax;
            this.daqView.TitleHeight = 28;
            // 
            // logView
            // 
            this.logView.BackColor = System.Drawing.Color.Silver;
            this.logView.ColorDateTime = System.Drawing.Color.Gray;
            this.logView.ColorDebug = System.Drawing.Color.Gray;
            this.logView.ColorError = System.Drawing.Color.Red;
            this.logView.ColorFatal = System.Drawing.Color.Magenta;
            this.logView.ColorInfo = System.Drawing.Color.Blue;
            this.logView.ColorNormal = System.Drawing.Color.Black;
            this.logView.ColorTrace = System.Drawing.Color.Gray;
            this.logView.ColorWarning = System.Drawing.Color.Gold;
            this.logView.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView.Font = new System.Drawing.Font("Consolas", 9F);
            this.logView.Location = new System.Drawing.Point(3, 3);
            this.logView.Name = "logView";
            this.logView.ReadOnly = true;
            this.logView.ShowDateTime = false;
            this.logView.Size = new System.Drawing.Size(832, 199);
            this.logView.TabIndex = 34;
            this.logView.Text = "";
            // 
            // linearLayout2
            // 
            this.linearLayout2.BackColor = System.Drawing.Color.Transparent;
            this.linearLayout2.Controls.Add(this.lbl_ServerIP);
            this.linearLayout2.Controls.Add(this.realtimeClockView1);
            this.linearLayout2.Controls.Add(this.systemMemoryView1);
            this.linearLayout2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linearLayout2.EnableAutoArrange = true;
            this.linearLayout2.FixedSize = 50;
            this.linearLayout2.Location = new System.Drawing.Point(0, 961);
            this.linearLayout2.Margin = new System.Windows.Forms.Padding(0);
            this.linearLayout2.Name = "linearLayout2";
            this.linearLayout2.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.linearLayout2.ShowPlaceHolder = false;
            this.linearLayout2.Size = new System.Drawing.Size(1264, 24);
            this.linearLayout2.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout2.Spacing = 0;
            this.linearLayout2.TabIndex = 38;
            // 
            // lbl_ServerIP
            // 
            this.lbl_ServerIP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ServerIP.BorderColor = System.Drawing.Color.Transparent;
            this.lbl_ServerIP.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lbl_ServerIP.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lbl_ServerIP.BorderRadius = 0;
            this.lbl_ServerIP.BorderWidth = 0;
            this.lbl_ServerIP.ContentBackColor = System.Drawing.Color.Red;
            this.lbl_ServerIP.ContentForeColor = System.Drawing.Color.Navy;
            this.lbl_ServerIP.FixedSize = 200;
            this.lbl_ServerIP.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.lbl_ServerIP.FontSize = 14F;
            this.lbl_ServerIP.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.lbl_ServerIP.ForeColor = System.Drawing.Color.Navy;
            this.lbl_ServerIP.Location = new System.Drawing.Point(0, 0);
            this.lbl_ServerIP.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ServerIP.Name = "lbl_ServerIP";
            this.lbl_ServerIP.Size = new System.Drawing.Size(200, 24);
            this.lbl_ServerIP.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.lbl_ServerIP.TabIndex = 39;
            this.lbl_ServerIP.Text = "192.168.1.1";
            this.lbl_ServerIP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // systemMemoryView1
            // 
            this.systemMemoryView1.BackColor = System.Drawing.Color.Transparent;
            this.systemMemoryView1.BorderColor = System.Drawing.Color.Navy;
            this.systemMemoryView1.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.systemMemoryView1.BorderMargins = new System.Windows.Forms.Padding(0);
            this.systemMemoryView1.BorderRadius = 3;
            this.systemMemoryView1.BorderWidth = 1;
            this.systemMemoryView1.ContentBackColor = System.Drawing.Color.Navy;
            this.systemMemoryView1.ContentForeColor = System.Drawing.Color.Silver;
            this.systemMemoryView1.FixedSize = 30;
            this.systemMemoryView1.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.systemMemoryView1.FontSize = 14F;
            this.systemMemoryView1.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.systemMemoryView1.ForeColor = System.Drawing.Color.Navy;
            this.systemMemoryView1.Location = new System.Drawing.Point(450, 0);
            this.systemMemoryView1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.systemMemoryView1.Name = "systemMemoryView1";
            this.systemMemoryView1.RefreshInterval = 1000;
            this.systemMemoryView1.Size = new System.Drawing.Size(814, 24);
            this.systemMemoryView1.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.systemMemoryView1.TabIndex = 36;
            this.systemMemoryView1.Text = "[DDR: 0.44/34GB] [C: 387/1050GB] [D: 404/500GB] [E: 1905/2000GB] [I: 231/256GB] >" +
    "";
            this.systemMemoryView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // realtimeClockView1
            // 
            this.realtimeClockView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.realtimeClockView1.BackColor = System.Drawing.Color.Transparent;
            this.realtimeClockView1.BorderColor = System.Drawing.Color.Navy;
            this.realtimeClockView1.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.realtimeClockView1.BorderMargins = new System.Windows.Forms.Padding(0);
            this.realtimeClockView1.BorderRadius = 5;
            this.realtimeClockView1.BorderWidth = 1;
            this.realtimeClockView1.ContentBackColor = System.Drawing.Color.Gray;
            this.realtimeClockView1.ContentForeColor = System.Drawing.Color.Navy;
            this.realtimeClockView1.FixedSize = 250;
            this.realtimeClockView1.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.realtimeClockView1.FontSize = 14F;
            this.realtimeClockView1.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.realtimeClockView1.ForeColor = System.Drawing.Color.Navy;
            this.realtimeClockView1.Location = new System.Drawing.Point(200, 0);
            this.realtimeClockView1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.realtimeClockView1.Name = "realtimeClockView1";
            this.realtimeClockView1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.realtimeClockView1.Size = new System.Drawing.Size(250, 24);
            this.realtimeClockView1.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.realtimeClockView1.TabIndex = 25;
            this.realtimeClockView1.Text = "2020-03-03 11:53:20";
            this.realtimeClockView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(415, 727);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 231);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.logView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(838, 205);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LOG";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.layoutRecentResult);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(572, 205);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RecentResult";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphProfile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.daqView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "I/O";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // currentResult
            // 
            this.currentResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentResult.BackColor = System.Drawing.Color.Transparent;
            this.currentResult.BorderColor = System.Drawing.Color.Gray;
            this.currentResult.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.currentResult.BorderMargins = new System.Windows.Forms.Padding(0);
            this.currentResult.BorderRadius = 0;
            this.currentResult.BorderWidth = 0;
            this.currentResult.ContentBackColor = System.Drawing.Color.Yellow;
            this.currentResult.ContentForeColor = System.Drawing.Color.Navy;
            this.currentResult.FixedSize = 30;
            this.currentResult.Font = new System.Drawing.Font("Montroc Semi-Italic", 64F);
            this.currentResult.FontSize = 64F;
            this.currentResult.FontType = LotusAPI.Controls.FontType.MontrocSemitall;
            this.currentResult.ForeColor = System.Drawing.Color.Navy;
            this.currentResult.Location = new System.Drawing.Point(1022, 90);
            this.currentResult.Margin = new System.Windows.Forms.Padding(0);
            this.currentResult.Name = "currentResult";
            this.currentResult.Size = new System.Drawing.Size(239, 433);
            this.currentResult.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.currentResult.TabIndex = 40;
            this.currentResult.Text = "...";
            this.currentResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentResult.Load += new System.EventHandler(this.currentResult_Load);
            // 
            // resultCounter
            // 
            this.resultCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultCounter.BackColor = System.Drawing.Color.Transparent;
            this.resultCounter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resultCounter.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.resultCounter.BorderRadius = 10;
            this.resultCounter.BorderWidth = 1;
            this.resultCounter.EnableAutoArrange = true;
            this.resultCounter.FixedSize = 0;
            this.resultCounter.LabelFixedSize = 30;
            this.resultCounter.LabelFontSize = 16F;
            this.resultCounter.LabelFontType = LotusAPI.Controls.FontType.MontrocSemitall;
            this.resultCounter.LabelTextColor = System.Drawing.Color.Navy;
            this.resultCounter.Location = new System.Drawing.Point(415, 627);
            this.resultCounter.Margin = new System.Windows.Forms.Padding(0);
            this.resultCounter.Name = "resultCounter";
            this.resultCounter.NGCount = 3;
            this.resultCounter.NumberColor = System.Drawing.Color.Navy;
            this.resultCounter.NumberFontSize = 36F;
            this.resultCounter.NumberFontType = LotusAPI.Controls.FontType.Samson;
            this.resultCounter.NumberTextColor = System.Drawing.Color.White;
            this.resultCounter.OKCount = 12345;
            this.resultCounter.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.resultCounter.ShowPlaceHolder = false;
            this.resultCounter.Size = new System.Drawing.Size(846, 97);
            this.resultCounter.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.resultCounter.Spacing = -1;
            this.resultCounter.TabIndex = 19;
            // 
            // btAutoManual
            // 
            this.btAutoManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAutoManual.BackColor = System.Drawing.Color.Transparent;
            this.btAutoManual.BlinkON = true;
            this.btAutoManual.BorderColor = System.Drawing.Color.Navy;
            this.btAutoManual.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.btAutoManual.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btAutoManual.BorderRadius = 10;
            this.btAutoManual.BorderWidth = 1;
            this.btAutoManual.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAutoManual.ContentForeColor = System.Drawing.Color.Navy;
            this.btAutoManual.FixedSize = 30;
            this.btAutoManual.Font = new System.Drawing.Font("12LotteMartDreamBold", 24F);
            this.btAutoManual.FontSize = 24F;
            this.btAutoManual.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btAutoManual.ForeColor = System.Drawing.Color.Navy;
            this.btAutoManual.LedBlinking = true;
            this.btAutoManual.LedBlinkRate = 5;
            this.btAutoManual.LedBorderWidth = 2;
            this.btAutoManual.LedMargin = 15;
            this.btAutoManual.LedOffColor = System.Drawing.Color.Gray;
            this.btAutoManual.LedOnColor = System.Drawing.Color.Lime;
            this.btAutoManual.LedShape = ATMC.Controls.LED.Shape.DoubleTriangle;
            this.btAutoManual.LedValue = true;
            this.btAutoManual.Location = new System.Drawing.Point(1022, 2);
            this.btAutoManual.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btAutoManual.Name = "btAutoManual";
            this.btAutoManual.Size = new System.Drawing.Size(170, 85);
            this.btAutoManual.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btAutoManual.State = false;
            this.btAutoManual.TabIndex = 26;
            this.btAutoManual.Text = "수동";
            this.btAutoManual.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAutoManual.TextOFF = "수동";
            this.btAutoManual.TextON = "자동";
            this.btAutoManual.StateON += new ATMC.Controls.ToggleButton.StateOnEventHandler(this.toggleButton1_StateON);
            this.btAutoManual.StateOFF += new ATMC.Controls.ToggleButton.StateOnEventHandler(this.toggleButton1_StateOFF);
            // 
            // lbl_InspectionCount
            // 
            this.lbl_InspectionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InspectionCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InspectionCount.BorderColor = System.Drawing.Color.Gray;
            this.lbl_InspectionCount.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lbl_InspectionCount.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lbl_InspectionCount.BorderRadius = 0;
            this.lbl_InspectionCount.BorderWidth = 0;
            this.lbl_InspectionCount.ContentBackColor = System.Drawing.Color.Navy;
            this.lbl_InspectionCount.ContentForeColor = System.Drawing.Color.White;
            this.lbl_InspectionCount.FixedSize = 30;
            this.lbl_InspectionCount.Font = new System.Drawing.Font("Slope Opera", 28F);
            this.lbl_InspectionCount.FontSize = 28F;
            this.lbl_InspectionCount.FontType = LotusAPI.Controls.FontType.SlopeOpera;
            this.lbl_InspectionCount.ForeColor = System.Drawing.Color.Navy;
            this.lbl_InspectionCount.Location = new System.Drawing.Point(1022, 528);
            this.lbl_InspectionCount.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_InspectionCount.Name = "lbl_InspectionCount";
            this.lbl_InspectionCount.Size = new System.Drawing.Size(239, 54);
            this.lbl_InspectionCount.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.lbl_InspectionCount.TabIndex = 41;
            this.lbl_InspectionCount.Text = "39/40";
            this.lbl_InspectionCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ContNGCount
            // 
            this.lbl_ContNGCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ContNGCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ContNGCount.BorderColor = System.Drawing.Color.Gray;
            this.lbl_ContNGCount.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lbl_ContNGCount.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lbl_ContNGCount.BorderRadius = 0;
            this.lbl_ContNGCount.BorderWidth = 0;
            this.lbl_ContNGCount.ContentBackColor = System.Drawing.Color.Navy;
            this.lbl_ContNGCount.ContentForeColor = System.Drawing.Color.White;
            this.lbl_ContNGCount.FixedSize = 30;
            this.lbl_ContNGCount.Font = new System.Drawing.Font("Slope Opera", 28F);
            this.lbl_ContNGCount.FontSize = 28F;
            this.lbl_ContNGCount.FontType = LotusAPI.Controls.FontType.SlopeOpera;
            this.lbl_ContNGCount.ForeColor = System.Drawing.Color.Navy;
            this.lbl_ContNGCount.Location = new System.Drawing.Point(1022, 582);
            this.lbl_ContNGCount.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ContNGCount.Name = "lbl_ContNGCount";
            this.lbl_ContNGCount.Size = new System.Drawing.Size(239, 42);
            this.lbl_ContNGCount.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.lbl_ContNGCount.TabIndex = 41;
            this.lbl_ContNGCount.Text = "0";
            this.lbl_ContNGCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.lbl_ContNGCount);
            this.Controls.Add(this.lbl_InspectionCount);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.currentResult);
            this.Controls.Add(this.linearLayout1);
            this.Controls.Add(this.imgVisualize);
            this.Controls.Add(this.imgCurrent);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linearLayout2);
            this.Controls.Add(this.resultCounter);
            this.Controls.Add(this.btAutoManual);
            this.Controls.Add(this.btSetting);
            this.Name = "FormMain";
            this.Text = "실러 검사 (v1.1)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVisualize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.linearLayout1.ResumeLayout(false);
            this.linearLayout2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LotusAPI.Controls.LogView logView;
        private ATMC.HW.DIOView daqView;
        private ATMC.Controls.ResultCounterView resultCounter;
        private ATMC.Controls.LabeledContentView modelName;
        private ATMC.Controls.RealtimeClockView realtimeClockView1;
        private ATMC.Controls.ToggleButton btAutoManual;
        private System.Windows.Forms.PictureBox logo;
        private LotusAPI.Controls.ImageView imgCurrent;
        private LotusAPI.Controls.ImageView imgVisualize;
        private LotusAPI.Controls.Button btSetting;
        private LotusAPI.Controls.Graph.GraphView graphProfile;
        private ATMC.Controls.SystemMemoryView systemMemoryView1;
        private LotusAPI.Controls.LinearLayout layoutRecentResult;
        private LotusAPI.Controls.LinearLayout linearLayout1;
        private Controls.LabeledContentView robotName;
        private LotusAPI.Controls.LinearLayout linearLayout2;
        private LotusAPI.Controls.Label lbl_ServerIP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private LotusAPI.Controls.Label currentResult;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private LotusAPI.Controls.Label lbl_InspectionCount;
        private LotusAPI.Controls.Label lbl_ContNGCount;
    }
}

