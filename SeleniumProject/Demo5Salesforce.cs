using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment on salesforce application
namespace SeleniumProject
{
    public class Demo5Salesforce
    {
        static void Main1(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://www.salesforce.com/in/form/signup/freetrial-sales/");

            driver.FindElement(By.Name("UserFirstName")).SendKeys("jack");
            driver.FindElement(By.XPath("//input[contains(@id,'UserLast')]")).SendKeys("jack");
            driver.FindElement(By.Name("UserTitle")).SendKeys("jack");

            //text font for linktext or partiallinktext - should match the UI
            //driver.FindElement(By.LinkText("NEXT")).Click();

            driver.FindElement(By.XPath("//span[text()='Next']")).Click();



            SelectElement selectEmployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            //selectEmployees.SelectByText("21 - 200 employees");.
            selectEmployees.SelectByValue("100");

            driver.FindElement(By.Name("CompanyName")).SendKeys("Siemens");
            driver.FindElement(By.XPath("//span[text()='Next']")).Click();


            driver.FindElement(By.Name("UserEmail")).SendKeys("jack@gmail.com");

            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();



        }
    }
}
