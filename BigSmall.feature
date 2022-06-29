Feature: BigSmall
 To check functionality is working or not

@mytag
Scenario: To check  Create Account is working correct
	Given user is on homepage
	When user click on Signin btn
	And user click on create account  btn
	And user enter  First name
	And  user enter Lastnmae
	And  user enter  Valid emailId
	And user enter Valid password
	Then  it should create id

Scenario Outline: login to excute using examples
	Given user is on homepage
	When user click on Signin btn
	And user enter "<EmailId>" user
	And  uset enter "<Password>" pass
	And user click on Siginbtn
	Then user should see result & logout btn

	Examples:
		| EmailId           | Password |
		| rajritu@gmail.com | 12345678 |
		| 1234              | 1234     |
		| ada123            | adse1234 |