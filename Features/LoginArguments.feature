Feature: Login Functionality 

@smoke
Scenario: To validate login functionality with invalid credentials 

Given User launches browser and opens "https://app.pluralsight.com/id"
When User enters username as "Kalidass" and password as "12345678"
Then user will be navigated to the error page