using TechTalk.SpecFlow;
using PageObjectsLayer;

namespace FrameworkLayer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage = new LoginPage();

        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When("User enters '<username>' and '<password>'")]
        public void WhenUserEntersUsernameAndPassword(string username, string password)
        {
            loginPage.EnterUsernameAndPassword(username, password);
        }

        [When("Clicks on Login button")]
        public void WhenClicksOnLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("User should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            loginPage.VerifyLoginSuccess();
        }
    }
}