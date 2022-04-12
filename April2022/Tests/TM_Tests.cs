using System;
using April2022.Pages;
//using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Support.UI;



namespace April2022
{ 
    internal class TM_Tests
    {
        static void Main(string[] args)
        {
            //  OPEN CHROME BROWSER

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            // Login  Page Object Initialization and definition 
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginSteps(driver);

            // Home Page Obeject Initialization and definition 
            HomePage homePageObject = new HomePage();
            homePageObject.GoToTMPage(driver);

            //  Time and Material /TM  Page Object Initialization and definition 
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTM(driver);

            // Edit Time and Material /TM
            tmPageObject.EditTM(driver);

            // Delete Time and Material /TM

            tmPageObject.DeleteTM(driver);


        }
    }
}
