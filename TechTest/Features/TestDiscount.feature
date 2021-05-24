Feature: TecTest
	

@TestDiscount
Scenario: E2E Testing
	Given i am on the hompage "https://www.theproteinworks.com/"
	And I go to the third product from the first carousel
	And I click the product
	And I select the penultimate flavour from the list
	And I select the second available weight
	And I clic on add to basket
	And I add the first item from pop up to basket
	And I proceed to basket
	And I apply the discount code "TESTDISCOUNT"
	And I validate this message "Coupon code(s) not valid: TESTDISCOUNT"
	When I proceed to checkout
	Then checkout must return 200 HTTP code