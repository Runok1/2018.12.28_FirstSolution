using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebDriverTests
{
    public class ContainerWithElements
    {
        public ContainerWithElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Test Id")]
        public IWebElement elementInContainer;


        //public ContainerWithElements(IWebDriver driver)
        //{
        //    elementInContainer = driver.FindElement(By.Id("Test Id"));
        //}

        //public IWebElement elementInContainer;
    }
}
