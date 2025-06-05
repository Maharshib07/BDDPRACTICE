Feature: Amazon Tv Search

Searching for a Tv in Amazon

@Regression
Scenario: search for a tv and verify the result
	Given I am on the amazon home page
	When I enter smart tv in the search bar and I click on the search button
	And   I selected a oneplus tv and I click on the tv
	Then I should see a list of tvs in the search results
