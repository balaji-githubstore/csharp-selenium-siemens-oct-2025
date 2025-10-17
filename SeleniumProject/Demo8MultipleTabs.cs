using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Demo8MultipleTabs
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


            foreach(string window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
                if(driver.Title.Equals("phpMyAdmin"))
                {
                    break;
                }
            }

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            driver.FindElement(By.Id("input_go")).Click();


            driver.Close();


            foreach (string window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
                if (driver.Title.Equals("phpMyAdmin"))
                {
                    break;
                }
            }

            //driver.Close();
            //foreach (string window in driver.WindowHandles)
            //{
            //    driver.SwitchTo().Window(window);
            //    if (driver.Title.Equals("phpMyAdmin"))
            //    {
            //        break;
            //    }
            //}

        }
    }
}
