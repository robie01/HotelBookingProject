Feature: BookARoomBefore
	As a potential customer
	I want to book a room soon

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