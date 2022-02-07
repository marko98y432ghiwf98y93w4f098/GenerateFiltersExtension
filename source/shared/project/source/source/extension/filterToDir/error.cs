using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualStudioCppExtensions
{
    namespace filterToDir
    {



        public class error
        {
            public enum Type { move, delete, dirName, sameFile, sameFilter };



            public class data
            {
                public Type t;
                public string[] s;
                public Exception e;
            }
            public List<data> x = new List<data>();
            public void add(data d) => this.x.Add(d);
            public bool full => x.Count > 0;




            public override string ToString()
            {
                StringBuilder s = new StringBuilder();

                for (int i = 0; i < x.Count; i++)
                {
                    data x2 = x[i];
                    string s2 = "[" + (i + 1) + ".]\r\n";
                    switch (x2.t)
                    {
                        case Type.move:
                            s2 += "\r\ncan not move file:";
                            s2 += "\r\n" + x2.s[0];
                            s2 += "\r\n" + x2.s[1];
                            break;

                        case Type.delete:
                            s2 += "\r\ncan not delete directory:";
                            s2 += "\r\n" + x2.s[0];
                            break;

                        case Type.dirName:
                            s2 += "\r\nfilter contains an invalid character for dirName,  please rename the filter:";
                            s2 += "\r\n" + x2.s[0];
                            break;

                        case Type.sameFile:
                            s2 += "\r\nfilter contains multiple files with the same name,  please rename or move them:";
                            s2 += "\r\n" + x2.s[0];
                            break;

                        case Type.sameFilter:
                            s2 += "\r\nfilter contains multiple filters with the same name,  please rename or move them:";
                            s2 += "\r\n" + x2.s[0];
                            break;
                    }

                    if (x2.e != null) s.Append("\r\n\r\nexception:  [" + x2.e.Message + "]");

                    s.Append(s2);
                    if (i < x.Count - 1) s.Append("\r\n\r\n\r\n\r\n");
                }

                return s.ToString();
            }







        }




    }
}