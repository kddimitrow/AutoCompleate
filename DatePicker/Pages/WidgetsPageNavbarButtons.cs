using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatePicker.Pages
{
    public class WidgetsPageNavbarButtons : BasePage
    {

        public WidgetsPageNavbarButtons(IWebDriver driver)
            : base(driver)
        {

        }


        public IWebElement DatePickerButton => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[4]/div/ul/li[3]"));
     
        
       

    }
}
