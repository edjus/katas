Feature: Car rental

@wip @ignore
Scenario: Hourly rent
    Given the rent date '2019-01-19'
    And the return date '2019-01-19'
    And cuit number 20112223336
    And the kind rent is 'hour'
    And the duration rent is 3
    When I pay for the rent
    Then the import is 300