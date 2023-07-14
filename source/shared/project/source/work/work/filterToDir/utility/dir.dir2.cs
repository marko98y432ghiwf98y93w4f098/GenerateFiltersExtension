using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.VCProjectEngine;
using System.Threading;
using extension.shared;
using Project = extension.shared.Project;
using u.other;

namespace extension
{
    namespace filterToDir
    {
        public partial class ProjectData
        {
            

            public partial class dir
            {
                

                public class dir2
                {
                    public path d;







                    public class result          //info
                    {
                        public int dirs;
                        public int files;
                        public int entries;
                    }
                    public result r;

                    public bool info()
                    {
                        if (!Directory.Exists(d.x)) return false;

                        r = new result();
                        r.dirs = Directory.GetDirectories(d.x).Length;
                        r.files = Directory.GetFiles(d.x).Length;
                        r.entries = Directory.GetFileSystemEntries(d.x).Length;
                        return true;
                    }




                    











                    public static bool reparse(path x) => File.GetAttributes(x.x).HasFlag(FileAttributes.ReparsePoint);          //flags
                    public static bool empty(path x) => Directory.GetFileSystemEntries(x.x).Length == 0;
                    public static bool emptyFiles(path x) => Directory.GetFiles(x.x).Length == 0;
                    public static bool exist(path x) => Directory.Exists(x.x);

                    public static void delete(path x, error e)
                    {
                        try
                        {
                            Directory.Delete(x.x);
                        }
                        catch (Exception e2)
                        {
                            e.add(new error.data() { t = error.Type.delete, s = new string[] { x.x }, e = e2 });
                        }
                    }




















                    
                    private static bool checkUpReparse(path r, path d)          //static
                    {
                        if (d == null) return true;

                        path d2 = d - r;
                        if (d2 == null) return false;
                        if (d2.count == 0) return true;

                        if (dir2.exist(d)) if (dir2.reparse(d)) return false;

                        return checkUpReparse(r, d.mUp());
                    }

                    

                    public static void deleteUp(path r, path d, error e)
                    {
                        void deleteUp2(path r, path d, error e)
                        {
                            if (d == null) return;
                            if (dir2.exist(d))
                            {
                                if (!dir2.empty(d)) return;

                                path d2 = d - r;
                                if (d2 == null) return;
                                if (d2.count == 0) return;

                                dir2.delete(d, e);
                            }
                            deleteUp2(r, d.mUp(), e);
                        }
                        if (checkUpReparse(r, d)) deleteUp2(r, d, e);
                    }



                    

                    public static void deleteDown(path r, path d, error e)
                    {
                        void deleteDown2(path r, path d, error e)
                        {
                            if (!dir2.exist(d)) return;
                            if (dir2.reparse(d)) return;
                            if (d - r == null) return;

                            if (!dir2.empty(d))
                            {
                                if (!dir2.emptyFiles(d)) return;

                                string[] x = Directory.GetDirectories(d.x);
                                foreach (string x2 in x)
                                    deleteDown2(r, new path(x2), e);
                            }

                            if (dir2.empty(d)) dir2.delete(d, e);
                        }
                        if (checkUpReparse(r, d)) deleteDown2(r, d, e);
                    }




























                    
                    public override int GetHashCode() => d?.GetHashCode() ?? 0;          //interface
                    public override bool Equals(object x) => x != null && x is dir2 && (d?.Equals(((dir2)x).d) ?? false);
                    public override string ToString() => d?.ToString();
                }
            }
        }
    }
}
