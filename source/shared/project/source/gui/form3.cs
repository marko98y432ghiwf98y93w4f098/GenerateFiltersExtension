using System.Windows.Forms;
using u;
using u.forms.control.form;







public class form3 : form2
{
    protected void init()
    {
        this.MouseWheel += fMouseWheel;
        this.xScale();
    }



    protected void fMouseWheel(object sender, MouseEventArgs e)
    {
        double x2 = 1.01;
        double x21 = 1 / 1.01;

        var x3 = System.Windows.Forms.Control.ModifierKeys;
        if (x3.HasFlag(Keys.Control))
        {
            x2 = 1.05;
            x21 = 1 / (1.05);
        }


        var xs = this.xControl().s.xs[1];
        if (e.Delta > 0)
            this.xControl().s.xs[1] *= x2;
        else
            this.xControl().s.xs[1] *= x21;
        if (!this.xScale(null, System.Windows.Forms.Cursor.Position)) this.xControl().s.xs[1] = xs;
    }

    protected void fMouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Middle) this.xScale2(System.Windows.Forms.Cursor.Position);
    }
}