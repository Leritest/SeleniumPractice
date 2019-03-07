using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice
{
    class LoginPageObject
    {
        // Constructor which initiliaze object of this page
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }



        public EAPageObject Login (String userName, string password)
        {
            // UserName
            txtUserName.EnterText(userName);
            // Password
            txtPassword.EnterText(password);
            // Click button (should use Clicks method from SeleniumSetMethods, but somehow it is not working)
            btnLogin.Submit();

            // Return the page object, since when we login we are navigating to EAPage
            return new EAPageObject();

        }
    }
}
