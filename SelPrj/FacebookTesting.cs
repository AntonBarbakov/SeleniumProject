using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

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
            CustomSeleniumMethods.GoToUrl(driver, "https://www.facebook.com/");
        }

        [Test]
        public void LoginFacebook()
        {
            driver.Manage().Window.Maximize();

            CustomSeleniumMethods.EnterTextIntoField(driver, "uilsmitt@mail.ru", "email");

            CustomSeleniumMethods.EnterTextIntoField(driver, "legenda@legenda", "pass");

            CustomSeleniumMethods.ClickOnElementByType(driver, "//label[@id='loginbutton']", "XPath");

            CustomSeleniumMethods.WaitUntilTypeIsVisible(driver, 20, "ID", "fbDockChatBuddylistNub");

        }

        [Test]
        public void SignUpFacebook()
        {
            driver.Manage().Window.Maximize();

            CustomSeleniumMethods.EnterTextIntoField(driver, "Konchita", "firstname");
            CustomSeleniumMethods.EnterTextIntoField(driver, "Voorst", "lastname");
            CustomSeleniumMethods.EnterTextIntoField(driver, "9379992", "reg_email__");
            CustomSeleniumMethods.EnterTextIntoField(driver, "11111111", "reg_passwd__");

            CustomSeleniumMethods.SelectDropDown(driver, "day", "16", "ID");
            CustomSeleniumMethods.SelectDropDown(driver, "month", "мар", "ID");
            CustomSeleniumMethods.SelectDropDown(driver, "year", "1977", "ID");
            Thread.Sleep(4000);
            CustomSeleniumMethods.ClickOnElementByType(driver, "//span[3]/label[@class='_58mt' and 1]", "XPath");
            
            CustomSeleniumMethods.WaitUntilTypeIsVisible(driver, 20, "ID", "custom_gender_container");
            CustomSeleniumMethods.SelectDropDown(driver, "preferred_pronoun", "Она: \"Поздравьте ее с днем рождения!\"", "Name");

            CustomSeleniumMethods.EnterTextIntoField(driver, "Да я сама не знаю", "custom_gender");
           
            CustomSeleniumMethods.ClickOnElementByType(driver, "websubmit", "Name");
            CustomSeleniumMethods.WaitUntilTypeIsVisible(driver, 20, "XPath", "//div[@class='_5v-0 _53im']");
        }



        [TearDown]
        public void CleanUp()
        {
           driver.Quit();
        }
    }
}
