using System.ComponentModel.Composition;

namespace IntroToMEF
{
    /// <summary>
    /// Our class will implement this interface (IModule) and the export 
    /// will tell that we are exporting the IModule interface
    /// </summary>
    [Export(typeof(IModule))]
    public class Module : IModule
    {
        public Module()
        {
            Title = "Customers";
        }

        public string Title { get; set; }
    }
}
