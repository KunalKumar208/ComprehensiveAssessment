using ComprehensiveAssesmentBddSpecflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ComprehensiveAssesmentBddSpecflow.CommonMethodFiles
{
    public class BasicFunctionObject
    {
        public void VerifyHome()
        {
            IWebElement home;
            bool display = true;
            home = BaseClass.driver.FindElement(By.XPath(".//*[@class='small--hide']"));
            display = home.Displayed;

            Thread.Sleep(2000);
            //BaseClass.driver.Manage().Timeouts().ImplicitWait();

        }

        public void ClickonSale()
        {
            IWebElement sale = BaseClass.driver.FindElement(By.LinkText("Sale"));
            sale.Click();
        }

        public void SelectProduct()
        {
            Thread.Sleep(2000);
            //BaseClass.driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(2));
            IWebElement product = BaseClass.driver.FindElement(By.XPath(".//*[@class='grid-product__title']"));
            product.Click();
        }

        public void IncreaseQuantity()
        {
            Thread.Sleep(2000);
            IWebElement quantity = BaseClass.driver.FindElement(By.XPath(".//*[@class='js--qty-adjuster js--add']"));
            quantity.Click();

        }
        public void CheckCodAvalibility()
        {

            IWebElement quantity = BaseClass.driver.FindElement(By.XPath(".//*[@id='PostalCode']"));
            quantity.SendKeys("110044");
        }

        public void AddtoCart()
        {
            Thread.Sleep(1000);
            IWebElement cart = BaseClass.driver.FindElement(By.XPath(".//*[@name='add']"));
            cart.Click();
        }
        public void ClickonCheckout()
        {
            Thread.Sleep(2000);
            IWebElement checkout = BaseClass.driver.FindElement(By.XPath(".//*[@name='checkout']"));
            checkout.Click();
        }

        public void ClickonLoginFunction()
        {

            Thread.Sleep(1000);
            IWebElement login = BaseClass.driver.FindElement(By.CssSelector("body > div > div > div > main > div.step > form > div.step__sections > div.section.section--contact-information > div.section__header > div > p > a"));
            login.Click();
        }

        public void VerifyloginPage()
        {
            Thread.Sleep(1000);
            IWebElement login;
            bool visible = true;
            login = BaseClass.driver.FindElement(By.XPath(".//*[@class='section-header__title']"));
            //login.Click();
            visible = login.Displayed;
        }


      

        public void SelectguyProduct()
        {
            Thread.Sleep(2000);
            IWebElement guy = BaseClass.driver.FindElement(By.LinkText("Beard Catcher"));
            guy.Click();
        }

        public void VerifyCheckOut()
        {
            Thread.Sleep(1000);
            IWebElement checkout;
            bool visible = true;
            checkout = BaseClass.driver.FindElement(By.XPath(".//span[.='Go To Checkout']"));
            //login.Click();
            visible = checkout.Displayed;


        }
    }
}
