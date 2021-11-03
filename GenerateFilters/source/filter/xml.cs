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


        //xml utils
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

        private static void WriteSources(XmlWriter xmlWriter, string itemType, List<string> files, string projectPath, string commonPath, bool pIsVcxitems)
        {
            if (files == null || files.Count == 0)
                return;

            // Only write if one occurence
            xmlWriter.WriteStartElement("ItemGroup");
            foreach (var file in files)
            {
                var path = Path.GetDirectoryName(file);
                if (path.Length == commonPath.Length)
                    continue;

                xmlWriter.WriteStartElement(itemType);
                xmlWriter.WriteAttributeString("Include", (pIsVcxitems ? "$(MSBuildThisFileDirectory)" : "") + GetRelativePathIfNeeded(projectPath, file));

                {
                    xmlWriter.WriteStartElement("Filter");
                    xmlWriter.WriteString(GetPathExtensionFromCommonPath(commonPath, path));
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }





    }
}
