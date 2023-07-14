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
               
                public class file2
                {
                    public path p1;          //info
                    public path p2;
                    public path d1;
                    public path d2;
                    public @file f;

                    public class Configuration
                    {
                        public string itemType;
                        //public string contentType;          //contentType   cannot be empty string or start with null char
                        public eFileType fileType;

                        public bool deploymentContent;
                        //public string customTool;
                        //public bool includedInProject;

                        public bool document = false;

                        public Configuration(VCFile x)
                        {
                            itemType = x.ItemType;
                            //contentType = x.ContentType;
                            fileType = x.FileType;

                            deploymentContent = x.DeploymentContent;
                            //customTool = x.CustomTool;
                            //includedInProject

                            Document x2 = ((ProjectItem)x.Object).Document;
                            if (x2 != null)
                            {
                                document = true;
                                x2.Close();          //if (!x2.Saved) x2.Save();          notImplemented
                            }
                        }
                        public void set(VCFile x)
                        {
                            if (x == null) return;

                            x.ItemType = itemType;
                            //x.ContentType = contentType;
                            x.FileType = fileType;

                            x.DeploymentContent = deploymentContent;
                            //x.CustomTool = customTool;          notImplemented
                            //includedInProject
                            
                            if (document)
                                try { ((ProjectItem)x.Object).DTE.Documents.Open(x.FullPath); }          //((ProjectItem)x.Object).Open(Document.Kind   {8E7B96A8-E33D-11D0-A6D5-00C04FB67F6A}   );
                                catch (Exception) { }
                        }
                    }



                    
                    



                    
                    public void createMoveD()          //move
                    {
                        d1 = p1.mUp();
                        d2 = p2.mUp();
                        if (!Directory.Exists(d1.x)) throw new();
                        if (Directory.Exists(d2.x)) return;

                        Directory.CreateDirectory(d2.x);
                    }


                    public bool move(ProjectData p, error e)
                    {
                        bool move2(path p1, path p2, error e)
                        {
                            while (true)
                            {
                                bool b = false;
                                try
                                {
                                    File.Move(p1.x, p2.x);
                                }
                                catch (Exception ex)
                                {
                                    if (ex.Message.Contains("because it is being used by another process"))
                                    {
                                        b = true;
                                        e.t++;
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    if (b && e.t < 30) continue;
                                    e.add(new error.data() { t = error.Type.move, s = new string[] { p1.x, p2.x }, e = ex });
                                    return false;
                                }
                                break;
                            }
                            return true;
                        }


                        if (File.Exists(p2.x)) return false;

                        VCFilter x = f.xp.x;
                        bool b = x != null;
                        path p3 = p2;

                        Configuration c = new(f.x);
                        {
                            if (b) x.RemoveFile(f.x); else p.p.p.RemoveFile(f.x);
                            {
                                if (!move2(p1, p2, e)) p3 = p1;
                            }
                            f.x = (VCFile)(b ? x.AddFile(p3.x) : p.p.p.AddFile(p3.x));
                        }
                        c.set(f.x);
                        return true;
                    }
































                    //static
                    public static path fileRelative(file x) => (x.xp.xn ?? new path("")) + x.xn.sLast;          //scan

                    public static LinkedList<file2> filesGet(path r, filter x, ref LinkedList<file2> x2)
                    {
                        foreach (var x3 in x.o.file)
                        {
                            path p1 = x3.Value.xn;
                            path p2 = r + fileRelative(x3.Value);
                            if (!path.oEqual(p1, p2)) x2.AddLast(new file2() { f = x3.Value, p1 = p1, p2 = p2 });
                        }

                        foreach (var x3 in x.o.filter)
                            filesGet(r, x3.Value, ref x2);

                        return x2;
                    }

                }
            }
        }
    }
}
