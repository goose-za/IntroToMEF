using System;
using System.ComponentModel.Composition;

namespace IntroToMEF
{
    /// <summary>
    /// In order to match the parts, we must say 
    /// that the imported part is also of the IModule type
    /// </summary>
    public class Menu
    {
        [Import]
        private IModule _module;

        public void OptionList()
        {
            Console.WriteLine(_module.Title);
        }
    }
}
