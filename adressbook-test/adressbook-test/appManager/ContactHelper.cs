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
    public class ContactHelper : HelperBase
    {
        public ContactHelper(appManager manager) : base(manager)
        {
            
         }


        public void SubmitContactForm()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }

        public void FillTheContactForm(Contact testContact)
        {
            driver.FindElement(By.Name("theform")).Click();
            driver.FindElement(By.Name("theform")).Click();
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(testContact.Name);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(testContact.Lastname);
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(testContact.Nickname);
        }

    }
}
