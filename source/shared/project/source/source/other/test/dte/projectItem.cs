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
        

        public static void dProjectItem(ProjectItem projectItem)
        {
            //projectItem
            {
                string o = (string)projectItem.Name;
                string p = ((VCProject)projectItem.Properties.Item("project").Object).Name;
            }
        }









    }
}