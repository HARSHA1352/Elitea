Feature: Login to SauceDemo website

Scenario: User login with valid credentials
  Given I navigate to 'https://www.saucedemo.com/'
  When I enter the username 'standard_user' and password 'secret_sauce'
  And I click the login button
  Then I should be logged in successfully