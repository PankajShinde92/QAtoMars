// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class PageDetailsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void pageDetails() {
    // Test name: PageDetails
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("http://192.168.99.100:5000/");
    // 2 | setWindowSize | 1473x997 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1473, 997);
    // 3 | click | linkText=Sign In | 
    driver.FindElement(By.LinkText("Sign In")).Click();
    // 4 | click | name=email | 
    driver.FindElement(By.Name("email")).Click();
    // 5 | type | name=email | pankajosplabs@gmail.com
    driver.FindElement(By.Name("email")).SendKeys("pankajosplabs@gmail.com");
    // 6 | type | name=password | Pankaj123
    driver.FindElement(By.Name("password")).SendKeys("Pankaj123");
    // 7 | click | name=rememberDetails | 
    driver.FindElement(By.Name("rememberDetails")).Click();
    // 8 | click | css=.fluid | 
    driver.FindElement(By.CssSelector(".fluid")).Click();
    // 9 | click | css=.title > .dropdown | 
    driver.FindElement(By.CssSelector(".title > .dropdown")).Click();
    // 10 | type | name=firstName | Pankaj
    driver.FindElement(By.Name("firstName")).SendKeys("Pankaj");
    // 11 | type | name=lastName | Shinde
    driver.FindElement(By.Name("lastName")).SendKeys("Shinde");
    // 12 | click | css=div > .teal | 
    driver.FindElement(By.CssSelector("div > .teal")).Click();
    // 13 | click | css=.item:nth-child(2) > .right .right | 
    driver.FindElement(By.CssSelector(".item:nth-child(2) > .right .right")).Click();
    // 14 | click | name=availabiltyType | 
    driver.FindElement(By.Name("availabiltyType")).Click();
    // 15 | click | css=.remove:nth-child(2) | 
    driver.FindElement(By.CssSelector(".remove:nth-child(2)")).Click();
    // 16 | click | css=.item:nth-child(3) > .right .right | 
    driver.FindElement(By.CssSelector(".item:nth-child(3) > .right .right")).Click();
    // 17 | click | name=availabiltyHour | 
    driver.FindElement(By.Name("availabiltyHour")).Click();
    // 18 | click | css=.remove:nth-child(2) | 
    driver.FindElement(By.CssSelector(".remove:nth-child(2)")).Click();
    // 19 | click | css=.item:nth-child(4) > .right .right | 
    driver.FindElement(By.CssSelector(".item:nth-child(4) > .right .right")).Click();
    // 20 | click | name=availabiltyTarget | 
    driver.FindElement(By.Name("availabiltyTarget")).Click();
    // 21 | click | css=.remove:nth-child(2) | 
    driver.FindElement(By.CssSelector(".remove:nth-child(2)")).Click();
    // 22 | click | css=.item:nth-child(4) > .ui | 
    driver.FindElement(By.CssSelector(".item:nth-child(4) > .ui")).Click();
  }
}