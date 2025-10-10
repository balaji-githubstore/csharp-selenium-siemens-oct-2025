using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Demo4FBSignUp
    {
        static void Main2(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.facebook.com/";

            //click on Create new account
            driver.FindElement(By.LinkText("Create new account")).Click();

            //enter firstname as john
            driver.FindElement(By.Name("firstname")).SendKeys("jack");

            //enter lastname as wick
            driver.FindElement(By.Name("lastname")).SendKeys("wick");


            //20 Dec 2000 
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");

            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Dec");

            //select year as 2000


            //click on custom radio button
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();


            //click on sign up

        }
    }
}
