using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FrameworkLayer.Hooks
{
    public class Hooks
    {
        public static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}