﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatePicker.Pages
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement Widget => Driver.FindElement(By.XPath("//*[normalize-space(text())='Widgets']/ancestor::div[contains(@class, 'top-card')]"));

    }
}
