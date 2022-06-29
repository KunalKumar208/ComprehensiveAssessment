using ComprehensiveAssesmentBddSpecflow.CommonMethodFiles;
using System;
using TechTalk.SpecFlow;

namespace ComprehensiveAssesmentBddSpecflow.stepDefinition
{
    [Binding]
    public class BigSmallSteps
    {


        BigSmallObject Obj = new BigSmallObject();


        [Given(@"user is on homepage")]
        public void GivenUserIsOnHomepage()
        {
            Obj.VerifyHome();
        }

        [When(@"user click on Signin btn")]
        public void WhenUserClickOnSigninBtn()
        {
            Obj.ClickOnSIgnInBtn();
        }

        [When(@"user click on create account  btn")]
        public void WhenUserClickOnCreateAccountBtn()
        {
            Obj.ClickOnCreateAccount();

        }

        [When(@"user enter  First name")]
        public void WhenUserEnterFirstName()
        {
            Obj.EnterFirstName();
        }

        [When(@"user enter Lastnmae")]
        public void WhenUserEnterLastnmae()
        {
            Obj.EnterLastName();
        }

        [When(@"user enter  Valid emailId")]
        public void WhenUserEnterValidEmailId()
        {
            Obj.EnterEmail();
        }

        [When(@"user enter Valid password")]
        public void WhenUserEnterValidPassword()
        {
            Obj.EnterPassword();
        }

        [Then(@"it should create id")]
        public void ThenItShouldCreateId()
        {
            Obj.CreateAccount();
        }

        [When(@"user enter ""(.*)"" user")]
        public void WhenUserEnterUser(string user)
        {
            Obj.EnterEmailId(user);
        }

        [When(@"uset enter ""(.*)"" pass")]
        public void WhenUsetEnterPass(string pass)
        {
            Obj.EnterPassword1(pass);
        }

       
        [When(@"user click on Siginbtn")]
        public void WhenUserClickOnSiginbtn()
        {
            Obj.ClickOnSiginBtn();
        }


        [Then(@"user should see result & logout btn")]
        public void ThenUserShouldSeeResultLogoutBtn()
        {
        }

    }


}    
