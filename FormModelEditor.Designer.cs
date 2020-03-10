namespace ATMC.App.SealerInspection
{
    partial class FormModelEditor
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.pgrid = new System.Windows.Forms.PropertyGrid();
            this.bt_DetectorEdit = new System.Windows.Forms.Button();
            this.lb_Models = new System.Windows.Forms.ListBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Consolas", 12F);
            this.btAdd.Location = new System.Drawing.Point(10, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(64, 33);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Consolas", 12F);
            this.btRemove.Location = new System.Drawing.Point(80, 13);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(76, 33);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // pgrid
            // 
            this.pgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgrid.Font = new System.Drawing.Font("Consolas", 12F);
            this.pgrid.Location = new System.Drawing.Point(219, 52);
            this.pgrid.Name = "pgrid";
            this.pgrid.Size = new System.Drawing.Size(417, 389);
            this.pgrid.TabIndex = 2;
            this.pgrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgrid_PropertyValueChanged);
            this.pgrid.SelectedObjectsChanged += new System.EventHandler(this.pgrid_SelectedObjectsChanged);
            // 
            // bt_DetectorEdit
            // 
            this.bt_DetectorEdit.Font = new System.Drawing.Font("Consolas", 12F);
            this.bt_DetectorEdit.Location = new System.Drawing.Point(219, 13);
            this.bt_DetectorEdit.Name = "bt_DetectorEdit";
            this.bt_DetectorEdit.Size = new System.Drawing.Size(161, 33);
            this.bt_DetectorEdit.TabIndex = 1;
            this.bt_DetectorEdit.Text = "Edit detector";
            this.bt_DetectorEdit.UseVisualStyleBackColor = true;
            this.bt_DetectorEdit.Click += new System.EventHandler(this.bt_DetectorEdit_Click);
            // 
            // lb_Models
            // 
            this.lb_Models.Font = new System.Drawing.Font("Consolas", 12F);
            this.lb_Models.FormattingEnabled = true;
            this.lb_Models.IntegralHeight = false;
            this.lb_Models.ItemHeight = 19;
            this.lb_Models.Location = new System.Drawing.Point(10, 52);
            this.lb_Models.Name = "lb_Models";
            this.lb_Models.Size = new System.Drawing.Size(204, 392);
            this.lb_Models.TabIndex = 3;
            this.lb_Models.SelectedIndexChanged += new System.EventHandler(this.lv_Models_SelectedIndexChanged);
            // 
            // bt_Save
            // 
            this.bt_Save.Font = new System.Drawing.Font("Consolas", 12F);
            this.bt_Save.Location = new System.Drawing.Point(547, 13);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(88, 33);
            this.bt_Save.TabIndex = 1;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // FormModelEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(645, 454);
            this.Controls.Add(this.lb_Models);
            this.Controls.Add(this.pgrid);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_DetectorEdit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Name = "FormModelEditor";
            this.Text = "FormModelEditor";
            this.Load += new System.EventHandler(this.FormModelEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.PropertyGrid pgrid;
        private System.Windows.Forms.Button bt_DetectorEdit;
        private System.Windows.Forms.ListBox lb_Models;
        private System.Windows.Forms.Button bt_Save;
    }
}