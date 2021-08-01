Feature: Login Functionality of Pluralsight

@smoke
Scenario: login functionality with invalid credentials 
Given User launches browser and opens plural sight application
When User enters invalid credentials 
Then user should not navigated to the home page