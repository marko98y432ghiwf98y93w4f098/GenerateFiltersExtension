using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudioCppExtensions
{
    public partial class formAdvanced : Form
    {
        public enum Result
        {
            none = 0,
            ok = 1
        }
        public Result r;



        public formAdvanced() { InitializeComponent(); textBoxResult.TabStop = false;}




        private void radioButtonBold(RadioButton x) => x.Font = new Font(x.Font, x.Checked ? FontStyle.Bold : FontStyle.Regular);
        private void radioButtonInCheckedChanged(object sender, EventArgs e)
        {
            bool inDir = !radioButtonInProject.Checked;
            textBoxIn.Enabled = inDir;
            buttonIn.Enabled = inDir;

            radioButtonBold(radioButtonInProject);
            radioButtonBold(radioButtonInDirSubDir);
            radioButtonBold(radioButtonInDir);
        }


        private void checkBoxRootFilterCheckedChanged(object sender, EventArgs e) => textBoxRootFilter.Enabled = checkBoxRootFilter.Checked;

        




        public void error(string s) => textBoxResult.Text = s;
        
        private void formAdvancedFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) { r = Result.none; return; }
            if (r != Result.ok) return;
                    
            try
            {
                if (!radioButtonInProject.Checked)
                    if (!Directory.Exists(textBoxIn.Text)) throw new Exception("in dir is not valid");
                if (!Directory.Exists(textBoxRootDir.Text)) throw new Exception("root dir is not valid");
                if (checkBoxRootFilter.Checked)
                    if (!dirToFilter.ProjectData.Data.filterCheck(textBoxRootFilter.Text)) throw new Exception("root filter is not valid");
            }
            catch(Exception e2)
            {
                error(e2.Message);
                r = Result.none;
                e.Cancel = true;
            }
                
        }












        private void dialogShow(TextBox x)
        {
            FolderBrowserDialog d = dialogFolder;
            d.RootFolder = Environment.SpecialFolder.Desktop;
            d.SelectedPath = x.Text;
            d.ShowNewFolderButton = true;
            if (d.ShowDialog(this) != DialogResult.OK) return;
            x.Text = d.SelectedPath;
        }

        private void buttonInClick(object sender, EventArgs e) => dialogShow(textBoxIn);
        private void buttonCalculateClick(object sender, EventArgs e) => dialogShow(textBoxRootDir);





        private void buttonOkClick(object sender, EventArgs e)
        {
            r = Result.ok;
            this.Close();
        }


        public dirToFilter.ProjectData p;
        private void buttonCalculateFiltersDeleteAllClick(object sender, EventArgs e)
        {
            dirToFilter.filters2.filtersDeleteAll(p.p.p);
            p.f.filesGet(p);
        }


        private void calculateMenuItemClicked(object sender, ToolStripItemClickedEventArgs e) => textBoxRootDir.Text = (string)e.ClickedItem.Tag;


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys != Keys.None || keyData != Keys.Escape) return base.ProcessDialogKey(keyData);
            r = Result.none;
            this.Close();
            return true;
        }
    }


}
