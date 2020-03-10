using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotusAPI.Controls;

namespace ATMC.App.SealerInspection
{
    public partial class RecentResultItem : LinearLayout
    {
        private NumberView lblIdx;
        private LotusAPI.Controls.Label lblResult;
        private LotusAPI.Controls.Label lblTime;
        private LotusAPI.Controls.Label lblOKRate;
        private LotusAPI.Controls.Label lblType;
        public DetectionResult Result { get; protected set; } = null;

        public int ID => (int)lblIdx.Value;
        public RecentResultItem(int id, DetectionResult result)
        {
            InitializeComponent();
            Result = result;
            this.FixedSize = 30;
            this.lblIdx.Value = id;
            this.lblType.Text = result.ModelName;
            this.lblTime.Text = result.Time.ToString("yyyy-MM-dd hh:mm:ss");
            this.lblResult.Text = result.IsOK ? "OK" : "NG";
            this.lblOKRate.Text = String.Format("{0:N2}%",result.OKRate*100);
            if (result.IsOK) lblResult.ContentBackColor = Color.Lime;
            else lblResult.ContentBackColor = Color.Red;
        }

        private void InitializeComponent()
        {
            this.lblIdx = new LotusAPI.Controls.NumberView();
            this.lblResult = new LotusAPI.Controls.Label();
            this.lblTime = new LotusAPI.Controls.Label();
            this.lblType = new LotusAPI.Controls.Label();
            this.lblOKRate = new LotusAPI.Controls.Label();
            this.SuspendLayout();
            // 
            // lblIdx
            // 
            this.lblIdx.BackColor = System.Drawing.Color.Navy;
            this.lblIdx.BorderColor = System.Drawing.Color.Gray;
            this.lblIdx.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lblIdx.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lblIdx.BorderRadius = 0;
            this.lblIdx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdx.BorderWidth = 0;
            this.lblIdx.ContentBackColor = System.Drawing.Color.Navy;
            this.lblIdx.ContentForeColor = System.Drawing.Color.White;
            this.lblIdx.FixedSize = 50;
            this.lblIdx.Font = new System.Drawing.Font("LED Calculator", 14F);
            this.lblIdx.FontSize = 14F;
            this.lblIdx.FontType = LotusAPI.Controls.FontType.DotMatrix;
            this.lblIdx.ForeColor = System.Drawing.Color.White;
            this.lblIdx.Location = new System.Drawing.Point(0, 0);
            this.lblIdx.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblIdx.Name = "lblIdx";
            this.lblIdx.NumberFormat = "0";
            this.lblIdx.Size = new System.Drawing.Size(50, 33);
            this.lblIdx.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.lblIdx.TabIndex = 0;
            this.lblIdx.Text = "999";
            this.lblIdx.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIdx.Value = 999D;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.BorderColor = System.Drawing.Color.Gray;
            this.lblResult.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lblResult.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lblResult.BorderRadius = 0;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.BorderWidth = 0;
            this.lblResult.ContentBackColor = System.Drawing.Color.Navy;
            this.lblResult.ContentForeColor = System.Drawing.Color.White;
            this.lblResult.FixedSize = 80;
            this.lblResult.Font = new System.Drawing.Font("Montroc Semi-Italic", 14F);
            this.lblResult.FontSize = 14F;
            this.lblResult.FontType = LotusAPI.Controls.FontType.MontrocSemitall;
            this.lblResult.ForeColor = System.Drawing.Color.Navy;
            this.lblResult.Location = new System.Drawing.Point(533, 0);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(80, 33);
            this.lblResult.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "OK";
            this.lblResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            this.lblResult.DoubleClick += new System.EventHandler(this.lblResult_DoubleClick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Navy;
            this.lblTime.BorderColor = System.Drawing.Color.Gray;
            this.lblTime.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lblTime.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lblTime.BorderRadius = 0;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.BorderWidth = 0;
            this.lblTime.ContentBackColor = System.Drawing.Color.Navy;
            this.lblTime.ContentForeColor = System.Drawing.Color.White;
            this.lblTime.FixedSize = 30;
            this.lblTime.Font = new System.Drawing.Font("LED Calculator", 14F);
            this.lblTime.FontSize = 14F;
            this.lblTime.FontType = LotusAPI.Controls.FontType.DotMatrix;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(250, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(133, 33);
            this.lblTime.SizePolicy = LotusAPI.Controls.SizePolicy.Expanding;
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label2";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Navy;
            this.lblType.BorderColor = System.Drawing.Color.Gray;
            this.lblType.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lblType.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lblType.BorderRadius = 0;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.BorderWidth = 0;
            this.lblType.ContentBackColor = System.Drawing.Color.Navy;
            this.lblType.ContentForeColor = System.Drawing.Color.White;
            this.lblType.FixedSize = 200;
            this.lblType.Font = new System.Drawing.Font("12롯데마트드림Bold", 14F);
            this.lblType.FontSize = 14F;
            this.lblType.FontType = LotusAPI.Controls.FontType.LotteBold;
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(50, 0);
            this.lblType.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(200, 33);
            this.lblType.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.lblType.TabIndex = 2;
            this.lblType.Text = "MODEL";
            this.lblType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOKRate
            // 
            this.lblOKRate.BackColor = System.Drawing.Color.Navy;
            this.lblOKRate.BorderColor = System.Drawing.Color.Gray;
            this.lblOKRate.BorderCorners = LotusAPI.Controls.BorderCorners.None;
            this.lblOKRate.BorderMargins = new System.Windows.Forms.Padding(0);
            this.lblOKRate.BorderRadius = 0;
            this.lblOKRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOKRate.BorderWidth = 0;
            this.lblOKRate.ContentBackColor = System.Drawing.Color.Navy;
            this.lblOKRate.ContentForeColor = System.Drawing.Color.White;
            this.lblOKRate.FixedSize = 150;
            this.lblOKRate.Font = new System.Drawing.Font("LED Calculator", 14F);
            this.lblOKRate.FontSize = 14F;
            this.lblOKRate.FontType = LotusAPI.Controls.FontType.DotMatrix;
            this.lblOKRate.ForeColor = System.Drawing.Color.White;
            this.lblOKRate.Location = new System.Drawing.Point(383, 0);
            this.lblOKRate.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblOKRate.Name = "lblOKRate";
            this.lblOKRate.Size = new System.Drawing.Size(150, 33);
            this.lblOKRate.SizePolicy = LotusAPI.Controls.SizePolicy.Fixed;
            this.lblOKRate.TabIndex = 1;
            this.lblOKRate.Text = "3.14%";
            this.lblOKRate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecentResultItem
            // 
            this.Controls.Add(this.lblIdx);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblOKRate);
            this.Controls.Add(this.lblResult);
            this.FixedSize = 30;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RecentResultItem";
            this.Size = new System.Drawing.Size(613, 33);
            this.Spacing = 0;
            this.ResumeLayout(false);

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }


        private void lblResult_DoubleClick(object sender, EventArgs e)
        {
            var f = new FormImageView();
            f.Text = Result.Text;
            f.SetImage(Result.ScreenImage);
            f.ShowDialog();
        }
    }
}
