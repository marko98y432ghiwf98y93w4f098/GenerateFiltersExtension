namespace VisualStudioCppExtensions
{
    partial class formQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuestion));
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelInfoProject2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfoFroject = new System.Windows.Forms.Label();
            this.labelInfoRootDir = new System.Windows.Forms.Label();
            this.labelInfoRootFilter = new System.Windows.Forms.Label();
            this.labelInfoRootFilter2 = new System.Windows.Forms.Label();
            this.labelInfoRootDir2 = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.labelWarning3 = new System.Windows.Forms.Label();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.labelBug = new System.Windows.Forms.Label();
            this.groupBoxQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(51, 57);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(88, 35);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYesClick);
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Location = new System.Drawing.Point(51, 16);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(88, 35);
            this.buttonAdvanced.TabIndex = 1;
            this.buttonAdvanced.Text = "advanced";
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvancedClick);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(487, 13);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "Do you want to automatically generate (directoryTree => filterTree) filters for:";
            // 
            // labelInfoProject2
            // 
            this.labelInfoProject2.AutoSize = true;
            this.labelInfoProject2.Location = new System.Drawing.Point(109, 32);
            this.labelInfoProject2.Name = "labelInfoProject2";
            this.labelInfoProject2.Size = new System.Drawing.Size(31, 13);
            this.labelInfoProject2.TabIndex = 2;
            this.labelInfoProject2.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "?";
            // 
            // labelInfoFroject
            // 
            this.labelInfoFroject.AutoSize = true;
            this.labelInfoFroject.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoFroject.Location = new System.Drawing.Point(30, 32);
            this.labelInfoFroject.Name = "labelInfoFroject";
            this.labelInfoFroject.Size = new System.Drawing.Size(55, 13);
            this.labelInfoFroject.TabIndex = 2;
            this.labelInfoFroject.Text = "project:";
            // 
            // labelInfoRootDir
            // 
            this.labelInfoRootDir.AutoSize = true;
            this.labelInfoRootDir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoRootDir.Location = new System.Drawing.Point(30, 55);
            this.labelInfoRootDir.Name = "labelInfoRootDir";
            this.labelInfoRootDir.Size = new System.Drawing.Size(55, 13);
            this.labelInfoRootDir.TabIndex = 2;
            this.labelInfoRootDir.Text = "rootDir:";
            // 
            // labelInfoRootFilter
            // 
            this.labelInfoRootFilter.AutoSize = true;
            this.labelInfoRootFilter.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoRootFilter.Location = new System.Drawing.Point(12, 78);
            this.labelInfoRootFilter.Name = "labelInfoRootFilter";
            this.labelInfoRootFilter.Size = new System.Drawing.Size(73, 13);
            this.labelInfoRootFilter.TabIndex = 2;
            this.labelInfoRootFilter.Text = "rootFilter:";
            // 
            // labelInfoRootFilter2
            // 
            this.labelInfoRootFilter2.AutoSize = true;
            this.labelInfoRootFilter2.Location = new System.Drawing.Point(109, 78);
            this.labelInfoRootFilter2.Name = "labelInfoRootFilter2";
            this.labelInfoRootFilter2.Size = new System.Drawing.Size(31, 13);
            this.labelInfoRootFilter2.TabIndex = 2;
            this.labelInfoRootFilter2.Text = "name";
            // 
            // labelInfoRootDir2
            // 
            this.labelInfoRootDir2.AutoSize = true;
            this.labelInfoRootDir2.Location = new System.Drawing.Point(109, 55);
            this.labelInfoRootDir2.Name = "labelInfoRootDir2";
            this.labelInfoRootDir2.Size = new System.Drawing.Size(31, 13);
            this.labelInfoRootDir2.TabIndex = 2;
            this.labelInfoRootDir2.Text = "name";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(12, 159);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(271, 13);
            this.labelWarning.TabIndex = 2;
            this.labelWarning.Text = "Warning:   Existing filters will be erased !";
            // 
            // labelWarning2
            // 
            this.labelWarning2.AutoSize = true;
            this.labelWarning2.Location = new System.Drawing.Point(12, 185);
            this.labelWarning2.Name = "labelWarning2";
            this.labelWarning2.Size = new System.Drawing.Size(373, 13);
            this.labelWarning2.TabIndex = 2;
            this.labelWarning2.Text = "Warning:   Project will be: 1. closed  2. changed  3. opened.";
            // 
            // labelWarning3
            // 
            this.labelWarning3.AutoSize = true;
            this.labelWarning3.Location = new System.Drawing.Point(78, 201);
            this.labelWarning3.Name = "labelWarning3";
            this.labelWarning3.Size = new System.Drawing.Size(277, 13);
            this.labelWarning3.TabIndex = 2;
            this.labelWarning3.Text = "You will be asked to save changes before 1. !";
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.buttonAdvanced);
            this.groupBoxQuestion.Controls.Add(this.buttonYes);
            this.groupBoxQuestion.Controls.Add(this.label2);
            this.groupBoxQuestion.Location = new System.Drawing.Point(484, 122);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Size = new System.Drawing.Size(154, 100);
            this.groupBoxQuestion.TabIndex = 3;
            this.groupBoxQuestion.TabStop = false;
            // 
            // labelBug
            // 
            this.labelBug.AutoSize = true;
            this.labelBug.Location = new System.Drawing.Point(12, 227);
            this.labelBug.Name = "labelBug";
            this.labelBug.Size = new System.Drawing.Size(487, 13);
            this.labelBug.TabIndex = 4;
            this.labelBug.Text = "Bug:       If used on vcxitems project, please unload projects that reference it";
            // 
            // formQuestion
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 250);
            this.Controls.Add(this.labelBug);
            this.Controls.Add(this.groupBoxQuestion);
            this.Controls.Add(this.labelWarning3);
            this.Controls.Add(this.labelWarning2);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelInfoRootDir2);
            this.Controls.Add(this.labelInfoRootFilter2);
            this.Controls.Add(this.labelInfoRootFilter);
            this.Controls.Add(this.labelInfoRootDir);
            this.Controls.Add(this.labelInfoFroject);
            this.Controls.Add(this.labelInfoProject2);
            this.Controls.Add(this.labelQuestion);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formQuestion";
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelQuestion;
        public System.Windows.Forms.Label labelInfoProject2;
        public System.Windows.Forms.Label labelInfoFroject;
        public System.Windows.Forms.Label labelInfoRootDir;
        public System.Windows.Forms.Label labelInfoRootFilter;
        public System.Windows.Forms.Label labelInfoRootFilter2;
        public System.Windows.Forms.Label labelInfoRootDir2;
        public System.Windows.Forms.Label labelWarning;
        public System.Windows.Forms.Label labelWarning2;
        public System.Windows.Forms.Label labelWarning3;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        public System.Windows.Forms.Label labelBug;
    }
}