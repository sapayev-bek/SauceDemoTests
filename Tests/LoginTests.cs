using OpenQA.Selenium;
using Xunit;
using FluentAssertions;

public class LoginTests : IDisposable
{
    private IWebDriver? _driver;

    [Theory]
    [InlineData("firefox", "", "", "Username is required")]
    [InlineData("edge", "", "", "Username is required")]
    [InlineData("firefox", "standard_user", "", "Password is required")]
    [InlineData("edge", "standard_user", "", "Password is required")]
    [InlineData("firefox", "standard_user", "secret_sauce", "Swag Labs")]
    [InlineData("edge", "standard_user", "secret_sauce", "Swag Labs")]
    public void LoginTest(string browser, string username, string password, string expected)
    {
        _driver = WebDriverFactory.CreateBrowser(browser);
        _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        var loginPage = new LoginPage(_driver);
        loginPage.Login(username, password);

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            loginPage.GetErrorMessage().Should().Contain(expected);
        else
            _driver.Title.Should().Contain(expected);
    }

    public void Dispose()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}