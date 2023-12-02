using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using u.api;
using font = u.forms.scale.control.font;

namespace u.forms.scale
{
    public static partial class s
    {
        






        public class data          //data
        {
            private static double x0;
            public static double d0;


            public static void init(double x, double d = 96.0) { x0 = x; d0 = d; }
            static data() => init(1080);








            public double x = 1;          //Screen.PrimaryScreen.Bounds.Height          //System.Windows.SystemParameters.PrimaryScreenWidth          -          scaled, by once per run
            public dpi.dpi2 d = dpi.d2();


            public bool init(Control c)
            {
                if (c == null) return true;
                var c2 = c.xControl();

                x = c2.s.xs[1] * (double)Screen.PrimaryScreen.Bounds.Height / x0;
                d = dpi.d2(c);

                return false;
                //return x == 1.0 && d0 == d.r.d.d1;
            }
        }
        















































































        public class value
        {
            bool xc => s2.x1 == 1;
            public int f(int x) => xc ? x : (int)Math.Round(x * s2.x1);
            public float f(float x) => xc ? x : (float)(x * s2.x1);
            public double f(double x) => xc ? x : (double)(x * s2.x1);

            public Point f(Point x) => xc ? x : new(f(x.X), f(x.Y));
            public Size f(Size x) => xc ? x : new(f(x.Width), f(x.Height));
            public Padding f(Padding x) => xc ? x : new(f(x.Left), f(x.Top), f(x.Right), f(x.Bottom));

            //public T i<T>(T x) where T : struct => xc ? x : (T)((double)x * this.x);














            private class f2
            {
                public HashSet<Font> x2 = new();
                public static int st1 = 0;
                public static int st2 = 1000;
                public void v(int v)
                {
                    st1 = Math.Max(st1, v);
                    st2 = Math.Min(st2, v);
                }
            }
            private f2 f3 = new();

            public font f(font x, Control c)
            {
                font x3 = new(x.x);
                if (s2.x2 == 1 || f3.x2.Contains(x.x)) return x3;



                using var g = c.CreateGraphics();
                string st = c.Text.xE() ? "abcdef 12345".ToUpper() : c.Text;
                int st1 = 0;
                
                SizeF measure(Font f) => TextRenderer.MeasureText(g, st, f, new(), TextFormatFlags.SingleLine | TextFormatFlags.NoClipping /*| TextFormatFlags.NoPadding*/ | TextFormatFlags.NoPrefix | TextFormatFlags.PreserveGraphicsTranslateTransform);
                





                {
                    x3.x3 = /*Math.Floor(*/x.x3 * s2.x2/*)*/;
                    x3.toFont();
                    var s = f(measure(x.x).xSize());

                    while (s.xComS(measure(x3.x).xSize()) && st1 < 1000)
                    {
                        x3.x3 *= 1 / 1.01;          //1.01;
                        x3.toFont();
                        st1++;
                    }
                }


                f3.v(st1);
                f3.x2.Add(x3.x);

                return x3;
            }




















            















            public (double x1, double x2) s2 = (1, 1);



            /*
            public void init()
            {
                x3 = new();
            }
            */

            private value() { }
            public value((double x1, double x2) s) => s2 = s;
            public value clone() => new(s2);
            public value rec() => new((1 / s2.x1, 1 / s2.x2));



            public static value x(Control x)
            {
                data d = new();
                if (d.init(x)) return null;          //padding,   margin,   autoSize,   autoScale,   anchor,   (dock)




                value v = new();          //init
                {
                    (double, double) f()
                    {
                        //x1, x1/x2   .net za sve izgleda

                        double x1 = d.x;
                        var a = d.d.r.a;
                        if (a == w32.dpi.t.dpiAwarenessContext.not || a == w32.dpi.t.dpiAwarenessContext.notGdiScaled) return (x1, x1);


                        double x2 = d.d.r.d.d1 / data.d0;
                        double x3 = x1 / x2;
                        if (a == w32.dpi.t.dpiAwarenessContext.system) return (x1, x3);
                        if (a == w32.dpi.t.dpiAwarenessContext.monitor || a == w32.dpi.t.dpiAwarenessContext.monitor2) return (x1, x3);
                        return (x3, x3);
                    }
                    v.s2 = f();
                }
                {
                    //using var g = x.CreateGraphics();
                    //var g1 = g.DpiX;
                    //var g2 = g.DpiY;
                    //var g3 = g.GetDpiContext();
                }
                return v;
            }
        }
    }
}