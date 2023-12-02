using System.Windows.Forms;





namespace u.forms.control
{
    public class textBox2 : TextBox          //textBox
    {
        public textBox2()
        {
            this.SetStyle(/*ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque |*/ ControlStyles.OptimizedDoubleBuffer /*| ControlStyles.UserPaint*/, true);
            this.DoubleBuffered = true;
            this.AutoSize = false;
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }
    }
}