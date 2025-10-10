using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Demo3Medibuddy
    {
        static void Main1(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.medibuddy.in/";  //wait for page load to complete

            //FindElement --> check for presence of locator in 0.5s/500ms 
            driver.FindElement(By.LinkText("Login")).Click();

            //FindElement --> check for presence of locator in 0.5s/500ms 
            driver.FindElement(By.Id("phone")).SendKeys("78788878787");


        }
    }
}
