Feature: This feature contains test scenarios for the following
Login test scenarios

Scenario:Verify user doesn't login with invalid credentials
Given user navigate to turnup portal
When user enters invalid credentials
Then user clicks on the login button




Scenario:Verify user is able to login with valid credentials
Given user navigate to turnup portal
When user enters valid credentials
Then user clicks on the login button

