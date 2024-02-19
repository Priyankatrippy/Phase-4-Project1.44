Feature: UserLogin

A short summary of the feature

@mytag
Scenario:Successfull UserLogin
Given a user with valid username "sam1256" and valid password "sam@1256@1256"

When the Login method is called
Then the result ahould Login Success

Scenario: UnSuccessfull UserLogin
Given a user with invalid username "Invalid_user" and invalid password "invalid"
When the Login method is called
Then  the result should Login Failed
