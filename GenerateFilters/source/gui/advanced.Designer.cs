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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxRootFilter = new System.Windows.Forms.TextBox();
            this.checkBoxRootFilter = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxRootDir
            // 
            this.textBoxRootDir.Location = new System.Drawing.Point(7, 26);
            this.textBoxRootDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRootDir.Name = "textBoxRootDir";
            this.textBoxRootDir.Size = new System.Drawing.Size(822, 22);
            this.textBoxRootDir.TabIndex = 1;
            // 
            // labelRootDir
            // 
            this.labelRootDir.AutoSize = true;
            this.labelRootDir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRootDir.Location = new System.Drawing.Point(4, 9);
            this.labelRootDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRootDir.Name = "labelRootDir";
            this.labelRootDir.Size = new System.Drawing.Size(77, 14);
            this.labelRootDir.TabIndex = 4;
            this.labelRootDir.Text = "root   dir";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(846, 17);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(77, 31);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowseClick);
            // 
            // textBoxRootFilter
            // 
            this.textBoxRootFilter.Enabled = false;
            this.textBoxRootFilter.Location = new System.Drawing.Point(7, 87);
            this.textBoxRootFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRootFilter.Name = "textBoxRootFilter";
            this.textBoxRootFilter.Size = new System.Drawing.Size(916, 22);
            this.textBoxRootFilter.TabIndex = 3;
            this.textBoxRootFilter.Text = "/source/";
            // 
            // checkBoxRootFilter
            // 
            this.checkBoxRootFilter.AutoSize = true;
            this.checkBoxRootFilter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRootFilter.Location = new System.Drawing.Point(7, 63);
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
            this.buttonOk.Location = new System.Drawing.Point(7, 125);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(154, 95);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOkClick);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Location = new System.Drawing.Point(177, 125);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(746, 95);
            this.textBoxResult.TabIndex = 5;
            // 
            // formAdvanced
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 229);
            this.Controls.Add(this.checkBoxRootFilter);
            this.Controls.Add(this.textBoxRootFilter);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelRootDir);
            this.Controls.Add(this.textBoxRootDir);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "formAdvanced";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAdvancedFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRootDir;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TextBox textBoxRootDir;
        public System.Windows.Forms.TextBox textBoxRootFilter;
        public System.Windows.Forms.CheckBox checkBoxRootFilter;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.FolderBrowserDialog dialogFolder;
    }
}