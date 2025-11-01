

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class XBrowser : IWebDriver
    {
        public string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Title => throw new NotImplementedException();

        public string PageSource => throw new NotImplementedException();

        public string CurrentWindowHandle => throw new NotImplementedException();

        public ReadOnlyCollection<string> WindowHandles => throw new NotImplementedException();

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }
    }


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
