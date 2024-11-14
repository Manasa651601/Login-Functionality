using OpenQA.Selenium;

namespace PageObjectsLayer
{
    public class Locators
    {
        public static By UsernameField = By.Id("user-name");
        public static By PasswordField = By.Id("password");
        public static By LoginButton = By.CssSelector("#login-button");
        public static By ErrorMessage = By.CssSelector("h3[data-test='error']");
    }
}
