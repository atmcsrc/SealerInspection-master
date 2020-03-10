namespace ATMC.App.SealerInspection {
    partial class FormSetting {
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new LotusAPI.Controls.Button();
            this.btModelEditor = new LotusAPI.Controls.Button();
            this.btCameraTool = new LotusAPI.Controls.Button();
            this.ckbTestMode = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Consolas", 11F);
            this.tbPassword.Location = new System.Drawing.Point(79, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(293, 25);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F);
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propertyGrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(363, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Font = new System.Drawing.Font("Consolas", 12F);
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(357, 346);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btModelEditor);
            this.tabPage1.Controls.Add(this.btCameraTool);
            this.tabPage1.Controls.Add(this.ckbTestMode);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tools";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox1.Location = new System.Drawing.Point(86, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(8, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Command";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.Gray;
            this.button1.BorderCorners = LotusAPI.Controls.BorderCorners.All;
            this.button1.BorderMargins = new System.Windows.Forms.Padding(0);
            this.button1.BorderRadius = 10;
            this.button1.BorderWidth = 0;
            this.button1.ColorActivate = System.Drawing.Color.Gray;
            this.button1.ColorHover = System.Drawing.Color.Cyan;
            this.button1.ColorNormal = System.Drawing.Color.Silver;
            this.button1.ContentBackColor = System.Drawing.Color.Silver;
            this.button1.ContentForeColor = System.Drawing.Color.Navy;
            this.button1.FixedSize = 30;
            this.button1.Font = new System.Drawing.Font("Prototype", 18F);
            this.button1.FontSize = 18F;
            this.button1.FontType = LotusAPI.Controls.FontType.Prototype;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(5, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 37);
            this.button1.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.button1.TabIndex = 0;
            this.button1.Text = "Reinitialize";
            this.button1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.btReinit_Clicked);
            // 
            // btModelEditor
            // 
            this.btModelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btModelEditor.BackColor = System.Drawing.Color.Transparent;
            this.btModelEditor.BorderColor = System.Drawing.Color.Gray;
            this.btModelEditor.BorderCorners = LotusAPI.Controls.BorderCorners.All;
            this.btModelEditor.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btModelEditor.BorderRadius = 10;
            this.btModelEditor.BorderWidth = 0;
            this.btModelEditor.ColorActivate = System.Drawing.Color.Gray;
            this.btModelEditor.ColorHover = System.Drawing.Color.Cyan;
            this.btModelEditor.ColorNormal = System.Drawing.Color.Silver;
            this.btModelEditor.ContentBackColor = System.Drawing.Color.Silver;
            this.btModelEditor.ContentForeColor = System.Drawing.Color.Navy;
            this.btModelEditor.FixedSize = 30;
            this.btModelEditor.Font = new System.Drawing.Font("Prototype", 18F);
            this.btModelEditor.FontSize = 18F;
            this.btModelEditor.FontType = LotusAPI.Controls.FontType.Prototype;
            this.btModelEditor.ForeColor = System.Drawing.Color.Navy;
            this.btModelEditor.Location = new System.Drawing.Point(5, 75);
            this.btModelEditor.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btModelEditor.Name = "btModelEditor";
            this.btModelEditor.Size = new System.Drawing.Size(352, 37);
            this.btModelEditor.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btModelEditor.TabIndex = 0;
            this.btModelEditor.Text = "Model editor";
            this.btModelEditor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btModelEditor.Load += new System.EventHandler(this.btModelEditor_Load);
            this.btModelEditor.Click += new System.EventHandler(this.btDetectorSetting_Click);
            // 
            // btCameraTool
            // 
            this.btCameraTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCameraTool.BackColor = System.Drawing.Color.Transparent;
            this.btCameraTool.BorderColor = System.Drawing.Color.Gray;
            this.btCameraTool.BorderCorners = LotusAPI.Controls.BorderCorners.All;
            this.btCameraTool.BorderMargins = new System.Windows.Forms.Padding(0);
            this.btCameraTool.BorderRadius = 10;
            this.btCameraTool.BorderWidth = 0;
            this.btCameraTool.ColorActivate = System.Drawing.Color.Gray;
            this.btCameraTool.ColorHover = System.Drawing.Color.Cyan;
            this.btCameraTool.ColorNormal = System.Drawing.Color.Silver;
            this.btCameraTool.ContentBackColor = System.Drawing.Color.Silver;
            this.btCameraTool.ContentForeColor = System.Drawing.Color.Navy;
            this.btCameraTool.FixedSize = 30;
            this.btCameraTool.Font = new System.Drawing.Font("Prototype", 18F);
            this.btCameraTool.FontSize = 18F;
            this.btCameraTool.FontType = LotusAPI.Controls.FontType.Prototype;
            this.btCameraTool.ForeColor = System.Drawing.Color.Navy;
            this.btCameraTool.Location = new System.Drawing.Point(5, 33);
            this.btCameraTool.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btCameraTool.Name = "btCameraTool";
            this.btCameraTool.Size = new System.Drawing.Size(352, 37);
            this.btCameraTool.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.btCameraTool.TabIndex = 0;
            this.btCameraTool.Text = "Camera Tool";
            this.btCameraTool.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCameraTool.Load += new System.EventHandler(this.btCameraTool_Load);
            this.btCameraTool.Click += new System.EventHandler(this.btCameraSetting1_Click);
            this.btCameraTool.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCameraTool_MouseClick);
            // 
            // ckbTestMode
            // 
            this.ckbTestMode.AutoSize = true;
            this.ckbTestMode.Font = new System.Drawing.Font("Consolas", 14F);
            this.ckbTestMode.Location = new System.Drawing.Point(8, 3);
            this.ckbTestMode.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.ckbTestMode.Name = "ckbTestMode";
            this.ckbTestMode.Size = new System.Drawing.Size(119, 26);
            this.ckbTestMode.TabIndex = 4;
            this.ckbTestMode.Text = "Test mode";
            this.ckbTestMode.UseVisualStyleBackColor = true;
            this.ckbTestMode.CheckedChanged += new System.EventHandler(this.ckbTestMode_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 12F);
            this.tabControl1.Location = new System.Drawing.Point(3, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 384);
            this.tabControl1.TabIndex = 4;
            // 
            // FormSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(375, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabPage tabPage1;
        private LotusAPI.Controls.Button btModelEditor;
        private LotusAPI.Controls.Button btCameraTool;
        private System.Windows.Forms.CheckBox ckbTestMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private LotusAPI.Controls.Button button1;
    }
}