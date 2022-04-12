using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace April2022.Utilities
{
    internal class Wait
    {
        public static void WaitoBeClikable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 2, seconds));
            if (locator == "XPATH")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }

        }


        public static void WaitTobeVisible(IWebDriver driver, string locator, string locatorValue, int seconds)
         {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 2, seconds));
            if (locator == "XPATH")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }   
    }  
}
