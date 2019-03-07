using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice
{
    class Program
    {

       


        static void Main(string[] args)
        {
            


        }
        [SetUp]
        public void Initialize()
        {
            // Create the reference for our browser
            PropertiesCollection.driver = new ChromeDriver();

            // Navigate to page
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            Console.WriteLine("OpenedURL");
        }
        [Test]
        public void ExecuteTets()
        {

            ExcelLib.PopulateInCollection(@"C:\Users\Bojan.Milovanovic\Desktop\Data.xlsx");

            // Login to Application - initialization of page object
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            //Fill User Details
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));

            // pageEA.FillUserForm("B", "M", "Bojan");


            //// Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            //// Initial
            //SeleniumSetMethods.EnterText("Initial", "execute", PropertyType.Name);
            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            //// Click 
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
            //// First Name
            //SeleniumSetMethods.EnterText("FirstName", "execute", PropertyType.Name);
        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }

        
    }
}
