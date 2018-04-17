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
{ public class appManager
    {

        protected IWebDriver driver;
        protected string baseURL = "http://localhost/";
        protected LoginHelper loginHelper;
        protected NavigatorHelper navigator;
        protected ContactHelper contHelper;
        protected GroupHelper gHelp;
        private static appManager instance;

        public appManager()
        {
        loginHelper = new LoginHelper(this);
        navigator = new NavigatorHelper(this, baseURL);
        gHelp = new GroupHelper(this);
        contHelper = new ContactHelper(this);
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox esr\firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            
        }

        public void Stop()
        {
             
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            

    }
        public static appManager GetInstance()
        {
            if (instance == null)
            {
                instance = new appManager();
            }
            return instance;
        }
        public LoginHelper Auth
    {
        get
        {
            return loginHelper;
        }
    }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public NavigatorHelper Navigator
    {
        get
        {
            return navigator;
        }
    }
    public ContactHelper Contact
    {
        get
        {
            return contHelper;
        }
    }
    public GroupHelper Group
    {
        get
        {
            return gHelp;
        }
    }

       
    }
}
