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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdvanced));
            this.textBoxRootDir = new System.Windows.Forms.TextBox();
            this.labelRootDir = new System.Windows.Forms.Label();
            this.buttonCaluculate = new System.Windows.Forms.Button();
            this.textBoxRootFilter = new System.Windows.Forms.TextBox();
            this.checkBoxRootFilter = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.radioButtonInProject = new System.Windows.Forms.RadioButton();
            this.radioButtonInDir = new System.Windows.Forms.RadioButton();
            this.radioButtonInDirSubDir = new System.Windows.Forms.RadioButton();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelCalculate = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelIn2 = new System.Windows.Forms.Label();
            this.labelCalculate2 = new System.Windows.Forms.Label();
            this.labelOut2 = new System.Windows.Forms.Label();
            this.checkBoxCalculateDeleteFilters = new System.Windows.Forms.CheckBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageGenerate = new System.Windows.Forms.TabPage();
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.buttonCalculateFiltersDeleteAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageGenerate.SuspendLayout();
            this.tabPageOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRootDir
            // 
            this.textBoxRootDir.Location = new System.Drawing.Point(12, 297);
            this.textBoxRootDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRootDir.Name = "textBoxRootDir";
            this.textBoxRootDir.Size = new System.Drawing.Size(808, 22);
            this.textBoxRootDir.TabIndex = 1;
            // 
            // labelRootDir
            // 
            this.labelRootDir.AutoSize = true;
            this.labelRootDir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRootDir.Location = new System.Drawing.Point(10, 278);
            this.labelRootDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRootDir.Name = "labelRootDir";
            this.labelRootDir.Size = new System.Drawing.Size(77, 14);
            this.labelRootDir.TabIndex = 4;
            this.labelRootDir.Text = "root   dir";
            // 
            // buttonCaluculate
            // 
            this.buttonCaluculate.Location = new System.Drawing.Point(708, 239);
            this.buttonCaluculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCaluculate.Name = "buttonCaluculate";
            this.buttonCaluculate.Size = new System.Drawing.Size(111, 52);
            this.buttonCaluculate.TabIndex = 4;
            this.buttonCaluculate.Text = "browse";
            this.buttonCaluculate.UseVisualStyleBackColor = true;
            this.buttonCaluculate.Click += new System.EventHandler(this.buttonCalculateClick);
            // 
            // textBoxRootFilter
            // 
            this.textBoxRootFilter.Enabled = false;
            this.textBoxRootFilter.Location = new System.Drawing.Point(10, 516);
            this.textBoxRootFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRootFilter.Name = "textBoxRootFilter";
            this.textBoxRootFilter.Size = new System.Drawing.Size(806, 22);
            this.textBoxRootFilter.TabIndex = 3;
            this.textBoxRootFilter.Text = "/source/";
            // 
            // checkBoxRootFilter
            // 
            this.checkBoxRootFilter.AutoSize = true;
            this.checkBoxRootFilter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRootFilter.Location = new System.Drawing.Point(10, 497);
            this.checkBoxRootFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxRootFilter.Name = "checkBoxRootFilter";
            this.checkBoxRootFilter.Size = new System.Drawing.Size(131, 18);
            this.checkBoxRootFilter.TabIndex = 2;
            this.checkBoxRootFilter.Text = "[root   filter]";
            this.checkBoxRootFilter.UseVisualStyleBackColor = true;
            this.checkBoxRootFilter.CheckedChanged += new System.EventHandler(this.checkBoxRootFilterCheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(7, 660);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(154, 47);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOkClick);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Location = new System.Drawing.Point(168, 660);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(654, 47);
            this.textBoxResult.TabIndex = 5;
            // 
            // textBoxIn
            // 
            this.textBoxIn.Enabled = false;
            this.textBoxIn.Location = new System.Drawing.Point(10, 122);
            this.textBoxIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(809, 22);
            this.textBoxIn.TabIndex = 6;
            // 
            // buttonIn
            // 
            this.buttonIn.Enabled = false;
            this.buttonIn.Location = new System.Drawing.Point(708, 66);
            this.buttonIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(111, 52);
            this.buttonIn.TabIndex = 7;
            this.buttonIn.Text = "browse";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonInClick);
            // 
            // radioButtonInProject
            // 
            this.radioButtonInProject.AutoSize = true;
            this.radioButtonInProject.Checked = true;
            this.radioButtonInProject.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInProject.Location = new System.Drawing.Point(10, 59);
            this.radioButtonInProject.Name = "radioButtonInProject";
            this.radioButtonInProject.Size = new System.Drawing.Size(130, 18);
            this.radioButtonInProject.TabIndex = 8;
            this.radioButtonInProject.TabStop = true;
            this.radioButtonInProject.Text = "project   whole";
            this.radioButtonInProject.UseVisualStyleBackColor = true;
            this.radioButtonInProject.CheckedChanged += new System.EventHandler(this.radioButtonInCheckedChanged);
            // 
            // radioButtonInDir
            // 
            this.radioButtonInDir.AutoSize = true;
            this.radioButtonInDir.Location = new System.Drawing.Point(10, 101);
            this.radioButtonInDir.Name = "radioButtonInDir";
            this.radioButtonInDir.Size = new System.Drawing.Size(46, 18);
            this.radioButtonInDir.TabIndex = 9;
            this.radioButtonInDir.Text = "dir";
            this.radioButtonInDir.UseVisualStyleBackColor = true;
            this.radioButtonInDir.CheckedChanged += new System.EventHandler(this.radioButtonInCheckedChanged);
            // 
            // radioButtonInDirSubDir
            // 
            this.radioButtonInDirSubDir.AutoSize = true;
            this.radioButtonInDirSubDir.Location = new System.Drawing.Point(10, 80);
            this.radioButtonInDirSubDir.Name = "radioButtonInDirSubDir";
            this.radioButtonInDirSubDir.Size = new System.Drawing.Size(158, 18);
            this.radioButtonInDirSubDir.TabIndex = 10;
            this.radioButtonInDirSubDir.Text = "dir   and   subDirs";
            this.radioButtonInDirSubDir.UseVisualStyleBackColor = true;
            this.radioButtonInDirSubDir.CheckedChanged += new System.EventHandler(this.radioButtonInCheckedChanged);
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.Location = new System.Drawing.Point(6, 3);
            this.labelIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(30, 22);
            this.labelIn.TabIndex = 11;
            this.labelIn.Text = "in";
            // 
            // labelCalculate
            // 
            this.labelCalculate.AutoSize = true;
            this.labelCalculate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculate.Location = new System.Drawing.Point(6, 222);
            this.labelCalculate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalculate.Name = "labelCalculate";
            this.labelCalculate.Size = new System.Drawing.Size(100, 22);
            this.labelCalculate.TabIndex = 12;
            this.labelCalculate.Text = "calculate";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOut.Location = new System.Drawing.Point(6, 441);
            this.labelOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(40, 22);
            this.labelOut.TabIndex = 13;
            this.labelOut.Text = "out";
            // 
            // labelIn2
            // 
            this.labelIn2.AutoSize = true;
            this.labelIn2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn2.Location = new System.Drawing.Point(7, 40);
            this.labelIn2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIn2.Name = "labelIn2";
            this.labelIn2.Size = new System.Drawing.Size(140, 14);
            this.labelIn2.TabIndex = 14;
            this.labelIn2.Text = "input files are in:";
            // 
            // labelCalculate2
            // 
            this.labelCalculate2.AutoSize = true;
            this.labelCalculate2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculate2.Location = new System.Drawing.Point(7, 259);
            this.labelCalculate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalculate2.Name = "labelCalculate2";
            this.labelCalculate2.Size = new System.Drawing.Size(266, 14);
            this.labelCalculate2.TabIndex = 15;
            this.labelCalculate2.Text = "1.   filters are named as subDirs of:";
            // 
            // labelOut2
            // 
            this.labelOut2.AutoSize = true;
            this.labelOut2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOut2.Location = new System.Drawing.Point(7, 478);
            this.labelOut2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOut2.Name = "labelOut2";
            this.labelOut2.Size = new System.Drawing.Size(161, 14);
            this.labelOut2.TabIndex = 16;
            this.labelOut2.Text = "filters are placed in:";
            // 
            // checkBoxCalculateDeleteFilters
            // 
            this.checkBoxCalculateDeleteFilters.AutoSize = true;
            this.checkBoxCalculateDeleteFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCalculateDeleteFilters.Checked = true;
            this.checkBoxCalculateDeleteFilters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCalculateDeleteFilters.Location = new System.Drawing.Point(7, 334);
            this.checkBoxCalculateDeleteFilters.Name = "checkBoxCalculateDeleteFilters";
            this.checkBoxCalculateDeleteFilters.Size = new System.Drawing.Size(285, 18);
            this.checkBoxCalculateDeleteFilters.TabIndex = 17;
            this.checkBoxCalculateDeleteFilters.Text = "2.   delete already empty filters:   ";
            this.checkBoxCalculateDeleteFilters.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGenerate);
            this.tabControlMain.Controls.Add(this.tabPageOther);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(837, 738);
            this.tabControlMain.TabIndex = 18;
            // 
            // tabPageGenerate
            // 
            this.tabPageGenerate.Controls.Add(this.labelIn);
            this.tabPageGenerate.Controls.Add(this.checkBoxCalculateDeleteFilters);
            this.tabPageGenerate.Controls.Add(this.textBoxRootDir);
            this.tabPageGenerate.Controls.Add(this.labelOut2);
            this.tabPageGenerate.Controls.Add(this.labelRootDir);
            this.tabPageGenerate.Controls.Add(this.labelCalculate2);
            this.tabPageGenerate.Controls.Add(this.buttonCaluculate);
            this.tabPageGenerate.Controls.Add(this.labelIn2);
            this.tabPageGenerate.Controls.Add(this.buttonOk);
            this.tabPageGenerate.Controls.Add(this.labelOut);
            this.tabPageGenerate.Controls.Add(this.textBoxResult);
            this.tabPageGenerate.Controls.Add(this.labelCalculate);
            this.tabPageGenerate.Controls.Add(this.textBoxRootFilter);
            this.tabPageGenerate.Controls.Add(this.checkBoxRootFilter);
            this.tabPageGenerate.Controls.Add(this.radioButtonInDirSubDir);
            this.tabPageGenerate.Controls.Add(this.textBoxIn);
            this.tabPageGenerate.Controls.Add(this.radioButtonInDir);
            this.tabPageGenerate.Controls.Add(this.buttonIn);
            this.tabPageGenerate.Controls.Add(this.radioButtonInProject);
            this.tabPageGenerate.Location = new System.Drawing.Point(4, 23);
            this.tabPageGenerate.Name = "tabPageGenerate";
            this.tabPageGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenerate.Size = new System.Drawing.Size(829, 711);
            this.tabPageGenerate.TabIndex = 1;
            this.tabPageGenerate.Text = "generate";
            this.tabPageGenerate.UseVisualStyleBackColor = true;
            // 
            // tabPageOther
            // 
            this.tabPageOther.Controls.Add(this.buttonCalculateFiltersDeleteAll);
            this.tabPageOther.Controls.Add(this.label1);
            this.tabPageOther.Location = new System.Drawing.Point(4, 23);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOther.Size = new System.Drawing.Size(829, 711);
            this.tabPageOther.TabIndex = 0;
            this.tabPageOther.Text = "other";
            this.tabPageOther.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateFiltersDeleteAll
            // 
            this.buttonCalculateFiltersDeleteAll.Location = new System.Drawing.Point(7, 259);
            this.buttonCalculateFiltersDeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCalculateFiltersDeleteAll.Name = "buttonCalculateFiltersDeleteAll";
            this.buttonCalculateFiltersDeleteAll.Size = new System.Drawing.Size(165, 54);
            this.buttonCalculateFiltersDeleteAll.TabIndex = 14;
            this.buttonCalculateFiltersDeleteAll.Text = "delete all filters";
            this.buttonCalculateFiltersDeleteAll.UseVisualStyleBackColor = true;
            this.buttonCalculateFiltersDeleteAll.Click += new System.EventHandler(this.buttonCalculateFiltersDeleteAllClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "calculate";
            // 
            // formAdvanced
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 738);
            this.Controls.Add(this.tabControlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "formAdvanced";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAdvancedFormClosing);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGenerate.ResumeLayout(false);
            this.tabPageGenerate.PerformLayout();
            this.tabPageOther.ResumeLayout(false);
            this.tabPageOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelRootDir;
        private System.Windows.Forms.Button buttonCaluculate;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TextBox textBoxRootDir;
        public System.Windows.Forms.TextBox textBoxRootFilter;
        public System.Windows.Forms.CheckBox checkBoxRootFilter;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.FolderBrowserDialog dialogFolder;
        public System.Windows.Forms.TextBox textBoxIn;
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
    }
}