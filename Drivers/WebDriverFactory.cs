using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

public static class WebDriverFactory
{
    public static IWebDriver CreateBrowser(string browser)
    {
        return browser.ToLower() switch
        {
            "firefox" => new FirefoxDriver(),
            "edge" => new EdgeDriver(),
            _ => throw new ArgumentException("Unsupported browser")
        };
    }
}
