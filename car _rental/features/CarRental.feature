Feature: Car rental

Scenario: Hourly rent
    Given the rent date '2019-01-19'
    And the return date '2019-01-19'
    And cuit number 20112223336
    And the kind rent is 'h'
    And the duration rent is 3
    When I pay for the rent
    Then the result is "Amount: 300"

Scenario: Rent per day
    Given the rent date '2019-01-19'
    And the return date '2019-01-19'
    And cuit number 20112223336
    And the kind rent is 'd'
    And the duration rent is 1
    When I pay for the rent
    Then the result is "Amount: 2000"

Scenario: Rent per kilometres
    Given the rent date '2019-01-19'
    And the return date '2019-01-19'
    And cuit number 20112223336
    And the kind rent is 'k'
    And the duration rent is 1
    When I pay for the rent
    Then the result is "Amount: 110"

Scenario: Rent per day to company
    Given the rent date '2019-01-19'
    And the return date '2019-01-19'
    And cuit number 26112223336
    And the kind rent is 'd'
    And the duration rent is 1
    When I pay for the rent
    Then the result is "Amount: 1900"
