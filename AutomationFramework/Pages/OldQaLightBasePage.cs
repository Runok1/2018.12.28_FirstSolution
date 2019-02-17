using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace AutomationFramework.Pages
{
    public class OldQaLightBasePage
    {
        public OldQaLightBasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#footer_social ul li")]
        public IList<IWebElement> socialNetworkLinks;
    }
}
