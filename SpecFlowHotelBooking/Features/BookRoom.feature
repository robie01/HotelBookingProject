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


Feature: OrderFood

Background:
	Given the following food
		| Food     | Price |
		| Burger   | 75    |
		| Pasta    | 50    |
		| Sandwich | 35    |
	And I am a current customer able to order food

@OrderFood
Scenario: Order food
	When food is available to being delivered
	Then send confirmation and food