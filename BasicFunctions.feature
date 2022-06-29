Feature: BasicFunctions
	To check all basic Functions 

@mytag
Scenario: Add to Cart a product 
	Given user is on homepage
	When user click on Sale 
	And user Select a product from search result 
	And user change the quantity from 1 to 2
	And  user check COD Availability 
    And user add item to cart 
	And  user Click on go to CheckOut 
	And user click on login 
	Then  user should able to  see login  page 


