using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
//using DotNetSeleniumExtras;

namespace SeleniumPractice
{
    class EAPageObject
    {

        public EAPageObject() =>
            // constructor which initiliaze object of this page
            PageFactory.InitElements(PropertiesCollection.driver, this);




        [FindsBy(How = How.Id, Using = "TitleId")]

        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]

        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]

        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]

        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]

        public IWebElement btnSave { get; set; }


        public void FillUserForm (string initial, string middleName, string firstName)
        {
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.Click();
        }

    }
}
