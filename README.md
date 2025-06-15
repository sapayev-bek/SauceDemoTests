# SauceDemo UI Automation Tests

## Description
Automated tests for login functionality at https://www.saucedemo.com using Selenium WebDriver and xUnit.

## Tech Stack
- C#
- Selenium WebDriver
- xUnit
- FluentAssertions
- Log4Net
- .NET 6

## Features
- Page Object Model
- Cross-browser support (Firefox & Edge)
- Parametrized tests via xUnit [Theory]
- Logging (Log4Net)
- Parallel test execution
- Clean architecture with Factory pattern

## How to Run
1. Install dependencies: dotnet restore
2. Run tests: dotnet test

## Project Structure
├── Pages/
│ └── LoginPage.cs
├── Drivers/
│ └── WebDriverFactory.cs
├── Tests/
│ └── LoginTests.cs
├── Utils/
│ └── Logger.cs
├── xunit.runner.json
├── README.md