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
    public class ProjectData
    {
        public Project p;
        public VCProject p2;
        public string fileName;
        public string path;
        public bool isVcxitems;



        public struct Files
        {
            public Dictionary<string, VCFile> file;
            public Dictionary<string, VCFile> fileIn;
            //public Dictionary<string, List<String>> group;
            public Dictionary<string, file> fileIn2;
        }
        public Files f;



        public filters f2;




















        public class Root
        {
            public class In
            {
                public enum inMode
                {
                    project,
                    dir,
                    dirSubDir
                }
                public inMode mode;
                public string dir;
            }
            public In i = new In();

            public class Calculate
            {
                public string dir;
                public bool fEmptyDelete = true;
            }
            public Calculate c = new Calculate();

            public class Out
            {
                public string filter;
            }
            public Out o = new Out();



            public string oFilterAdd(string s)
            {
                bool sFull = !string.IsNullOrWhiteSpace(s);
                bool rFull = filterFull;
                return (rFull ? o.filter : "") +
                    ((rFull && sFull) ? "\\" : "") +
                    (sFull ? s : "");
            }

            public bool filterFull { get => !string.IsNullOrWhiteSpace(o.filter); }


            public static bool filterCheck(string s)
            {
                if (string.IsNullOrWhiteSpace(s)) return true;
                return !s.Any(x => !(char.IsLetterOrDigit(x) || x == ' ' || x == '\\' || x == '/'));
            }


            public void filterSet(string s)
            {
                o.filter = "";
                if (string.IsNullOrWhiteSpace(s)) { o.filter = ""; return; }

                //check
                if (!filterCheck(s)) throw new Exception();

                string[] s2 = s.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                StringBuilder s3 = new StringBuilder();
                for (int i = 0; i < s2.Length; i++)
                {
                    s3.Append(s2[i]);
                    if (i < s2.Length - 1) s3.Append('\\');
                }
                o.filter = s3.ToString();
            }
        }
        public Root r = new Root();

































        public void filesGet()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            HashSet<string> xp = new HashSet<string>();
            VCReferences xr = (VCReferences)p2.VCReferences;


            if (!isVcxitems)
            {
                //reference   search
                foreach (VCSharedProjectReference x in xr.GetReferencesOfType(32))
                    xp.Add(((Project)x.ReferencedProject).FullName);


                //reference   remove
                foreach (VCSharedProjectReference x in xr.GetReferencesOfType(32))
                    xr.RemoveReference(x);
            }


            //projecctItems
            f.file = ((IVCCollection)p2.Files).Cast<VCFile>().Where(x => x.ItemType != null).ToDictionary(x => x.FullPath);

            
            if (!isVcxitems)
            {
                //reference   add
                bool x3;
                foreach (string x in xp)
                    xr.AddSharedProjectReference(x, out x3);
            }
        }


        public void filesIn()
        {
            f.fileIn = (r.i.mode == Root.In.inMode.project) ? f.file :
                       r.i.mode == Root.In.inMode.dirSubDir ?
                           f.file.Where(x => x.Key.StartsWith(r.i.dir)).ToDictionary(x => x.Key, x => x.Value) :
                           f.file.Where(x => File.Exists(r.i.dir + '\\' + x.Value.Name)).ToDictionary(x => x.Key, x => x.Value);

            f.fileIn2 = f.fileIn.Select(x =>
                {
                    file x2 = new file();
                    x2.init(x.Value);
                    x2.init(r.c.dir);
                    return x2;
                }
            ).ToDictionary(x => x.xn.x, x => x);
            
            //filesGroup();
        }





        /*public void filesGroup()
        {
            // ClCompile -> .cpp, .cc, .c, ...
            // ClInclude -> .h, .hxx, .hpp, ...
            // None -> Makefile, .gitignore, ...
            f.group = new Dictionary<string, List<string>>();
            foreach (ProjectItem projectItem in f.file)
                try
                {
                    string itemType = (string)projectItem.Properties.Item("ItemType").Value;
                    if (string.IsNullOrEmpty(itemType)) continue;

                    if (!f.group.ContainsKey(itemType))
                        f.group.Add(itemType, new List<string>());

                    f.group[itemType].Add((string)projectItem.Properties.Item("FullPath").Value);
                }
                catch (Exception)
                {
                }
        }*/
























        public void filtersGet()
        {
            f2 = new filters();
            f2.init(p2);
            f2.fCleanEmpty(f.fileIn, r.c.fEmptyDelete);
            f2.fRoot = f2.fAdd(f2.f, r.o.filter);
            f2.filtersSet(f.fileIn2);
        }
    }


}
