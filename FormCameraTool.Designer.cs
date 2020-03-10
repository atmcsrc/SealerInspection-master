namespace ATMC.App.SealerInspection
{
    partial class FormCameraTool
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
            this.btCam1 = new System.Windows.Forms.Button();
            this.imageView1 = new LotusAPI.Controls.ImageView();
            this.imageView2 = new LotusAPI.Controls.ImageView();
            this.btCam2 = new System.Windows.Forms.Button();
            this.linearLayout1 = new LotusAPI.Controls.LinearLayout();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btSaveConnectionSetting = new System.Windows.Forms.Button();
            this.btConnectFromInfo = new System.Windows.Forms.Button();
            this.btCamSetting1 = new System.Windows.Forms.Button();
            this.btCamSetting2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageView2)).BeginInit();
            this.linearLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCam1
            // 
            this.btCam1.Location = new System.Drawing.Point(136, 5);
            this.btCam1.Name = "btCam1";
            this.btCam1.Size = new System.Drawing.Size(103, 25);
            this.btCam1.TabIndex = 0;
            this.btCam1.Text = "Connect Camera 1";
            this.btCam1.UseVisualStyleBackColor = true;
            this.btCam1.Click += new System.EventHandler(this.btCam1_Click);
            // 
            // imageView1
            // 
            this.imageView1.BackColor = System.Drawing.Color.Gray;
            this.imageView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageView1.Location = new System.Drawing.Point(3, 3);
            this.imageView1.Name = "imageView1";
            this.imageView1.Size = new System.Drawing.Size(417, 518);
            this.imageView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageView1.TabIndex = 1;
            this.imageView1.TabStop = false;
            // 
            // imageView2
            // 
            this.imageView2.BackColor = System.Drawing.Color.Gray;
            this.imageView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageView2.Location = new System.Drawing.Point(423, 3);
            this.imageView2.Name = "imageView2";
            this.imageView2.Size = new System.Drawing.Size(417, 518);
            this.imageView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageView2.TabIndex = 2;
            this.imageView2.TabStop = false;
            // 
            // btCam2
            // 
            this.btCam2.Location = new System.Drawing.Point(136, 37);
            this.btCam2.Name = "btCam2";
            this.btCam2.Size = new System.Drawing.Size(103, 25);
            this.btCam2.TabIndex = 0;
            this.btCam2.Text = "Connect Camera 2";
            this.btCam2.UseVisualStyleBackColor = true;
            this.btCam2.Click += new System.EventHandler(this.btCam2_Click);
            // 
            // linearLayout1
            // 
            this.linearLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linearLayout1.Controls.Add(this.imageView1);
            this.linearLayout1.Controls.Add(this.imageView2);
            this.linearLayout1.EnableAutoArrange = true;
            this.linearLayout1.FixedSize = 50;
            this.linearLayout1.Location = new System.Drawing.Point(10, 68);
            this.linearLayout1.Name = "linearLayout1";
            this.linearLayout1.Orientation = LotusAPI.Controls.LayoutOrientation.Horizontal;
            this.linearLayout1.ShowPlaceHolder = false;
            this.linearLayout1.Size = new System.Drawing.Size(844, 524);
            this.linearLayout1.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.linearLayout1.Spacing = 3;
            this.linearLayout1.TabIndex = 3;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(368, 5);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(92, 56);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(465, 5);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(92, 56);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btSaveConnectionSetting
            // 
            this.btSaveConnectionSetting.Location = new System.Drawing.Point(10, 37);
            this.btSaveConnectionSetting.Name = "btSaveConnectionSetting";
            this.btSaveConnectionSetting.Size = new System.Drawing.Size(121, 25);
            this.btSaveConnectionSetting.TabIndex = 6;
            this.btSaveConnectionSetting.Text = "Save Setting";
            this.btSaveConnectionSetting.UseVisualStyleBackColor = true;
            this.btSaveConnectionSetting.Click += new System.EventHandler(this.btSaveConnectionSetting_Click);
            // 
            // btConnectFromInfo
            // 
            this.btConnectFromInfo.Location = new System.Drawing.Point(10, 5);
            this.btConnectFromInfo.Name = "btConnectFromInfo";
            this.btConnectFromInfo.Size = new System.Drawing.Size(121, 25);
            this.btConnectFromInfo.TabIndex = 6;
            this.btConnectFromInfo.Text = "Connect From Info";
            this.btConnectFromInfo.UseVisualStyleBackColor = true;
            this.btConnectFromInfo.Click += new System.EventHandler(this.btConnectFromInfo_Click);
            // 
            // btCamSetting1
            // 
            this.btCamSetting1.Location = new System.Drawing.Point(244, 5);
            this.btCamSetting1.Name = "btCamSetting1";
            this.btCamSetting1.Size = new System.Drawing.Size(99, 25);
            this.btCamSetting1.TabIndex = 7;
            this.btCamSetting1.Text = "Cam1 Setting";
            this.btCamSetting1.UseVisualStyleBackColor = true;
            this.btCamSetting1.Click += new System.EventHandler(this.btCamSetting1_Click);
            // 
            // btCamSetting2
            // 
            this.btCamSetting2.Location = new System.Drawing.Point(244, 37);
            this.btCamSetting2.Name = "btCamSetting2";
            this.btCamSetting2.Size = new System.Drawing.Size(99, 25);
            this.btCamSetting2.TabIndex = 7;
            this.btCamSetting2.Text = "Cam2 Setting";
            this.btCamSetting2.UseVisualStyleBackColor = true;
            this.btCamSetting2.Click += new System.EventHandler(this.btCamSetting2_Click);
            // 
            // FormCameraTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 605);
            this.Controls.Add(this.btCamSetting2);
            this.Controls.Add(this.btCamSetting1);
            this.Controls.Add(this.btConnectFromInfo);
            this.Controls.Add(this.btSaveConnectionSetting);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.linearLayout1);
            this.Controls.Add(this.btCam2);
            this.Controls.Add(this.btCam1);
            this.Name = "FormCameraTool";
            this.Text = "CameraTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCameraTool_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageView2)).EndInit();
            this.linearLayout1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCam1;
        private LotusAPI.Controls.ImageView imageView1;
        private LotusAPI.Controls.ImageView imageView2;
        private System.Windows.Forms.Button btCam2;
        private LotusAPI.Controls.LinearLayout linearLayout1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btSaveConnectionSetting;
        private System.Windows.Forms.Button btConnectFromInfo;
        private System.Windows.Forms.Button btCamSetting1;
        private System.Windows.Forms.Button btCamSetting2;
    }
}