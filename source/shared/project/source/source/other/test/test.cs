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
    internal sealed partial class extension
    {

        public class test
        {
            //references
            //project2.ReferencesConsumableByDesigners
            //Kind   =?   ActiveX, Assembly, Project, Sdk, Web, WinRT, File
            //ReferencedProject
            //FullPath
            //identity   [shared - fullPath, project - guid]


            //KInd     VCSharedProjectReference
            //VCReferenceType   32,   VCSharedProjectReference

            //KInd     VCProjectReference
            //VCReferenceType     4,     VCProjectReference


            //IVCCollection c = (IVCCollection) p.p2.Filters;          //Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.VCCollectionShim
            //VCFilter c2 in c          //Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.VCFilterShim
            //VCFile:ProjectItem c3 in (IVCCollection) c2.Files          //Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.VCCollectionShim







            public void propertyList(Properties p, HashSet<string> x)
            {
                ThreadHelper.ThrowIfNotOnUIThread();
                foreach (Property x2 in p)
                    x.Add(x2.Name);
            }




            public static void calculate()
            {
                //properties   project
                /*{
                    HashSet<string> s = new HashSet<string>();
                    foreach (Project x in project.DTE.Solution.Projects)
                        propertyList(project.Properties, s);
                    string s2 = "";
                    foreach (string s3 in s.ToList().OrderBy(x => x)) s2 += s3 + "\r\n";
                }*/



                //properties   projectItems
                /*{
                    HashSet<string> s = new HashSet<string>();
                    foreach (Project p in project.DTE.Solution.Projects)
                        foreach (ProjectItem p2 in p.ProjectItems)
                        {
                            if (p2.Kind != EnvDTE.Constants.vsProjectItemKindPhysicalFile) continue;
                            propertyList(p2.Properties, s);
                        }
                    string s2 = "";
                    foreach (string s3 in s.ToList().OrderBy(x => x)) s2 += s3 + "\r\n";
                }*/



                /*{
                    ProjectItem[] o0 = p.p.ProjectItems.OfType<ProjectItem>().ToArray();
                    IVCCollection[] o = ((IVCCollection)p.p2.Items).OfType<VCProjectItem>().ToArray();
                    object f = p.p2.Files;

                    VCFilter[] o2 = ((IVCCollection)p.p2.Filters).OfType<VCFilter>().ToArray();
                    foreach (VCFilter o3 in o2)
                    {
                        string s1 = o3.Filter;
                        string s2 = o3.Name;
                        string s3 = o3.ItemName;
                    }
                }*/




                //projectItem
                /*{
                    string o = (string)projectItem.Name;
                    string p = ((VCProject)projectItem.Properties.Item("project").Object).Name;
                }*/
            }




        }





    }
}