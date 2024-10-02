using Aug2024Turnup_Portal.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug2024Turnup_Portal.Pages
{
    public class Loginpage
    { 
        //functions that allow user to login to Turnup portal
        public void LoginActions(IWebDriver driver)
        {
            // Lanunch TurnnabUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            // Identify username Textbox and enter valid username
            IWebElement userNameTextbox = driver.FindElement(By.Id("UserName"));
            userNameTextbox.SendKeys("hari");

            Wait.WaitToBeVisible(driver, "Password", 7);

            // Identify Password textbox and enter valid password 
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);
            
        }
       

    }
}
