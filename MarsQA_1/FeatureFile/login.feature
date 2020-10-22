Feature: loginpage
	

@mytag
Scenario:Login to page
	Given enter URL and launch page
	When enter username password click submit
	| Username                | Password  |
	 | pankajosplabs@gmail.com | Pankaj123 |
	Then land to profile page
	And validate the title
	Then Signout