using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using u.api;

namespace u.forms.scale.control
{
    
        



        public class font
        {
            public FontFamily x2;
            public double x3;
            public FontStyle x4;
            public GraphicsUnit x5;
            public byte x6;          //gdiCharSet
            public bool x7;          //gdiVerticalFont

            public Font x;



            public void load(Font x)
            {
                this.x = x;
                x2 = x.FontFamily;
                x3 = x.Size;
                x4 = x.Style;
                x5 = x.Unit;
                x6 = x.GdiCharSet;
                x7 = x.GdiVerticalFont;
            }

            public Font toFont() => x = new Font(x2, (float)x3, x4, x5, x6, x7);

            public bool compare(Font x2)
            {
                bool b = x.FontFamily.Name == x2.FontFamily.Name && x.Size == x2.Size && x.Style == x2.Style && x.Unit == x2.Unit && x.GdiCharSet == x2.GdiCharSet && x.GdiVerticalFont == x2.GdiVerticalFont;
                bool b1 = x.FontFamily == x2.FontFamily;
                bool b2 = x.Size == x2.Size && x.Style == x2.Style && x.Unit == x2.Unit && x.GdiCharSet == x2.GdiCharSet && x.GdiVerticalFont == x2.GdiVerticalFont;

                /*if (!b)
                {
                    int x234 = 10;
                }*/
                return b;
            }




            public font() { }
            public font(Font x) => load(x);
        }













        
    
}