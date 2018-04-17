using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace adressbook_test
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected appManager manager;
        public HelperBase(appManager manager)
        {
            this.driver = manager.Driver;
            this.manager = manager;
        }

    }

}