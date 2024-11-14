using OpenQA.Selenium;

namespace UtilityLayer
{
    public class UtilHelper
    {
        public static void InputText(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }

        public static void ClickButton(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
