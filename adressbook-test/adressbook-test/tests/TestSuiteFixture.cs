using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace adressbook_test
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
       
        [SetUp]
        public void initAppManager()
        {
            appManager app = appManager.GetInstance();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }
        [TearDown]
        public void StopAppManager()
        {
            appManager.GetInstance().Stop();

        }
    }
}
