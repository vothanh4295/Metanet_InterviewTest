using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Metanet_InterviewTest.Tests
{
    public class TestBase:IDisposable
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        public TestBase() { }
        public TestBase(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
