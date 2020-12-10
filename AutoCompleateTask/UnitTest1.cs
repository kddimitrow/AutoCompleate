using AutoCompleateTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutoCompleateTask
{
    public class Tests
    {

        private IWebDriver _driver;
        private Pages.HomePage _homePage;
        private WidgestPageNavBar _widgetsPage;
        private AutoCompleatePage _autoCompletePage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _homePage = new Pages.HomePage(_driver);
            _widgetsPage = new Pages.WidgestPageNavBar(_driver);
            _autoCompletePage = new Pages.AutoCompleatePage(_driver);


        }

        [Test]
        public void AutoComplete()
        {
            _driver.Url = "https://demoqa.com/";

            _homePage.Widget.Click();
            _widgetsPage.AutoCompleteNavButton.Click();
            _autoCompletePage.SingleColorInputField.Click();
            _autoCompletePage.inputText();



            Assert.IsTrue(_autoCompletePage.outputTextElement.Displayed);
            Assert.AreEqual(" Red\r\nGreen", _autoCompletePage.outputTextElement.Text);
               



        }


        [TearDown]

        public void TearDown()
        {


            _driver.Quit();
        }
        



    }
}