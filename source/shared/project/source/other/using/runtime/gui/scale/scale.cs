using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using u.api;

namespace u.forms
{
    public static partial class S
    {
        //private static S s;          //static
        //public static S s2 => s ??= new();

        //public S() { }
























        private static void f4(Control c, Action<Control> f)
        {
            IContainer f3(object x) => (IContainer)x.GetType().GetField("components", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(x);


            foreach (Control c2 in c.Controls)          //controls
                f(c2);

            {
                if (c is ContainerControl c2)          //components
                {
                    var x3 = f3(c2)?.Components;
                    if (x3 != null)
                        foreach (var x4 in x3)
                            if (x4 is Control x5)
                                f(x5);
                }
            }
        }









        public static void scale(Control x, value v = null, Point? p = null)
        {
            if ((v ??= value.x(x)) == null) return;
            //if (p != null) p = x.PointToScreen((Point)p);          //p.Value + (Size)x.Location;





            Dictionary<Control, control> x2 = new();
            {
                void f(Control c)
                {
                    x2.TryAdd(c, c.xControl());          //candidate

                    f4(c, f);
                    
                    //c.AutoSize = false;
                }
                f(x);
                //f(x);

                x2.xFor(x => x.Value.init2());
            }






            void f2(Control c)
            {
                {
                    if (!x2.TryGetValue(c, out var x3)) return;

                    c.SuspendLayout();
                    //w32.other.SendMessageW(c.Handle, w32.other.message.paintRedrawSet, 0, 0);
                    //if (c is form2 c3) c3.f.draw = false;

                    x3.x[2].x = x3.x[1].x.scale(c, v, x3.v, p);
                    x3.x[2].x.save(c.xControl());
                    x3.v = new(v.s2);
                }



                f4(c, f2);


                {
                    c.ResumeLayout(false);
                    //w32.other.SendMessageW(c.Handle, w32.other.message.paintRedrawSet, 1, 0);
                    //if (c is form2 c3) { c3.f.draw = true; c3.Invalidate(true); }
                }
            }
            f2(x);



            x.Invalidate(true);
        }






























        public static void scale2(Control x, Point? p = null)
        {
            var x2 = x.xControl();
            x2.x[1].xs = x2.x[0].xs;
            scale(x, null, p);
            //var x3 = x.Location;









            bool b = true;
            void f(Control x)
            {
                var x2 = x.xControl();

                var x3 = x2.x[1].x.x.x;
                x2.x[1] = x2.x[0];
                if (b) { x2.x[1].x.x.x = x3; b = false; }

                x2.v = null;

                f4(x, f);
            }
            f(x);
            scale(x);


            /*{
                var x4 = Screen.FromControl(x).Bounds;
                x3.X = Math.Min(x3.X, x4.Right - 100);
                x3.Y = Math.Min(x3.Y, x4.Bottom - 100);
                x3.X = Math.Max(x3.X, x4.X);
                x3.Y = Math.Max(x3.Y, x4.Y);

                x2.x[2].x.x.x = x3;
                x.Location = x3;
            }*/



            //x.Invalidate(true);
        }
    }
}











































































namespace u          //extensions
{
    public static partial class xCommon
    {
        //private static void f(Control x2) { if (x2 != null) u.forms.S.init(x2); }

        //public static int xScale(this int x, Control x2 = null) { f(x2); return u.forms.S.s2.v.i(x); }          //int
        //public static float xScale(this float x, Control x2 = null) { f(x2); return u.forms.S.s2.v.f(x); }          //float
        //public static double xScale(this double x, Control x2 = null) { f(x2); return u.forms.S.s2.v.d(x); }          //double




        //public static u.forms.S.font xScale(this u.forms.S.font x, Control x2 = null) { f(x2); return u.forms.S.s2.v.f(x); }          //font




        //public static Point xScale(this Point x, Control x2 = null) { f(x2); return u.forms.S.s2.v.f(x); }          //point
        //public static Size xScale(this Size x, Control x2 = null) { f(x2); return u.forms.S.s2.v.f(x); }          //size
        //public static Padding xScale(this Padding x, Control x2 = null) { f(x2); return u.forms.S.s2.v.f(x); }          //padding







        public static void xScale(this Control x, Control x2 = null, Point? p = null) { /*f(x2);*/ u.forms.S.scale(x, u.forms.S.value.x(x2), p); }        //control
        public static void xScale2(this Control x, Point? p = null) { u.forms.S.scale2(x, p); }
        //public static double xDpiG(this Control x, Control x2 = null) { f(x2); return u.forms.dpi.f.g(x); }
        //public static double xDpiD(this Control x, Control x2 = null) { f(x2); return u.forms.dpi.f.d(x); }










        public static u.forms.S.control xControl(this Control x) => u.forms.S.control.c(x);
    }
}