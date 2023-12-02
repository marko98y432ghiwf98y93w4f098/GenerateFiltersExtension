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




namespace extension
{
    public partial class test
    {


        public static IEnumerable<Property> dProperty(Properties p)
        {
            List<Property> p2 = new();
            foreach (Property p3 in p)
                p2.Add(p3);
            return p2;
        }






        
        


        public static void dProject(Project p)
        {
            void dPropertyList(Properties p, HashSet<string> x)          //properties
            {
                foreach (Property x2 in p)
                    x.Add(x2.Name);
            }















            {
                HashSet<string> s = new();
                foreach (Project x in p.DTE.Solution.Projects)          //properties   project
                    dPropertyList(p.Properties, s);
                string s2 = "";
                foreach (string s3 in s.ToList().OrderBy(x => x)) s2 += s3 + "\r\n";
            }



            

            {
                HashSet<string> s = new();
                foreach (Project p1 in p.DTE.Solution.Projects)          //properties   projectItems
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