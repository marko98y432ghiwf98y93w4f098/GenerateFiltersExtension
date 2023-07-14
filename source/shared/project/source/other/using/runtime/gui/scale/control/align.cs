using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace u.forms
{
    public static partial class S
    {





        public partial class control
        {
            public class position
            {
                public Control c;

                public class align
                {
                    public enum a { l, m, r };
                    public a x;
                    public a y;
                   







                    public Size size(Size x2)
                    {
                        Point x = new();
                        var x3 = x2.xMul(0.5);

                        x.X = this.x switch
                        {
                            align.a.m => x3.Width,
                            align.a.r => x2.Width,
                            _ => x.X,
                        };

                        x.Y = this.y switch
                        {
                            align.a.m => x3.Height,
                            align.a.r => x2.Height,
                            _ => x.Y,
                        };

                        return (Size)x;
                    }



                }
                public align a = new();




































                public Point l
                {
                    get => c.Location + a.size(c.Size);

                    set => c.Location = value - a.size(c.Size);
                }







                


                public Size s
                {
                    get => (c is Form c3) ? c3.Size : c.Size;

                    set
                    {
                        c.Location = this.l - a.size(value);


                        if (c is Form c2)
                            c2.Size = value;
                        else
                            c.Size = value;
                    }
                }



                
                
                
                



                public Size s2
                {
                    get => (c is Form c4) ? c4.ClientSize : c.ClientSize;

                    //set;
                }
            }
            public position a = new();
        }
    }
}