using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace QAtoMars.Specflow_Pages.Pages
{
    class profile_language
    {

        public IWebDriver Webdriver { get; }
        public profile_language(IWebDriver webdriver)
        {
            Webdriver = webdriver;
        }

        public void IsProfileDisplayed()
        {
            Thread.Sleep(4000);
            Webdriver.FindElement(By.LinkText("Profile")).Click();
            Assert.That(Webdriver.FindElement(By.LinkText("Profile")).Text, Is.EqualTo("Profile"));
        }

        public IWebElement Message => Webdriver.FindElement(By.CssSelector(".ns-box-inner"));
        WebDriverWait wait => new WebDriverWait(Webdriver, TimeSpan.FromSeconds(10));
        public void NoLanguageadded()
        {


            Thread.Sleep(4000);
            Webdriver.FindElement(By.LinkText("Languages")).Click();
            Webdriver.FindElement(By.CssSelector(".ui:nth-child(2) > .row .ui .ui")).Click();
            Webdriver.FindElement(By.CssSelector(".six > .teal")).Click();
            Webdriver.FindElement(By.CssSelector(".button:nth-child(2)")).Click();
            Thread.Sleep(2000);
            Webdriver.FindElement(By.CssSelector(".ns-close")).Click();
            
        }
        public bool IsLanguageErrorDisplayed() => Message.Displayed;

        public void Language()
        {
            //Webelements for profile page Language Section
            Thread.Sleep(2000);
            Webdriver.FindElement(By.LinkText("Languages")).Click();
            Thread.Sleep(2000);


            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ExcelOperations.PopulateInCollection(@"C:\Users\Elias\Documents\Project_workspace\QAtoMars\Book1.xlsx");


          


             int i;
            for (i = 1; i <=4 ; i++)

            {
                Webdriver.FindElement(By.CssSelector(".ui:nth-child(2) > .row .ui .ui")).Click();
                Thread.Sleep(2000);
                Webdriver.FindElement(By.Name("name")).SendKeys(ExcelOperations.ReadData(i, "LANGUAGE"));
                Webdriver.FindElement(By.Name("level")).Click();
            {
                var dropdown = Webdriver.FindElement(By.Name("level"));
                String  Level = ExcelOperations.ReadData(i, "LEVEL");
                dropdown.FindElement(By.XPath("//option[. = '"+Level+"']")).Click();
            }
                //Webdriver.FindElement(By.Name("level")).Click();
                Webdriver.FindElement(By.CssSelector(".six > .teal")).Click();
                Thread.Sleep(1000);
                Webdriver.FindElement(By.CssSelector(".ns-close")).Click();

            }

        }
        public bool IsLanguageSaveDisplayed() => Message.Displayed;

        public void UpdateandDeleteLanguage()
        {

            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //ExcelOperations.PopulateInCollection(@"C:\Users\Elias\Documents\Project_workspace\QAtoMars\Book1.xlsx");
            int i;
            for (i = 2; i <= 5; i++)

            {
                Thread.Sleep(2000);
                Webdriver.FindElement(By.CssSelector(".ui:nth-child(2) > .row:nth-child(1) tbody:nth-child(2) .outline:nth-child(1)")).Click();
                Webdriver.FindElement(By.Name("name")).Clear();

                Console.WriteLine("this is console:" +ExcelOperations.ReadData(i, "LANGUAGE"));
                Webdriver.FindElement(By.Name("name")).SendKeys(ExcelOperations.ReadData(i, "LANGUAGE"));
                Console.WriteLine(ExcelOperations.ReadData(i, "LANGUAGE"));
                Webdriver.FindElement(By.Name("level")).Click();
                {
                    var dropdown = Webdriver.FindElement(By.Name("level"));
                    String Level = ExcelOperations.ReadData(++i, "LEVEL");
                    dropdown.FindElement(By.XPath("//option[. = '" + Level + "']")).Click();
                    i--;
                }
                Webdriver.FindElement(By.XPath("//span/input")).Click();
                Thread.Sleep(2000);
                Webdriver.FindElement(By.XPath("//span[2]/i")).Click();
                Console.WriteLine("this is console:" + ExcelOperations.ReadData(i, "LANGUAGE"));
              //  Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]")).Click();
                //Assert.That(Webdriver.FindElement(By.CssSelector("input#text[type=’text’]")).Text, Is.EqualTo(ExcelOperations.ReadData(i, "LANGUAGE")));

                //driver.FindElement(By.XPath("//*[contains(., 'TextToFind')]"));

                //*Thread.Sleep(2000);
                 Webdriver.FindElement(By.LinkText("Languages")).Click();
                Webdriver.FindElement(By.CssSelector("tbody:nth-child(2) .outline")).Click();
                Webdriver.FindElement(By.CssSelector(".fields > .five:nth-child("+i+")")).Click();
                Webdriver.FindElement(By.Name("name")).SendKeys(ExcelOperations.ReadData(i, "LANGUAGE"));
                Webdriver.FindElement(By.Name("level")).Click();
                {
                    var dropdown = Webdriver.FindElement(By.Name("level")); 
                    String Level = ExcelOperations.ReadData(++i, "LEVEL");
                    dropdown.FindElement(By.XPath("//option[. = '" + Level + "']")).Click();
                }
                Webdriver.FindElement(By.Name("level")).Click();
                Webdriver.FindElement(By.CssSelector(".buttons-wrapper > .teal")).Click();
                Thread.Sleep(2000);


            }

            //*Thread.Sleep(2000);
           /* Webdriver.FindElement(By.LinkText("Languages")).Click();
            Webdriver.FindElement(By.CssSelector("tbody:nth-child(2) .outline")).Click();
            Webdriver.FindElement(By.CssSelector(".fields > .five:nth-child(1)")).Click();
            Webdriver.FindElement(By.Name("name")).SendKeys(UpadtedLanguagename);
            Webdriver.FindElement(By.Name("level")).Click();
            {
                var dropdown = Webdriver.FindElement(By.Name("level"));
                dropdown.FindElement(By.XPath("//option[. = 'Conversational']")).Click();
            }
            Webdriver.FindElement(By.Name("level")).Click();
            Webdriver.FindElement(By.CssSelector(".buttons-wrapper > .teal")).Click();
            Thread.Sleep(2000);
            Webdriver.FindElement(By.LinkText("Languages")).Click();
            Webdriver.FindElement(By.CssSelector("tbody:nth-child(2) .remove")).Click();
            Thread.Sleep(2000);
            Webdriver.FindElement(By.CssSelector(".remove")).Click();
            Webdriver.FindElement(By.LinkText("Languages")).Click();
            Thread.Sleep(2000);*/
        }

    }
}
