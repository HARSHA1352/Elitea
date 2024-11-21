Feature: Login to SauceDemo website

  Scenario: Verify user login with valid credentials
    Given User is on the SauceDemo login page
    When User enters valid username and password
    And User clicks on the login button
    Then User should be logged in successfully