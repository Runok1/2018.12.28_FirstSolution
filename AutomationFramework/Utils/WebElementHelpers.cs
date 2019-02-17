using OpenQA.Selenium;
using System;

namespace AutomationFramework.Utils
{
    public static class WebElementHelpers
    {
        public static bool IsElementPresent(IWebDriver driver, By elementLocator)
        {
            try
            {
                driver.FindElement(elementLocator);
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Unexpected exception. " + e.Message);
            }
        }

        public static bool IsElementPresent(IWebElement element)
        {
            var isPresent = false;
            try
            {
                isPresent = element.Displayed;
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Unexpected exception. " + e.Message);
            }
        }

        public static string GetText(this IWebElement element)
        {
            var text = string.Empty;

            text = element.GetAttribute("value") ?? element.GetAttribute("textContent");

            //if (element.GetAttribute("value") != null)
            //{
            //    text = element.GetAttribute("value");
            //}
            //else if (element.GetAttribute("textContent") != null)
            //{
            //    text = element.GetAttribute("textContent");
            //}
            //else if (element.Text != string.Empty)
            //{
            //    text = element.Text;
            //}
            //else
            //{
            //    throw new Exception("Unexpected exception while getting text from WebElement");
            //}

            return text;
        }
    }
}
