Feature: forget password

@mytag
Scenario: to check wether the forget password works fine.
	Given enter URL and launch page
	When pop up opens click on forget password link entre the valid email id
	| Verificationemail			 |
	| pankajosplabs@gmail.com     |
	Then click on sned verification email
	
	
	