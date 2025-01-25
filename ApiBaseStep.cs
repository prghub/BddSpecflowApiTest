using RestSharp;
using TechTalk.SpecFlow.Infrastructure;
using System;
using Newtonsoft.Json;
using Xunit.Abstractions;

namespace BddApiTest
{
    public class ApiBaseStep
    {
        protected readonly ScenarioContext _scenarioContext;
        protected readonly RestClient _client;
        protected RestResponse _response;
        protected readonly ITestOutputHelper _output;  // Add the output helper here


        public ApiBaseStep(ScenarioContext scenarioContext, ITestOutputHelper output)
        {
            _scenarioContext = scenarioContext;
            _client = new RestClient();  // You can add base URL configuration here if necessary
            _output = output;
        }

        // Common method for sending requests
        protected void SendRequest(string url, Method method, object body = null)
        {
            var request = new RestRequest(url, method);

            if (body != null)
            {
                string data = JsonConvert.SerializeObject(body);
                var contentData = new StringContent(data);
                request.AddJsonBody(contentData);
                request.AddHeader("Content-Type", "application/json");// For POST/PUT requests, you can add a JSON body
            }

            _response = _client.Execute(request);
            _scenarioContext["Response"] = _response;

            // Log response details
            _output.WriteLine($"Response Content: {_response.Content}");  // Log the response content
        }
    }
}
