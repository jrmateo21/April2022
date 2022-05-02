using System;
using April2022.Pages;
using April2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace April2022.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions  : CommonDriver
    {
        LoginPage loginPageObject = new LoginPage();
        HomePage homePageObject = new HomePage();
        TMPage tmPageObject = new TMPage();

        [Given(@"I logged into turn up portal successfully\.")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully_()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            // Login  Page Object Initialization and definition 
            
            loginPageObject.LoginSteps(driver);

            
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home Page Object Initialization and definition 
           
            homePageObject.GoToTMPage(driver);


        }

        [When(@"I create a new time and  material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            
            tmPageObject.CreateTM(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObject = new TMPage();

            string newCode = tmPageObject.GetCode(driver);
            string newTypecode = tmPageObject.GetTypecode(driver);
            string newDescription = tmPageObject.GetDescrption(driver);
            string newPrice = tmPageObject.GetPrice(driver);


            Assert.That(newCode == "ZZZZZZZZZZZZZ02JR01", "Actual code and expected code do not match");
            Assert.That(newTypecode == "T", "Actual type code and expected type code do not match.");
            Assert.That(newDescription == "Des001", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match.");
                
        }


        [When(@"I update '([^']*)', '([^']*)' and '([^']*)'  a new time and  material record")]
        public void WhenIUpdateAndANewTimeAndMaterialRecord(string p0,string p1,string p2)
        {
            tmPageObject.EditTM(driver, p0,p1,p2);

        }


        [Then(@"the record should have the update '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdateAnd(string p0,string p1,string p2)
        {
            
            string editedDescription = tmPageObject.GetEditedDescription(driver);
            string editedCode = tmPageObject.GetEditedCode(driver);
            string editedPrice = tmPageObject.GetEditedPrice(driver);

            Assert.That(editedDescription == p0, "Actual description and expected description do not match.");
            Assert.That(editedCode == p1, "Actual code and expected code do not match.");
            Assert.That(editedPrice == p2, "Actual price and expected price do not match");



        }


    }
}
