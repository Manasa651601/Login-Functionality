Feature: Login Validation

  Scenario: Successful login with valid credentials
    Given User is on the login page
    When User enters valid username and password
    And User clicks on login button
    Then User should be logged in successfully

  Scenario: Invalid login with incorrect credentials
    Given User is on the login page
    When User enters invalid username and password
    And User clicks on login button
    Then User should see an error message

  Scenario: Login attempt with empty fields
    Given User is on the login page
    When User leaves username and password fields empty
    And User clicks on login button
    Then User should see a validation message

  Scenario Outline: Multiple login attempts
    Given User is on the login page
    When User enters <username> and <password>
    And User clicks on login button
    Then User should see <message>

    Examples:
      | username | password | message                  |
      | user1    | pass1    | Login successful          |
      | user2    | pass2    | Incorrect username or password |
      | user3    |         | Password is required      |
      |          | pass4    | Username is required      |
