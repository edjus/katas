Feature: Prime Factors

Scenario: Prime factors of 1
    Given the number 1
    When I generete the prime factors
    Then there is not prime factors

Scenario: Prime factors of 2
    Given the number 2
    When I generete the prime factors
    Then the prime factor is 2   

Scenario: Prime factors of 3
    Given the number 3
    When I generete the prime factors
    Then the prime factor is 3

Scenario: Prime factors of 4
    Given the number 4
    When I generete the prime factors
    Then the prime factors are 2,2

Scenario: Prime factors of 5
    Given the number 5
    When I generete the prime factors
    Then the prime factor is 5

@ignore @wip
Scenario: Prime factors of 6
    Given the number 6
    When I generete the prime factors
    Then the prime factor are 2,3