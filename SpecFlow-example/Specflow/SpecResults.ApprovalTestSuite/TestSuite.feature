@Category:SomeFeatureCategory
Feature: Test Suite
	In order to test my reporter plugin
	As a developer
	I want to run a predefined test suite

@tag1
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@tag2
	Scenario: Add another two numbers
	Given I have entered 50 into the calculator
	And I have also entered 73 into the calculator
	When I press add
	Then the result should be 123 on the screen

@tag3
	Scenario: Add again two numbers
	Given I have entered 53 into the calculator
	And I have also entered 73 into the calculator
	When I press add
	Then the result should be 126 on the screen