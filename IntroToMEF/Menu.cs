using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMEF
{
    public class Menu
    {
        private Module _module;

        public void OptionList()
        {
            Console.WriteLine(_module.Title);
        }
    }
}
