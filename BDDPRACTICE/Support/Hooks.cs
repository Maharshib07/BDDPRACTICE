using BDDPRACTICE.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPRACTICE.Support
{
    [Binding]
    public class Hooks 
    {
        Browsers WebBrowser = new Browsers();
            
        [BeforeScenario]
        public void BeforeScenario()
        {
            WebBrowser.initial();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebBrowser.CloseBrowser();
        }
    }
}
