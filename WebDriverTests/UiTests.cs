using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace WebDriverTests
{
    public class UiTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.etsy.com/c/shoes/mens-shoes/boots?ref=catnav-10923");

            //ChromeOptions options = new ChromeOptions();
            //options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            //driver = new ChromeDriver(options);
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.Navigate().GoToUrl("https://www.ukr.net/");
            //Thread.Sleep(60000);
        }

        [Test]
        public void TestColor()
        {
            var elements = driver.FindElements(By.CssSelector(".promotion-price"));
            foreach (var element in elements)
            {
                Console.WriteLine(element.GetCssValue("color")); ;
            }      
        }

        [Test]
        public void TestFindsBy()
        {
            var logs = driver.Manage().Logs.GetLog(LogType.Browser);

            foreach (LogEntry log in logs)
            {
                    Console.WriteLine(log.Level);
            }

            //RequestForCoursePage page = new RequestForCoursePage(driver);
            //var set = page.testElements;
            //Console.WriteLine(set.Count);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void FirstUiTest()
        {                                        
            Console.WriteLine("First test");

            IWebElement element = driver.FindElement(By.XPath("test Xpath"));

            ReadOnlyCollection<IWebElement> elements = driver
                .FindElements(By.XPath("test multi Xpath"));

            IWebElement test = elements[4];

            var currentHandle = driver.CurrentWindowHandle;

            // Here is Code to open new tab

            var handles = driver.WindowHandles;

            foreach (var item in handles)
            {
                if (item != currentHandle)
                {
                    driver.SwitchTo().Window(item);
                }
            }

            element.Click();
        }

        [Test]
        public void TestPageObject()
        {
            driver.Navigate()
                .GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy.html");

            RequestForCoursePage requestForCoursePage = new RequestForCoursePage(driver);

            SelectElement dropdown = new SelectElement(requestForCoursePage.courseDropdown);
            dropdown.SelectByIndex(3);

            requestForCoursePage.surname.SendKeys("MySurname");

            //requestForCoursePage.containerWithElements.elementInContainer.Click();

            Thread.Sleep(3000);
        }
    }
}
