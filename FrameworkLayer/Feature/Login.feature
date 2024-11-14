Feature: Login Functionality

Scenario Outline: Valid Login
    Given User is on the login page
    When User enters '<username>' and '<password>'
    And Clicks on Login button
    Then User should be logged in successfully

Examples:
    | username | password |
    | standard_user | secret_sauce |
    | problem_user | secret_sauce |
    | performance_glitch_user | secret_sauce |