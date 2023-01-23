﻿using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;


namespace VisualStudioCppExtensions
{



    [Guid(gui.packageGuid)]          //tag entry with attributes
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [ProvideAutoLoad(VSConstants.UICONTEXT.SolutionExistsAndFullyLoaded_string, PackageAutoLoadFlags.BackgroundLoad)]

    [ProvideMenuResource("Menus.ctmenu", 1)]          //always
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class main : AsyncPackage
    {



        
        public class gui          //gui
        {
            public const string packageGuid = "99d03761-6200-41ad-b2a1-638ae9e780e5";
            public static readonly Guid groupGuid = new Guid("acd8036f-19ae-43b2-a2d6-11788cb282fe");
            public const int buttonId = 0x0100;
            public const int button2Id = 0x0101;
        }


        //public main() { }

        protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            main2.Initialize(this);
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }  
    }


}
