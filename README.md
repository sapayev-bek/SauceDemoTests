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

---

## Original Task
Launch URL: https://www.saucedemo.com/

## UC-1 Test Login form with empty credentials:
- Type any credentials into "Username" and "Password" fields.
- Clear the inputs.
- Hit the "Login" button.
- Check the error messages: "Username is required".

## UC-2 Test Login form with credentials by passing Username:
- Type any credentials in username.
- Enter password.
- Clear the "Password" input.
- Hit the "Login" button.
- Check the error messages: "Password is required".

## UC-3 Test Login form with credentials by passing Username & Password:
- Type credentials in username which are under Accepted username are sections.
- Enter password as secret_sauce.
- Click on Login and validate the title “Swag Labs” in the dashboard.

---

## Additional Requirements:
- Provide parallel execution.
- Add logging for tests.
- Use Data Provider to parametrize tests.
- Make sure all tasks are supported by these 3 conditions: UC-1; UC-2; UC-3.

## Required Tools and Options:
- Test Automation tool: Selenium WebDriver
- Browsers: Edge, Firefox
- Locators: CSS
- Test Runner: xUnit
- Assertions: FluentAssertions
- [Optional] Patterns: Abstract Factory, Adapter, Bridge
- [Optional] Loggers: Log4Net
- [Optional] Test automation approach: BDD