Feature: Counter Experience

Background: 
    Given I navigate to the counter page
    Then I am on the counter page

Scenario: I can increment the value
    Given the counter value is 0
    When I click the increment button
    Then the counter value is 1    