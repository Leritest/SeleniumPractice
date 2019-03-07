using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice
{
    class SeleniumGetMethods
    {
        //  public static string GetText (string element, PropertyType elementtype)
        // {
        //        if (elementtype == PropertyType.Id)
        //        return Properties.Collection.driver.FindElement(By.Id(element)).GetAttribute("value");
        //        if (elementtype == PropertyType.Name)
        //        return Properties.Collection.driver.FindElement(By.Name(element)).GetAttribute("value");// 
        //        else return String.Empty }

            // Upper method is Customize with this one
        public static string GetText (IWebElement element)
        {
                return element.GetAttribute("value");

        }
        //DDL-dropdown list
        public static string GetTextFromDDL (IWebElement element)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            
        }
    }
}
