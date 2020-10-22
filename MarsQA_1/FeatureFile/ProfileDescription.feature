Feature: Add Description in Profile 
	

@mytag
Scenario:Add Description in Profile 
	Given enter URL and launch page
	When enter username password click submit
	| Username                | Password  |
	| pankajosplabs@gmail.com | Pankaj123 |
	
	When click on add Description then add and validate the error message
	And Click on textarea and save
	| Details                                |
	| Hi My name is Pankaj Shinde. I have completed my Masters in IT and currently I am Working as Intern at MVP studio. |
	Then Signout
