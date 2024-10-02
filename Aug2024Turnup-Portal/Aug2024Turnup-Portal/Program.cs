using Aug2024Turnup_Portal.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System.Net;
using System.Xml.Serialization;

public class Program
{
    private static void Main(String[] args)
    {
        // Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        //Login page object initialization and definition
        Loginpage loginpage = new Loginpage();
        loginpage.LoginActions(driver);
       
        //Home Page object initialization and definition
        Homepage homepageObj  = new Homepage();
        homepageObj.NavigateToTMPage(driver);

        //TM page object initialization and definition
        TMpage tmpageObj = new TMpage();
        tmpageObj.CreateTimeRecord(driver);


        //Edit time record 
        tmpageObj.EditTimeRecord(driver);
        

        //Deleate time record
        tmpageObj.DeleteTimeRecord(driver);
        


        

        




    }

}
   
       




            




        

        


    
    
    
























































































































































