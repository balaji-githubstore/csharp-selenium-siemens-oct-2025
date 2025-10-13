using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.SeleniumAdvanceProject
{
    public class Demo1FrameTest
    {

        [Test]
        public void HdfcLoginTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://netbanking.hdfcbank.com/netbanking/");

            //switch to frame using IWebElement
            //frame[contains(@src,'RSNBLogin')]
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("john123");

            //click on Continue
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();


        }

        [Test]
        public void QspidersTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("http://demoapps.qspiders.com/ui/frames/nested?sublist=1");


            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='w-full h-96']")));

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe")));

            driver.FindElement(By.Id("email")).SendKeys("hello@gmail.com");


        }

        [Test]
        public void QspidersUsingIndexTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            driver.Navigate().GoToUrl("http://demoapps.qspiders.com/ui/frames/nested?sublist=1");


            driver.SwitchTo().Frame(0);

            driver.SwitchTo().Frame(0);

            driver.FindElement(By.Id("email")).SendKeys("hello@gmail.com");

            //switch to main html
            driver.SwitchTo().DefaultContent();

        }

    }
}
