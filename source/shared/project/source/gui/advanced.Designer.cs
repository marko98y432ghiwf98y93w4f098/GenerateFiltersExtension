namespace VisualStudioCppExtensions
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
            textBoxRootDir.Location = new System.Drawing.Point(12, 297);
            textBoxRootDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRootDir.Name = "textBoxRootDir";
            textBoxRootDir.Size = new System.Drawing.Size(808, 22);
            textBoxRootDir.TabIndex = 1;
            // 
            // calculateMenu
            // 
            calculateMenu.Font = new System.Drawing.Font("Consolas", 9F);
            calculateMenu.Name = "calculateMenu";
            calculateMenu.Size = new System.Drawing.Size(61, 4);
            calculateMenu.ItemClicked += calculateMenuItemClicked;
            // 
            // labelRootDir
            // 
            labelRootDir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRootDir.Location = new System.Drawing.Point(10, 278);
            labelRootDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRootDir.Name = "labelRootDir";
            labelRootDir.Size = new System.Drawing.Size(77, 14);
            labelRootDir.TabIndex = 4;
            labelRootDir.Text = "root   dir";
            // 
            // buttonCaluculate
            // 
            buttonCaluculate.ContextMenuStrip = calculateMenu;
            buttonCaluculate.Location = new System.Drawing.Point(708, 239);
            buttonCaluculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCaluculate.Name = "buttonCaluculate";
            buttonCaluculate.Size = new System.Drawing.Size(111, 52);
            buttonCaluculate.TabIndex = 4;
            buttonCaluculate.Text = "browse";
            buttonCaluculate.UseVisualStyleBackColor = true;
            buttonCaluculate.Click += buttonCalculateClick;
            // 
            // textBoxRootFilter
            // 
            textBoxRootFilter.Enabled = false;
            textBoxRootFilter.Location = new System.Drawing.Point(10, 516);
            textBoxRootFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRootFilter.Name = "textBoxRootFilter";
            textBoxRootFilter.Size = new System.Drawing.Size(806, 22);
            textBoxRootFilter.TabIndex = 3;
            textBoxRootFilter.Text = "/source/";
            // 
            // checkBoxRootFilter
            // 
            checkBoxRootFilter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxRootFilter.Location = new System.Drawing.Point(10, 497);
            checkBoxRootFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxRootFilter.Name = "checkBoxRootFilter";
            checkBoxRootFilter.Size = new System.Drawing.Size(131, 18);
            checkBoxRootFilter.TabIndex = 2;
            checkBoxRootFilter.Text = "[root   filter]";
            checkBoxRootFilter.UseVisualStyleBackColor = true;
            checkBoxRootFilter.CheckedChanged += checkBoxRootFilterCheckedChanged;
            // 
            // buttonOk
            // 
            buttonOk.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonOk.Location = new System.Drawing.Point(7, 620);
            buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(154, 47);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOkClick;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            textBoxResult.Location = new System.Drawing.Point(168, 620);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxResult.Size = new System.Drawing.Size(654, 47);
            textBoxResult.TabIndex = 5;
            // 
            // textBoxIn
            // 
            textBoxIn.Enabled = false;
            textBoxIn.Location = new System.Drawing.Point(10, 122);
            textBoxIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new System.Drawing.Size(809, 22);
            textBoxIn.TabIndex = 6;
            // 
            // buttonIn
            // 
            buttonIn.Enabled = false;
            buttonIn.Location = new System.Drawing.Point(708, 66);
            buttonIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonIn.Name = "buttonIn";
            buttonIn.Size = new System.Drawing.Size(111, 52);
            buttonIn.TabIndex = 7;
            buttonIn.Text = "browse";
            buttonIn.UseVisualStyleBackColor = true;
            buttonIn.Click += buttonInClick;
            // 
            // radioButtonInProject
            // 
            radioButtonInProject.Checked = true;
            radioButtonInProject.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radioButtonInProject.Location = new System.Drawing.Point(10, 59);
            radioButtonInProject.Name = "radioButtonInProject";
            radioButtonInProject.Size = new System.Drawing.Size(130, 18);
            radioButtonInProject.TabIndex = 8;
            radioButtonInProject.TabStop = true;
            radioButtonInProject.Text = "project   whole";
            radioButtonInProject.UseVisualStyleBackColor = true;
            radioButtonInProject.CheckedChanged += radioButtonInCheckedChanged;
            // 
            // radioButtonInDir
            // 
            radioButtonInDir.Location = new System.Drawing.Point(10, 101);
            radioButtonInDir.Name = "radioButtonInDir";
            radioButtonInDir.Size = new System.Drawing.Size(46, 18);
            radioButtonInDir.TabIndex = 9;
            radioButtonInDir.Text = "dir";
            radioButtonInDir.UseVisualStyleBackColor = true;
            radioButtonInDir.CheckedChanged += radioButtonInCheckedChanged;
            // 
            // radioButtonInDirSubDir
            // 
            radioButtonInDirSubDir.Location = new System.Drawing.Point(10, 80);
            radioButtonInDirSubDir.Name = "radioButtonInDirSubDir";
            radioButtonInDirSubDir.Size = new System.Drawing.Size(158, 18);
            radioButtonInDirSubDir.TabIndex = 10;
            radioButtonInDirSubDir.Text = "dir   and   subDirs";
            radioButtonInDirSubDir.UseVisualStyleBackColor = true;
            radioButtonInDirSubDir.CheckedChanged += radioButtonInCheckedChanged;
            // 
            // labelIn
            // 
            labelIn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelIn.Location = new System.Drawing.Point(6, 3);
            labelIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelIn.Name = "labelIn";
            labelIn.Size = new System.Drawing.Size(40, 22);
            labelIn.TabIndex = 11;
            labelIn.Text = "in";
            // 
            // labelCalculate
            // 
            labelCalculate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelCalculate.Location = new System.Drawing.Point(6, 222);
            labelCalculate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCalculate.Name = "labelCalculate";
            labelCalculate.Size = new System.Drawing.Size(110, 22);
            labelCalculate.TabIndex = 12;
            labelCalculate.Text = "calculate";
            // 
            // labelOut
            // 
            labelOut.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelOut.Location = new System.Drawing.Point(6, 441);
            labelOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelOut.Name = "labelOut";
            labelOut.Size = new System.Drawing.Size(50, 22);
            labelOut.TabIndex = 13;
            labelOut.Text = "out";
            // 
            // labelIn2
            // 
            labelIn2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelIn2.Location = new System.Drawing.Point(7, 40);
            labelIn2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelIn2.Name = "labelIn2";
            labelIn2.Size = new System.Drawing.Size(140, 14);
            labelIn2.TabIndex = 14;
            labelIn2.Text = "input files are in:";
            // 
            // labelCalculate2
            // 
            labelCalculate2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelCalculate2.Location = new System.Drawing.Point(7, 259);
            labelCalculate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCalculate2.Name = "labelCalculate2";
            labelCalculate2.Size = new System.Drawing.Size(266, 14);
            labelCalculate2.TabIndex = 15;
            labelCalculate2.Text = "1.   filters are named as subDirs of:";
            // 
            // labelOut2
            // 
            labelOut2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelOut2.Location = new System.Drawing.Point(7, 478);
            labelOut2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelOut2.Name = "labelOut2";
            labelOut2.Size = new System.Drawing.Size(189, 14);
            labelOut2.TabIndex = 16;
            labelOut2.Text = "filters are placed out to:";
            // 
            // checkBoxCalculateDeleteFilters
            // 
            checkBoxCalculateDeleteFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBoxCalculateDeleteFilters.Checked = true;
            checkBoxCalculateDeleteFilters.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCalculateDeleteFilters.Location = new System.Drawing.Point(7, 334);
            checkBoxCalculateDeleteFilters.Name = "checkBoxCalculateDeleteFilters";
            checkBoxCalculateDeleteFilters.Size = new System.Drawing.Size(285, 18);
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
            tabControlMain.Size = new System.Drawing.Size(837, 698);
            tabControlMain.TabIndex = 18;
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
            tabPageGenerate.Location = new System.Drawing.Point(4, 23);
            tabPageGenerate.Name = "tabPageGenerate";
            tabPageGenerate.Padding = new System.Windows.Forms.Padding(3);
            tabPageGenerate.Size = new System.Drawing.Size(829, 671);
            tabPageGenerate.TabIndex = 1;
            tabPageGenerate.Text = "generate";
            tabPageGenerate.UseVisualStyleBackColor = true;
            // 
            // tabPageOther
            // 
            tabPageOther.Controls.Add(buttonCalculateFiltersDeleteAll);
            tabPageOther.Controls.Add(label1);
            tabPageOther.Location = new System.Drawing.Point(4, 23);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Padding = new System.Windows.Forms.Padding(3);
            tabPageOther.Size = new System.Drawing.Size(829, 711);
            tabPageOther.TabIndex = 0;
            tabPageOther.Text = "other";
            tabPageOther.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateFiltersDeleteAll
            // 
            buttonCalculateFiltersDeleteAll.Location = new System.Drawing.Point(7, 259);
            buttonCalculateFiltersDeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCalculateFiltersDeleteAll.Name = "buttonCalculateFiltersDeleteAll";
            buttonCalculateFiltersDeleteAll.Size = new System.Drawing.Size(165, 54);
            buttonCalculateFiltersDeleteAll.TabIndex = 14;
            buttonCalculateFiltersDeleteAll.Text = "delete all filters";
            buttonCalculateFiltersDeleteAll.UseVisualStyleBackColor = true;
            buttonCalculateFiltersDeleteAll.Click += buttonCalculateFiltersDeleteAllClick;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(6, 222);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 22);
            label1.TabIndex = 13;
            label1.Text = "calculate";
            // 
            // formAdvanced
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(837, 698);
            Controls.Add(tabControlMain);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "formAdvanced";
            FormClosing += formAdvancedFormClosing;
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