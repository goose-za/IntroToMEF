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
            // We have created an AssemblyCatalog (that searches the parts in the assembly 
            // – in our case, in the current assembly)
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());

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
