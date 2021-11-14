using System;
using System.Collections.Generic;
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
            public HashSet<ProjectItem> file;
            public Dictionary<string, List<String>> group;
        }
        public Files f;




        public struct Root
        {
            public string dir;
            public string filter;

            public string filterAppend(string s)
            {
                bool sFull = !string.IsNullOrWhiteSpace(s);
                bool rFull = filterFull;
                return (rFull ? filter : "") +
                    ((rFull && sFull) ? "\\" : "") +
                    (sFull ? s : "");
            }

            public bool filterFull { get => !string.IsNullOrWhiteSpace(filter); }


            public static bool filterCheck(string s)
            {
                if (string.IsNullOrWhiteSpace(s)) return true;
                return !s.Any(x => !(char.IsLetterOrDigit(x) || x == '\\' || x == '/'));
            }


            public void filterSet(string s)
            {
                filter = "";
                if (string.IsNullOrWhiteSpace(s)) { filter = ""; return; }

                //check
                if (!filterCheck(s)) throw new Exception();

                string[] s2 = s.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                StringBuilder s3 = new StringBuilder();
                for (int i = 0; i < s2.Length; i++)
                {
                    s3.Append(s2[i]);
                    if (i < s2.Length - 1) s3.Append('\\');
                }
                filter = s3.ToString();
            }
        }
        public Root r;







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
            f.file = new HashSet<ProjectItem>(projectUtility.Recurse(p.ProjectItems)).Where(x => x.Kind == EnvDTE.Constants.vsProjectItemKindPhysicalFile).ToHashSet();

            
            if (!isVcxitems)
            {
                //reference   add
                bool x3;
                foreach (string x in xp)
                    xr.AddSharedProjectReference(x, out x3);
            }
        }




        public void filesGroup()
        {
            // ClCompile -> .cpp, .cc, .c, ...
            // ClInclude -> .h, .hxx, .hpp, ...
            // None -> Makefile, .gitignore, ...
            f.group = new Dictionary<string /* ItemType */, List<string> /* Files FullPath */>();
            foreach (ProjectItem projectItem in f.file)
                try
                {

                    //projectItem
                    /*{
                        string o = (string)projectItem.Name;
                        string p = ((VCProject)projectItem.Properties.Item("project").Object).Name;
                    }*/




                    string itemType = (string)projectItem.Properties.Item("ItemType").Value;
                    if (string.IsNullOrEmpty(itemType)) continue;

                    if (!f.group.ContainsKey(itemType))
                        f.group.Add(itemType, new List<string>());

                    f.group[itemType].Add((string)projectItem.Properties.Item("FullPath").Value);
                }
                catch (Exception)
                {
                }
        }
    }


}
