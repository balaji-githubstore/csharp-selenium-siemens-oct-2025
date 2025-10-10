using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Demo6MultipleTabs
    {
        static void Main4(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://www.db4free.net/");


            //click on phpMyAdmin »
            //b[contains(normalize-space(),'phpMyAdmin')]
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            //Console.WriteLine(driver.WindowHandles[0]);
            //Console.WriteLine(driver.WindowHandles[1]);

          


        }
    }
}
