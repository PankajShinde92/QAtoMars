Feature: Add Education in Profile 
	

@mytag
Scenario:Add Education in Profile 

	Given enter URL and launch page
	When enter username password click submit
	| Username                | Password  |
	| pankajosplabs@gmail.com | Pankaj123 |
	Then land to profile page
	When click on add new Education then add and validate the error message
	Then  add Education and save
	| CollegeName| Degree	|
	| CSU		 | Bachelors  |
	And update the Education and Delete
	| UpadtedDegree |
	| Masters      |
	Then Signout
	

