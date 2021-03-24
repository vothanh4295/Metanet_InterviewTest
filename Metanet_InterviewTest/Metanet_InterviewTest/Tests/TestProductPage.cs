using System;
using OpenQA.Selenium;
using Metanet_InterviewTest.Pages;

namespace Metanet_InterviewTest.Tests
{
    public class TestProductPage: TestBase
    {
        public TestProductPage() { }

        public TestProductPage(IWebDriver driver) : base(driver) { }

        public int GetNumberOfProduct()
        {           
            return new ProductPage(driver).GetNumberOfProduct();
        }
    }
}
