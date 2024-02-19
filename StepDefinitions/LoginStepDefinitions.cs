using UserLoginLib;
namespace SpecFlowProjectUSLogin.StepDefinitions
{
    [Binding]
    public  class LoginStepDefinitions
    {
        private string userName;

        private string password;

        private string loginResult;

        private readonly ScenarioContext scenarioContext;

        private readonly UserLogin userLogin;
        public LoginStepDefinitions(ScenarioContext sc)
        {

            this.scenarioContext = sc;

            userLogin = new UserLoginLib.UserLogin();
        }
        [Given(@"a user with valid username ""([^""]*)"" and valid password ""([^""]*)""")]

        public void GivenAUserWithValidUsernameAndValidPassword(string p0, string p1)
        {

            userName = p0;

            password = p1;
        }

        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()

          {

        loginResult = userLogin.Login(userName, password);

           }

           [Then(@"the result should Login Success")]
          public void WhenTheResultShouldLoginSuccess()
        {
            Assert.Equal("Login Success", loginResult);
        }
        [Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)""" )]
         public void GivenAUserWithInvalidUsernameAndInvalidPassword(string p0, string invalid)
        {
            userName = p0;
            userName =invalid;
        }

        [Then(@"the result should Login Failed")]

        public void ThenThelResultShouldLoginFailed()
        {
            Assert.Equal("Login Failed", loginResult);
        }
    }


}
