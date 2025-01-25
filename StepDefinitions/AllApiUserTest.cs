using RestSharp;
using TechTalk.SpecFlow;
using System;
using Xunit.Abstractions;

namespace BddApiTest.StepDefinitions
{
    [Binding]
    public class AllApiUserTest :ApiBaseStep
    {
        // Constructor accepts both ScenarioContext and ITestOutputHelper
        public AllApiUserTest(ScenarioContext scenarioContext, ITestOutputHelper output) : base(scenarioContext, output)
        {
        }

        // For GET request
        [Given(@"the user sends a get request with url as ""(.*)""")]
        public void GivenTheUserSendsAGetRequestWithUrlAs(string url)
        {
            SendRequest(url, Method.Get);
        }

        [Then(@"request should be a success with (.*) status code")]
        public void ThenTheRequestShouldBeASuccessWithStatusCode(int expectedStatusCode)
        {
            var response = (RestResponse)_scenarioContext["Response"];

            if ((int)response.StatusCode != expectedStatusCode)
            {
                throw new Exception($"Expected status code {expectedStatusCode}, but got {(int)response.StatusCode}");
            }
        }

        // For POST request
        [Given(@"the user sends a post request with url as ""(.*)"" and body ""(.*)""")]
        public void GivenTheUserSendsAPostRequestWithUrlAndBody(string url, string body)
        {
            SendRequest(url, Method.Post, body);

            var _response = (RestResponse)_scenarioContext["Response"];

            if (_response == null)
            {
                throw new Exception("Response is null");
            }

        }

        [Then(@"the post request should be a success with (.*) status code")]
        public void ThenThePostRequestShouldBeASuccessWithStatusCode(int expectedStatusCode)
        {

            if ((int)_response.StatusCode != expectedStatusCode)
            {
                throw new Exception($"Expected status code {expectedStatusCode}, but got {(int)_response.StatusCode}");
            }
        }

        // For Put request
        [Given(@"the user sends a put request with url as ""(.*)"" and body ""(.*)""")]
        public void GivenTheUserSendsAPUtRequestWithUrlAndBody(string url, string body)
        {
            SendRequest(url, Method.Put, body);

            var _response = (RestResponse)_scenarioContext["Response"];

            if (_response == null)
            {
                throw new Exception("Response is null");
            }

        }

        [Then(@"the put request should be a success with (.*) status code")]
        public void ThenThePutRequestShouldBeASuccessWithStatusCode(int expectedStatusCode)
        {

            if ((int)_response.StatusCode != expectedStatusCode)
            {
                throw new Exception($"Expected status code {expectedStatusCode}, but got {(int)_response.StatusCode}");
            }
        }

        // For Delete request
        [Given(@"the user sends a delete request with url as ""(.*)""")]
        public void GivenTheUserSendsADeleteRequestWithUrlAs(string url)
        {
            SendRequest(url, Method.Delete);
        }

        [Then(@"delete request should be a success with (.*) status code")]
        public void ThenTheDeleteRequestShouldBeASuccessWithStatusCode(int expectedStatusCode)
        {
            var response = (RestResponse)_scenarioContext["Response"];

            if ((int)response.StatusCode != expectedStatusCode)
            {
                throw new Exception($"Expected status code {expectedStatusCode}, but got {(int)response.StatusCode}");
            }
        }

    }
}
