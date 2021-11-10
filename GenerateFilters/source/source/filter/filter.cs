using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Internal.VisualStudio.PlatformUI;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;


namespace VisualStudioCppExtensions
{
    internal sealed partial class filter
    {
        //attributes
        public const int CommandId = 0x0100;
        public static readonly Guid menuGroup = new Guid("acd8036f-19ae-43b2-a2d6-11788cb282fe");
        private readonly Package package;








        //error box
        private void ErrorMessageBox(string errorMessage)
        {
            VsShellUtilities.ShowMessageBox(this.packageIServiceProvider,
                                            errorMessage,
                                            string.Empty,
                                            OLEMSGICON.OLEMSGICON_CRITICAL,
                                            OLEMSGBUTTON.OLEMSGBUTTON_OK,
                                            OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }

















        //init
        public static filter Instance
        {
            get;
            private set;
        }

        // Gets the service provider from the owner package.
        private IServiceProvider packageIServiceProvider { get => this.package; }


        // Initializes the singleton instance of the command.      
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package) => Instance = new filter(package);
        

        /// <summary>
        /// Initializes a new instance of the <see cref="filter"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private filter(Package package)
        {
            if (package == null) throw new ArgumentNullException("package");
            this.package = package;


            OleMenuCommandService commandService = this.packageIServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService == null) return;

            var menuItem = new OleMenuCommand(this.MenuItemCallback, new CommandID(menuGroup, CommandId));
            menuItem.BeforeQueryStatus += OnBeforeQueryStatusCallBack;

            commandService.AddCommand(menuItem);
        }




    }
}


