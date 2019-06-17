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
       public void GoToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterTextIntoField (IWebDriver driver, string text, string field)
        {
            IWebElement elem = driver.FindElement(By.Name(field));

            elem.SendKeys(text);
        }

        public void ClickOnElementByType (IWebDriver driver, string nameElement, string type)
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

        public void WaitUntilTypeIsVisible (IWebDriver driver,int seconds,string type, string value)
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
        }
    }
}
