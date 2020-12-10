using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCompleateTask.Pages
{
    public class AutoCompleatePage : BasePage
    {

        public AutoCompleatePage(IWebDriver driver)
            : base(driver)
        {

        }


        public IWebElement SingleColorInputField => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[2]/div/div/div/div/div[1]"));

        public IWebElement outputTextElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[2]/div/div/div"));

        public void inputText()
        {
            Actions.SendKeys("re").Perform();
        }

    }
}
