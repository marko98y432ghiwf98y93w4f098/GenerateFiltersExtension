namespace extension
{
    partial class formError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formError));
            textBox = new u.forms.control.textBox2();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = System.Drawing.SystemColors.Window;
            textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox.Location = new System.Drawing.Point(0, 0);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox.Size = new System.Drawing.Size(800, 450);
            textBox.TabIndex = 0;
            textBox.TabStop = false;
            textBox.WordWrap = false;
            textBox.MouseDown += fMouseDown;
            // 
            // formError
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBox);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Consolas", 8.25F);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(200, 100);
            Name = "formError";
            Text = "error";
            MouseDown += fMouseDown;
            ResumeLayout(false);
        }

        #endregion

        public u.forms.control.textBox2 textBox;
    }
}