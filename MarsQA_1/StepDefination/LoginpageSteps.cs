using MarsQA_1.Specflow_Pages.Helper;
using MarsQA_1.Specflow_Pages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAtoMars.Specflow_Pages.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.StepDefination
{
    [Binding]
    public class LoginpageSteps
    {
        IWebDriver webDriver;
        private WebDriverforClass wbdc = null;
        Loginpage loginpg =null;
        profile_language lang= null;

        [TearDown]
        protected void TearDown()
        {
            webDriver.Quit();
        }

        [Given(@"enter URL and launch page")]
        public void GivenEnterURLAndLaunchPage()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://192.168.99.100:5000/Home");
            loginpg = new Loginpage(webDriver);
        }
        [When(@"enter username password click submit")]
        public void WhenEnterUsernamePasswordClickSubmit(Table table)
        {
            loginpg.ClickSignIN();
            dynamic data = table.CreateDynamicInstance();
            loginpg.Login((string)data.Username, (string)data.Password);
        }
        [When(@"enter details click join")]
        public void WhenEnterDetailsClickJoin(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpg.Signup((string)data.FirstName, (string)data.LastName, (string)data.Email, (string)data.Password);
        }
        [Then(@"signIn with same credentials")]
        public void ThenSignInWithSameCredentials(Table table)
        {
            loginpg.ClickSignIN();
            dynamic data = table.CreateDynamicInstance();
            loginpg.Signupsame((string)data.Email, (string)data.Password);
        }
        [When(@"pop up opens click on forget password link entre the valid email id")]
        public void WhenPopUpOpensClickOnForgetPasswordLinkEntreTheValidEmailId(Table table)
        {
            loginpg.ClickSignIN();
            dynamic data = table.CreateDynamicInstance();
            loginpg.EntreTheValidEmailId((string)data.Verificationemail);
        }

        [Then(@"click on sned verification email")]
        public void ThenClickOnSnedVerificationEmail()
        {
            loginpg.ThenClickOnSnedVerificationEmail();
        }

        [Then(@"land to profile page")]
        public void ThenLandToProfilePage()
        {
            loginpg.IsProfileDisplayed();
        }

        [Then(@"validate the title")]
        public void ThenValidateTheTitle()
        {
            loginpg.IsNameDisplayed();
        }


        [When(@"click on add new then add and validate the error message")]
        public void WhenClickOnAddNewThenAddAndValidateTheErrorMessage()
        {
            loginpg.IsProfileDisplayed();
            loginpg.NoLanguageadded();
            loginpg.IsLanguageSaveDisplayed();
        }

        [Then(@"add new Language and save")]
        public void ThenAddNewLanguageAndSave()
        {
            // dynamic data = table.CreateDynamicInstance();
            loginpg.Language();
            //loginpg.IsLanguageErrorDisplayed();
        }

        [Then(@"update the language and Delete")]
        public void ThenUpdateTheLanguageAndDelete()
        {
            // dynamic data = table.CreateDynamicInstance();
            loginpg.UpdateandDeleteLanguage();
            loginpg.IsLanguageSaveDisplayed();
        }



        [When(@"click on add new skill then add and validate the error message")]
        public void WhenClickOnAddNewSkillThenAddAndValidateTheErrorMessage()
        {
            loginpg.Skillmessage();
        }

        [Then(@"add new skill and save")]
        public void ThenAddNewSkillAndSave()
        {
            //dynamic data = table.CreateDynamicInstance();
            loginpg.AddtoSkills();
        }

        [Then(@"update the Skill and Delete")]
        public void ThenUpdateTheSkillAndDelete()
        {
            //loginpg.UpdatetoSkills();
        }


        [When(@"click on add new Education then add and validate the error message")]
        public void WhenClickOnAddNewEducationThenAddAndValidateTheErrorMessage()
        {
        }

        [Then(@"add Education and save")]
        public void ThenAddEducationAndSave(Table table)
        {
        }

        [Then(@"update the Education and Delete")]
        public void ThenUpdateTheEducationAndDelete(Table table)
        {
        }

        [When(@"click on add new Certification then add and validate the error message")]
        public void WhenClickOnAddNewCertificationThenAddAndValidateTheErrorMessage()
        {
        }

        [Then(@"add Certification and save")]
        public void ThenAddCertificationAndSave(Table table)
        {
        }

        [Then(@"update the Certification and Delete")]
        public void ThenUpdateTheCertificationAndDelete(Table table)
        {
        }

        [When(@"click on add Description then add and validate the error message")]
        public void WhenClickOnAddDescriptionThenAddAndValidateTheErrorMessage()
        {
            loginpg.Description();
        }

        [When(@"Click on textarea and save")]
        public void WhenClickOnTextareaAndSave(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpg.SendDescription((string)data.Details);
        }

        [When(@"Click on avaliablity and Details")]
        public void WhenClickOnAvaliablityAndDetails()
        {
            loginpg.FillAvaliablityProfile();
        }

        [Then(@"Click on Earn and add Details")]
        public void ThenClickOnEarnAndAddDetails()
        {
            loginpg.FillEarnProfile();
        }

        [Then(@"Click on Target and add Details")]
        public void ThenClickOnTargetAndAddDetails()
        {
            loginpg.FillTargetProfile();
            loginpg.ValidateALL();
        }


        [Then(@"Signout")]
        public void ThenSignout()
        {
            loginpg.SignOut();

        }
        
    }

}
