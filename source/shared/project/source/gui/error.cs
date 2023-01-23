using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using u;
using u.forms.form;

namespace VisualStudioCppExtensions
{
    public partial class formError : form2
    {
        public formError()
        {
            InitializeComponent();
            this.xScale();
        }



        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys != Keys.None || keyData != Keys.Escape) return base.ProcessDialogKey(keyData);
            this.Close();
            return true;
        }
    }
}
