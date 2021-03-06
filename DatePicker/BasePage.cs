﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatePicker
{

    public class BasePage
    {


        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Actions = new Actions(driver);
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        public IWebDriver Driver { get; private set; }
        public Actions Actions { get; private set; }
        public WebDriverWait Wait { get; set; }


        public void ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }



    }



}
