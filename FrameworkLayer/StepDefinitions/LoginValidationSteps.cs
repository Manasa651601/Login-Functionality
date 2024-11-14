using FrameworkLayer.Hooks;
using FrameworkLayer.PageObjects;
using TechTalk.SpecFlow;

namespace FrameworkLayer.StepDefinitions
{
    [Binding]
    public class LoginValidationSteps
    {
        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            Hooks.InitializeDriver();
        }

        // Implement other step definitions for the scenarios
    }
}