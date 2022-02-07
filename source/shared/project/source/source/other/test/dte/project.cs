using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.VCProjectEngine;
using Microsoft.Internal.VisualStudio.PlatformUI;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Text;
using System.Linq;




namespace VisualStudioCppExtensions
{
    public partial class test
    {
        //properties
        public static void dPropertyList(Properties p, HashSet<string> x)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            foreach (Property x2 in p)
                x.Add(x2.Name);
        }




        public static void dProject(Project p)
        {

            //properties   project
            {
                HashSet<string> s = new HashSet<string>();
                foreach (Project x in p.DTE.Solution.Projects)
                    dPropertyList(p.Properties, s);
                string s2 = "";
                foreach (string s3 in s.ToList().OrderBy(x => x)) s2 += s3 + "\r\n";
            }



            //properties   projectItems
            {
                HashSet<string> s = new HashSet<string>();
                foreach (Project p1 in p.DTE.Solution.Projects)
                    foreach (ProjectItem p2 in p1.ProjectItems)
                    {
                        if (p2.Kind != EnvDTE.Constants.vsProjectItemKindPhysicalFile) continue;
                        dPropertyList(p2.Properties, s);
                    }
                string s2 = "";
                foreach (string s3 in s.ToList().OrderBy(x => x)) s2 += s3 + "\r\n";
            }

            ProjectItem[] o0 = p.ProjectItems.OfType<ProjectItem>().ToArray();



        }







    }
}