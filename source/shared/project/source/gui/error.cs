﻿using System;
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
    public partial class formError : Form
    {
        public formError()
        {
            InitializeComponent();
        }



        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys != Keys.None || keyData != Keys.Escape) return base.ProcessDialogKey(keyData);
            this.Close();
            return true;
        }
    }
}
