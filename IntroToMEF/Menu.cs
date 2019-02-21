using IntroToMEF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace IntroToMEF
{
    /// <summary>
    /// In order to match the parts, we must say 
    /// that the imported part is also of the IModule type
    /// </summary>
    public class Menu
    {
        [ImportMany]
        private IEnumerable<IModule> _modules;

        /// <summary>
        /// List all the modules.
        /// </summary>
        public void OptionList()
        {
            // iterate over all the modules that we find
            foreach (var module in _modules)
            {
                // write to console 
                Console.WriteLine(module.Title);
            }
            
        }
    }
}
