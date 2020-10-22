using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography.X509Certificates;
using QAtoMars;
using System.Diagnostics;

namespace MarsQA_1.Specflow_Pages.Pages
{
    class Loginpage
    {
        

        public IWebDriver Webdriver { get; }
        public Loginpage(IWebDriver webdriver)
        {
            Webdriver = webdriver;
        }

        
        //------------- Global declaration of common used element for Error messages. ---------------
        public IWebElement Message => Webdriver.FindElement(By.CssSelector(".ns-box-inner"));
        WebDriverWait wait => new WebDriverWait(Webdriver, TimeSpan.FromSeconds(10));

       

        // ---------------------------- Signup page ----------------------------

        public void Signup(String FirstName, String LastName, String Email, String Password)//enter username and password by using data set
        {  //Webelements for login page

         
            Webdriver.FindElement(By.CssSelector(".green")).Click();
            Webdriver.FindElement(By.Name("firstName")).Click();
            Webdriver.FindElement(By.Name("firstName")).SendKeys(FirstName);
            Webdriver.FindElement(By.Name("lastName")).Click();
            Webdriver.FindElement(By.Name("lastName")).SendKeys(LastName);
            Webdriver.FindElement(By.Name("email")).Click();
            Webdriver.FindElement(By.Name("email")).SendKeys(Email);
            Webdriver.FindElement(By.Name("password")).Click();
            Webdriver.FindElement(By.Name("password")).SendKeys(Password);
            Webdriver.FindElement(By.Name("confirmPassword")).Click();
            Webdriver.FindElement(By.Name("confirmPassword")).SendKeys(Password);
            Webdriver.FindElement(By.Name("terms")).Click();
            Webdriver.FindElement(By.Id("submit-btn")).Click();
            Thread.Sleep(5000);
            Webdriver.FindElement(By.CssSelector(".ns-close")).Click();

        }

        public void ClickSignIN()
        {
            IWebElement linkLogin = Webdriver.FindElement(By.LinkText("Sign In"));
            linkLogin.Click();
            //Click on Sign button to enter username and password
        }

        public void Signupsame(String Email, String Password)//enter username and password by using data set
        {
            //Webelements for login page
            Webdriver.FindElement(By.Name("email")).Click();
            Webdriver.FindElement(By.Name("email")).SendKeys(Email);
            Webdriver.FindElement(By.Name("password")).Click();
            Webdriver.FindElement(By.Name("password")).SendKeys(Password);
            Webdriver.FindElement(By.Name("rememberDetails")).Click();             //Click on Remember me
            Webdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

        }

            // ---------------------------- login page ----------------------------
        public void Login(String Username, String Password)//enter username and password by using data set
        {
            //Webelements for login page
            Webdriver.FindElement(By.Name("email")).Click();
            Webdriver.FindElement(By.Name("email")).SendKeys(Username);
            Webdriver.FindElement(By.Name("password")).Click();
            Webdriver.FindElement(By.Name("password")).SendKeys(Password);
            Webdriver.FindElement(By.Name("rememberDetails")).Click();             //Click on Remember me
            Webdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }


        
        public void EntreTheValidEmailId( String Verificationemail)
        {
            Webdriver.FindElement(By.ClassName("pointerCursor")).Click();
            Webdriver.FindElement(By.Name("email")).SendKeys(Verificationemail);
        }
        public void ThenClickOnSnedVerificationEmail()
        {
            Thread.Sleep(4000);
            Webdriver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div/div[2]/div")).Click();
            Assert.That(Webdriver.FindElement(By.CssSelector(".large > div")).Text, Is.EqualTo("A recovery link has been sent to your inbox.\r\nPlease use the link to recover your account."));
        }


        public void IsProfileDisplayed() {
            Thread.Sleep(4000);
            Webdriver.FindElement(By.LinkText("Profile")).Click();
            Assert.That(Webdriver.FindElement(By.LinkText("Profile")).Text, Is.EqualTo("Profile"));
        }
       
        public void IsNameDisplayed()
        {
            Thread.Sleep(4000);
            Webdriver.FindElement(By.CssSelector(".dividing")).Click();
            Assert.That(Webdriver.FindElement(By.CssSelector(".dividing")).Text, Is.EqualTo("Description"));
        }
        
        //---------------------------- profile page Description Section ----------------------------
        public void Description()
        {
            //Webelements for profile page Description Section
            Thread.Sleep(5000);
            Webdriver.FindElement(By.CssSelector(".dividing")).Click();
            Webdriver.FindElement(By.XPath("//h3/span/i")).Click();
            Thread.Sleep(1000);
            Webdriver.FindElement(By.CssSelector(".teal:nth-child(3)")).Click();
            Thread.Sleep(3000);
            Webdriver.FindElement(By.CssSelector(".ns-close")).Click();
           
        }
         public bool IsDescripErrorDisplayed() => Message.Displayed;
        public void SendDescription(String Details)
        {
            Thread.Sleep(5000);
            Webdriver.FindElement(By.XPath("//h3/span/i")).Click();
            Webdriver.FindElement(By.Name("value")).Click();
            Webdriver.FindElement(By.Name("value")).SendKeys(Keys.Backspace);
            Webdriver.FindElement(By.Name("value")).SendKeys(Details);
            Webdriver.FindElement(By.CssSelector(".teal:nth-child(3)")).Click();
            Thread.Sleep(5000);
            Webdriver.FindElement(By.CssSelector(".ns-close")).Click();
        }

        // ---------------------------- profile page Language Section ----------------------------
        public void NoLanguageadded()
        {
            Thread.Sleep(2000);
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


          Debug.WriteLine("first name: " + ExcelOperations.ReadData(1, "LANGUAGE"));
            Debug.WriteLine("first name: " + ExcelOperations.ReadData(1, "LEVEL"));

           
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

               /*Thread.Sleep(2000);
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
                Thread.Sleep(2000);*/

            }

            /*Thread.Sleep(2000);
            Webdriver.FindElement(By.LinkText("Languages")).Click();
            Webdriver.FindElement(By.CssSelector("tbody:nth-child(2) .outline")).Click();
            Webdriver.FindElement(By.CssSelector(".fields > .five:nth-child(1)")).Click();
            Webdriver.FindElement(By.Name("name")).SendKeys();
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


        //---------------------------- profile page Skills Section ----------------------------

        public void Skillmessage()
        {
            new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Webdriver.FindElement(By.XPath("//a[text()='Skills']")).Click();
            new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Webdriver.FindElement(By.LinkText("Skills")).Click();
            Webdriver.FindElement(By.CssSelector(".ui:nth-child(3) .ui .ui")).Click();//addnew button
            Webdriver.FindElement(By.CssSelector(".buttons-wrapper > .teal")).Click();
            Webdriver.FindElement(By.CssSelector(".ns-box-inner")).Click();
            {
                var element = Webdriver.FindElement(By.CssSelector(".ns-close"));
                Actions builder = new Actions(Webdriver);
                builder.DoubleClick(element).Perform();
            }
            Webdriver.FindElement(By.XPath("//span/input[2]")).Click();
        }
        

        public void AddtoSkills()
        {


            //Find the Skill
            new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Webdriver.FindElement(By.LinkText("Skills")).Click();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ExcelOperations.PopulateInCollection(@"C:\Users\Elias\Documents\Project_workspace\QAtoMars\skills.xlsx");

            int i;
            for (i = 1; i <= ExcelOperations.GetTotalRowCount(); i++)

            {
                Console.WriteLine(ExcelOperations.GetTotalRowCount());

                //Thread.Sleep(3000);
                Webdriver.FindElement(By.CssSelector(".ui:nth-child(3) .ui .ui")).Click();//addnew button
                Thread.Sleep(1000);

                Webdriver.FindElement(By.XPath("//div[2]/div/div/div/input")).SendKeys(ExcelOperations.ReadData(i, "SKILLS"));

                Webdriver.FindElement(By.Name("level")).Click();
                {
                    var dropdown = Webdriver.FindElement(By.Name("level"));
                    String level = ExcelOperations.ReadData(i, "LEVEL");
                    dropdown.FindElement(By.XPath("//option[. = '"+level+"']")).Click();
                }
                // 11 | click | name=level | 
                Webdriver.FindElement(By.Name("level")).Click();
                Thread.Sleep(2000);
                Webdriver.FindElement(By.XPath("//span/input")).Click();

            }




/*
                //Find the Add new button
                new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Webdriver.FindElement(By.CssSelector(".ui:nth-child(3) .ui .ui")).Click();//addnew button
            //Enter Skill
            Thread.Sleep(2000);
            IWebElement SkillOn = Webdriver.FindElement(By.XPath("//input[@name='name']"));
            SkillOn.SendKeys("");

            //Select dropdown
            Webdriver.FindElement(By.Name("level")).Click();
            {
                IWebElement dropdow = Webdriver.FindElement(By.Name("level"));
                dropdow.FindElement(By.XPath("//option[. = 'Intermediate']")).Click();
            }

            //Add Skill
            Webdriver.FindElement(By.Name("level")).Click();
            Webdriver.FindElement(By.CssSelector(".buttons-wrapper 1 .teal")).Click();


            //Find the Add new button
            new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Webdriver.FindElement(By.XPath("//th[text()='Skill']//parent::tr//following-sibling::th[@class='right aligned']//div[@class='ui teal button']")).Click();

            //Enter Skill
            Thread.Sleep(2000);
            IWebElement SkillTw = Webdriver.FindElement(By.Name("name"));
            SkillTw.SendKeys("");

            //Select dropdown
            Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
            Webdriver.FindElement(By.XPath("//option[text()='Beginner']")).Click();

            //Add Skill
            Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
*/




            //Find the Skill
            /*new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Webdriver.FindElement(By.XPath("//a[text()='Skills']")).Click();

            new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            IWebElement Addskills = Webdriver.FindElement(By.XPath("//th[text()='Skill']//parent::tr//following-sibling::th[@class='right aligned']//div[@class='ui teal button']"));
            IWebElement Skills = Webdriver.FindElement(By.Name("name"));
            IWebElement dropdown = Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            IWebElement Beginner =Webdriver.FindElement(By.XPath("//option[text()='Beginner']"));
            IWebElement Addbutton = Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

            Addskills.Click();
            Skills.SendKeys();             //Enter Skill 1
            dropdown.Click();
            Beginner.Click();
            Addbutton.Click();

            Thread.Sleep(2000);
            Skills.SendKeys();             //Enter Skill 2
            dropdown.Click();
            Beginner.Click();
            Addbutton.Click();*/   
        }

        public void UpdatetoSkills()
        {

            int i;
            for (i = 2; i <= 5; i++)

            {
                Thread.Sleep(2000);
                Webdriver.FindElement(By.CssSelector("=tbody:nth-child(2) .outline")).Click();
                Webdriver.FindElement(By.CssSelector("=td .five > input")).Click();
                Webdriver.FindElement(By.CssSelector("=td .five > input")).Clear();

                Webdriver.FindElement(By.Name("name")).SendKeys(ExcelOperations.ReadData(i, "SKILLS"));
                Console.WriteLine(ExcelOperations.ReadData(i, "SKILLS"));
                Webdriver.FindElement(By.Name("level")).Click();

                {
                    var dropdown = Webdriver.FindElement(By.Name("level"));
                    String level = ExcelOperations.ReadData(++i, "LEVEL");
                    dropdown.FindElement(By.XPath("//option[. = '" + level + "']")).Click();
                }
                Webdriver.FindElement(By.Name("level")).Click();
                Thread.Sleep(2000);
                Webdriver.FindElement(By.XPath("//span/input")).Click();
            }



                /*Thread.Sleep(2000);
                Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
                Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Click();
                Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();
                Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("");

                //Select dropdown
                Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")).Click();
                Webdriver.FindElement(By.XPath("//option[text()='Intermediate']")).Click();

                //click on the update button
                Webdriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
                new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='Creativity']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
                Webdriver.FindElement(By.XPath("//td[text()='Creativity']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();
    */
            }
        //---------------------------- profile page Education Section ----------------------------
        public void Eductaion()
        { }
        // ---------------------------- profile page Certification Section ----------------------------
        public void Certification()
        { }



        //----------------------------   profile page Availability Section -----------------------------
        public void FillAvaliablityProfile()
        {
            //Webelements for profile page Avaliablity Section
            Thread.Sleep(2000);
          //  new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".item:nth-child(2) > .right .right")));

            Webdriver.FindElement(By.CssSelector(".item:nth-child(2) > .right .right")).Click();
            Webdriver.FindElement(By.Name("availabiltyType")).Click();
            Webdriver.FindElement(By.CssSelector(".remove:nth-child(2)")).Click(); //Close dropdown
        }
       // public bool IsFillProfileDisplayed() => Message.Displayed;
        public void FillEarnProfile()
        {
           // Thread.Sleep(2000);
          //  new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".item:nth-child(3) > .right .right")));

            Webdriver.FindElement(By.CssSelector(".item:nth-child(3) > .right .right")).Click();
            Webdriver.FindElement(By.Name("availabiltyHour")).Click();
            Webdriver.FindElement(By.CssSelector(".remove:nth-child(2)")).Click();
        }
       // public bool IsFillEarnDisplayed() => Message.Displayed;
        public void FillTargetProfile()
        {
           // new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".item:nth-child(4) > .right .right")));

            Webdriver.FindElement(By.CssSelector(".item:nth-child(4) > .right .right")).Click();
            Webdriver.FindElement(By.Name("availabiltyTarget")).Click();
            Webdriver.FindElement(By.CssSelector(".remove:nth-child(2)")).Click();
        }
       // public bool IsFillTargetDisplayed() => Message.Displayed;
        public void ValidateALL()
        {
            Webdriver.FindElement(By.CssSelector(".eight:nth-child(3)")).Click();
            Assert.That(Webdriver.FindElement(By.XPath("//span[contains(.,\'Part Time\')]")).Text, Is.EqualTo("Part Time"));
            Assert.That(Webdriver.FindElement(By.XPath("//span[contains(.,\'More than 30hours a week\')]")).Text, Is.EqualTo("More than 30hours a week"));
            Assert.That(Webdriver.FindElement(By.XPath("//span[contains(.,\'More than $1000 per month\')]")).Text, Is.EqualTo("More than $1000 per month"));


        }

        //Signout Section
        public void SignOut()
            {
            new WebDriverWait(Webdriver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".item:nth-child(4) > .ui")));
           Webdriver.FindElement(By.CssSelector(".item:nth-child(4) > .ui")).Click();
             }

    }
}
