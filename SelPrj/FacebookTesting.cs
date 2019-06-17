using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelPrj
{
    class FacebookTesting
    {
        IWebDriver driver = new ChromeDriver();
        CustomSeleniumMethods CSM = new CustomSeleniumMethods();

        static void Main(string[] args)
        {
        }
        //Background
        [SetUp]
        public void Initialize()
        {
            CSM.GoToUrl(driver, "https://www.facebook.com/");
        }

        [Test]
        public void Test()
        {
            driver.Manage().Window.Maximize();

            CSM.EnterTextIntoField(driver, "uilsmitt@mail.ru", "email");

            CSM.EnterTextIntoField(driver, "legenda@legenda", "pass");

            CSM.ClickOnElementByType(driver, "u_0_a", "ID");

            CSM.WaitUntilTypeIsVisible(driver, 20, "ID", "fbDockChatBuddylistNub");

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
