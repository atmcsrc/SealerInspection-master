using System.Windows.Forms;

namespace ATMC.App.SealerInspection {
    partial class FormDetectorSetting {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgrid = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCamera2 = new System.Windows.Forms.RadioButton();
            this.rbCamera1 = new System.Windows.Forms.RadioButton();
            this.linearLayout5 = new LotusAPI.Controls.LinearLayout();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgridBlur = new System.Windows.Forms.PropertyGrid();
            this.cbbBlurType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pgridThreshold = new System.Windows.Forms.PropertyGrid();
            this.cbbThresholdType = new System.Windows.Forms.ComboBox();
            this.linearLayout4 = new LotusAPI.Controls.LinearLayout();
            this.btAddROI = new LotusAPI.Controls.Button();
            this.btClearROI = new LotusAPI.Controls.Button();
            this.lbRegions = new System.Windows.Forms.ListBox();
            this.nud_RoiWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_WidthThresholdUpper = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_WidthThresholdLower = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_OKThreshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImgIdx = new LotusAPI.Controls.Label();
            this.ckb_Use = new System.Windows.Forms.CheckBox();
            this.linearLayout2 = new LotusAPI.Controls.LinearLayout();
            this.btLoadConfig = new LotusAPI.Controls.Button();
            this.btSaveConfig = new LotusAPI.Controls.Button();
            this.linearLayout1 = new LotusAPI.Controls.LinearLayout();
            this.bt_FirstImg = new LotusAPI.Controls.Button();
            this.bt_PrevImg = new LotusAPI.Controls.Button();
            this.bt_NextImg = new LotusAPI.Controls.Button();
            this.bt_LastImg = new LotusAPI.Controls.Button();
            this.cbbImages = new System.Windows.Forms.ComboBox();
            this.btOpenVisualizeImage = new LotusAPI.Controls.Button();
            this.btLoadImage = new LotusAPI.Controls.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linearLayout3 = new LotusAPI.Controls.LinearLayout();
            this.imgview = new LotusAPI.Controls.ImageView();
            this.vizView = new LotusAPI.Controls.ImageView();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.graph = new LotusAPI.Controls.Graph.GraphView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.linearLayout5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.linearLayout4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RoiWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WidthThresholdUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WidthThresholdLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OKThreshold)).BeginInit();
            this.linearLayout2.SuspendLayout();
            this.linearLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.linearLayout3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.lblImgIdx);
            this.splitContainer1.Panel1.Controls.Add(this.ckb_Use);
            this.splitContainer1.Panel1.Controls.Add(this.linearLayout2);
            this.splitContainer1.Panel1.Controls.Add(this.linearLayout1);
            this.splitContainer1.Panel1.Controls.Add(this.cbbImages);
            this.splitContainer1.Panel1.Controls.Add(this.btOpenVisualizeImage);
            this.splitContainer1.Panel1.Controls.Add(this.btLoadImage);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1242, 781);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pgrid);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.linearLayout5);
            this.panel1.Controls.Add(this.linearLayout4);
            this.panel1.Controls.Add(this.lbRegions);
            this.panel1.Controls.Add(this.nud_RoiWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nud_WidthThresholdUpper);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nud_WidthThresholdLower);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nud_OKThreshold);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 569);
            this.panel1.TabIndex = 1;
            // 
            // pgrid
            // 
            this.pgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgrid.Font = new System.Drawing.Font("Consolas", 10F);
            this.pgrid.HelpVisible = false;
            this.pgrid.Location = new System.Drawing.Point(3, 3);
            this.pgrid.Name = "pgrid";
            this.pgrid.Size = new System.Drawing.Size(322, 67);
            this.pgrid.TabIndex = 6;
            this.pgrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgrid_PropertyValueChanged);
            this.pgrid.Click += new System.EventHandler(this.pgrid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbCamera2);
            this.groupBox1.Controls.Add(this.rbCamera1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "카메라";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbCamera2
            // 
            this.rbCamera2.AutoSize = true;
            this.rbCamera2.Font = new System.Drawing.Font("Consolas", 12F);
            this.rbCamera2.Location = new System.Drawing.Point(151, 19);
            this.rbCamera2.Name = "rbCamera2";
            this.rbCamera2.Size = new System.Drawing.Size(90, 23);
            this.rbCamera2.TabIndex = 0;
            this.rbCamera2.Text = "Camera2";
            this.rbCamera2.UseVisualStyleBackColor = true;
            this.rbCamera2.CheckedChanged += new System.EventHandler(this.rbCamera1_CheckedChanged);
            // 
            // rbCamera1
            // 
            this.rbCamera1.AutoSize = true;
            this.rbCamera1.Checked = true;
            this.rbCamera1.Font = new System.Drawing.Font("Consolas", 12F);
            this.rbCamera1.Location = new System.Drawing.Point(18, 19);
            this.rbCamera1.Name = "rbCamera1";
            this.rbCamera1.Size = new System.Drawing.Size(90, 23);
            this.rbCamera1.TabIndex = 0;
            this.rbCamera1.TabStop = true;
            this.rbCamera1.Text = "Camera1";
            this.rbCamera1.UseVisualStyleBackColor = true;
            this.rbCamera1.CheckedChanged += new System.EventHandler(this.rbCamera1_CheckedChanged);
            // 
            // linearLayout5
            // 
            this.linearLayout5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linearLayout5.BackColor = System.Drawing.SystemColors.Control;
            this.linearLayout5.Controls.Add(this.groupBox2);
            this.linearLayout5.Controls.Add(this.groupBox3);
            this.linearLayout5.EnableAutoArrange = true;
            this.linearLayout5.FixedSize = 50;
            this.linearLayout5.Location = new System.Drawing.Point(3, 76);
            this.linearLayout5.Margin = new System.Windows.Forms.Padding(0);
            this.linearLayout5.Name = "linearLayout5";
            this.linearLayout5.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.linearLayout5.ShowPlaceHolder = false;
            this.linearLayout5.Size = new System.Drawing.Size(322, 197);
            this.linearLayout5.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout5.Spacing = 3;
            this.linearLayout5.TabIndex = 14;
            this.linearLayout5.Load += new System.EventHandler(this.linearLayout5_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgridBlur);
            this.groupBox2.Controls.Add(this.cbbBlurType);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 197);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "블러 방법";
            // 
            // pgridBlur
            // 
            this.pgridBlur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgridBlur.HelpVisible = false;
            this.pgridBlur.Location = new System.Drawing.Point(3, 49);
            this.pgridBlur.Name = "pgridBlur";
            this.pgridBlur.Size = new System.Drawing.Size(153, 145);
            this.pgridBlur.TabIndex = 0;
            this.pgridBlur.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgrid_PropertyValueChanged);
            // 
            // cbbBlurType
            // 
            this.cbbBlurType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbBlurType.FormattingEnabled = true;
            this.cbbBlurType.Items.AddRange(new object[] {
            "LotusAPI.MV.BoxFilter",
            "LotusAPI.MV.GaussianFilter",
            "LotusAPI.MV.MedianFilter"});
            this.cbbBlurType.Location = new System.Drawing.Point(3, 22);
            this.cbbBlurType.Name = "cbbBlurType";
            this.cbbBlurType.Size = new System.Drawing.Size(153, 27);
            this.cbbBlurType.TabIndex = 1;
            this.cbbBlurType.SelectedIndexChanged += new System.EventHandler(this.cbbBlurType_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pgridThreshold);
            this.groupBox3.Controls.Add(this.cbbThresholdType);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBox3.Location = new System.Drawing.Point(162, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 197);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "임계값 방법";
            // 
            // pgridThreshold
            // 
            this.pgridThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgridThreshold.HelpVisible = false;
            this.pgridThreshold.Location = new System.Drawing.Point(3, 49);
            this.pgridThreshold.Name = "pgridThreshold";
            this.pgridThreshold.Size = new System.Drawing.Size(153, 145);
            this.pgridThreshold.TabIndex = 1;
            this.pgridThreshold.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgrid_PropertyValueChanged);
            // 
            // cbbThresholdType
            // 
            this.cbbThresholdType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbThresholdType.FormattingEnabled = true;
            this.cbbThresholdType.Items.AddRange(new object[] {
            "LotusAPI.MV.BinaryThresholdFilter",
            "LotusAPI.MV.MeanAdaptiveThresholdFilter",
            "LotusAPI.MV.GaussianAdaptiveThresholdFilter",
            "LotusAPI.MV.LocalAverageAdaptiveThresholdFilter"});
            this.cbbThresholdType.Location = new System.Drawing.Point(3, 22);
            this.cbbThresholdType.Name = "cbbThresholdType";
            this.cbbThresholdType.Size = new System.Drawing.Size(153, 27);
            this.cbbThresholdType.TabIndex = 0;
            this.cbbThresholdType.SelectedIndexChanged += new System.EventHandler(this.cbbThresholdType_SelectedIndexChanged);
            // 
            // linearLayout4
            // 
            this.linearLayout4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linearLayout4.BackColor = System.Drawing.SystemColors.Control;
            this.linearLayout4.Controls.Add(this.btAddROI);
            this.linearLayout4.Controls.Add(this.btClearROI);
            this.linearLayout4.EnableAutoArrange = true;
            this.linearLayout4.FixedSize = 50;
            this.linearLayout4.Location = new System.Drawing.Point(3, 451);
            this.linearLayout4.Margin = new System.Windows.Forms.Padding(0);
            this.linearLayout4.Name = "linearLayout4";
            this.linearLayout4.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.linearLayout4.ShowPlaceHolder = false;
            this.linearLayout4.Size = new System.Drawing.Size(322, 41);
            this.linearLayout4.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout4.Spacing = -1;
            this.linearLayout4.TabIndex = 5;
            // 
            // btAddROI
            // 
            this.btAddROI.BackColor = System.Drawing.Color.Transparent;
            this.btAddROI.BorderColor = System.Drawing.Color.Gray;
            this.btAddROI.BorderCorners = LotusAPI.Controls.BorderCorners.Left;
            this.btAddROI.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btAddROI.BorderRadius = 10;
            this.btAddROI.BorderWidth = 1;
            this.btAddROI.ColorActivate = System.Drawing.Color.Gray;
            this.btAddROI.ColorHover = System.Drawing.Color.Cyan;
            this.btAddROI.ColorNormal = System.Drawing.Color.Silver;
            this.btAddROI.ContentBackColor = System.Drawing.Color.Silver;
            this.btAddROI.ContentForeColor = System.Drawing.Color.Navy;
            this.btAddROI.FixedSize = 60;
            this.btAddROI.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.btAddROI.FontSize = 14F;
            this.btAddROI.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btAddROI.ForeColor = System.Drawing.Color.Navy;
            this.btAddROI.Location = new System.Drawing.Point(0, 0);
            this.btAddROI.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btAddROI.Name = "btAddROI";
            this.btAddROI.Size = new System.Drawing.Size(161, 41);
            this.btAddROI.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btAddROI.TabIndex = 4;
            this.btAddROI.Text = "세그먼트 추가";
            this.btAddROI.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAddROI.Click += new System.EventHandler(this.bt_AddROI);
            // 
            // btClearROI
            // 
            this.btClearROI.BackColor = System.Drawing.Color.Transparent;
            this.btClearROI.BorderColor = System.Drawing.Color.Gray;
            this.btClearROI.BorderCorners = LotusAPI.Controls.BorderCorners.Right;
            this.btClearROI.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btClearROI.BorderRadius = 10;
            this.btClearROI.BorderWidth = 1;
            this.btClearROI.ColorActivate = System.Drawing.Color.Gray;
            this.btClearROI.ColorHover = System.Drawing.Color.Cyan;
            this.btClearROI.ColorNormal = System.Drawing.Color.Silver;
            this.btClearROI.ContentBackColor = System.Drawing.Color.Silver;
            this.btClearROI.ContentForeColor = System.Drawing.Color.Navy;
            this.btClearROI.FixedSize = 40;
            this.btClearROI.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.btClearROI.FontSize = 14F;
            this.btClearROI.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btClearROI.ForeColor = System.Drawing.Color.Navy;
            this.btClearROI.Location = new System.Drawing.Point(160, 0);
            this.btClearROI.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btClearROI.Name = "btClearROI";
            this.btClearROI.Size = new System.Drawing.Size(161, 41);
            this.btClearROI.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btClearROI.TabIndex = 4;
            this.btClearROI.Text = "다시 놓기";
            this.btClearROI.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btClearROI.Click += new System.EventHandler(this.btClearROI_Click);
            // 
            // lbRegions
            // 
            this.lbRegions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRegions.Font = new System.Drawing.Font("Consolas", 9F);
            this.lbRegions.FormattingEnabled = true;
            this.lbRegions.IntegralHeight = false;
            this.lbRegions.ItemHeight = 14;
            this.lbRegions.Location = new System.Drawing.Point(1, 495);
            this.lbRegions.Name = "lbRegions";
            this.lbRegions.Size = new System.Drawing.Size(324, 72);
            this.lbRegions.TabIndex = 8;
            // 
            // nud_RoiWidth
            // 
            this.nud_RoiWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_RoiWidth.Font = new System.Drawing.Font("Consolas", 12F);
            this.nud_RoiWidth.Location = new System.Drawing.Point(76, 326);
            this.nud_RoiWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_RoiWidth.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_RoiWidth.Name = "nud_RoiWidth";
            this.nud_RoiWidth.Size = new System.Drawing.Size(249, 26);
            this.nud_RoiWidth.TabIndex = 10;
            this.nud_RoiWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_RoiWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_RoiWidth.ValueChanged += new System.EventHandler(this.nud_RoiWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(4, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "OK 임계값";
            // 
            // nud_WidthThresholdUpper
            // 
            this.nud_WidthThresholdUpper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_WidthThresholdUpper.Font = new System.Drawing.Font("Consolas", 12F);
            this.nud_WidthThresholdUpper.Location = new System.Drawing.Point(76, 384);
            this.nud_WidthThresholdUpper.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_WidthThresholdUpper.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_WidthThresholdUpper.Name = "nud_WidthThresholdUpper";
            this.nud_WidthThresholdUpper.Size = new System.Drawing.Size(249, 26);
            this.nud_WidthThresholdUpper.TabIndex = 10;
            this.nud_WidthThresholdUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_WidthThresholdUpper.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_WidthThresholdUpper.ValueChanged += new System.EventHandler(this.nud_Threshold_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.Location = new System.Drawing.Point(3, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "폭 상한값";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // nud_WidthThresholdLower
            // 
            this.nud_WidthThresholdLower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_WidthThresholdLower.Font = new System.Drawing.Font("Consolas", 12F);
            this.nud_WidthThresholdLower.Location = new System.Drawing.Point(76, 355);
            this.nud_WidthThresholdLower.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_WidthThresholdLower.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_WidthThresholdLower.Name = "nud_WidthThresholdLower";
            this.nud_WidthThresholdLower.Size = new System.Drawing.Size(249, 26);
            this.nud_WidthThresholdLower.TabIndex = 10;
            this.nud_WidthThresholdLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_WidthThresholdLower.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_WidthThresholdLower.ValueChanged += new System.EventHandler(this.nud_Threshold_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(4, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "폭 하한값";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nud_OKThreshold
            // 
            this.nud_OKThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_OKThreshold.Font = new System.Drawing.Font("Consolas", 12F);
            this.nud_OKThreshold.Location = new System.Drawing.Point(76, 413);
            this.nud_OKThreshold.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_OKThreshold.Name = "nud_OKThreshold";
            this.nud_OKThreshold.Size = new System.Drawing.Size(249, 26);
            this.nud_OKThreshold.TabIndex = 10;
            this.nud_OKThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_OKThreshold.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nud_OKThreshold.ValueChanged += new System.EventHandler(this.nud_Threshold_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(4, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "ROI 폭";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblImgIdx
            // 
            this.lblImgIdx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImgIdx.BackColor = System.Drawing.Color.Transparent;
            this.lblImgIdx.BorderColor = System.Drawing.Color.Gray;
            this.lblImgIdx.BorderCorners = LotusAPI.Controls.BorderCorners.All;
            this.lblImgIdx.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lblImgIdx.BorderRadius = 10;
            this.lblImgIdx.BorderWidth = 1;
            this.lblImgIdx.ContentBackColor = System.Drawing.SystemColors.Control;
            this.lblImgIdx.ContentForeColor = System.Drawing.Color.Navy;
            this.lblImgIdx.FixedSize = 30;
            this.lblImgIdx.Font = new System.Drawing.Font("Conthrax Sb", 22F);
            this.lblImgIdx.FontSize = 22F;
            this.lblImgIdx.FontType = LotusAPI.Controls.FontType.Conthrax;
            this.lblImgIdx.ForeColor = System.Drawing.Color.Navy;
            this.lblImgIdx.Location = new System.Drawing.Point(182, 5);
            this.lblImgIdx.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblImgIdx.Name = "lblImgIdx";
            this.lblImgIdx.Size = new System.Drawing.Size(148, 65);
            this.lblImgIdx.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.lblImgIdx.TabIndex = 16;
            this.lblImgIdx.Text = "0/0";
            this.lblImgIdx.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckb_Use
            // 
            this.ckb_Use.AutoSize = true;
            this.ckb_Use.Font = new System.Drawing.Font("Consolas", 12F);
            this.ckb_Use.Location = new System.Drawing.Point(3, 142);
            this.ckb_Use.Name = "ckb_Use";
            this.ckb_Use.Size = new System.Drawing.Size(52, 23);
            this.ckb_Use.TabIndex = 15;
            this.ckb_Use.Text = "사용";
            this.ckb_Use.UseVisualStyleBackColor = true;
            this.ckb_Use.CheckedChanged += new System.EventHandler(this.ckb_Skip_CheckedChanged);
            // 
            // linearLayout2
            // 
            this.linearLayout2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linearLayout2.BackColor = System.Drawing.SystemColors.Control;
            this.linearLayout2.Controls.Add(this.btLoadConfig);
            this.linearLayout2.Controls.Add(this.btSaveConfig);
            this.linearLayout2.EnableAutoArrange = true;
            this.linearLayout2.FixedSize = 50;
            this.linearLayout2.Location = new System.Drawing.Point(4, 734);
            this.linearLayout2.Margin = new System.Windows.Forms.Padding(0);
            this.linearLayout2.Name = "linearLayout2";
            this.linearLayout2.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.linearLayout2.ShowPlaceHolder = false;
            this.linearLayout2.Size = new System.Drawing.Size(325, 43);
            this.linearLayout2.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout2.Spacing = -1;
            this.linearLayout2.TabIndex = 9;
            // 
            // btLoadConfig
            // 
            this.btLoadConfig.BackColor = System.Drawing.Color.Transparent;
            this.btLoadConfig.BorderColor = System.Drawing.Color.Gray;
            this.btLoadConfig.BorderCorners = LotusAPI.Controls.BorderCorners.Left;
            this.btLoadConfig.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btLoadConfig.BorderRadius = 10;
            this.btLoadConfig.BorderWidth = 1;
            this.btLoadConfig.ColorActivate = System.Drawing.Color.Gray;
            this.btLoadConfig.ColorHover = System.Drawing.Color.Cyan;
            this.btLoadConfig.ColorNormal = System.Drawing.Color.Silver;
            this.btLoadConfig.ContentBackColor = System.Drawing.Color.Silver;
            this.btLoadConfig.ContentForeColor = System.Drawing.Color.Navy;
            this.btLoadConfig.FixedSize = 30;
            this.btLoadConfig.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.btLoadConfig.FontSize = 14F;
            this.btLoadConfig.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btLoadConfig.ForeColor = System.Drawing.Color.Navy;
            this.btLoadConfig.Location = new System.Drawing.Point(0, 0);
            this.btLoadConfig.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btLoadConfig.Name = "btLoadConfig";
            this.btLoadConfig.Size = new System.Drawing.Size(163, 43);
            this.btLoadConfig.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btLoadConfig.TabIndex = 4;
            this.btLoadConfig.Text = "구성로드";
            this.btLoadConfig.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLoadConfig.Load += new System.EventHandler(this.btLoadConfig_Load);
            this.btLoadConfig.Click += new System.EventHandler(this.btLoadConfig_Click);
            // 
            // btSaveConfig
            // 
            this.btSaveConfig.BackColor = System.Drawing.Color.Transparent;
            this.btSaveConfig.BorderColor = System.Drawing.Color.Gray;
            this.btSaveConfig.BorderCorners = LotusAPI.Controls.BorderCorners.Right;
            this.btSaveConfig.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btSaveConfig.BorderRadius = 10;
            this.btSaveConfig.BorderWidth = 1;
            this.btSaveConfig.ColorActivate = System.Drawing.Color.Gray;
            this.btSaveConfig.ColorHover = System.Drawing.Color.Cyan;
            this.btSaveConfig.ColorNormal = System.Drawing.Color.Silver;
            this.btSaveConfig.ContentBackColor = System.Drawing.Color.Silver;
            this.btSaveConfig.ContentForeColor = System.Drawing.Color.Navy;
            this.btSaveConfig.FixedSize = 30;
            this.btSaveConfig.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.btSaveConfig.FontSize = 14F;
            this.btSaveConfig.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btSaveConfig.ForeColor = System.Drawing.Color.Navy;
            this.btSaveConfig.Location = new System.Drawing.Point(162, 0);
            this.btSaveConfig.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btSaveConfig.Name = "btSaveConfig";
            this.btSaveConfig.Size = new System.Drawing.Size(163, 43);
            this.btSaveConfig.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btSaveConfig.TabIndex = 4;
            this.btSaveConfig.Text = "구성 저장";
            this.btSaveConfig.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSaveConfig.Load += new System.EventHandler(this.btSaveConfig_Load);
            this.btSaveConfig.Click += new System.EventHandler(this.btSaveConfig_Click);
            // 
            // linearLayout1
            // 
            this.linearLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linearLayout1.BackColor = System.Drawing.SystemColors.Control;
            this.linearLayout1.Controls.Add(this.bt_FirstImg);
            this.linearLayout1.Controls.Add(this.bt_PrevImg);
            this.linearLayout1.Controls.Add(this.bt_NextImg);
            this.linearLayout1.Controls.Add(this.bt_LastImg);
            this.linearLayout1.EnableAutoArrange = true;
            this.linearLayout1.FixedSize = 50;
            this.linearLayout1.Location = new System.Drawing.Point(6, 73);
            this.linearLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.linearLayout1.Name = "linearLayout1";
            this.linearLayout1.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.linearLayout1.ShowPlaceHolder = false;
            this.linearLayout1.Size = new System.Drawing.Size(326, 35);
            this.linearLayout1.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout1.Spacing = -1;
            this.linearLayout1.TabIndex = 5;
            // 
            // bt_FirstImg
            // 
            this.bt_FirstImg.BackColor = System.Drawing.Color.Transparent;
            this.bt_FirstImg.BorderColor = System.Drawing.Color.Gray;
            this.bt_FirstImg.BorderCorners = LotusAPI.Controls.BorderCorners.Left;
            this.bt_FirstImg.BorderMargins = new System.Windows.Forms.Padding(0);
            this.bt_FirstImg.BorderRadius = 10;
            this.bt_FirstImg.BorderWidth = 1;
            this.bt_FirstImg.ColorActivate = System.Drawing.Color.Gray;
            this.bt_FirstImg.ColorHover = System.Drawing.Color.Cyan;
            this.bt_FirstImg.ColorNormal = System.Drawing.Color.Silver;
            this.bt_FirstImg.ContentBackColor = System.Drawing.Color.Silver;
            this.bt_FirstImg.ContentForeColor = System.Drawing.Color.Navy;
            this.bt_FirstImg.FixedSize = 60;
            this.bt_FirstImg.Font = new System.Drawing.Font("Montroc", 14F);
            this.bt_FirstImg.FontSize = 14F;
            this.bt_FirstImg.FontType = LotusAPI.Controls.FontType.Montroc;
            this.bt_FirstImg.ForeColor = System.Drawing.Color.Navy;
            this.bt_FirstImg.Location = new System.Drawing.Point(0, 0);
            this.bt_FirstImg.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.bt_FirstImg.Name = "bt_FirstImg";
            this.bt_FirstImg.Size = new System.Drawing.Size(82, 35);
            this.bt_FirstImg.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.bt_FirstImg.TabIndex = 4;
            this.bt_FirstImg.Text = "|<";
            this.bt_FirstImg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_FirstImg.Click += new System.EventHandler(this.bt_ChangeImgIdx_Click);
            // 
            // bt_PrevImg
            // 
            this.bt_PrevImg.BackColor = System.Drawing.Color.Transparent;
            this.bt_PrevImg.BorderColor = System.Drawing.Color.Gray;
            this.bt_PrevImg.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.bt_PrevImg.BorderMargins = new System.Windows.Forms.Padding(0);
            this.bt_PrevImg.BorderRadius = 10;
            this.bt_PrevImg.BorderWidth = 1;
            this.bt_PrevImg.ColorActivate = System.Drawing.Color.Gray;
            this.bt_PrevImg.ColorHover = System.Drawing.Color.Cyan;
            this.bt_PrevImg.ColorNormal = System.Drawing.Color.Silver;
            this.bt_PrevImg.ContentBackColor = System.Drawing.Color.Silver;
            this.bt_PrevImg.ContentForeColor = System.Drawing.Color.Navy;
            this.bt_PrevImg.FixedSize = 40;
            this.bt_PrevImg.Font = new System.Drawing.Font("Montroc", 14F);
            this.bt_PrevImg.FontSize = 14F;
            this.bt_PrevImg.FontType = LotusAPI.Controls.FontType.Montroc;
            this.bt_PrevImg.ForeColor = System.Drawing.Color.Navy;
            this.bt_PrevImg.Location = new System.Drawing.Point(81, 0);
            this.bt_PrevImg.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.bt_PrevImg.Name = "bt_PrevImg";
            this.bt_PrevImg.Size = new System.Drawing.Size(82, 35);
            this.bt_PrevImg.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.bt_PrevImg.TabIndex = 4;
            this.bt_PrevImg.Text = "<";
            this.bt_PrevImg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_PrevImg.Click += new System.EventHandler(this.bt_ChangeImgIdx_Click);
            // 
            // bt_NextImg
            // 
            this.bt_NextImg.BackColor = System.Drawing.Color.Transparent;
            this.bt_NextImg.BorderColor = System.Drawing.Color.Gray;
            this.bt_NextImg.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.bt_NextImg.BorderMargins = new System.Windows.Forms.Padding(0);
            this.bt_NextImg.BorderRadius = 10;
            this.bt_NextImg.BorderWidth = 1;
            this.bt_NextImg.ColorActivate = System.Drawing.Color.Gray;
            this.bt_NextImg.ColorHover = System.Drawing.Color.Cyan;
            this.bt_NextImg.ColorNormal = System.Drawing.Color.Silver;
            this.bt_NextImg.ContentBackColor = System.Drawing.Color.Silver;
            this.bt_NextImg.ContentForeColor = System.Drawing.Color.Navy;
            this.bt_NextImg.FixedSize = 40;
            this.bt_NextImg.Font = new System.Drawing.Font("Montroc", 14F);
            this.bt_NextImg.FontSize = 14F;
            this.bt_NextImg.FontType = LotusAPI.Controls.FontType.Montroc;
            this.bt_NextImg.ForeColor = System.Drawing.Color.Navy;
            this.bt_NextImg.Location = new System.Drawing.Point(162, 0);
            this.bt_NextImg.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.bt_NextImg.Name = "bt_NextImg";
            this.bt_NextImg.Size = new System.Drawing.Size(82, 35);
            this.bt_NextImg.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.bt_NextImg.TabIndex = 4;
            this.bt_NextImg.Text = ">";
            this.bt_NextImg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_NextImg.Click += new System.EventHandler(this.bt_ChangeImgIdx_Click);
            // 
            // bt_LastImg
            // 
            this.bt_LastImg.BackColor = System.Drawing.Color.Transparent;
            this.bt_LastImg.BorderColor = System.Drawing.Color.Gray;
            this.bt_LastImg.BorderCorners = LotusAPI.Controls.BorderCorners.Right;
            this.bt_LastImg.BorderMargins = new System.Windows.Forms.Padding(0);
            this.bt_LastImg.BorderRadius = 10;
            this.bt_LastImg.BorderWidth = 1;
            this.bt_LastImg.ColorActivate = System.Drawing.Color.Gray;
            this.bt_LastImg.ColorHover = System.Drawing.Color.Cyan;
            this.bt_LastImg.ColorNormal = System.Drawing.Color.Silver;
            this.bt_LastImg.ContentBackColor = System.Drawing.Color.Silver;
            this.bt_LastImg.ContentForeColor = System.Drawing.Color.Navy;
            this.bt_LastImg.FixedSize = 60;
            this.bt_LastImg.Font = new System.Drawing.Font("Montroc", 14F);
            this.bt_LastImg.FontSize = 14F;
            this.bt_LastImg.FontType = LotusAPI.Controls.FontType.Montroc;
            this.bt_LastImg.ForeColor = System.Drawing.Color.Navy;
            this.bt_LastImg.Location = new System.Drawing.Point(243, 0);
            this.bt_LastImg.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.bt_LastImg.Name = "bt_LastImg";
            this.bt_LastImg.Size = new System.Drawing.Size(82, 35);
            this.bt_LastImg.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.bt_LastImg.TabIndex = 4;
            this.bt_LastImg.Text = ">|";
            this.bt_LastImg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_LastImg.Click += new System.EventHandler(this.bt_ChangeImgIdx_Click);
            // 
            // cbbImages
            // 
            this.cbbImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbImages.Font = new System.Drawing.Font("Consolas", 14F);
            this.cbbImages.FormattingEnabled = true;
            this.cbbImages.Location = new System.Drawing.Point(6, 111);
            this.cbbImages.Name = "cbbImages";
            this.cbbImages.Size = new System.Drawing.Size(325, 30);
            this.cbbImages.TabIndex = 1;
            this.cbbImages.SelectedIndexChanged += new System.EventHandler(this.cbbImages_SelectedIndexChanged);
            this.cbbImages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbbImages_KeyUp);
            // 
            // btOpenVisualizeImage
            // 
            this.btOpenVisualizeImage.BackColor = System.Drawing.Color.Transparent;
            this.btOpenVisualizeImage.BorderColor = System.Drawing.Color.Gray;
            this.btOpenVisualizeImage.BorderCorners = LotusAPI.Controls.BorderCorners.Bottom;
            this.btOpenVisualizeImage.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btOpenVisualizeImage.BorderRadius = 10;
            this.btOpenVisualizeImage.BorderWidth = 1;
            this.btOpenVisualizeImage.ColorActivate = System.Drawing.Color.Gray;
            this.btOpenVisualizeImage.ColorHover = System.Drawing.Color.Cyan;
            this.btOpenVisualizeImage.ColorNormal = System.Drawing.Color.Silver;
            this.btOpenVisualizeImage.ContentBackColor = System.Drawing.Color.Silver;
            this.btOpenVisualizeImage.ContentForeColor = System.Drawing.Color.Navy;
            this.btOpenVisualizeImage.FixedSize = 30;
            this.btOpenVisualizeImage.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.btOpenVisualizeImage.FontSize = 14F;
            this.btOpenVisualizeImage.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btOpenVisualizeImage.ForeColor = System.Drawing.Color.Navy;
            this.btOpenVisualizeImage.Location = new System.Drawing.Point(6, 36);
            this.btOpenVisualizeImage.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btOpenVisualizeImage.Name = "btOpenVisualizeImage";
            this.btOpenVisualizeImage.Size = new System.Drawing.Size(174, 34);
            this.btOpenVisualizeImage.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btOpenVisualizeImage.TabIndex = 4;
            this.btOpenVisualizeImage.Text = "모델 이미지로드";
            this.btOpenVisualizeImage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOpenVisualizeImage.Click += new System.EventHandler(this.btLoadVIsualizeImage_Click);
            // 
            // btLoadImage
            // 
            this.btLoadImage.BackColor = System.Drawing.Color.Transparent;
            this.btLoadImage.BorderColor = System.Drawing.Color.Gray;
            this.btLoadImage.BorderCorners = LotusAPI.Controls.BorderCorners.Top;
            this.btLoadImage.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btLoadImage.BorderRadius = 10;
            this.btLoadImage.BorderWidth = 1;
            this.btLoadImage.ColorActivate = System.Drawing.Color.Gray;
            this.btLoadImage.ColorHover = System.Drawing.Color.Cyan;
            this.btLoadImage.ColorNormal = System.Drawing.Color.Silver;
            this.btLoadImage.ContentBackColor = System.Drawing.Color.Silver;
            this.btLoadImage.ContentForeColor = System.Drawing.Color.Navy;
            this.btLoadImage.FixedSize = 30;
            this.btLoadImage.Font = new System.Drawing.Font("12LotteMartDreamBold", 14F);
            this.btLoadImage.FontSize = 14F;
            this.btLoadImage.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.btLoadImage.ForeColor = System.Drawing.Color.Navy;
            this.btLoadImage.Location = new System.Drawing.Point(6, 5);
            this.btLoadImage.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btLoadImage.Name = "btLoadImage";
            this.btLoadImage.Size = new System.Drawing.Size(174, 33);
            this.btLoadImage.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btLoadImage.TabIndex = 4;
            this.btLoadImage.Text = "이미지로드";
            this.btLoadImage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLoadImage.Load += new System.EventHandler(this.btLoadImage_Load);
            this.btLoadImage.Click += new System.EventHandler(this.btLoadImage_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.linearLayout3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbResult);
            this.splitContainer2.Panel2.Controls.Add(this.graph);
            this.splitContainer2.Size = new System.Drawing.Size(904, 781);
            this.splitContainer2.SplitterDistance = 576;
            this.splitContainer2.TabIndex = 2;
            // 
            // linearLayout3
            // 
            this.linearLayout3.BackColor = System.Drawing.SystemColors.Control;
            this.linearLayout3.Controls.Add(this.imgview);
            this.linearLayout3.Controls.Add(this.vizView);
            this.linearLayout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linearLayout3.EnableAutoArrange = true;
            this.linearLayout3.FixedSize = 50;
            this.linearLayout3.Location = new System.Drawing.Point(0, 0);
            this.linearLayout3.Margin = new System.Windows.Forms.Padding(0);
            this.linearLayout3.Name = "linearLayout3";
            this.linearLayout3.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.linearLayout3.ShowPlaceHolder = false;
            this.linearLayout3.Size = new System.Drawing.Size(904, 576);
            this.linearLayout3.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout3.Spacing = 3;
            this.linearLayout3.TabIndex = 1;
            // 
            // imgview
            // 
            this.imgview.BackColor = System.Drawing.Color.Gray;
            this.imgview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgview.Location = new System.Drawing.Point(0, 0);
            this.imgview.Name = "imgview";
            this.imgview.Size = new System.Drawing.Size(450, 576);
            this.imgview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgview.TabIndex = 0;
            this.imgview.TabStop = false;
            // 
            // vizView
            // 
            this.vizView.BackColor = System.Drawing.Color.Gray;
            this.vizView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vizView.Location = new System.Drawing.Point(453, 0);
            this.vizView.Name = "vizView";
            this.vizView.Size = new System.Drawing.Size(450, 576);
            this.vizView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vizView.TabIndex = 0;
            this.vizView.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbResult.FormattingEnabled = true;
            this.lbResult.IntegralHeight = false;
            this.lbResult.ItemHeight = 19;
            this.lbResult.Location = new System.Drawing.Point(630, 3);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(271, 195);
            this.lbResult.TabIndex = 1;
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph.BorderWidth = 1F;
            this.graph.Color = System.Drawing.Color.Black;
            this.graph.LegendFont = new System.Drawing.Font("Arial", 12F);
            this.graph.LegendLineLength = 50;
            this.graph.LegendSpacingX = 20;
            this.graph.LegendSpacingY = 6;
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            this.graph.ShowLegend = true;
            this.graph.Size = new System.Drawing.Size(624, 198);
            this.graph.TabIndex = 0;
            this.graph.TitleFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            // 
            // FormDetectorSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1242, 781);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormDetectorSetting";
            this.Text = "Detector configurator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.linearLayout5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.linearLayout4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_RoiWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WidthThresholdUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WidthThresholdLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OKThreshold)).EndInit();
            this.linearLayout2.ResumeLayout(false);
            this.linearLayout1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.linearLayout3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizView)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PropertyGrid pgrid;
        private LotusAPI.Controls.LinearLayout linearLayout1;
        private LotusAPI.Controls.Button bt_PrevImg;
        private LotusAPI.Controls.Button bt_NextImg;
        private LotusAPI.Controls.Button bt_FirstImg;
        private LotusAPI.Controls.Button bt_LastImg;
        private LotusAPI.Controls.Button btLoadImage;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private RadioButton rbCamera2;
        private RadioButton rbCamera1;
        private ListBox lbRegions;
        private LotusAPI.Controls.Button btSaveConfig;
        private LotusAPI.Controls.Button btLoadConfig;
        private LotusAPI.Controls.LinearLayout linearLayout2;
        private SplitContainer splitContainer2;
        private LotusAPI.Controls.LinearLayout linearLayout3;
        private LotusAPI.Controls.ImageView imgview;
        private LotusAPI.Controls.ImageView vizView;
        private LotusAPI.Controls.Graph.GraphView graph;
        private LotusAPI.Controls.LinearLayout linearLayout4;
        private LotusAPI.Controls.Button btAddROI;
        private LotusAPI.Controls.Button btClearROI;
        private Label label1;
        private NumericUpDown nud_RoiWidth;
        private ListBox lbResult;
        private Label label2;
        private NumericUpDown nud_WidthThresholdLower;
        private LotusAPI.Controls.Button btOpenVisualizeImage;
        private ComboBox cbbImages;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PropertyGrid pgridBlur;
        private ComboBox cbbBlurType;
        private TabPage tabPage3;
        private PropertyGrid pgridThreshold;
        private ComboBox cbbThresholdType;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private LotusAPI.Controls.LinearLayout linearLayout5;
        private Label label3;
        private NumericUpDown nud_OKThreshold;
        private CheckBox ckb_Use;
        private LotusAPI.Controls.Label lblImgIdx;
        private Panel panel1;
        private NumericUpDown nud_WidthThresholdUpper;
        private Label label4;
    }
}