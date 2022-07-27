Feature: AbelAndCole
	

@mytag
Scenario: Shopping spree
	Given I navigate to the website"http://www.abelandcole.co.uk/"
	And I click accept cookies
	And I click startshopping
	And I enter Item one"Brownie tray organic Daylesford (570g)"
	And I click search item1
	And I add to cart
	And I click search button
	And I insert item2"Hummus chips organic, Eat Real (100g)"
	And I click search item 2
	And I add second item to cart
	And I click add to increase the qty to two
	And I click add to increase the qty to three
	And I click SEARCH
	And I enter the item3"Simply salted popcorn organic, Nom (20g)"
	And I click on search
	And I click add
	And I click add to increase quantity to2
	When I click on cart
	Then I should have been able to add all items to the cart succesfuly
	And I delete the firsts item
	And I delete the second item
	When I delete third item
	Then I should be able to delete all cart items succesfully