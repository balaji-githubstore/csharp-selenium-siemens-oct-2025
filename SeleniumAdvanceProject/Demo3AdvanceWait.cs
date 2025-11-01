using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.SeleniumAdvanceProject
{
    public class Demo3AdvanceWait
    {
 
        [Test]
        public void Demo1FBLoginExplicitWaitTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://facebook.com");

            //driver.FindElement(By.Id("email")).SendKeys("hello33434343@gmail.com");
            //driver.FindElement(By.Id("pass")).SendKeys("welcome1234");
            //driver.FindElement(By.Name("login")).Click();

            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(20));

            IWebElement element = wait.Until(x => x.FindElement(By.Id("email")));
            element.SendKeys("hello33434343@gmail.com");
        }

        [Test]
        public void Demo2FBLoginFluentWaitTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://facebook.com");

            //driver.FindElement(By.Id("email")).SendKeys("hello33434343@gmail.com");
            //driver.FindElement(By.Id("pass")).SendKeys("welcome1234");
            //driver.FindElement(By.Name("login")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    
            wait.Until(x => x.FindElement(By.Id("email"))).SendKeys("hello33434343@gmail.com"); 
            wait.Until(x=>x.FindElement(By.Id("pass"))).SendKeys("welcome1234");
            wait.Until(x => x.FindElement(By.Name("login"))).Click();

            string alertText= wait.Until(x => x.SwitchTo().Alert()).Text;
            wait.Until(x => x.SwitchTo().Alert()).Accept();

        }

        [Test]
        public void Demo4FBLoginFluentWait()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://facebook.com");

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout=TimeSpan.FromSeconds(20);
            wait.PollingInterval=TimeSpan.FromSeconds(1);
            //wait.IgnoreExceptionTypes(typeof(NoAlertPresentException),typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(Exception));

           wait.Until(x => x.SwitchTo().Alert());
          

            wait.Until(x => x.FindElement(By.XPath("//*[@id='email']"))).SendKeys("hello33434343@gmail.com");
            wait.Until(x => x.FindElement(By.Id("pass"))).SendKeys("welcome1234");
            wait.Until(x => x.FindElement(By.Name("login"))).Click();

            //string alertText = wait.Until(x => x.SwitchTo().Alert()).Text;
            //wait.Until(x => x.SwitchTo().Alert()).Accept();

        }

    }
}
