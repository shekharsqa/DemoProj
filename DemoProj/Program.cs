using System;  
using OpenQA.Selenium;  
using OpenQA.Selenium.Chrome;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading;  
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace DemoProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Program.cs file Code");

            Console.Write("SQA- test case 1 started ");  

            //ChromeOptions options = new ChromeOptions();//optional
            // options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //IWebDriver c_driver = new ChromeDriver("C:/Users/lenovo/Documents/Webdriver", options);
            //IWebDriver c_driver = new ChromeDriver("E:/Vyas_Dev/ReadySeleniumProjects/Selenium_c#/DriversAndJars/Drivers");
            //IWebDriver driver = new ChromeDriver();  
            //create the reference for the browser  
            //IWebDriver driver = new ChromeDriver("E:/Vyas_Dev/ReadySeleniumProjects/Selenium_c#/DriversAndJars/Drivers");

            // ChromeOptions options = new ChromeOptions();//optional
            // IWebDriver driver = new ChromeDriver("E:/Vyas_Dev/ReadySeleniumProjects/Selenium_c#/DriversAndJars/Drivers");

            var options = new EdgeOptions();
            IWebDriver driver = new EdgeDriver("E:/Vyas_Dev/ReadySeleniumProjects/Selenium_c#/DriversAndJars/Drivers");

            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.google.com/");  
            Thread.Sleep(2000);  
            // identify the Google search text box  
            IWebElement ele = driver.FindElement(By.Name("q"));  
            //enter the value in the google search text box  
            ele.SendKeys("javatpoint tutorials");  
            Thread.Sleep(2000);  
            //identify the google search button  
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));  
            // click on the Google search button  
            ele1.Click();  
            Thread.Sleep(3000);  
            //close the browser  
            driver.Close();  
            Console.Write("SQA- test case 1 ended ");  


        }
    }
}
