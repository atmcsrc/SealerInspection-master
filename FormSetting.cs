using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotusAPI;
using LotusAPI.HW;

namespace ATMC.App.SealerInspection
{
    public partial class FormSetting : Form
    {
        public event EventHandler ReinitEvent = null;

        public FormSetting()
        {
            InitializeComponent();
            SetEnableButtons(false);
            ckbTestMode.Checked = Registry.GetBoolValue("TestMode", false);
            propertyGrid1.SelectedObject = Global.Instance;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetEnableButtons(false);
        }

        void SetEnableButtons(bool enable)
        {
            tbPassword.Text = "";
            tabControl1.Enabled = enable;
        }

        private void btDetectorSetting_Click(object sender, EventArgs e)
        {
            (new FormModelEditor()).ShowDialog();
        }

        private void btCameraSetting1_Click(object sender, EventArgs e)
        {
            (new FormCameraTool()).ShowDialog();
        }

        private void btCameraSetting2_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetEnableButtons(tbPassword.Text == LotusAPI.Registry.GetStringValue("Password", "1111"));
            }
        }

        private void btCameraTool_Load(object sender, EventArgs e)
        {

        }

        private void btCameraTool_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ckbTestMode_CheckedChanged(object sender, EventArgs e)
        {
            Registry.SetValue("TestMode", ckbTestMode.Checked);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Global.Instance.ControllerServer.Send(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void btReinit_Clicked(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reload detector settings?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //reload here
                ReinitEvent?.Invoke(null, null);
            }
        }

        private void btModelEditor_Load(object sender, EventArgs e)
        {
        }
    }
}
