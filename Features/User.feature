Feature: to test the user request

A short summary of the feature

@tag1
Scenario: Get request testing
	Given the user sends a get request with url as "https://reqres.in/api/users/2"
	Then request should be a success with 200 status code

  @tag2
  Scenario: Post request testing
    Given the user sends a post request with url as "https://reqres.in/api/users" and body "{ \"name\": \"morpheus\", \"job\": \"leader\" }"
    Then the post request should be a success with 201 status code

  @tag3
  Scenario: Update request testing
    Given the user sends a put request with url as "https://reqres.in/api/users/2" and body "{ \"name\": \"morpheus\", \"job\": \"zion resident\" }"
    Then the put request should be a success with 200 status code

  @tag4
  Scenario: Delete request testing
	Given the user sends a delete request with url as "https://reqres.in/api/users/2"
	Then delete request should be a success with 204 status code