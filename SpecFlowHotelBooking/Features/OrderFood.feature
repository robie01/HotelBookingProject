Feature: OrderFood

Background:
	Given the following food
		| Food     | Price |
		| Burger   | 75    |
		| Pasta    | 50    |
		| Sandwich | 35    |
	And I am a current customer able to order food


Scenario: Order food
	When food is available to being delivered
	Then send confirmation and food

Scenario: Buy buffet
	When buffet is ordered
	Then send confirmation and food with a discount