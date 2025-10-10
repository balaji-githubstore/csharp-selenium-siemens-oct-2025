using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Demo7MultipleTabs
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://www.db4free.net/");

            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            
            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            driver.FindElement(By.Id("input_go")).Click();


            string actualHeader= driver.FindElement(By.XPath("//h1")).Text;
            Console.WriteLine(actualHeader);


            string actualError = driver.FindElement(By.Id("pma_errors")).Text;
            Console.WriteLine(actualError);

            //driver.Close(); //close the current tab

            ////switch to first tab
            //driver.SwitchTo().Window(driver.WindowHandles[0]);

            //Console.WriteLine(driver.Title);


            //driver.Quit(); //close the current browser and also kill the process associated to it

        }
    }
}
