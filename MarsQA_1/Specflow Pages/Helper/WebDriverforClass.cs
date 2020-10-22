using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA_1.Specflow_Pages.Helper
{
    class WebDriverforClass
    {
        public IWebDriver webDriver;

        [OneTimeSetUp]
        public void Webdriver( )
        {
            webDriver = new ChromeDriver();
        }
        [OneTimeSetUp]
        public void OpenURL()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://192.168.99.100:5000/Home");


        }
    }
}
