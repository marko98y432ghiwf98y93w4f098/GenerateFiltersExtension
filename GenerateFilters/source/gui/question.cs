using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudioCppExtensions
{
    public partial class formQuestion : Form
    {
        public enum Result
        {
            none = 0,
            yes = 1,
            advanced = 2
        }
        public Result r = Result.none;



        public formQuestion() => InitializeComponent();
        

        private void buttonYesClick(object sender, EventArgs e)
        {
            r = Result.yes;
            this.Close();
        }

        private void buttonAdvancedClick(object sender, EventArgs e)
        {
            r = Result.advanced;
            this.Close();
        }
    }
}
