using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace u.forms.scale
{
    public static partial class s
    {
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
                                if (!(x5 is ContextMenuStrip))
                                    f(x5);
                }
            }
        }











































        public static bool scale(Control x, value v = null, Point? p = null)
        {
            bool b = true;
            if ((v ??= value.x(x)) == null) return false;





            Dictionary<Control, control.control> x2 = new();
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





            {
                void f1(Control c)
                {
                    if (!x2.TryGetValue(c, out var x3)) return;

                    x3.s.x[3] = x3.s.x[1];
                    x3.s.x[4] = x3.s.x[2];
                    x3.s.v[1] = x3.s.v[0];

                    f4(c, f1);
                }
                f1(x);
            }








            void f2(Control c)
            {
                {
                    if (!x2.TryGetValue(c, out var x3)) return;

                    c.SuspendLayout();
                    //w32.other.SendMessageW(c.Handle, w32.other.message.paintRedrawSet, 0, 0);
                    //if (c is form2 c3) c3.f.draw = false;

                    x3.s.x[2] = x3.s.x[1].scale(c, v, x3.s.v[0], p);
                    x3.s.x[2].save(x3);
                    x3.s.v[0] = v.clone();

                    if (c is Form c2)
                        if (c2.ClientSize != x3.s.x[2].x.x2.s2) throw new();
                }



                f4(c, f2);


                {
                    c.ResumeLayout(false);
                    //w32.other.SendMessageW(c.Handle, w32.other.message.paintRedrawSet, 1, 0);
                    //if (c is form2 c3) { c3.f.draw = true; c3.Invalidate(true); }
                }
            }





            try
            {
                f2(x);
            }
            catch (Exception)
            {
                b = false;

                void f3(Control c)
                {
                    if (!x2.TryGetValue(c, out var x3)) return;

                    c.SuspendLayout();

                    x3.s.x[1] = x3.s.x[3];
                    x3.s.x[2] = x3.s.x[4];
                    x3.s.v[0] = x3.s.v[1];

                    x3.s.x[2].save(x3);


                    f4(c, f3);


                    c.ResumeLayout(false);
                }
                f3(x);
            }


            x.Invalidate(true);
            return b;
        }












































        public static void scale2(Control x, Point? p = null)
        {
            var x2 = x.xControl();
            x2.s.xs[1] = x2.s.xs[0];
            scale(x, null, p);
            



            /*if (x2.s.x[2].x.x != x.Location)
            {

            }*/


            


            bool b = true;
            void f(Control x)
            {
                var x2 = x.xControl();

                var x3 = x.Location;          //x2.s.x[2].x.x
                x2.s.x[1] = x2.s.x[0];
                if (b) { x2.s.x[1].x.x = x3; b = false; }

                x2.s.v[0] = null;

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
















































        public static void scale3(Control x)
        {
            void f(Control x)
            {
                u.forms.scale.control.control.c2(x);
                f4(x, f);
            }
            f(x);
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







        public static bool xScale(this Control x, Control x2 = null, Point? p = null) { /*f(x2);*/ return u.forms.scale.s.scale(x, u.forms.scale.s.value.x(x2), p); }        //control
        public static void xScale2(this Control x, Point? p = null) { u.forms.scale.s.scale2(x, p); }
        //public static double xDpiG(this Control x, Control x2 = null) { f(x2); return u.forms.dpi.f.g(x); }
        //public static double xDpiD(this Control x, Control x2 = null) { f(x2); return u.forms.dpi.f.d(x); }










        public static u.forms.scale.control.control xControl(this Control x) => u.forms.scale.control.control.c(x);
    }
}