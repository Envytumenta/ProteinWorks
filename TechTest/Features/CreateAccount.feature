Feature: CreateAccount
	

@CreateAccount
Scenario:Valid CreateAccount
	Given I navigate to homepage"https://www.theproteinworks.com/customer/account/create/"
	When I enter my details '<FirstName>''<LastName>''<Email>''<Password>''<ConfirmPassword>''<PhoneNumber>'
	Then account should be created


	Examples: 
	| FirstName | LastName | Email            | Password    | ConfirmPassword | PhoneNumber |
	| Peter     | Smith    | mantiti@mail.com | Asernal1234 | Asernal1234     | 01179221771 |