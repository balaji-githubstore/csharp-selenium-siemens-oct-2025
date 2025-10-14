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
    public class Demo5UploadActionsTest
    {

        [Test]
        public void Demo1UploadTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://smallpdf.com/pdf-to-word");


            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"D:\Balaji\Profile.pdf");
        }

        [Test]
        public void Demo2ActionsTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://google.com");

            Actions actions=new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.Name("q"))).Click()
                .KeyDown(Keys.Shift).SendKeys("hello world")
                .KeyUp(Keys.Shift).Pause(TimeSpan.FromMilliseconds(800)) 
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromMilliseconds(800))
                .SendKeys(Keys.Enter)
                .Perform();
            
        }
    }
}
