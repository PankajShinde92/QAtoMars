Feature: Add Skill in Profile 
	

@mytag
Scenario:Add Skill in Profile 
	Given enter URL and launch page
	When enter username password click submit
	| Username                | Password  |
	| pankajosplabs@gmail.com | Pankaj123 |
	
	When click on add new skill then add and validate the error message
	Then  add new skill and save
	##| SkillOne    | SkillTwo |
	##| Programming | Dancing  |
	And update the Skill and Delete
	##| UpadtedSkillName |
	##| Leadership      |
	Then Signout
	

