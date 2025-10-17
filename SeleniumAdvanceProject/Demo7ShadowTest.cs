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
    public class Demo7ShadowTest
    {
        [Test]
        public void Demo1OptionalShadowRootJSTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://www.salesforce.com/in/form/signup/freetrial-sales/");

            //  driver.FindElement(By.CssSelector("button[aria-label='Minimize Agentforce']")).Click();

            driver.ExecuteJavaScript("document.querySelector(\"page-builder-miaw-ui[deployment-dev-name='page_builder_miaw_ui']\").shadowRoot.querySelector(\"button[aria-label='Minimize Agentforce']\").click()");


        }


        /// <summary>
        /// Use below always to use wait conditions 
        /// </summary>
        [Test]
        public void Demo2ShadowRootFindElementTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://www.salesforce.com/in/form/signup/freetrial-sales/");

            //FindElement supports only cssselector for shadow
            var shadow1= driver.FindElement(By.CssSelector("page-builder-miaw-ui[deployment-dev-name='page_builder_miaw_ui']")).GetShadowRoot();
            shadow1.FindElement(By.CssSelector("button[aria-label='Minimize Agentforce']")).Click();
        }

    }
}
