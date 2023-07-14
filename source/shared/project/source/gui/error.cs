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

namespace extension
{
    public partial class formError : form2
    {
        public formError()
        {
            InitializeComponent();
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

        private void formErrorMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) this.xScale2(System.Windows.Forms.Cursor.Position);
        }




























        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys != Keys.None || keyData != Keys.Escape) return base.ProcessDialogKey(keyData);
            this.Close();
            return true;
        }
    }
}
