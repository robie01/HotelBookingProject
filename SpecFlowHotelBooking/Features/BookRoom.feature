Feature: BookARoomBefore
	As a potential customer
	I want to book a room soon

#Test Type - NameSpace - System under test - Ticket Number - Requirement
@Unit		@Book		@Booking			@10A			@Trello-14.A
Scenario Outline: Book a room
	Given the start date which is tomorrow plus <startDate>
	And the end date which is tomorrow plus <endDate>
	When the dates are checked to be correct
	Then the <Availability> should be returned

	Examples:
		| startDate | endDate | Availability |
		| 2         | 4       | True         |
		| 2         | 6       | False        |
		| -1        | 2       | Exception    |
		| 4         | 2       | Exception    |

@bookRoom
Scenario: Order food
	Given a customer
	And the food wish
	When food is available to being delivered
	And  customer is able to order food
	Then send confirmation and food