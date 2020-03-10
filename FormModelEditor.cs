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
using System.IO;

namespace ATMC.App.SealerInspection
{
    public partial class FormModelEditor : Form
    {

        Json m_allModels = new Json();

        public FormModelEditor()
        {
            InitializeComponent();
        }

        void ReloadModels()
        {
            try
            {
                lb_Models.Items.Clear();
                var models = Global.Instance.Models;
                foreach (var model in models)
                {
                    lb_Models.Items.Add(model.ModelName);
                }
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void FormModelEditor_Load(object sender, EventArgs e)
        {
            ReloadModels();
        }

        private void lv_Models_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var models = Global.Instance.Models;
                pgrid.SelectedObject = models.Find(x => x.ModelName == lb_Models.SelectedItem.ToString());
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var models = Global.Instance.Models;
                models.Add(new ModelConfig());
                ReloadModels();
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void pgrid_SelectedObjectsChanged(object sender, EventArgs e)
        {
        }

        private void pgrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            try
            {
                //rename directory
                string model_dir = Registry.GetStringValue("ModelDir", "");
                if (e.ChangedItem.Label == "ModelName")
                {
                    string old_model_dir = model_dir + "/" + e.OldValue;
                    string new_model_dir = model_dir + "/" + e.ChangedItem.Value;
                    if (Directory.Exists(old_model_dir))
                    {
                        Directory.Move(old_model_dir, new_model_dir);
                    }
                    else
                    {
                        Directory.CreateDirectory(new_model_dir);
                    }
                    ReloadModels();
                }
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        void Save() { bt_Save_Click(null, null); }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Json j = new Json();
                j.FromArray(Global.Instance.Models.ToArray());
                Json.WriteToFile(Registry.GetStringValue("AllModelFile", ""), j);
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var models = Global.Instance.Models;
                if (MessageBox.Show("Are you sure you want to remove the selected item?",
                    "Remove confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string model_dir = Registry.GetStringValue("ModelDir", "");
                    models.Remove(models.Find(x => x.ModelName == lb_Models.SelectedItem.ToString()));
                    Save();
                    string new_model_dir = model_dir + "/" + lb_Models.SelectedItem.ToString();
                    ReloadModels();
                    if (MessageBox.Show(
                        "Are you sure you want to delete the configuration directory?",
                        "Remove confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Directory.Delete(new_model_dir, true);
                    }
                }
                pgrid.SelectedObject = null;
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void bt_DetectorEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var model = pgrid.SelectedObject as ModelConfig;
                if (model == null) { MessageBox.Show("No model"); return; }
                string model_dir = Registry.GetStringValue("ModelDir", "");
                string new_model_dir = model_dir + "/" + model.ModelName;
                (new FormDetectorSetting(new_model_dir + "/detector.json")).ShowDialog();
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }
    }
}
