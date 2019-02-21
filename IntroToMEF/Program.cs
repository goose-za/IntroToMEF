using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace IntroToMEF
{
    /// <summary>
    /// Tutorial    : Developing Modular Applications with MEF
    /// URL         : https://blogs.msmvps.com/bsonnino/2013/08/31/developing-modular-applications-with-mef/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Now we need to tell that our parts are not only in the current assembly, 
            // but they can also be found in the current folder.For that we must compose 
            // two catalogs: one for the current assembly(for the imported parts) and 
            // another for the folder (for the exported parts).We will use an AggregateCatalog 
            // to compose both catalogs
            var catalog = new AggregateCatalog(
                new AssemblyCatalog(Assembly.GetExecutingAssembly()),
                new DirectoryCatalog("."));

            // created the container that composes the parts after the menu is created
            var container = new CompositionContainer(catalog);
            var menu = new Menu();
            container.ComposeParts(menu);

            // When the menu.OptionList() method is called, the module’s title is listed
            menu.OptionList();
            Console.ReadLine();
        }
    }
}
