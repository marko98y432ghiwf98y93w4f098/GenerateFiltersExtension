using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using u.other;






namespace u.forms.form
{
    public class form2 : Form
    {
        [DllImport("user32.dll", EntryPoint = "MoveWindow")] private static extern bool MoveWindow(nint id, int x, int y, int x2, int y2, bool repaint);
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)          //clientSize,   formBorderStyle,   scaleControl,   size,   showDialog
        {
            base.SetBoundsCore(x, y, width, height, specified);
            if (this.Width != width || this.Height != height)
                MoveWindow(this.Handle, x, y, width, height, true);

            /*Size s1 = this.Size;
            Size s2 = this.ClientSize;

            SizeF s3 = this.AutoScaleDimensions;
            SizeF s4 = this.CurrentAutoScaleDimensions;
            var s5 = this.AutoScaleBaseSize;
            SizeF s6 = this.AutoScaleFactor;
            var s7 = this.AutoScaleMode;

            int s8 = this.DeviceDpi;*/

            //SystemInformation.dpi
            //var s9 = Application.HighDpiMode;
        }






















        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)          //scale,          //resumeLayout
        {
            base.ScaleControl(factor, specified);
        }

        protected override void ScaleCore(float x, float y)
        {
            base.ScaleCore(x, y);
        }

        /*protected override void ScaleMinMaxSize(float xScaleFactor, float yScaleFactor, bool updateContainerSize = true)
        {
            base.ScaleMinMaxSize(xScaleFactor, yScaleFactor, updateContainerSize);
        }*/

        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)          //getScaledBounds          //scaleControl
        {
            return base.GetScaledBounds(bounds, factor, specified);
        }

























        protected override void OnDpiChanged(DpiChangedEventArgs e)          //dpi
        {
            base.OnDpiChanged(e);
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
        }

        protected override void OnDpiChangedBeforeParent(EventArgs e)
        {
            base.OnDpiChangedBeforeParent(e);
        }

        protected override bool OnGetDpiScaledSize(int deviceDpiOld, int deviceDpiNew, ref Size desiredSize)
        {
            return base.OnGetDpiScaledSize(deviceDpiOld, deviceDpiNew, ref desiredSize);
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
        }
















        public form2()
        {
            Size x = new(7000, 7000);
            this.MaximumSize = x;
        }
    }
}


















































































































namespace u.forms.label
{
    public class labelAlign : Label          //label
    {
        public labelAlign()
        {
            base.AutoSize = false;
            this.SetStyle(/*ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque |*/ ControlStyles.OptimizedDoubleBuffer /*| ControlStyles.UserPaint*/, true);
        }



        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }










        private class Data
        {
            public string text;
            public bool text2;
        }
        private Data d = new();






        public override ContentAlignment TextAlign
        {
            get => base.TextAlign;

            set
            {
                base.TextAlign = value;

                if (d == null) return;
                if (d.text2) { var d2 = d.text; d = null; base.Text = d2; }
                d = null;
            }
        }






        bool textIn;
        public override string Text
        {
            get => (d?.text2).x() ? d.text : base.Text;

            set
            {
                if (d != null)
                {
                    d.text = value;
                    d.text2 = true;
                    return;
                }


                base.Text = value;

                if (textIn) return;
                textIn = true;
                this.xText();
                textIn = false;
            }
        }
    }
}
















































namespace u.forms
{
    public static partial class xCommon
    {
        public static void xText(this Label x, string x2 = null)          //label
        {
            if (x == null) return;

            x.Text = x2 ??= x.Text;





            //using StringFormat s = u.forms.other.stringFormat.x2;
            using var g = x.CreateGraphics();
            //g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            //SizeF x3 = (x2 != null) ? g.MeasureString(x2 + 'x', x.Font, 0, s) : new();


            SizeF x3 = (x2 != null) ? TextRenderer.MeasureText(g, x2 /*+ 'x'*/, x.Font, new(), TextFormatFlags.SingleLine | TextFormatFlags.NoClipping /*| TextFormatFlags.NoPadding*/ | TextFormatFlags.NoPrefix | TextFormatFlags.PreserveGraphicsTranslateTransform) : new();




            //if (x3.Height != 0) x3.Height += 5;
            //x3 = x3.xDiv(new(96.0f / g.DpiX, 96.0f / g.DpiY));
            Size x4 = x3.xSize() - x.Size;
            Size x5 = x4.xMul(0.5);



            if ((x.TextAlign & (ContentAlignment.BottomCenter | ContentAlignment.MiddleCenter | ContentAlignment.TopCenter)) != 0)          //x
                x.Left -= x5.Width;

            if ((x.TextAlign & (ContentAlignment.BottomRight | ContentAlignment.MiddleRight | ContentAlignment.TopRight)) != 0)
                x.Left -= x4.Width;

            if ((x.TextAlign & (ContentAlignment.MiddleLeft | ContentAlignment.MiddleCenter | ContentAlignment.MiddleRight)) != 0)          //y
                x.Top -= x5.Height;

            if ((x.TextAlign & (ContentAlignment.BottomLeft | ContentAlignment.BottomCenter | ContentAlignment.BottomRight)) != 0)
                x.Top -= x4.Height;

            x.Size = x3.xSize();

            //x.BackColor = System.Drawing.Color.BlueViolet;
        }
    }
}



















































































































namespace u.forms.table
{
    public class dataGridView2 : DataGridView          //dataGridView
    {
        public dataGridView2() => this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
    }
}













namespace u.forms.textBox
{
    public class textBox2 : TextBox          //textBox
    {
        public textBox2()
        {
            this.SetStyle(/*ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque |*/ ControlStyles.OptimizedDoubleBuffer /*| ControlStyles.UserPaint*/, true);
            this.AutoSize = false;
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }
    }
}











































































































namespace u.forms.other
{
    public class stringFormat
    {
        public static StringFormat x
        {
            get
            {
                StringFormat s = StringFormat.GenericTypographic;
                s.Trimming = StringTrimming.Character;
                s.FormatFlags &= ~(StringFormatFlags.FitBlackBox | StringFormatFlags.LineLimit | StringFormatFlags.NoClip);
                s.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
                return s;
            }
        }

        public static StringFormat x2
        {
            get
            {
                StringFormat s = StringFormat.GenericDefault;
                s.Trimming = StringTrimming.Character;
                s.FormatFlags &= ~(StringFormatFlags.FitBlackBox | StringFormatFlags.LineLimit | StringFormatFlags.NoClip);
                s.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
                return s;
            }
        }
    }



















    public class p          //common
    {
        public static Font font9b = new Font("Consolas", 9.0f, FontStyle.Bold, GraphicsUnit.Point);
        public static Font font9 = new Font("Consolas", 9.0f, FontStyle.Regular, GraphicsUnit.Point);

        public static Font font8b = new Font("Consolas", 8.0f, FontStyle.Bold, GraphicsUnit.Point);
        public static Font font8 = new Font("Consolas", 8.0f, FontStyle.Regular, GraphicsUnit.Point);

        public static Font font7b = new Font("Consolas", 7.0f, FontStyle.Bold, GraphicsUnit.Point);
        public static Font font7 = new Font("Consolas", 7.0f, FontStyle.Regular, GraphicsUnit.Point);
    }
}








































































































namespace u.forms
{
    public class S
    {
        private static S s;          //static
        public static S s2 => s ??= new();
















        public class data          //data
        {
            public double x0;
            public double x = 1;          //Screen.PrimaryScreen.Bounds.Height          //System.Windows.SystemParameters.PrimaryScreenWidth          -          scaled, by onece per run
            public double xDpiD0;
            //public double xDpiD;
            public void xInit(double x, double xDpiD = 96.0) { x0 = x; this.xDpiD0 = xDpiD; }
            public bool xCheck => xCheck2 && xDpiD0 == (/*xDpiD =*/ dpiD());
            public bool xCheck2 => (x = ((double)Screen.PrimaryScreen.Bounds.Height) / x0) == 1.0;




            //public Dictionary<double, HashSet<Font>> x2 = new();
            public HashSet<Font> x2 = new();





            //int        cu\control panel\desktop\logPixels
            //int        cu\control panel\desktop\win8DpiScaling          [0, 1]          p2
            //int        cu\control panel\desktop\windowMetrics\appliedDpi          -          win10,   (sign)
            //string     cu\software\microsoft\windows\currentVersion\themeManager\lastLoadedDpi   (sign)
            public double dpiC
            {
                get
                {
                    var r = Registry.CurrentUser;

                    object f(string x, string x2, Type x3)
                    {
                        var r2 = r.OpenSubKey(x);
                        object v = r2?.GetValue(x2);
                        if (v == null) return v;
                        if (v.GetType() != x3) return null;
                        return v;
                    }

                    object v = f("control panel\\desktop\\windowMetrics", "appliedDpi", typeof(int));
                    if (v != null) return (int)v;

                    if (int.TryParse((string)f("software\\microsoft\\windows\\currentVersion\\themeManager", "lastLoadedDpi", typeof(string)), out int v2))
                        return v2;

                    v = f("control panel\\desktop", "logPixels", typeof(int));
                    if (v != null) return (int)v;

                    return 96.0;
                }
            }

            public double dpiG(Control x = null)
            {
                x ??= new();
                using var g = x.CreateGraphics();
                return g.DpiY;
            }

            public double dpiD(Control x = null) => (x ?? new()).DeviceDpi;
        }
        public data d = new();


























        public class value
        {
            public S s;



            //public T i<T>(T x) where T : struct => check ? x : (T)((double)x * this.x);

            public int i(int x) => s.d.xCheck ? x : (int)Math.Round(x * s.d.x);
            public float f(float x) => s.d.xCheck ? x : (float)(x * s.d.x);
            public double d(double x) => s.d.xCheck ? x : (double)(x * s.d.x);




            public Font f(Font x, double dpiG = 96.0)
            {
                if (s.d.xCheck) return x;

                double x0 = s.d.x;
                //if (!s.d.x2.TryGetValue(x0, out HashSet<Font> x3))
                //s.d.x2.Add(x0, x3 = new());
                var x3 = s.d.x2;


                Font f2()
                {
                    Font x2 = new Font(x.FontFamily, (float)Math.Floor((double)x.Size * x0 * 96.0 / dpiG), x.Style, x.Unit, x.GdiCharSet, x.GdiVerticalFont);
                    x3.Add(x2);
                    return x2;
                }

                return x3.Contains(x) ? x : f2();
            }




            public Point f(Point x) => s.d.xCheck ? x : new(x.X.xScale(), x.Y.xScale());
            public Size f(Size x) => s.d.xCheck ? x : new(x.Width.xScale(), x.Height.xScale());
            public Padding f(Padding x) => s.d.xCheck ? x : new(x.Left.xScale(), x.Top.xScale(), x.Right.xScale(), x.Bottom.xScale());
        }
        public value v = new();

        public S() => v.s = this;










































        public void scale(Control x)
        {
            if (d.xCheck) return;          //padding,   margin,   autoSize,   autoScale,   anchor,   (dock)


            d.x2 = new();          //init
            {
                //using var g = x.CreateGraphics();
                //var g1 = g.DpiX;
                //var g2 = g.DpiY;
                //var g3 = g.GetDpiContext();
            }




            IContainer f3(object x) => (IContainer)x.GetType().GetField("components", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.NonPublic).GetValue(x);

            Dictionary<Control, (Point x, Size s, Size s2, Size sMin, Size sMax, Padding sPadding, Padding sMargin)> x2 = new();
            void f(Control c)
            {
                x2.TryAdd(c, (c.Location, (c is Form c3) ? c3.Size : c.Size, (c is Form c4) ? c4.ClientSize : c.ClientSize, c.MinimumSize, c.MaximumSize, c.Padding, c.Margin));

                foreach (Control c2 in c.Controls)
                    f(c2);

                {
                    if (c is Form c2)
                    {
                        var x3 = f3(c2)?.Components;
                        if (x3 != null)
                            foreach (var x4 in x3)
                                if (x4 is Control x5)
                                    f(x5);
                    }
                }

                //c.AutoSize = false;
            }
            f(x);
            //f(x);







            void f2(Control c)
            {
                {
                    if (!x2.TryGetValue(c, out var x3)) return;

                    /*{
                        var dpiC = d.dpiC;
                        var dpiG = c.xDpiG();
                        var dpiD = c.xDpiD();
                    }*/

                    c.SuspendLayout();





                    var a = c.Anchor;
                    c.Anchor = AnchorStyles.Top | AnchorStyles.Left;


                    var a2 = c.AutoSize;
                    c.AutoSize = false;          //form,   label,   textBox
                    //ContentAlignment a3 = 0;
                    //if (c is Label cl) { a3 = cl.TextAlign; cl.TextAlign = ContentAlignment.TopLeft; }
                    if (c is Form c3) c3.AutoScaleMode = AutoScaleMode.None;
                    //if (d.xCheck2) goto exit2;





                    {
                        Size s2 = x3.s - x3.s2;
                        //Size s2x = s2.xMul(d.dpiC / 96.0);          //size
                        Size f3(Size s)
                        {
                            Size s3 = (s - s2).xScale() + s2;
                            if (s.Width == 0 || s3.Width < 0) s3.Width = 0;
                            if (s.Height == 0 || s3.Height < 0) s3.Height = 0;
                            return s3;
                        }


                        c.MaximumSize = f3(x3.sMax);
                        c.MinimumSize = f3(x3.sMin);

                        c.Padding = x3.sPadding.xScale();
                        c.Margin = x3.sMargin.xScale();


                        c.Location = x3.x.xScale();

                        if (c is Form c2)
                        {
                            //c2.ClientSize = x3.s2.xScale();
                            c2.Size = f3(x3.s);
                        }
                        else
                            c.Size = x3.s.xScale();
                    }


                    //exit2:
                    c.Font = c.Font.xScale(c.xDpiG());
                    if (c is Label cl2) { /*cl2.TextAlign = a3;*/ cl2.xText(); }

                    c.Anchor = a;
                    c.AutoSize = a2;
                }








                if (c is SplitContainer)          //splitContainer.distance
                {
                    SplitContainer x2 = (SplitContainer)c;
                    bool f2()
                    {
                        foreach (Control x3 in x2.Panel1.Controls)
                            if (x3.Dock == DockStyle.Fill) return false;
                        return true;
                    }
                    if (f2())
                        x2.SplitterDistance = x2.SplitterDistance.xScale();
                }








                //if (c is RadioButton) goto exit;
                //if (c is CheckBox) goto exit;


                foreach (Control c2 in c.Controls)          //controls
                    f2(c2);

                {
                    if (c is Form c2)          //components
                    {
                        var x3 = f3(c2)?.Components;
                        if (x3 != null)
                            foreach (var x4 in x3)
                                if (x4 is Control x5)
                                    f2(x5);
                    }
                }


                //exit:
                c.ResumeLayout(false);
            }

            f2(x);
            x.Invalidate(true);
        }








        /*public interface iScale
        {
            public IContainer container => (IContainer)this.GetType().GetField("components", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.NonPublic).GetValue(this);
        }*/
    }
}


































































namespace u          //extensions
{
    public static partial class xCommon
    {
        public static int xScale(this int x) => u.forms.S.s2.v.i(x);          //int
        public static float xScale(this float x) => u.forms.S.s2.v.f(x);          //float
        public static double xScale(this double x) => u.forms.S.s2.v.d(x);          //double


        public static Font xScale(this Font x, double x2 = 96.0) => u.forms.S.s2.v.f(x, x2);          //font


        public static Point xScale(this Point x) => u.forms.S.s2.v.f(x);          //point
        public static Size xScale(this Size x) => u.forms.S.s2.v.f(x);          //size
        public static Padding xScale(this Padding x) => u.forms.S.s2.v.f(x);          //padding


        public static void xScale(this Control x) => u.forms.S.s2.scale(x);          //control
        public static double xDpiG(this Control x) => u.forms.S.s2.d.dpiG(x);
        public static double xDpiD(this Control x) => u.forms.S.s2.d.dpiD(x);
    }
}



































































































namespace u
{
    public static partial class xCommon
    {
        public static bool xE(this string s) => string.IsNullOrEmpty(s);          //string
        public static bool xE2(this string x) => string.IsNullOrWhiteSpace(x);

        public static string xE(this string s, string s2) => string.IsNullOrEmpty(s) ? "" : s + s2;


        public static bool xC(this string x, string x2) => string.Equals(x, x2, StringComparison.Ordinal);
        public static bool xC2(this string x, string x2) => string.Equals(x, x2, StringComparison.OrdinalIgnoreCase);
















        public static string xS(this bool x) => x ? "true" : "false";          //bool
        public static string xS2(this bool x) => x ? "true" : "";




        public static bool x(this bool? x2) => x2 != null && x2 == true;          //bool?











        public static bool xEmpty(this Array x) => x == null || x.Length == 0;          //array










        public static void xFor<T>(this IEnumerable<T> x, Action<T> x2) { foreach (T x3 in x) x2(x3); }          //collection














        public static string xS(this Enum x) => x.ToString();          //enum




        /*public static void set<T>(this ref T x, T x2, bool b) where T : struct          //p   ne menja valueType
        {
            try
            {
                Type t = x.GetType();
                TypeCode t2 = Type.GetTypeCode(Enum.GetUnderlyingType(t));
                dynamic y = Convert.ChangeType(x, t2);
                dynamic y2 = Convert.ChangeType(x2, t2);
                if (b)
                    y |= y2;
                else
                    y &= ~y2;
                x = (T)y;
            }
            catch(Exception e)
            {

            }
        }*/

        /*public static bool get(this Enum x, Enum x2)
        {
            try
            {
                TypeCode t = Type.GetTypeCode(Enum.GetUnderlyingType(x.GetType()));          //popraviti   da li dynamic usporava
                dynamic y = Convert.ChangeType(x, t);
                dynamic y2 = Convert.ChangeType(x2, t);
                if (y2 == 0) return y == y2;
                return (y & y2) == y2;
            }
            catch (Exception e)
            {
                return true;
            }
        }*/























        public static Size xMul(this Size x, double x2)          //size
        {
            x.Width = (int)(x.Width * x2);
            x.Height = (int)(x.Height * x2);
            return x;
        }







        public static Size xSize(this SizeF x)          //sizeF
        {
            Size x2 = new();
            x2.Width = (int)Math.Ceiling(x.Width);
            x2.Height = (int)Math.Ceiling(x.Height);
            return x2;
        }

        public static SizeF xDiv(this SizeF x, SizeF x2)
        {
            x.Width /= x2.Width;
            x.Height /= x2.Height;
            return x;
        }
    }
}




















































































namespace u
{
    public static partial class xCommon
    {


        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
                return true;
            }

            return false;
        }


    }
}







































































namespace u.other
{


    public class path
    {
        public string x;
        public string[] x2;



        public class separator
        {
            public char[] s = ss;
            public char s2 = ss2;

            public static char[] ss = new char[] { System.IO.Path.DirectorySeparatorChar, System.IO.Path.AltDirectorySeparatorChar };
            public static char ss2 = System.IO.Path.DirectorySeparatorChar;
            public static separator sDefault = new() { s = new char[] { '\\', '/' }, s2 = '\\' };
        }
        public separator s = new();












        public path(string x = null, separator s = null)
        {
            this.s = s ?? new();
            if (x != null) init(x);
        }

        public path(string[] x2, separator s = null)
        {
            this.s = s ?? new();
            this.x2 = x2;
            if (x2 != null) xJoin();
        }


        private path init(string x)
        {
            x2 = new string[0];
            if (x != null)
                x2 = x.Split(s.s, StringSplitOptions.RemoveEmptyEntries).Select(x3 => x3.Trim()).Where(x3 => !x3.xE2()).ToArray();
            xJoin();

            return this;
        }
















        public string xJoin() => x = string.Join(s.s2.ToString(), x2);















        public string sLast { get => x2.xEmpty() ? null : x2[x2.Length - 1]; }
        public int count { get => x2.xEmpty() ? 0 : x2.Length; }














        public static path operator +(path x1, path x2) => path.oPlus(x1, x2);
        public static path operator +(path x1, string x2) => path.oPlus(x1, x2);
        public static path operator -(path x1, path x2) => path.oMinus(x1, x2);
        public static path operator *(path x1, path x2) => path.oCommon(x1, x2);
        /*public static bool operator ==(path x1, path x2) => path.oEqual(x1, x2);
        public static bool operator !=(path x1, path x2) => !path.oEqual(x1, x2);*/


        public static path oPlus(path x1, path x2, separator s = null)
        {
            if (x1.xNull()) return null;
            if (x2.xNull()) return null;
            if (s == null) s = new separator();

            return new path(x1.x2.Concat(x2.x2).ToArray(), s);
        }

        public static path oPlus(path x1, string x2, separator s = null)
        {
            if (x1.xNull()) return null;
            if (x2.xE2()) return new path(x1.x2, x1.s);          //clone
            if (s == null) s = new separator();

            return new path(x1.x2.Append(x2).ToArray(), s);
        }



        public static path oMinus(path x1, path x2, separator s = null)
        {
            if (x1.xNull()) return null;
            if (x2.xNull()) return null;
            if (s == null) s = new separator();

            if (!(x1.x2.Length >= x2.x2.Length)) return null;

            for (int i = 0; i < x2.x2.Length; i++)
                if (string.Compare(x1.x2[i], x2.x2[i], StringComparison.OrdinalIgnoreCase) != 0) return null;

            return new path(x1.x2.Skip(x2.x2.Length).ToArray(), s);
        }






        public static path oCommon(path x1, path x2, separator s = null)          //common
        {
            if (x1.xNull()) return null;          //check
            if (x2.xNull()) return null;
            //s ??= new();
            if (s == null) s = new();



            int i = 0;
            {
                int i1 = Math.Min(x1.x2.Length, x2.x2.Length);
                for (; i < i1; i++)
                    if (String.Compare(x1.x2[i], x2.x2[i], StringComparison.OrdinalIgnoreCase) != 0) break;
            }

            return new path(x1.x2.Take(i).ToArray(), s);
        }




        public static path oCommon(string[] p, separator s = null)
        {
            if (p.xEmpty()) return null;          //check
            if (s == null) s = new();



            path x = null;
            foreach (string p2 in p)
            {
                if (x == null)
                {
                    x = (new path(p2, s)).mUp();
                    continue;
                }
                x = oCommon(x, new path(p2, s).mUp(), s);
                if (x == null) break;
                if (x.x2.Length == 0) break;
            }

            return x;
        }





        public static bool oEqual(path x1, path x2)
        {
            bool b1 = !x1.xNull();
            bool b2 = !x2.xNull();
            if (!(b1 || b2)) return true;
            if (b1 ^ b2) return false;
            return x1.x.xC2(x2.x);
        }






        public path mUp()
        {
            if (x2.xEmpty()) return null;
            int i = x2.Length - 1;
            if (i < 0) return null;
            return new path(x2.Take(i).ToArray(), s);
        }

















        public override int GetHashCode() => x?.ToLower().GetHashCode() ?? 0;          //interface

        public override bool Equals(object x) => x != null && x is path x2 && path.oEqual(this, x2);

        public override string ToString() => x;
    }
}




















namespace u
{
    public static class xPath
    {
        public static bool xNull(this path x) => x == null || x.x2 == null || x.x == null;          //extension

        public static bool xFull(this path x) => !x?.x2.xEmpty() ?? false;
    }
}