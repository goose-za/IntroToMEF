using System.ComponentModel.Composition;

namespace IntroToMEF
{
    [Export]
    public class Module
    {
        public Module()
        {
            Title = "Customers";
        }

        public string Title { get; set; }
    }
}
