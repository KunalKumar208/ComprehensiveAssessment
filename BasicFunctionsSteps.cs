using ComprehensiveAssesmentBddSpecflow.CommonMethodFiles;
using System;
using TechTalk.SpecFlow;

namespace ComprehensiveAssesmentBddSpecflow.stepDefinition
{
    [Binding]
    public class BasicFunctionsSteps
    {
        BasicFunctionObject Basicobj = new BasicFunctionObject();
        BigSmallObject Obj = new BigSmallObject();

        [When(@"user click on Sale")]
        public void WhenUserClickOnSale()
        {
            Basicobj.ClickonSale();
        }
        
        [When(@"user Select a product from search result")]
        public void WhenUserSelectAProductFromSearchResult()
        {
            Basicobj.SelectProduct();
            
        }
        
        [When(@"user change the quantity from (.*) to (.*)")]
        public void WhenUserChangeTheQuantityFromTo(int p0, int p1)
        {

            Basicobj.IncreaseQuantity();
        }
        
        [When(@"user check COD Availability")]
        public void WhenUserCheckCODAvailability()
        {
            Basicobj.CheckCodAvalibility();
        }
        
        [When(@"user add item to cart")]
        public void WhenUserAddItemToCart()
        {
            Basicobj.AddtoCart();
        }
        
        [When(@"user Click on go to CheckOut")]
        public void WhenUserClickOnGoToCheckOut()
        {

            Basicobj.ClickonCheckout();
        }
        
        [When(@"user click on login")]
        public void WhenUserClickOnLogin()
        {

            Basicobj.ClickonLoginFunction();

        }
        
        [Then(@"user should able to  see login  page")]
        public void ThenUserShouldAbleToSeeLoginPage()
        {
            Basicobj.VerifyloginPage();
        }


      

     

    }
}
