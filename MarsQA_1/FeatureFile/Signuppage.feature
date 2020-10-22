Feature: Sign up Page
	

@mytag
Scenario:Sign up Page                                                                               
	Given enter URL and launch page
	When enter details click join
	| FirstName | LastName | Email                       | Password    |
	| Alison   | Robert  | alison93@gmail.com | Robert@123 |
	Then signIn with same credentials
	| Email				 | Password |
	| alison93@gmail.com | Robert@123 |
	Then Signout