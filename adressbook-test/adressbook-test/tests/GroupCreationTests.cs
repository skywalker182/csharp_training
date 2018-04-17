using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace adressbook_test
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {   [Test]
        public void GroupCreationTest()
        {
            
            app.Group.CreateGroup();
            app.Navigator.ReturnToGroupPage();
    
        }

    }
}
