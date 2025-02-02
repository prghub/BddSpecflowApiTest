# BDD API Test with SpecFlow, xUnit, and RestSharp (Using https://reqres.in/)

This project demonstrates API testing using Behavior-Driven Development (BDD) principles with **SpecFlow**, **xUnit**, and **RestSharp**. The tests are structured in a BDD style, allowing easy collaboration and automated API testing.

## Table of Contents

- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Project Setup](#project-setup)
- [Prerequisites](#prerequisites)

## Overview

This repository contains tests for various API endpoints, structured using **SpecFlow** for BDD. The test scenarios are written in **Gherkin syntax** and are implemented using SpecFlow step definitions. The tests are executed using **xUnit** as the test runner, and **RestSharp** is used for making HTTP requests to the API.

Key features of this project:
- BDD-style tests using SpecFlow.
- API request handling using RestSharp.
- Test logging using **xUnit's `ITestOutputHelper`**.

## Technologies Used

- **SpecFlow**: A BDD framework for .NET to define scenarios and automate tests.
- **xUnit**: A testing framework for .NET to run the tests and generate reports.
- **RestSharp**: A popular HTTP client for making API requests.
- **Newtonsoft.Json**: For serializing and deserializing JSON in HTTP requests and responses.

## Project Setup

### Prerequisites

- **.NET SDK**: Ensure that the latest version of the .NET SDK is installed on your machine. You can check this by running:
  ```bash
  dotnet --version
