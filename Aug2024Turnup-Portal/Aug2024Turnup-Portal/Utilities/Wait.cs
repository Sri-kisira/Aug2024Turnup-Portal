using Aug2024Turnup_Portal.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug2024Turnup_Portal.Utilities
{
    public class Wait
    {

        // Generic function to wait for an element to be clickable
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string LocatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));


            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorValue)));

            }
       
        
        }

        public static void WaitToBeVisible(IWebDriver driver,string LocatorType,string LocatorValue, int seconds)
        {
            var wait = WebDriverWait(driver,new TimeSpan(0, 0,5));

            if (LocatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorValue)));
            }
            if(LocatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorValue)));
            }

        }
        
    }
}






