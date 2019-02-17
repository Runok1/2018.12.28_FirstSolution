using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Pages
{
    public class TestingGoalsPage : OldQaLightBasePage
    {
        public TestingGoalsPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".item-page.my_base_qn")]
        public IWebElement informationArea;
    }
}
