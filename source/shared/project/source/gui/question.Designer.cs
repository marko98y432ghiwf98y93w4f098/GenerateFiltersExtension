using u.forms.control;

namespace extension
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
            buttonYes = new System.Windows.Forms.Button();
            buttonAdvanced = new System.Windows.Forms.Button();
            labelQuestion = new System.Windows.Forms.Label();
            labelInfoProject2 = new System.Windows.Forms.Label();
            labelQuestionMark = new System.Windows.Forms.Label();
            labelInfoProject = new label2();
            labelInfoCalculate2 = new label2();
            labelInfoOut2 = new label2();
            labelInfoOut3 = new System.Windows.Forms.Label();
            labelInfoCalculate3 = new System.Windows.Forms.Label();
            labelWarning = new System.Windows.Forms.Label();
            groupBoxQuestion = new System.Windows.Forms.GroupBox();
            labelWarning2 = new System.Windows.Forms.Label();
            labelWarning3 = new System.Windows.Forms.Label();
            labelInfoIn = new label2();
            labelInfoCalculate = new label2();
            labelInfoOut = new label2();
            labelInfoIn2 = new System.Windows.Forms.Label();
            labelWarning4 = new System.Windows.Forms.Label();
            groupBoxQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // buttonYes
            // 
            buttonYes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonYes.Location = new System.Drawing.Point(51, 57);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new System.Drawing.Size(88, 35);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "yes";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYesClick;
            // 
            // buttonAdvanced
            // 
            buttonAdvanced.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonAdvanced.Location = new System.Drawing.Point(51, 16);
            buttonAdvanced.Name = "buttonAdvanced";
            buttonAdvanced.Size = new System.Drawing.Size(88, 35);
            buttonAdvanced.TabIndex = 1;
            buttonAdvanced.Text = "advanced";
            buttonAdvanced.UseVisualStyleBackColor = true;
            buttonAdvanced.Click += buttonAdvancedClick;
            // 
            // labelQuestion
            // 
            labelQuestion.Location = new System.Drawing.Point(12, 9);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new System.Drawing.Size(486, 13);
            labelQuestion.TabIndex = 2;
            labelQuestion.Text = "Do you want to automatically generate (directoryTree 🡢 filterTree) filters for:";
            // 
            // labelInfoProject2
            // 
            labelInfoProject2.AutoSize = true;
            labelInfoProject2.Location = new System.Drawing.Point(103, 31);
            labelInfoProject2.Name = "labelInfoProject2";
            labelInfoProject2.Size = new System.Drawing.Size(31, 13);
            labelInfoProject2.TabIndex = 2;
            labelInfoProject2.Text = "name";
            // 
            // labelQuestionMark
            // 
            labelQuestionMark.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelQuestionMark.Location = new System.Drawing.Point(6, 16);
            labelQuestionMark.Name = "labelQuestionMark";
            labelQuestionMark.Size = new System.Drawing.Size(39, 43);
            labelQuestionMark.TabIndex = 2;
            labelQuestionMark.Text = "?";
            // 
            // labelInfoProject
            // 
            labelInfoProject.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelInfoProject.Location = new System.Drawing.Point(24, 31);
            labelInfoProject.Name = "labelInfoProject";
            labelInfoProject.Size = new System.Drawing.Size(55, 13);
            labelInfoProject.TabIndex = 2;
            labelInfoProject.Text = "project:";
            labelInfoProject.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInfoCalculate2
            // 
            labelInfoCalculate2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelInfoCalculate2.Location = new System.Drawing.Point(121, 86);
            labelInfoCalculate2.Name = "labelInfoCalculate2";
            labelInfoCalculate2.Size = new System.Drawing.Size(55, 13);
            labelInfoCalculate2.TabIndex = 2;
            labelInfoCalculate2.Text = "rootDir:";
            labelInfoCalculate2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInfoOut2
            // 
            labelInfoOut2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelInfoOut2.Location = new System.Drawing.Point(103, 108);
            labelInfoOut2.Name = "labelInfoOut2";
            labelInfoOut2.Size = new System.Drawing.Size(73, 13);
            labelInfoOut2.TabIndex = 2;
            labelInfoOut2.Text = "rootFilter:";
            labelInfoOut2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInfoOut3
            // 
            labelInfoOut3.AutoSize = true;
            labelInfoOut3.Location = new System.Drawing.Point(200, 108);
            labelInfoOut3.Name = "labelInfoOut3";
            labelInfoOut3.Size = new System.Drawing.Size(31, 13);
            labelInfoOut3.TabIndex = 2;
            labelInfoOut3.Text = "name";
            // 
            // labelInfoCalculate3
            // 
            labelInfoCalculate3.AutoSize = true;
            labelInfoCalculate3.Location = new System.Drawing.Point(200, 86);
            labelInfoCalculate3.Name = "labelInfoCalculate3";
            labelInfoCalculate3.Size = new System.Drawing.Size(31, 13);
            labelInfoCalculate3.TabIndex = 2;
            labelInfoCalculate3.Text = "name";
            // 
            // labelWarning
            // 
            labelWarning.Location = new System.Drawing.Point(12, 165);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new System.Drawing.Size(73, 13);
            labelWarning.TabIndex = 2;
            labelWarning.Text = "Warning:   ";
            // 
            // groupBoxQuestion
            // 
            groupBoxQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBoxQuestion.Controls.Add(buttonAdvanced);
            groupBoxQuestion.Controls.Add(buttonYes);
            groupBoxQuestion.Controls.Add(labelQuestionMark);
            groupBoxQuestion.Location = new System.Drawing.Point(437, 114);
            groupBoxQuestion.Name = "groupBoxQuestion";
            groupBoxQuestion.Size = new System.Drawing.Size(154, 100);
            groupBoxQuestion.TabIndex = 3;
            groupBoxQuestion.TabStop = false;
            // 
            // labelWarning2
            // 
            labelWarning2.Location = new System.Drawing.Point(82, 165);
            labelWarning2.Name = "labelWarning2";
            labelWarning2.Size = new System.Drawing.Size(319, 13);
            labelWarning2.TabIndex = 4;
            labelWarning2.Text = "Please save the project before using this extension.";
            // 
            // labelWarning3
            // 
            labelWarning3.Location = new System.Drawing.Point(82, 182);
            labelWarning3.Name = "labelWarning3";
            labelWarning3.Size = new System.Drawing.Size(349, 13);
            labelWarning3.TabIndex = 5;
            labelWarning3.Text = "If results are not adequate, close project without saving";
            // 
            // labelInfoIn
            // 
            labelInfoIn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelInfoIn.Location = new System.Drawing.Point(54, 64);
            labelInfoIn.Name = "labelInfoIn";
            labelInfoIn.Size = new System.Drawing.Size(25, 13);
            labelInfoIn.TabIndex = 6;
            labelInfoIn.Text = "in:";
            labelInfoIn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInfoCalculate
            // 
            labelInfoCalculate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelInfoCalculate.Location = new System.Drawing.Point(12, 86);
            labelInfoCalculate.Name = "labelInfoCalculate";
            labelInfoCalculate.Size = new System.Drawing.Size(67, 13);
            labelInfoCalculate.TabIndex = 7;
            labelInfoCalculate.Text = "calculate:";
            labelInfoCalculate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInfoOut
            // 
            labelInfoOut.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelInfoOut.Location = new System.Drawing.Point(48, 108);
            labelInfoOut.Name = "labelInfoOut";
            labelInfoOut.Size = new System.Drawing.Size(31, 13);
            labelInfoOut.TabIndex = 8;
            labelInfoOut.Text = "out:";
            labelInfoOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInfoIn2
            // 
            labelInfoIn2.AutoSize = true;
            labelInfoIn2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelInfoIn2.Location = new System.Drawing.Point(200, 64);
            labelInfoIn2.Name = "labelInfoIn2";
            labelInfoIn2.Size = new System.Drawing.Size(97, 13);
            labelInfoIn2.TabIndex = 9;
            labelInfoIn2.Text = "project   whole";
            // 
            // labelWarning4
            // 
            labelWarning4.Location = new System.Drawing.Point(82, 199);
            labelWarning4.Name = "labelWarning4";
            labelWarning4.Size = new System.Drawing.Size(151, 13);
            labelWarning4.TabIndex = 10;
            labelWarning4.Text = "and open last save point";
            // 
            // formQuestion
            // 
            AcceptButton = buttonYes;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(599, 221);
            Controls.Add(labelWarning4);
            Controls.Add(labelInfoIn2);
            Controls.Add(labelInfoOut);
            Controls.Add(labelInfoCalculate);
            Controls.Add(labelInfoIn);
            Controls.Add(labelWarning3);
            Controls.Add(labelWarning2);
            Controls.Add(groupBoxQuestion);
            Controls.Add(labelWarning);
            Controls.Add(labelInfoCalculate3);
            Controls.Add(labelInfoOut3);
            Controls.Add(labelInfoOut2);
            Controls.Add(labelInfoCalculate2);
            Controls.Add(labelInfoProject);
            Controls.Add(labelInfoProject2);
            Controls.Add(labelQuestion);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formQuestion";
            MouseDown += fMouseDown;
            groupBoxQuestion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label labelQuestionMark;
        public System.Windows.Forms.Label labelQuestion;
        public System.Windows.Forms.Label labelInfoProject2;
        public System.Windows.Forms.Label labelInfoOut3;
        public System.Windows.Forms.Label labelInfoCalculate3;
        public System.Windows.Forms.Label labelWarning;
        public System.Windows.Forms.Label labelWarning2;
        public System.Windows.Forms.Label labelWarning3;
        public System.Windows.Forms.Label labelInfoIn2;
        public System.Windows.Forms.Label labelWarning4;
        public System.Windows.Forms.Button buttonAdvanced;
        public System.Windows.Forms.GroupBox groupBoxQuestion;
        public label2 labelInfoProject;
        public label2 labelInfoCalculate2;
        public label2 labelInfoOut2;
        public label2 labelInfoIn;
        public label2 labelInfoCalculate;
        public label2 labelInfoOut;
    }
}