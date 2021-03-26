using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Metanet_InterviewTest.Tests
{
    public class TestCase : IDisposable
    {
        private IWebDriver driver = null;

        public TestCase()
        {
            //string dir = "/Users/Document/Interview/Metanet_InterviewTest/Metanet_InterviewTest/Metanet_InterviewTest/Driver";
            //driver = new ChromeDriver(@"\..\..\..\Driver");
            string dir = Environment.CurrentDirectory + @"/../../../Driver";
            driver = new ChromeDriver(dir);
        }

        [Theory]
        [InlineData(6)] //expected result
        public void VerifyHowManyProduct(int expected)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            try
            {
                TestLoginPage testLoginPage = new TestLoginPage(driver);
                testLoginPage.LoginInSystem("standard_user", "secret_sauce");
                
                TestProductPage testProductPage = new TestProductPage(driver);
                Assert.Equal(testProductPage.GetNumberOfProduct(),expected);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }
        }

        public void Dispose()
        {
        }
    }
}