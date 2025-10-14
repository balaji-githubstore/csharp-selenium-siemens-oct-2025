using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.SeleniumAdvanceProject
{
    public class Demo4Assignments
    {

        
        [Test,Repeat(5)]
        public void Demo1CitiBank()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://www.citigroup.com/global/about-us/global-presence/india");

            IWebElement ele = driver.FindElement(By.XPath("//button[text()='Accept All']"));
            ele.Click();
            //driver.FindElement(By.XPath("//button[text()='Accept All']")).Click();


            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//div[text()='My Account']"))).Perform();

            driver.FindElement(By.XPath("//div[text()='Banking with Citi']")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //driver.FindElement(By.Id("username")).SendKeys("hello");

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout=TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(Exception));

            //wait.Until(x => x.FindElement(By.XPath("//p[contains(text(),'federal government shutdown')]")).Displayed == true);

            //wait.Until(x => x.Title == "");

            wait.Until(x => x.FindElement(By.XPath("//input[@placeholder='User ID']"))).SendKeys("hello123");

            driver.Quit();
        }

        //[Test]
        //public void Demo2CitiBank()
        //{
        //    ChromeOptions options = new ChromeOptions();
        //    options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

        //    IWebDriver driver = new ChromeDriver(options);
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        //    driver.Navigate().GoToUrl("https://www.google.com");

        //    IWebElement ele = driver.FindElement(By.XPath("//*[text()='Gmail']"));
        //    ele.Click();

        //}
    }
}
