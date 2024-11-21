Feature: Login

Scenario: Successful Login
  Given I am on the SauceDemo login page
  When I enter valid username and password
  And I click the login button
  Then I should be logged in successfully