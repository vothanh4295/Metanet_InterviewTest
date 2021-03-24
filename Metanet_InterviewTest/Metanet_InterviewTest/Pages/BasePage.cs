using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Metanet_InterviewTest.Pages
{
    public class BasePage:IDisposable
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        public BasePage() { }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
