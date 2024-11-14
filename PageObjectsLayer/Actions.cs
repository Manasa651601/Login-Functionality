using OpenQA.Selenium;

namespace PageObjectsLayer
{
    public class Actions
    {
        public static void EnterUsername(IWebDriver driver, string username)
        {
            driver.FindElement(Locators.UsernameField).SendKeys(username);
        }

        public static void EnterPassword(IWebDriver driver, string password)
        {
            driver.FindElement(Locators.PasswordField).SendKeys(password);
        }

        public static void ClickLoginButton(IWebDriver driver)
        {
            driver.FindElement(Locators.LoginButton).Click();
        }

        public static string GetErrorMessage(IWebDriver driver)
        {
            return driver.FindElement(Locators.ErrorMessage).Text;
        }
    }
}