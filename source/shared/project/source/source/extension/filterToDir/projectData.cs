using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.VCProjectEngine;

namespace VisualStudioCppExtensions
{
    namespace filterToDir
    {
        public class ProjectData
        {
            //project
            public class Project
            {
                public VCProject p;

                //id
                public string name;
                public string dir;
                public string dirFile;
                public string guid;

                public Project(VCProject x)
                {
                    p = x;

                    name = p.Name;
                    dir = p.ProjectDirectory;
                    dirFile = p.ProjectFile;
                    guid = p.ProjectGUID;
                }

                public bool flagDirty { get => p.IsDirty; }
                public bool flagVcxItems { get => dirFile.EndsWith(".vcxitems", StringComparison.OrdinalIgnoreCase); }
            }
            public Project p;















            public class Files
            {
                public filters2 f2;

                public void filesGet(Project p)
                {
                    ThreadHelper.ThrowIfNotOnUIThread();
                    VCReferences xr = (VCReferences)p.p.VCReferences;
                    HashSet<string> xp = new HashSet<string>();


                    if (!p.flagVcxItems)
                    {
                        //reference   search
                        foreach (VCSharedProjectReference x in xr.GetReferencesOfType(32))
                            xp.Add(((EnvDTE.Project)x.ReferencedProject).FullName);

                        //reference   remove
                        foreach (VCSharedProjectReference x in xr.GetReferencesOfType(32))
                            xr.RemoveReference(x);
                    }



                    //projecctItems
                    f2 = new filters2();
                    f2.init(p.p);



                    if (!p.flagVcxItems)
                    {
                        //reference   add
                        bool x3;
                        foreach (string x in xp)
                            xr.AddSharedProjectReference(x, out x3);
                    }
                }




                //check
                private char[] checkC = Path.GetInvalidPathChars().Union(Path.GetInvalidFileNameChars()).ToArray();
                private void check2(filter x, error e)
                {
                    //chars
                    bool b = true;
                    foreach (char c in checkC)
                        if (x.xn2.Contains(c)) { b = false; break; }
                    if (!b) e.add(new error.data() { t = error.Type.dirName, s = new string[] { x.xn.x } });

                    //same   file
                    foreach (var x3 in x.o.files.GroupBy(x2 => dir.file2.fileRelative(x2.Value).x.ToLower()).Where(x2 => x2.Count() > 1))
                        e.add(new error.data() { t = error.Type.sameFile, s = new string[] { x3.Key } });

                    //same   filter
                    foreach (var x3 in x.o.filters2.GroupBy(x2 => x2.xn.x.ToLower()).Where(x2 => x2.Count() > 1))
                        e.add(new error.data() { t = error.Type.sameFilter, s = new string[] { x3.Key } });


                    foreach (filter x2 in x.o.filters2)
                        check2(x2, e);
                }

                public void check(error e)
                {
                    foreach (filter x in f2.f.o.filters2)
                        check2(x, e);
                }
            }
            public Files f = new Files();





























            public class Data
            {
                public class Calculate
                {
                    public path filter = new path("");

                    static bool filterCheck(string s)
                    {
                        if (!s.xFull()) return true;
                        return !s.Any(x => !(char.IsLetterOrDigit(x) || x == ' ' || x == '\\' || x == '/'));
                    }

                    public void filterSet(string s)
                    {
                        filter = null;
                        if (!s.xFull()) return;

                        //check
                        if (!filterCheck(s)) throw new Exception();

                        filter = new path(s);
                    }
                }
                public Calculate c = new Calculate();



                public class Out
                {
                    public path dir;
                }
                public Out o = new Out();

            }
            public Data d = new Data();



            public error e = new error();














































            public class dir
            {
                public ProjectData p;
                public path root;


                public dir(ProjectData p) => this.p = p;







                public class file2
                {
                    //info
                    public path p1;
                    public path p2;
                    public path d1;
                    public path d2;
                    public file f;

                    public class Configuration
                    {
                        public eFileType fileType;
                        public bool deploymentContent;
                        //public string customTool;
                        //public bool includedInProject;

                        public bool document = false;
                        public string dGuid;
                        public Configuration(VCFile x)
                        {
                            fileType = x.FileType;
                            deploymentContent = x.DeploymentContent;
                            //customTool = x.CustomTool;

                            ProjectItem x2 = (ProjectItem)x.Object;
                            //if (!x2.Saved) x2.Save();          notImplemented
                            Document x3 = x2.Document;
                            if (x3 != null)
                            {
                                document = true;
                                dGuid = x3.Kind;
                            }
                        }
                        public void set(VCFile x)
                        {
                            if (x == null) return;
                            x.FileType = fileType;
                            x.DeploymentContent = deploymentContent;
                            //x.CustomTool = customTool;          notImplemented

                            ProjectItem x2 = (ProjectItem)x.Object;
                            if (document) x2.Open();
                        }
                    }



                    //static
                    public static bool move(path p1, path p2, error e)
                    {
                        try
                        {
                            File.Move(p1.x, p2.x);
                        }
                        catch (Exception ex)
                        {
                            e.add(new error.data() { t = error.Type.move, s = new string[] { p1.x, p2.x }, e = ex });
                            return false;
                        }
                        return true;
                    }



                    //move
                    public void createMoveD()
                    {
                        d1 = p1.mUp();
                        d2 = p2.mUp();
                        if (!Directory.Exists(d1.x)) throw new Exception();
                        if (Directory.Exists(d2.x)) return;

                        Directory.CreateDirectory(d2.x);
                    }


                    public bool move(ProjectData p, error e)
                    {
                        if (File.Exists(p2.x)) return false;

                        object o = f.xp.x;
                        bool b = o != null;

                        Configuration c = new Configuration(f.x);
                        {
                            if (b) ((VCFilter)o).RemoveFile(f.x); else p.p.p.RemoveFile(f.x);
                            {
                                if (!file2.move(p1, p2, e)) p2 = p1;
                            }
                            f.x = (VCFile)(b ? ((VCFilter)o).AddFile(p2.x) : p.p.p.AddFile(p2.x));
                        }
                        c.set(f.x);
                        return true;
                    }




                    //scan
                    public static path fileRelative(file x) => (x.xp.xn ?? new path("")) + x.x2.sLast;

                    public static LinkedList<file2> filesGet(path r, filter x, ref LinkedList<file2> x2)
                    {
                        foreach (var x3 in x.o.files)
                        {
                            path p1 = x3.Value.x2;
                            path p2 = r + fileRelative(x3.Value);
                            if (!path.oEqual(p1, p2)) x2.AddLast(new file2() { f = x3.Value, p1 = p1, p2 = p2 });
                        }

                        foreach (filter x3 in x.o.filters2)
                            filesGet(r, x3, ref x2);

                        return x2;
                    }

                }

















                public class dir2
                {
                    public path d;

                    public class result
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




                    //flags
                    public static bool reparse(path x) => File.GetAttributes(x.x).HasFlag(FileAttributes.ReparsePoint);
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






                    //static
                    public static bool checkUpReparse(path r, path d)
                    {
                        if (d == null) return true;

                        path d2 = d - r;
                        if (d2 == null) return false;
                        if (d2.count == 0) return true;

                        if (dir2.exist(d)) if (dir2.reparse(d)) return false;

                        return checkUpReparse(r, d.mUp());
                    }

                    private static void deleteUp2(path r, path d, error e)
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

                    public static void deleteUp(path r, path d, error e) { if (checkUpReparse(r, d)) deleteUp2(r, d, e); }



                    private static void deleteDown2(path r, path d, error e)
                    {
                        if (!dir2.exist(d)) return;
                        if (dir2.reparse(d)) return;
                        if (d - r == null) return;
                        if (dir2.empty(d)) { dir2.delete(d, e); return; }
                        if (!dir2.emptyFiles(d)) return;


                        string[] x = Directory.GetDirectories(d.x);
                        foreach (string x2 in x)
                            deleteDown2(r, new path(x2), e);

                        if (dir2.empty(d)) dir2.delete(d, e);
                    }

                    public static void deleteDown(path r, path d, error e) { if (dir2.checkUpReparse(r, d)) deleteDown2(r, d, e); }








                    //interface
                    public override int GetHashCode() => d?.GetHashCode() ?? 0;
                    public override bool Equals(object x)
                    {
                        if (x == null) return false;
                        if (!(x is dir2)) return false;
                        return d?.Equals(((dir2)x).d) ?? false;
                    }

                    public override string ToString() => d?.ToString();
                }




















                public void init(error e)
                {
                    root = p.d.o.dir;
                    if (!Directory.Exists(root.x)) throw new Exception();


                    //file, dir   get
                    file2[] x = null;
                    {
                        LinkedList<file2> x1 = new LinkedList<file2>();
                        file2.filesGet(root, p.f.f2.f, ref x1);
                        x = x1.ToArray();
                    }

                    HashSet<dir2> x2 = new HashSet<dir2>();
                    foreach (file2 x3 in x)
                    {
                        x2.Add(new dir2() { d = x3.f.x2.mUp() });
                        x3.createMoveD();
                    }



                    //file   move
                    do
                    {
                        int x3 = x.Length;
                        x = x.Where(x4 => !x4.move(p, e)).ToArray();
                        if (x3 == x.Length) break;
                    } while (true);
                    //error
                    foreach (file2 x3 in x)
                        e.add(new error.data() { t = error.Type.move, s = new string[] { x3.p1.x, x3.p2.x } });



                    //dir   delete
                    foreach (dir2 x3 in x2)
                        x3.info();
                    x2 = x2.Where(x3 => x3.r.files == 0).ToHashSet();

                    do
                    {
                        int x3 = x2.Count;
                        foreach (dir2 x4 in x2.Where(x4 => x4.r.dirs == 0))
                        {
                            dir2.delete(x4.d, e);
                            dir2.deleteUp(root, x4.d.mUp(), e);
                        }

                        x2 = x2.Where(x4 => x4.r.dirs != 0).ToHashSet();

                        x2 = x2.Where(x4 => x4.info()).ToHashSet();

                        if (x3 == x2.Count) break;
                    } while (true);



                    //dir   deleteDown
                    foreach (dir2 x3 in x2) { dir2.deleteDown(root, x3.d, e); dir2.deleteUp(root, x3.d.mUp(), e); }
                }



            }
            public dir di;














            public void dirSet()
            {
                di = new dir(this);
                di.init(e);
            }


        }

    }
}
