Feature: BookRoom
	As a potential customer
	I want to see desired booked dates are free or not
	So I can decide what days are free to book.


	Scenario Outline: Book room
	Given the start date which is tomorrow plus'<startDate>'
	And the end date which is tomorrow plus'<endDate>'
	When the dates are check with the occupied range 
	Then the '<Availability>' should be returned

	Examples: 
		| startDate | endDate | Availability |
		|     02/01/2021    |      10/01/2021  |  True   |
		|     14/01/2021    |      20/01/2021  |  False |







