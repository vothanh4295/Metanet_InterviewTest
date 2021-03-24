using System;
using OpenQA.Selenium;

namespace Metanet_InterviewTest.Pages
{
    public class ProductPage:BasePage
    {
        private int NoProducts => driver.FindElements(By.ClassName("inventory_item_name")).Count;
        private IWebElement LblProduct => driver.FindElement(By.Id("Products"));

        public ProductPage()
        {
        }

        public ProductPage(IWebDriver driver) : base(driver)
        {

        }

        public int GetNumberOfProduct()
        {
            return NoProducts;
        }

        public bool VerifyLabel()
        {
            try
            {
                return LblProduct.Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}
