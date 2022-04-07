using System;
//using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Support.UI;



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
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            
            //Click Adminstration dropdown list
           IWebElement administrationDropdown = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            administrationDropdown.Click();
            // Click  Time and Materials 

            IWebElement timeandmaterialsButton = driver.FindElement(By.XPath(" / html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            timeandmaterialsButton.Click();

            


            // Click Create New Button

            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewButton.Click();


            // Creating a new record for Time and Materials

            // select Materialsor Time on type code


            
            IWebElement materialtimeDrop = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            materialtimeDrop.Click();
            System.Threading.Thread.Sleep(5000);

            //materialtimeDrop.SendKeys("T");
             

            //  materialtimeDrop.Click();
            
            //IWebElement materialOption = driver.FindElement(By.XPath("//*[@id="TypeCode_option_selected"]"))








            //IWebElement typecodeTi = driver.FindElement(By.XPath("/html/body/div[5]"));


            // Click Code Textbox and enter  a valid code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("ZZZZZZZZZZZZZ02JR01");


            // Click Description  Textbox and enter a valid  Description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Des001");


            // Click Price  Textbox and enter a valid  Price

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");
                     

            // Click Save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            System.Threading.Thread.Sleep(5000);

            // Click "On  go to last page" button

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            //Check the record has been created in the table  with value

            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            actualCode.Click();

            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////



            // CHECK IF USER IS LOGGED IN SUCCESSFULLY.

           // IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

           // if ( helloHari.Text == ("Hello hari!"))
           // {

           //     Console.WriteLine("Logged in succesfully, test passed");

           // }

           // else

          //  {

         //       Console.WriteLine("Logged in unsucessfull, test failed");
         //   }




        }
    }
}
