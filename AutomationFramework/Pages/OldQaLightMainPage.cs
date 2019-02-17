using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Pages
{
    public class OldQaLightMainPage : OldQaLightBasePage
    {
        public OldQaLightMainPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "[href='/knowledge.html']")]
        public IWebElement knowledgeBase;
    }
}
