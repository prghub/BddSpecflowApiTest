//using RestSharp;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TechTalk.SpecFlow.Infrastructure;

//namespace BddApiTest.StepDefinitions
//{
//    [Binding]
//    public sealed class UserSteps
//    {
//        private readonly ScenarioContext _scenarioContext;
//        private readonly RestClient _client;
//        private RestResponse _response;

//        public UserSteps(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//            _client = new RestClient();
//        }

//        [Given(@"the user sends a get request with url as ""(.*)""")]
//        public void GivenTheUserSendsAGetRequestWithUrlAs(string url)
//        {
//            // Create a GET request for the given URL
//            var request = new RestRequest(url, Method.Get);

//            // Send the request and store the response
//            _response = _client.Execute(request);

//            // Store the response in the ScenarioContext for use in later steps
//            _scenarioContext["Response"] = _response;
//        }

//        [Then(@"request should be a success with (.*) status code")]
//        public void ThenTheRequestShouldBeASuccessWithStatusCode(int expectedStatusCode)
//        {
//            // Retrieve the response from ScenarioContext
//            var response = (RestResponse)_scenarioContext["Response"];

//            // Assert that the response code matches the expected status code
//            if ((int)response.StatusCode != expectedStatusCode)
//            {
//                throw new Exception($"Expected status code {expectedStatusCode}, but got {(int)response.StatusCode}");
//            }
//        }
//    }
//}
