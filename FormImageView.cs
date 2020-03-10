using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMC.App.SealerInspection
{
    public partial class FormImageView : Form
    {
        public void SetImage(Image img)
        {
            pictureBox1.Image = img;
        }
        public FormImageView()
        {
            InitializeComponent();
        }
    }
}
