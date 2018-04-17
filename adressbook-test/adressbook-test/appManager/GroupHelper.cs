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
    public class GroupHelper : HelperBase
    {
        
        public GroupHelper(appManager manager) : base(manager)
        {
    
        }

        public GroupHelper CreateGroup()
        {
            manager.Navigator.GoToGroupPage();
            ClickGroupCreation();
            FillGroupFom(new GroupData("aaaa"));
            SubmitGroupCreation();
            return this;

        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ClickGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;

        }


        public GroupHelper FillGroupFom(GroupData group)
        {
            //fill form
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            driver.FindElement(By.XPath("//form[@action='/addressbook/group.php']")).Click();
            return this;

        }

    }
}
