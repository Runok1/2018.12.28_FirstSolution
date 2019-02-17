using AutomationFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationFramework.Tests
{
    public class OldQaLightTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CheckGoalsOfTestingInKnowledgeBase()
        {
            // Arrange
            var expectedText1 = "Предоставление информации о качестве ПО конечному заказчику";
            var expectedText2 = "Повышение качества ПО";
            var expectedText3 = "Предотвращение появления дефектов";

            // Act
            OldQaLightMainPage oldQaLightMainPage = new OldQaLightMainPage(driver);
            oldQaLightMainPage.knowledgeBase.Click();
            KnowledgePage knowledgePage = new KnowledgePage(driver);
            knowledgePage.basics.Click();

            knowledgePage.testingGoals.Click();
            TestingGoalsPage testingGoalsPage = new TestingGoalsPage(driver);
            var currentText = testingGoalsPage.informationArea.Text;

            // Assert
            //// Option 1
            //Assert.True(currentText.Contains(expectedText1), $"'{expectedText1}'" + 
            //    $" is absent, but expected. Current text is '{currentText}'");

            //Assert.True(currentText.Contains(expectedText2), $"'{expectedText2}'" +
            //    $" is absent, but expected. Current text is '{currentText}'");

            //Assert.True(currentText.Contains(expectedText3), $"'{expectedText3}'" +
            //    $" is absent, but expected. Current text is '{currentText}'");

            // Option 2
            var result1 = currentText.Contains(expectedText1);
            var result2 = currentText.Contains(expectedText2);
            var result3 = currentText.Contains(expectedText3);

            //foreach (var item in collection)
            //{
            //    Assert.True(item == expectedText1, $"{item} is not present.");
            //}

            Assert.True(result1 && result2 && result3, "Expected text is " +
                $"not present on the page. '{expectedText1}' - {result1}," +
                $"'{expectedText2}' - {result2}, '{expectedText3}' - {result3}.");
        }

        [Test]
        public void CheckSocialNetworkLinksCount()
        {
            // Arrange
            var expectedNumber = 7;

            // Act
            OldQaLightMainPage oldQaLightMainPage = new OldQaLightMainPage(driver);
            var currentNumber = oldQaLightMainPage.socialNetworkLinks.Count;

            // Assert
            Assert.True(currentNumber == expectedNumber,
                $"Current social network links count '{currentNumber}' is invalid. Expected value is '{expectedNumber}'.");
        }
    }
}
