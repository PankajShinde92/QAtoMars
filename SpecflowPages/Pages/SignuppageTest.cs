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
public class SignuppageTest {
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
  public void signuppage() {
    // Test name: Signuppage
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("http://192.168.99.100:5000/");
    // 2 | setWindowSize | 1473x997 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1473, 997);
    // 3 | click | css=.green | 
    driver.FindElement(By.CssSelector(".green")).Click();
    // 4 | click | name=firstName | 
    driver.FindElement(By.Name("firstName")).Click();
    // 5 | type | name=firstName | disha
    driver.FindElement(By.Name("firstName")).SendKeys("disha");
    // 6 | click | name=lastName | 
    driver.FindElement(By.Name("lastName")).Click();
    // 7 | type | name=lastName | khilari
    driver.FindElement(By.Name("lastName")).SendKeys("khilari");
    // 8 | click | name=email | 
    driver.FindElement(By.Name("email")).Click();
    // 9 | type | name=email | dishali@gmail.com
    driver.FindElement(By.Name("email")).SendKeys("dishali@gmail.com");
    // 10 | click | name=password | 
    driver.FindElement(By.Name("password")).Click();
    // 11 | type | name=password | ABCabc123
    driver.FindElement(By.Name("password")).SendKeys("ABCabc123");
    // 12 | click | name=confirmPassword | 
    driver.FindElement(By.Name("confirmPassword")).Click();
    // 13 | type | name=confirmPassword | ABCabc123
    driver.FindElement(By.Name("confirmPassword")).SendKeys("ABCabc123");
    // 14 | click | name=terms | 
    driver.FindElement(By.Name("terms")).Click();
    // 15 | click | id=submit-btn | 
    driver.FindElement(By.Id("submit-btn")).Click();
    // 16 | click | linkText=Sign In | 
    driver.FindElement(By.LinkText("Sign In")).Click();
    // 17 | click | name=email | 
    driver.FindElement(By.Name("email")).Click();
    // 18 | type | name=email | dishali@gmail.com
    driver.FindElement(By.Name("email")).SendKeys("dishali@gmail.com");
    // 19 | click | name=password | 
    driver.FindElement(By.Name("password")).Click();
    // 20 | type | name=password | ABCabc123
    driver.FindElement(By.Name("password")).SendKeys("ABCabc123");
    // 21 | click | name=rememberDetails | 
    driver.FindElement(By.Name("rememberDetails")).Click();
    // 22 | click | css=.fluid | 
    driver.FindElement(By.CssSelector(".fluid")).Click();
    // 23 | click | linkText=Profile | 
    driver.FindElement(By.LinkText("Profile")).Click();
    // 24 | click | css=.item:nth-child(4) > .ui | 
    driver.FindElement(By.CssSelector(".item:nth-child(4) > .ui")).Click();
  }
}
