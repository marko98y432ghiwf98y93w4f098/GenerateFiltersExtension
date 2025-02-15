﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using u;
using u.forms.control.form;

namespace extension
{
    public partial class formQuestion : form3
    {
        public enum Result
        {
            none = 0,
            yes = 1,
            advanced = 2
        }
        public Result r = Result.none;



        public formQuestion()
        {
            InitializeComponent();
            int x = this.Height;
            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Width * 10, Height);
            init();
        }


        




























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



        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys != Keys.None || keyData != Keys.Escape) return base.ProcessDialogKey(keyData);
            r = Result.none;
            this.Close();
            return true;
        }
    }
}
