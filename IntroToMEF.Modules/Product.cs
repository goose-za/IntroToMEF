using IntroToMEF.Interfaces;
using System.ComponentModel.Composition;

namespace IntroToMEF.Modules
{
    /// <summary>
    /// Our class will implement this interface (IModule) and the export 
    /// will tell that we are exporting the IModule interface
    /// </summary>
    [Export(typeof(IModule))]
    public class Product : IModule
    {
        public Product()
        {
            Title = "Products";
        }

        public string Title { get; set; }
    }
}
