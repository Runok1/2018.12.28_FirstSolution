using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace WebDriverTests
{
    public class ActionsTest
    {
        [Test]
        public void TestingActions()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);

            IWebElement element = driver.FindElement(By.Id("sfcsd"));

            actions.KeyDown(Keys.Control)
                .SendKeys("a").Perform();

            Thread.Sleep(2000);
            
            actions.KeyUp(Keys.Control).SendKeys(Keys.Delete)
                .SendKeys(element, "verberb").Click(element).Perform();

            IAction action = actions.KeyDown(Keys.Control)
                .SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Delete)
                .SendKeys("verberb").Build();

            action.Perform();
            //kkj
            //    gfbdf
            //    ffgb
            //    bdf
            //    dfbn
            //    fgb
            //    fb
            action.Perform();
        }
    }
}
