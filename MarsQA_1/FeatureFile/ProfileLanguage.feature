Feature: Add Language in Profile 
	

@mytag
Scenario: Add Language in Profile

	Given enter URL and launch page
	When enter username password click submit
	| Username                | Password  |
	| pankajosplabs@gmail.com | Pankaj123 |
	
	When click on add new then add and validate the error message
	Then  add new Language and save
	
	And update the language and Delete
	
	Then Signout
	

