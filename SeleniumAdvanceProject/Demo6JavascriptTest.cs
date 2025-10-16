using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.SeleniumAdvanceProject
{
    public class Demo6JavascriptTest
    {
        [Test]
        public void CSSSelectorTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.facebook.com/";

            driver.FindElement(By.CssSelector("#email")).SendKeys("hello33434343@gmail.com");
            driver.FindElement(By.CssSelector("#pass")).SendKeys("welcome1234");
            driver.FindElement(By.CssSelector("button[name='login']")).Click();
        }

        [Test]
        public void JS1Test()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            options.AddArgument("start-maximized");
            options.AddArgument("--disable-notifications");
            //options.AddArgument("--headless");
            //options.AcceptInsecureCertificates = true;

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";


            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();
            //approach 1 - not works 
            //driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateDeparture']")).SendKeys("03 Dec 2025");

            //approach 2 - automate calendar if possible 


            //approach 3 - js 
            driver.ExecuteJavaScript("document.querySelector(\"div[id='book-flight'] input[name='dateDeparture']\").value='12 Dec 2023'");

            driver.ExecuteJavaScript("document.querySelector(\"div[id='book-flight'] input[name='dateReturn']\").value='12 Dec 2023'");

            Console.WriteLine(driver.Title);
        }

        [Test]
        public void JS2WithWebElementTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            options.AddArgument("start-maximized");
            options.AddArgument("--disable-notifications");
            //options.AddArgument("--headless");
            //options.AcceptInsecureCertificates = true;

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";


            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();

            //approach 3 - js 
            IWebElement ele1 = driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateDeparture']"));
            driver.ExecuteJavaScript("arguments[0].value='10 Dec 2023'", ele1);

            IWebElement ele2 = driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateReturn']"));
            driver.ExecuteJavaScript("arguments[0].value='22 Dec 2023'", ele2);

            // driver.ExecuteJavaScript("arguments[0].value='12 Dec 2023';arguments[1].value='22 Dec 2023';", ele1,ele2);

            string attValue = driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateDeparture']")).GetAttribute("value");
            Console.WriteLine(attValue);

            //string value=driver.ExecuteJavaScript<string>("return document.querySelector('#main').value");
            string value = driver.ExecuteJavaScript<string>("return document.querySelector(\"input[name='dateDeparture']\").value");
            Console.WriteLine(value);

            string value1 = driver.ExecuteJavaScript<string>("return document.title");
            Console.WriteLine(value1);
        }


    }
}
