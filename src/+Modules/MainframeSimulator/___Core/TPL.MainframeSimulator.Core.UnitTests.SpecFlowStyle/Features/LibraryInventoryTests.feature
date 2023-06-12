Feature: Library Inventory Management

Scenario: Add books to the library inventory
    Given I have a library
    When I add books to the library
    Then the Library should have books in its inventory