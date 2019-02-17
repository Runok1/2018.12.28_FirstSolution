using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Pages
{
    public class KnowledgePage : OldQaLightBasePage
    {
        public KnowledgePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".item-366.deeper.parent span")]
        public IWebElement basics;

        [FindsBy(How = How.CssSelector, Using = "[href='/testirovanie/osnovy/tseli-testirovaniya.html']")]
        public IWebElement testingGoals;
    }
}
