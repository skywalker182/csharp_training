using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace adressbook_test
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {   [Test]
        public void ContactCreationTest()
        {
          
            app.Navigator.GoToContactsPage();
            app.Contact.FillTheContactForm(new Contact("aaa","aaa","3333333"));
            app.Contact.SubmitContactForm();

        } 
     
    }
}
