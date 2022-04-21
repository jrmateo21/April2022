using System;
using April2022.Pages;
using April2022.Utilities;
using NUnit.Framework;
//using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Support.UI;



namespace April2022.Tests

{ 
    [TestFixture]
    internal class TM_Tests : CommonDriver
    {   
        [SetUp]
        public void LoginFunction()
        {
            //  OPEN CHROME BROWSER

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            // Login  Page Object Initialization and definition 
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginSteps(driver);

            // Home Page Object Initialization and definition 
            HomePage homePageObject = new HomePage();
            homePageObject.GoToTMPage(driver);
        }
        [Test, Order(1) ]
        public void CreateTM_test()
        {

            //  Time and Material /TM  Page Object Initialization and definition 
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTM(driver);


        }
            
        [Test, Order(2)]
        public void EditTM_test()
        {
            // Edit Time and Material /TM
            TMPage tmPageObject = new TMPage();
            tmPageObject.EditTM(driver, "Dummy1", "Dummy2", "Dummy3");
        }
        [Test, Order(3)]
        public void DeleteTM_test()
        {


            // Delete Time and Material /TM
            TMPage tmPageObject = new TMPage();
            tmPageObject.DeleteTM(driver);

        }
        [TearDown]
        public void ClosedTestRun()
        {
            driver.Quit();
        }




    }
}
