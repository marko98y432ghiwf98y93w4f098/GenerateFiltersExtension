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
using u;
using u.forms.form;

namespace extension
{
    public partial class formAdvanced : form2
    {
        public enum Result
        {
            none = 0,
            ok = 1
        }
        public Result r;



        public formAdvanced()
        {
            InitializeComponent();
            textBoxResult.TabStop = false;

            {
                var x = this.xControl();
                x.x[0].xs = x.x[1].xs = 0.9609803444828163;
            }
            this.xScale();

            this.MouseWheel += fMouseWheel;
        }


        private void fMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                this.xControl().x[1].xs *= 1.01;
            else
                this.xControl().x[1].xs /= 1.01;
            this.xScale(null, System.Windows.Forms.Cursor.Position);
        }

        private void formAdvancedMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) this.xScale2(System.Windows.Forms.Cursor.Position);
        }


















































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

        private void calculateMenuItemClicked(object sender, ToolStripItemClickedEventArgs e) => textBoxRootDir.Text = (string)e.ClickedItem.Tag;















































        private void error(string s) => textBoxResult.Text = s;

        private void formAdvancedFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) { r = Result.none; return; }
            if (r != Result.ok) return;

            try
            {
                if (!radioButtonInProject.Checked)
                    if (!Directory.Exists(textBoxIn.Text)) throw new("in dir is not valid");
                if (!Directory.Exists(textBoxRootDir.Text)) throw new("root dir is not valid");
                if (checkBoxRootFilter.Checked)
                    if (!dirToFilter.ProjectData.Data.filterCheck(textBoxRootFilter.Text)) throw new("root filter is not valid");
            }
            catch (Exception e2)
            {
                error(e2.Message);
                r = Result.none;
                e.Cancel = true;
            }

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys != Keys.None || keyData != Keys.Escape) return base.ProcessDialogKey(keyData);
            r = Result.none;
            this.Close();
            return true;
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
    }
}
