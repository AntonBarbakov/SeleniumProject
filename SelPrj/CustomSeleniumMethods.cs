using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SelPrj
{
    class CustomSeleniumMethods
    {
       public static void GoToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void EnterTextIntoField (IWebDriver driver, string text, string field)
        {
            IWebElement elem = driver.FindElement(By.Name(field));

            elem.SendKeys(text);
        }

        public static void ClickOnElementByType (IWebDriver driver, string nameElement, string type)
        {
            if (type == "ID")
            {
                IWebElement elem = driver.FindElement(By.Id(nameElement));
                elem.Click();
            }
            if (type == "Name")
            {
                IWebElement elem = driver.FindElement(By.Name(nameElement));
                elem.Click();
            }
            if (type == "XPath")
            {
                IWebElement elem = driver.FindElement(By.XPath(nameElement));
                elem.Click();
            }
            if (type == "Css")
            {
                IWebElement elem = driver.FindElement(By.CssSelector(nameElement));
                elem.Click();
            }
            if (type == "ClassName")
            {
                IWebElement elem = driver.FindElement(By.ClassName(nameElement));
                elem.Click();
            }
        }

        public static void WaitUntilTypeIsVisible (IWebDriver driver,int seconds,string type, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            if (type == "ID")
            {
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Id(value)));
            }
            if (type == "Css")
            {
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.CssSelector(value)));
            }
            if (type == "Name")
            {
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Name(value)));
            }
            if (type == "XPath")
            {
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.XPath(value)));
            }
            if (type == "ClassName")
            {
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.ClassName(value)));
            }
        }


        public static void SelectDropDown(IWebDriver driver, string typeValue, string innerText, string type)
        {
            if(type == "ID")
            {
                SelectElement oSelect = new SelectElement(driver.FindElement( By.Id(typeValue) ));
                oSelect.SelectByText(innerText);
            }
            if (type == "Name")
            {
                SelectElement oSelect = new SelectElement(driver.FindElement(By.Name(typeValue)));
                oSelect.SelectByText(innerText);
            }
            if (type == "ClassName")
            {
                SelectElement oSelect = new SelectElement(driver.FindElement(By.ClassName(typeValue)));
                oSelect.SelectByText(innerText);
            }
        }
    }
}
