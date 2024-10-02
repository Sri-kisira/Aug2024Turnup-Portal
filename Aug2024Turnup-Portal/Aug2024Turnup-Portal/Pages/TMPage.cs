using Aug2024Turnup_Portal.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug2024Turnup_Portal.Pages
{
    public class TMpage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            // Click on create New Button
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNewButton.Click();
            Thread.Sleep(1000);
            // Select Time from Dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);
            IWebElement timeOptions = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOptions.Click();
            Thread.Sleep(1000);

            String codeValue = generateRandomString();

            // Type code into code textbox
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys(codeValue);

            // Type description into Description testbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("This is a description");

            //  Type price into price textbox
            IWebElement PriceTagOverLap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTagOverLap.Click();

            IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
            PriceTextbox.SendKeys("12");

            Wait.WaitToBeClickable(driver, "Id", "SaveButton ", 3);
            
        

            // Click on Save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(3000);

            //  Check if Time record has been created successfully  
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == codeValue)
            {
                Console.WriteLine("time record created successfully");
            }
            else
            {
                Console.WriteLine("new time record has not been created!");
            }

        }
      public void EditTimeRecord(IWebDriver driver)
        {// Edit time record
            String codeValue = generateRandomString();
        IWebElement editButton = driver.FindElement(By.XPath("//td[contains(text(),'" + codeValue + "')]/following-sibling::td[4]/a[contains(text(), 'Edit')]"));


            Thread.Sleep(2000);
            editButton.Click();
            Thread.Sleep(3000);
            IWebElement CodeTextboxEdit = driver.FindElement(By.Id("Code"));
            IWebElement descriptionTextboxEdit = driver.FindElement(By.Id("Description"));
            IWebElement PriceTextboxEdit = driver.FindElement(By.XPath("//input[@id='Price']/preceding-sibling::input"));
            IWebElement EditSaveButton = driver.FindElement(By.Id("SaveButton"));
            CodeTextboxEdit.Clear();
            CodeTextboxEdit.SendKeys(codeValue + " Edited");
            descriptionTextboxEdit.Clear();
            descriptionTextboxEdit.SendKeys("editing description");
            Thread.Sleep(3000);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='55';", PriceTextboxEdit);
            EditSaveButton.Click();
            Thread.Sleep(2000);

        }
        public void DeleteTimeRecord(IWebDriver driver)
        {//DeleteTimeRecord
            String codeValue = generateRandomString();
            IWebElement goToLastPageButtonAfterEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAfterEdit.Click();
            Thread.Sleep(3000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//td[contains(text(),'" + codeValue + " Edited')]/following-sibling::td[4]/a[contains(text(), 'Delete')]"));
            deleteButton.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            driver.Close();
        }
        public String generateRandomString()
        { 
            Random rand = new Random();

            // Choosing the size of string 
            // Using Next() string 
            int stringlen = rand.Next(4, 10);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {

                // Generating a random number. 
                randValue = rand.Next(0, 26);

                // Generating random character by converting 
                // the random number into character. 
                letter = Convert.ToChar(randValue + 65);

                // Appending the letter to string. 
                str = str + letter;
            }
            Console.Write("Random String:" + str);
            return str;
        }






        

        

    }


} 



    
      
   






