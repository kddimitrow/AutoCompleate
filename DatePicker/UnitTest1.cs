using DatePicker.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Threading;

namespace DatePicker
{
    public class Tests
    {
        private ChromeDriver _driver;
        private HomePage _homePage;
        private WidgetsPageNavbarButtons _widgetsPage;
        private DatePickerPage _datePickerPage;

        [SetUp]
        public void Setup()
        {

            _driver = new ChromeDriver();
            _homePage = new HomePage(_driver);
            _widgetsPage = new WidgetsPageNavbarButtons(_driver);
            _datePickerPage = new DatePickerPage(_driver);

        }

        [Test]
        public void datePickerr()
        {

            _driver.Url = "https://demoqa.com/";

            _homePage.Widget.Click();
            _widgetsPage.ScrollTo(_widgetsPage.DatePickerButton);
            _widgetsPage.DatePickerButton.Click();
           
            _datePickerPage.SelectDateField.Click();
            _datePickerPage.SelectDateField.Clear();

            //_datePickerPage.SelectDateField.SendKeys(Keys.LeftControl + "a");
            // _datePickerPage.SelectDateField.SendKeys(Keys.Backspace);

             Thread.Sleep(2000);
             string date1 = "01/01/2020";

             _datePickerPage.SelectDateField.SendKeys(date1);
                
            Assert.AreEqual("January", _datePickerPage.Driver);
        }


        [TearDown]

        public void TearDown()
        {


            _driver.Quit();
        }

    }
}