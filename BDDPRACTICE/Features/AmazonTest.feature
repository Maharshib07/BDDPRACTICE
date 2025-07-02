Feature: Amazon Tv Search

Searching for a Tv in Amazon

@Regression
Scenario: search for a tv and verify the result
	Given I am on the amazon home page
	When I enter smart tv in the search bar "acer 43 inch tv"and I click on the search button
	And  I selected a acer tv and I click on the tv and added to cart
	Then I Assert whether tv added to kart or not

@Regression
Scenario: Login to Amazon website
	Given I am on the amazon home page and I click on the signin
	When I enter Username and then I click on the continue button
	And  I enter Password and click on the Signin button
	Then I Assert the login successfully


