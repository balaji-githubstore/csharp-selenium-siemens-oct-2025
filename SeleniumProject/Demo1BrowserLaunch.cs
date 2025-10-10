

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Demo1BrowserLaunch
    {
        static void Main1(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";



            IWebDriver obj = new ChromeDriver(options);

            obj.Url = "https://www.facebook.com/";

            //Property -- Title
            Console.WriteLine(obj.Title);

            //url
            Console.WriteLine(obj.Url);

            //get the page source and print it
            Console.WriteLine(obj.PageSource);

            string actualTitle= obj.Title;
            Console.WriteLine(actualTitle);
        }
    }
}
