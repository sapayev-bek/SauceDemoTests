using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver _driver;

    public LoginPage(IWebDriver driver) => _driver = driver;
    public IWebElement UsernameInput => _driver.FindElement(By.CssSelector("#user-name"));
    public IWebElement PasswordInput => _driver.FindElement(By.CssSelector("#password"));
    public IWebElement LoginButton => _driver.FindElement(By.CssSelector("#login-button"));
    public IWebElement ErrorMessage => _driver.FindElement(By.CssSelector("h3[data-test='error']"));

    public void Login(string username, string password)
    {
        UsernameInput.Clear();
        UsernameInput.SendKeys(username);
        PasswordInput.Clear();
        PasswordInput.SendKeys(password);
        LoginButton.Click();
    }

    public string GetErrorMessage() => ErrorMessage.Text;
}
