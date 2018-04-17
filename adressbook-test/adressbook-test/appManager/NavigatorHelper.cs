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
    public class NavigatorHelper : HelperBase
    {
        private string baseURL;
        public NavigatorHelper(appManager manager,string baseURL) : base(manager)
        {
           
            this.baseURL = baseURL;
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }


        public void GoToGroupPage()
        {
            //Go to Groups page
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoToContactsPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

    }
}
