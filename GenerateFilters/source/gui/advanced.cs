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
        




        private void checkBoxRootFilterCheckedChanged(object sender, EventArgs e) => textBoxRootFilter.Enabled = checkBoxRootFilter.Checked;
        





        public void error(string s) => textBoxResult.Text = s;
        
        private void formAdvancedFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) { r = Result.none; return; }
            if (r != Result.ok) return;
                    
            try
            {
                if (!Directory.Exists(textBoxRootDir.Text)) throw new Exception("root dir is not valid");
                if (checkBoxRootFilter.Checked)
                    if (!ProjectData.Root.filterCheck(textBoxRootFilter.Text)) throw new Exception("root filter is not valid");
            }
            catch(Exception e2)
            {
                error(e2.Message);
                r = Result.none;
                e.Cancel = true;
            }
                
        }





        private void buttonOkClick(object sender, EventArgs e)
        {
            r = Result.ok;
            this.Close();
        }





        private void buttonBrowseClick(object sender, EventArgs e)
        {
            FolderBrowserDialog d = dialogFolder;
            d.RootFolder = Environment.SpecialFolder.Desktop;
            d.SelectedPath = textBoxRootDir.Text;
            d.ShowNewFolderButton = true;
            if (d.ShowDialog(this) != DialogResult.OK) return;
            textBoxRootDir.Text = d.SelectedPath;
        }
    }


}
