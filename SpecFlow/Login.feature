Feature: Login to SauceDemo website

  Scenario: User login with valid credentials
    Given User is on the SauceDemo login page
    When User enters username 'standard_user' and password 'secret_sauce'
    And User clicks the login button
    Then User should be logged in successfully