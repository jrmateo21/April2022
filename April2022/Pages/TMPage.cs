using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using April2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace April2022
{
    internal class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click Create New Button

            //IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewButton.Click();


            // Creating a new record for Time and Materials

            // select Materials or Time on type code


            IWebElement materialtimeDrop = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            materialtimeDrop.Click();
            System.Threading.Thread.Sleep(1000);


            IWebElement materialTimeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            materialTimeOption.Click();


            

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
            Wait.WaitTobeVisible(driver, "XPATH", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]",2);
            

            // Click "On  go to last page" button

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);

            //Check the record has been created in the table  with value

            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            //Option 1

            Assert.That(actualCode.Text == "ZZZZZZZZZZZZZ02JR01", "Actual code and expected code do not much");
            Assert.That(actualTypeCode.Text == "T", "Actual type code and expected type  code do not much");
            Assert.That(actualDescription.Text == "Des001", "Actual Description and expected type  description do not much ");
            Assert.That(actualPrice.Text == "$12.00", "Actual price and expected type  price do not much ");

                
            //Assert.That
            //Option 2 

           // if (actualCode.Text == ("ZZZZZZZZZZZZZ02JR01"))
           // {

           //     Assert.Pass("Record has been created, Test Passed!");
               
           // }
           // else
           // {

          //   Assert.Fail("Record Not Found, Test Failed!");
          //  }

        }
        public void EditTM(IWebDriver driver)
        {
            // Wait till the entire Time and Material page is displayed.
            Wait.WaitTobeVisible(driver, "XPATH", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);


            // Click "On  go to last page" button

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
           // Thread.Sleep(1000);

            // Find the record if exist

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]"));

            if(findRecordCreated.Text == "ZZZZZZZZZZZZZ02JR01")
            {
                //click the Edit button
             IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
             editButton.Click();

            }
            else
            {
                Assert.Fail("Record not found");
            }
            // Edit code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("EditedZZZZZ02JR01");

            // Edit description
            IWebElement descriptionTextbox = driver.FindElement(By.Id ("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("EditedDes001");


            //Edit price

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox.Clear();
            priceTag.Click();
            priceTextbox.SendKeys("120");
            

            // Save the changes 

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitTobeVisible(driver, "XPATH", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);


        }
        public void DeleteTM(IWebDriver driver)
        {

            // Wait till the entire Time and Material page is displayed.
            Wait.WaitTobeVisible(driver, "XPATH", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);


            // Click "On  go to last page" button

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            // Thread.Sleep(1000);

            // Find the record if exist

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "EditedZZZZZ02JR01")
            {
                //click the Delete button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(1000);

                driver.SwitchTo().Alert().Accept();

            }
            else
            {
                Assert.Fail("Record to be deleted  not found");
            }
            driver.Navigate().Refresh();
            Thread.Sleep(1000);

            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(1000);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(editedCode.Text != "EditedZZZZZ02JR01", "Code record hasn't been deleted.");
            Assert.That(editedDescription.Text != "EditedDesc001", "Description record hasn't been deleted.");
            Assert.That(editedPrice.Text != "$120.00", "Price record hasn't been deleted.");
        }
        
    }

}
