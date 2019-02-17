using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Pages
{
    public class FirstPage
    {
        public FirstPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Test Id")]
        public IWebElement testElement;
    }
}
