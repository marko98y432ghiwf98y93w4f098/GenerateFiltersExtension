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



namespace extension
{
    internal sealed partial class main2
    {


        /*private static void WriteFilter(XmlWriter xmlWriter, HashSet<string> filters)
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




        private static void WriteSources(XmlWriter xmlWriter, string filesKey, List<string> files, ProjectData p)
        {
            if (files == null || files.Count == 0) return;


            // Only write if one occurence
            xmlWriter.WriteStartElement("ItemGroup");
            foreach (var f in files)
            {
                string filter = "";
                {
                    string fd = Path.GetDirectoryName(f);
                    if (p.r.c.dir.Length > fd.Length) continue;
                    filter = p.r.oFilterAdd(pathUtility.relativeDir(p.r.c.dir, fd));
                    if (filter == "") continue;
                }

                xmlWriter.WriteStartElement(filesKey);
                xmlWriter.WriteAttributeString("Include", (p.isVcxitems ? "$(MSBuildThisFileDirectory)" : "") + pathUtility.relativeFile(p.path, f));
                xmlWriter.WriteStartElement("Filter");
                xmlWriter.WriteString(filter);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }*/




























        /*
            //calculate
            //project   unload
            p.p.DTE.ExecuteCommand("Project.UnloadProject");



            //write
            {
                XmlWriter xmlWriter = XmlWriter.Create(p.fileName + ".filters", new XmlWriterSettings() { Indent = true });
                xmlWriter.WriteStartElement("Project");
                xmlWriter.WriteAttributeString("ToolsVersion", "4.0");
                xmlWriter.WriteAttributeString("Project", "xmlns", null, @"http://schemas.microsoft.com/developer/msbuild/2003");

                WriteFilter(xmlWriter, pathUtility.getFilterList(p));
                foreach (var x in p.f.group)
                    WriteSources(xmlWriter, x.Key, x.Value, p);

                xmlWriter.WriteEndElement();
                xmlWriter.Close();
            }



            //project   reload
            p.p.DTE.ExecuteCommand("Project.ReloadProject");
            */







    }
}
