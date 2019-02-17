using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WebDriverTests
{
    public class RequestForCoursePage : BasePage
    {
        public RequestForCoursePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            containerWithElements = new ContainerWithElements(driver);
        }

        [FindsBy(How = How.CssSelector, Using = "#z_sender0")]
        public IWebElement surname;

        [FindsBy(How = How.CssSelector, Using = "select[name = '_7c8289bf6b8e80c1749ef54ab01b92b8']")]
        public IWebElement courseDropdown;

        public ContainerWithElements containerWithElements;

        [FindsBy(How = How.XPath, Using = "//input")]
        public IList<IWebElement> testElements;
    }
}
