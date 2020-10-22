Feature: Add Data in Profile 
	

@mytag
Scenario:Login to page
	Given enter URL and launch page
	When enter username password click submit
	| Username                | Password  |
	| pankajosplabs@gmail.com | Pankaj123 |
	
	When click on add new Certification then add and validate the error message
	Then  add Certification and save
	| CertificationName| Certificationfrom	|
	| BE in IT		 | CSU  |
	And update the Certification and Delete
	| UpadtedDegree |
	| Masters in IT |
	Then Signout
	

