Feature: Amazon Tv Search

Searching for a Tv in Amazon

@Regression
Scenario: search for a tv and verify the result
	Given I am on the amazon home page
	When I enter smart tv in the search bar "acer 43 inch tv"and I click on the search button
	And   I selected a acer tv and I click on the tv and added to cart
	Then I checked whether tv added to kart or not
