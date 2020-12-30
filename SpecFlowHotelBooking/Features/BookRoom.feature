Feature: BookRoom
	As a potential customer 
	I want to see which dates are booked
	So I can decide what days are free to book a room.

@mytag
Scenario Outline:
	Given the start date which is tomorrow plus <startDate>
	And the end date which is tomorrow plus <endDate>
	When the dates are check with the occupied range
	Then the <Availability> should be returned

Examples: 
| startDate | endDate | Availability |
|	  0		|	 1    |    True      |


