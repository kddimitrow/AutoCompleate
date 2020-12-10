using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatePicker.Pages
{
    public class DatePickerPage : BasePage
    {

        public DatePickerPage(IWebDriver driver)
            : base(driver)
        {

        }


        public IWebElement SelectDateField => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/div/div/input"));

 
        
        

        public IWebElement CalendarMonthTitle => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[1]"));
    }




}
