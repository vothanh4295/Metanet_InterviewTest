using System;
using OpenQA.Selenium;

namespace Metanet_InterviewTest.Pages
{
    public class LoginPage:BasePage
    {
        private IWebElement TxtUsername => driver.FindElement(By.Id("user-name"));
        private IWebElement TxtPassword => driver.FindElement(By.Id("password"));
        private IWebElement BtnLogin => driver.FindElement(By.Id("login-button"));

        public LoginPage() : base() { }

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void LoginSystem(string username, string password) {
            TxtUsername.SendKeys(username);
            TxtPassword.SendKeys(password);
            BtnLogin.Click();
        }

        public bool VerifyLoginSuccessfully() => new ProductPage(driver).VerifyLabel();
    }
}
