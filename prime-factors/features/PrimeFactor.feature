Feature: Prime Factors

Scenario: Prime factors of 1
    Given the number 1
    When I generete the prime factors
    Then there is not prime factors

Scenario: Prime factors of 2
    Given the number 2
    When I generete the prime factors
    Then the prime factor is 2   