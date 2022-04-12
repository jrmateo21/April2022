using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace April2022.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            // LAUNCH THE PORTAL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
           

            // IDENTIFY USERNAME  TEXTBOX AND ENTER VALID USERNAME
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // IDENTIFY PASSWORD  TEXTBOX AND ENTER VALID PASSWORD
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");


            // CLICK LOG IN BUTTON
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            // Check if user is logged in sucessfully 
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

        }
    }
}
