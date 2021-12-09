using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Internal.VisualStudio.PlatformUI;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Text;



namespace VisualStudioCppExtensions
{
    internal sealed partial class filter
    {


        private static void WriteFilter(XmlWriter xmlWriter, HashSet<string> filters)
        {
            if (filters == null || filters.Count == 0)
                return;

            xmlWriter.WriteStartElement("ItemGroup");
            foreach (var filter in filters)
            {
                xmlWriter.WriteStartElement("Filter");
                xmlWriter.WriteAttributeString("Include", filter);

                {
                    xmlWriter.WriteStartElement("UniqueIdentifier");
                    xmlWriter.WriteString("{" + Guid.NewGuid().ToString() + "}");
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }




        private static void WriteSources(XmlWriter xmlWriter, string fileType, List<string> files, ProjectData p)
        {
            if (files == null || files.Count == 0) return;


            // Only write if one occurence
            xmlWriter.WriteStartElement("ItemGroup");
            foreach (var f in files)
            {
                string d = Path.GetDirectoryName(f);
                if (d.Length < p.r.dir.Length) continue;
                string s = p.r.filterAppend(pathUtility.GetExtensionFromCommon(p.r.dir, d));
                if (s == "") continue;

                xmlWriter.WriteStartElement(fileType);
                xmlWriter.WriteAttributeString("Include", (p.isVcxitems ? "$(MSBuildThisFileDirectory)" : "") + pathUtility.GetRelativeIfNeeded(p.path, f));
                xmlWriter.WriteStartElement("Filter");
                xmlWriter.WriteString(s);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }


    }
}
