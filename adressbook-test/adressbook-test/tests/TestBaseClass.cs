using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace adressbook_test
{
    public class TestBase
    {
        protected appManager app;

        [SetUp]
        public void SetupTest()
        {
            app = appManager.GetInstance();

        }

        [TearDown]
        public void TeardownTest()
        {
        }

      
  
    }
}
