namespace extension
{
    partial class formAdvanced
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdvanced));
            textBoxRootDir = new u.forms.textBox.textBox2();
            calculateMenu = new System.Windows.Forms.ContextMenuStrip(components);
            labelRootDir = new System.Windows.Forms.Label();
            buttonCaluculate = new System.Windows.Forms.Button();
            textBoxRootFilter = new u.forms.textBox.textBox2();
            checkBoxRootFilter = new System.Windows.Forms.CheckBox();
            buttonOk = new System.Windows.Forms.Button();
            textBoxResult = new u.forms.textBox.textBox2();
            dialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            textBoxIn = new u.forms.textBox.textBox2();
            buttonIn = new System.Windows.Forms.Button();
            radioButtonInProject = new System.Windows.Forms.RadioButton();
            radioButtonInDir = new System.Windows.Forms.RadioButton();
            radioButtonInDirSubDir = new System.Windows.Forms.RadioButton();
            labelIn = new System.Windows.Forms.Label();
            labelCalculate = new System.Windows.Forms.Label();
            labelOut = new System.Windows.Forms.Label();
            labelIn2 = new System.Windows.Forms.Label();
            labelCalculate2 = new System.Windows.Forms.Label();
            labelOut2 = new System.Windows.Forms.Label();
            checkBoxCalculateDeleteFilters = new System.Windows.Forms.CheckBox();
            tabControlMain = new System.Windows.Forms.TabControl();
            tabPageGenerate = new System.Windows.Forms.TabPage();
            tabPageOther = new System.Windows.Forms.TabPage();
            buttonCalculateFiltersDeleteAll = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tabControlMain.SuspendLayout();
            tabPageGenerate.SuspendLayout();
            tabPageOther.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxRootDir
            // 
            textBoxRootDir.ContextMenuStrip = calculateMenu;
            textBoxRootDir.Location = new System.Drawing.Point(11, 282);
            textBoxRootDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRootDir.Name = "textBoxRootDir";
            textBoxRootDir.Size = new System.Drawing.Size(767, 21);
            textBoxRootDir.TabIndex = 1;
            // 
            // calculateMenu
            // 
            calculateMenu.Font = new System.Drawing.Font("Consolas", 8.54F);
            calculateMenu.Name = "calculateMenu";
            calculateMenu.Size = new System.Drawing.Size(61, 4);
            calculateMenu.ItemClicked += calculateMenuItemClicked;
            // 
            // labelRootDir
            // 
            labelRootDir.Font = new System.Drawing.Font("Consolas", 8.54F, System.Drawing.FontStyle.Bold);
            labelRootDir.Location = new System.Drawing.Point(9, 264);
            labelRootDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRootDir.Name = "labelRootDir";
            labelRootDir.Size = new System.Drawing.Size(73, 13);
            labelRootDir.TabIndex = 4;
            labelRootDir.Text = "root   dir";
            // 
            // buttonCaluculate
            // 
            buttonCaluculate.ContextMenuStrip = calculateMenu;
            buttonCaluculate.Location = new System.Drawing.Point(672, 227);
            buttonCaluculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCaluculate.Name = "buttonCaluculate";
            buttonCaluculate.Size = new System.Drawing.Size(105, 49);
            buttonCaluculate.TabIndex = 4;
            buttonCaluculate.Text = "browse";
            buttonCaluculate.UseVisualStyleBackColor = true;
            buttonCaluculate.Click += buttonCalculateClick;
            // 
            // textBoxRootFilter
            // 
            textBoxRootFilter.Enabled = false;
            textBoxRootFilter.Location = new System.Drawing.Point(9, 490);
            textBoxRootFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRootFilter.Name = "textBoxRootFilter";
            textBoxRootFilter.Size = new System.Drawing.Size(765, 21);
            textBoxRootFilter.TabIndex = 3;
            textBoxRootFilter.Text = "/source/";
            // 
            // checkBoxRootFilter
            // 
            checkBoxRootFilter.Font = new System.Drawing.Font("Consolas", 8.54F, System.Drawing.FontStyle.Bold);
            checkBoxRootFilter.Location = new System.Drawing.Point(9, 472);
            checkBoxRootFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxRootFilter.Name = "checkBoxRootFilter";
            checkBoxRootFilter.Size = new System.Drawing.Size(124, 17);
            checkBoxRootFilter.TabIndex = 2;
            checkBoxRootFilter.Text = "[root   filter]";
            checkBoxRootFilter.UseVisualStyleBackColor = true;
            checkBoxRootFilter.CheckedChanged += checkBoxRootFilterCheckedChanged;
            // 
            // buttonOk
            // 
            buttonOk.Font = new System.Drawing.Font("Consolas", 9.26F);
            buttonOk.Location = new System.Drawing.Point(7, 627);
            buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(146, 45);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOkClick;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            textBoxResult.Font = new System.Drawing.Font("Consolas", 8.54F);
            textBoxResult.Location = new System.Drawing.Point(159, 627);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxResult.Size = new System.Drawing.Size(621, 45);
            textBoxResult.TabIndex = 5;
            // 
            // textBoxIn
            // 
            textBoxIn.Enabled = false;
            textBoxIn.Location = new System.Drawing.Point(9, 116);
            textBoxIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new System.Drawing.Size(768, 21);
            textBoxIn.TabIndex = 6;
            // 
            // buttonIn
            // 
            buttonIn.Enabled = false;
            buttonIn.Location = new System.Drawing.Point(672, 63);
            buttonIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonIn.Name = "buttonIn";
            buttonIn.Size = new System.Drawing.Size(105, 49);
            buttonIn.TabIndex = 7;
            buttonIn.Text = "browse";
            buttonIn.UseVisualStyleBackColor = true;
            buttonIn.Click += buttonInClick;
            // 
            // radioButtonInProject
            // 
            radioButtonInProject.Checked = true;
            radioButtonInProject.Font = new System.Drawing.Font("Consolas", 8.54F, System.Drawing.FontStyle.Bold);
            radioButtonInProject.Location = new System.Drawing.Point(9, 56);
            radioButtonInProject.Name = "radioButtonInProject";
            radioButtonInProject.Size = new System.Drawing.Size(123, 17);
            radioButtonInProject.TabIndex = 8;
            radioButtonInProject.TabStop = true;
            radioButtonInProject.Text = "project   whole";
            radioButtonInProject.UseVisualStyleBackColor = true;
            radioButtonInProject.CheckedChanged += radioButtonInCheckedChanged;
            // 
            // radioButtonInDir
            // 
            radioButtonInDir.Font = new System.Drawing.Font("Consolas", 8.54F);
            radioButtonInDir.Location = new System.Drawing.Point(9, 96);
            radioButtonInDir.Name = "radioButtonInDir";
            radioButtonInDir.Size = new System.Drawing.Size(44, 17);
            radioButtonInDir.TabIndex = 9;
            radioButtonInDir.Text = "dir";
            radioButtonInDir.UseVisualStyleBackColor = true;
            radioButtonInDir.CheckedChanged += radioButtonInCheckedChanged;
            // 
            // radioButtonInDirSubDir
            // 
            radioButtonInDirSubDir.Location = new System.Drawing.Point(9, 76);
            radioButtonInDirSubDir.Name = "radioButtonInDirSubDir";
            radioButtonInDirSubDir.Size = new System.Drawing.Size(150, 17);
            radioButtonInDirSubDir.TabIndex = 10;
            radioButtonInDirSubDir.Text = "dir   and   subDirs";
            radioButtonInDirSubDir.UseVisualStyleBackColor = true;
            radioButtonInDirSubDir.CheckedChanged += radioButtonInCheckedChanged;
            // 
            // labelIn
            // 
            labelIn.Font = new System.Drawing.Font("Consolas", 13.53F, System.Drawing.FontStyle.Bold);
            labelIn.Location = new System.Drawing.Point(6, 3);
            labelIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelIn.Name = "labelIn";
            labelIn.Size = new System.Drawing.Size(38, 21);
            labelIn.TabIndex = 11;
            labelIn.Text = "in";
            // 
            // labelCalculate
            // 
            labelCalculate.Font = new System.Drawing.Font("Consolas", 13.53F, System.Drawing.FontStyle.Bold);
            labelCalculate.Location = new System.Drawing.Point(6, 211);
            labelCalculate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCalculate.Name = "labelCalculate";
            labelCalculate.Size = new System.Drawing.Size(104, 21);
            labelCalculate.TabIndex = 12;
            labelCalculate.Text = "calculate";
            // 
            // labelOut
            // 
            labelOut.Font = new System.Drawing.Font("Consolas", 13.53F, System.Drawing.FontStyle.Bold);
            labelOut.Location = new System.Drawing.Point(6, 419);
            labelOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelOut.Name = "labelOut";
            labelOut.Size = new System.Drawing.Size(47, 21);
            labelOut.TabIndex = 13;
            labelOut.Text = "out";
            // 
            // labelIn2
            // 
            labelIn2.Font = new System.Drawing.Font("Consolas", 8.54F);
            labelIn2.Location = new System.Drawing.Point(7, 38);
            labelIn2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelIn2.Name = "labelIn2";
            labelIn2.Size = new System.Drawing.Size(133, 13);
            labelIn2.TabIndex = 14;
            labelIn2.Text = "input files are in:";
            // 
            // labelCalculate2
            // 
            labelCalculate2.Font = new System.Drawing.Font("Consolas", 8.54F);
            labelCalculate2.Location = new System.Drawing.Point(7, 246);
            labelCalculate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCalculate2.Name = "labelCalculate2";
            labelCalculate2.Size = new System.Drawing.Size(253, 13);
            labelCalculate2.TabIndex = 15;
            labelCalculate2.Text = "1.   filters are named as subDirs of:";
            // 
            // labelOut2
            // 
            labelOut2.Font = new System.Drawing.Font("Consolas", 8.54F);
            labelOut2.Location = new System.Drawing.Point(7, 454);
            labelOut2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelOut2.Name = "labelOut2";
            labelOut2.Size = new System.Drawing.Size(179, 13);
            labelOut2.TabIndex = 16;
            labelOut2.Text = "filters are placed out to:";
            // 
            // checkBoxCalculateDeleteFilters
            // 
            checkBoxCalculateDeleteFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxCalculateDeleteFilters.Checked = true;
            checkBoxCalculateDeleteFilters.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCalculateDeleteFilters.Location = new System.Drawing.Point(7, 317);
            checkBoxCalculateDeleteFilters.Name = "checkBoxCalculateDeleteFilters";
            checkBoxCalculateDeleteFilters.Size = new System.Drawing.Size(271, 17);
            checkBoxCalculateDeleteFilters.TabIndex = 17;
            checkBoxCalculateDeleteFilters.Text = "2.   delete already empty filters:   ";
            checkBoxCalculateDeleteFilters.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageGenerate);
            tabControlMain.Controls.Add(tabPageOther);
            tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlMain.Location = new System.Drawing.Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new System.Drawing.Size(793, 698);
            tabControlMain.TabIndex = 18;
            tabControlMain.MouseDown += formAdvancedMouseDown;
            // 
            // tabPageGenerate
            // 
            tabPageGenerate.Controls.Add(labelIn);
            tabPageGenerate.Controls.Add(checkBoxCalculateDeleteFilters);
            tabPageGenerate.Controls.Add(textBoxRootDir);
            tabPageGenerate.Controls.Add(labelOut2);
            tabPageGenerate.Controls.Add(labelRootDir);
            tabPageGenerate.Controls.Add(labelCalculate2);
            tabPageGenerate.Controls.Add(buttonCaluculate);
            tabPageGenerate.Controls.Add(labelIn2);
            tabPageGenerate.Controls.Add(buttonOk);
            tabPageGenerate.Controls.Add(labelOut);
            tabPageGenerate.Controls.Add(textBoxResult);
            tabPageGenerate.Controls.Add(labelCalculate);
            tabPageGenerate.Controls.Add(textBoxRootFilter);
            tabPageGenerate.Controls.Add(checkBoxRootFilter);
            tabPageGenerate.Controls.Add(radioButtonInDirSubDir);
            tabPageGenerate.Controls.Add(textBoxIn);
            tabPageGenerate.Controls.Add(radioButtonInDir);
            tabPageGenerate.Controls.Add(buttonIn);
            tabPageGenerate.Controls.Add(radioButtonInProject);
            tabPageGenerate.Location = new System.Drawing.Point(4, 22);
            tabPageGenerate.Name = "tabPageGenerate";
            tabPageGenerate.Padding = new System.Windows.Forms.Padding(3);
            tabPageGenerate.Size = new System.Drawing.Size(785, 672);
            tabPageGenerate.TabIndex = 1;
            tabPageGenerate.Text = "generate";
            tabPageGenerate.UseVisualStyleBackColor = true;
            tabPageGenerate.MouseDown += formAdvancedMouseDown;
            // 
            // tabPageOther
            // 
            tabPageOther.Controls.Add(buttonCalculateFiltersDeleteAll);
            tabPageOther.Controls.Add(label1);
            tabPageOther.Location = new System.Drawing.Point(4, 22);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Padding = new System.Windows.Forms.Padding(3);
            tabPageOther.Size = new System.Drawing.Size(785, 672);
            tabPageOther.TabIndex = 0;
            tabPageOther.Text = "other";
            tabPageOther.UseVisualStyleBackColor = true;
            tabPageOther.MouseDown += formAdvancedMouseDown;
            // 
            // buttonCalculateFiltersDeleteAll
            // 
            buttonCalculateFiltersDeleteAll.Font = new System.Drawing.Font("Consolas", 8.54F);
            buttonCalculateFiltersDeleteAll.Location = new System.Drawing.Point(7, 246);
            buttonCalculateFiltersDeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCalculateFiltersDeleteAll.Name = "buttonCalculateFiltersDeleteAll";
            buttonCalculateFiltersDeleteAll.Size = new System.Drawing.Size(157, 51);
            buttonCalculateFiltersDeleteAll.TabIndex = 14;
            buttonCalculateFiltersDeleteAll.Text = "delete all filters";
            buttonCalculateFiltersDeleteAll.UseVisualStyleBackColor = true;
            buttonCalculateFiltersDeleteAll.Click += buttonCalculateFiltersDeleteAllClick;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Consolas", 13.53F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(6, 211);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 21);
            label1.TabIndex = 13;
            label1.Text = "calculate";
            // 
            // formAdvanced
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(793, 698);
            Controls.Add(tabControlMain);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Consolas", 8.54F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(7000, 6614);
            Name = "formAdvanced";
            FormClosing += formAdvancedFormClosing;
            MouseDown += formAdvancedMouseDown;
            tabControlMain.ResumeLayout(false);
            tabPageGenerate.ResumeLayout(false);
            tabPageOther.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label labelRootDir;
        private System.Windows.Forms.Button buttonCaluculate;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.CheckBox checkBoxRootFilter;
        private System.Windows.Forms.FolderBrowserDialog dialogFolder;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelCalculate;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelIn2;
        private System.Windows.Forms.Label labelCalculate2;
        private System.Windows.Forms.Label labelOut2;
        public System.Windows.Forms.RadioButton radioButtonInProject;
        public System.Windows.Forms.RadioButton radioButtonInDir;
        public System.Windows.Forms.RadioButton radioButtonInDirSubDir;
        public System.Windows.Forms.CheckBox checkBoxCalculateDeleteFilters;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOther;
        private System.Windows.Forms.TabPage tabPageGenerate;
        private System.Windows.Forms.Button buttonCalculateFiltersDeleteAll;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ContextMenuStrip calculateMenu;
        public u.forms.textBox.textBox2 textBoxRootDir;
        public u.forms.textBox.textBox2 textBoxRootFilter;
        private u.forms.textBox.textBox2 textBoxResult;
        public u.forms.textBox.textBox2 textBoxIn;
    }
}