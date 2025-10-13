using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Demo2FBLogin
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.facebook.com/";


            //By locator= By.Id("email");
            //IWebElement element= driver.FindElement(locator);
            //element.SendKeys("hello33434343@gmail.com");


            IWebElement element = driver.FindElement(By.Id("email"));
            //element.SendKeys("hello33434343@gmail.com");

            driver.FindElement(By.Id("email")).SendKeys("hello33434343@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("welcome1234");
            //click on login
            driver.FindElement(By.Name("login")).Click();

           
        }
    }
}
