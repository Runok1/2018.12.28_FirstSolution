using AutomationFramework.Pages;
using AutomationFramework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.Tests
{
    public class FirstTestSuite
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void FirstTest()
        {
            //IWebElement element = null;

            FirstPage firstPage = new FirstPage(driver); 
            bool isPresent = WebElementHelpers.IsElementPresent(firstPage.testElement);

            string expectedText = "";

            //string textFromWebElement = element.GetText();

            int count = 5;
            Assert.False(count == 0, "dsvsdv");
        }
    }
}
