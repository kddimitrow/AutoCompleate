using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCompleateTask.Pages
{
    public class WidgestPageNavBar : BasePage
    {

        public WidgestPageNavBar(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement AutoCompleteNavButton => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[4]/div/ul/li[2]"));



    }
}
