Feature: Login of Pluralsight

@smoke
Scenario: login with invalid credentials 
Given User opens plural sight application
When User clicks invalid credentials
         | username | password |
         | Kalidass | 12345678 |

Then user navigated again to the home page

@regression
Scenario Outline: Login Function with Inavlid credentials 

Given User launches plural sight application
When User is trying to login with "<username>" and "<password>"
Then user should be navigated to the error page

Examples: 
          | username | password |
          | Kalidass | 12345lf678 |
 