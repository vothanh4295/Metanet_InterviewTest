using System;
using OpenQA.Selenium;
using Metanet_InterviewTest.Pages;

namespace Metanet_InterviewTest.Tests
{
    public class TestLoginPage : TestBase
    {
        public TestLoginPage() : base() { }

        public TestLoginPage(IWebDriver driver) : base(driver) { }

        public bool LoginInSystem(string username, string password)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSystem(username, password);
            try
            {
                return loginPage.VerifyLoginSuccessfully();
            }
            catch { return false; }
        }
    }
}
