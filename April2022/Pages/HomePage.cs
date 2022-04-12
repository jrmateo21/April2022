using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace April2022.Pages
{
    internal class HomePage
    {
       public void GoToTMPage(IWebDriver driver)


       { //Click Adminstration dropdown list

        IWebElement administrationDropdown = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
        administrationDropdown.Click();

            // Click  Time and Materials 

        IWebElement timeandmaterialsButton = driver.FindElement(By.XPath(" / html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
        timeandmaterialsButton.Click();
        }
    }
}
