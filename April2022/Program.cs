using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace April2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPEN CHROME BROWSER
            IWebDriver driver = new ChromeDriver();



            // LAUNCH THE PORTAL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            // IDENTIFY USERNAME  TEXTBOX AND ENTER VALID USERNAME
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // IDENTIFY PASSWORD  TEXTBOX AND ENTER VALID PASSWORD
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");


            // CLICK LOG IN BUTTON
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();



            // CHECK IF USER IS LOGGED IN SUCCESSFULLY.

            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if ( helloHari.Text == ("Hello hari!"))
            {

                Console.WriteLine("Logged in succesfully, test passed");

            }

            else

            {

                Console.WriteLine("Logged in unsucessfull, test failed");
            }




        }
    }
}
