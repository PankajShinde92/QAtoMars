Feature: Add Details to Profile 
	

@mytag
Scenario: Add Details to Profile
	Given enter URL and launch page
	When enter username password click submit
	| Username                | Password  |
	| pankajosplabs@gmail.com | Pankaj123 |
	Then land to profile page
	When Click on avaliablity and Details
	Then Click on Earn and add Details
	And Click on Target and add Details
	Then Signout
