Feature: TMFeature

As  a TurnUp Portal admin
I would like to create  edit and delete time and materials records
so that I can manage employees' time and materials successfully.


Scenario: Create time and material record with valid details
	Given I logged into turn up portal successfully.
	When  I navigate to Time and Material page
	When I create a new time and  material record
	Then  the record should be created successfully

Scenario Outline: Edit  time and material record with valid details
	Given I logged into turn up portal successfully.
	When  I navigate to Time and Material page
	When I update '<Description>', '<Code>' and '<Price>'  a new time and  material record
	Then  the record should have the update '<Description>', '<Code>' and '<Price>'

	Examples: 
	| Description | Code     | Price |
	| Time        | JR       | 50    |
	| Material    | Keyboard | 150   |
	| EditRecord  | Code     | 200   |