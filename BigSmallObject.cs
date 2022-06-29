using ComprehensiveAssesmentBddSpecflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ComprehensiveAssesmentBddSpecflow.CommonMethodFiles
{
    public class BigSmallObject
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

        public void ClickOnSIgnInBtn()
        {
            Thread.Sleep(4000);
            IWebElement signin = BaseClass.driver.FindElement(By.XPath(".//*[@class='link_text']"));
            signin.Click();
        }

        public void ClickOnCreateAccount()
        {
            Thread.Sleep(2000);
            IWebElement searchbar = BaseClass.driver.FindElement(By.XPath(".//*[@id='customer_register_link']"));
            searchbar.Click(); ;
            
        }
        public void EnterFirstName()
        {
            Thread.Sleep(2000);
            IWebElement searchbar1 = BaseClass.driver.FindElement(By.XPath(".//*[@id='FirstName']"));
            searchbar1.SendKeys("Raj");
        }
        public void EnterLastName()
        {
            Thread.Sleep(2000);
            IWebElement amazonmusic = BaseClass.driver.FindElement(By.XPath(".//*[@id='LastName']"));

            amazonmusic.SendKeys("Ritu");

        }

        public void EnterEmail()
        {
            Thread.Sleep(2000);
            IWebElement podcast = BaseClass.driver.FindElement(By.XPath(".//*[@id='Email']"));

            podcast.SendKeys("rajritu@gmail.com");

        }

        public void EnterPassword()
        {
            Thread.Sleep(2000);
            IWebElement podcast1 = BaseClass.driver.FindElement(By.XPath(".//*[@id='CreatePassword']"));

            podcast1.SendKeys("12345678");

        }

        public void CreateAccount()
        {
            Thread.Sleep(2000);
            IWebElement create= BaseClass.driver.FindElement(By.XPath(".//*[@class='btn btn--full']"));

            create.Click();

        }



        public void ClickOnVerifyLogin()
        {
            Thread.Sleep(2000);
            IWebElement dashboard = BaseClass.driver.FindElement(By.XPath(".//*[@class='shopify-challenge__button btn']"));

            dashboard.Click();
        }


        public void EnterEmailId(String user)
        {
            Thread.Sleep(2000);

            IWebElement email = BaseClass.driver.FindElement(By.XPath(".//*[@id='CustomerEmail']"));

            email.SendKeys(user);
        }
        public void EnterPassword1(String pass)
        {


            IWebElement password = BaseClass.driver.FindElement(By.XPath(".//*[@id='CustomerPassword']"));

            password.SendKeys(pass);
        }

        public void ClickOnSiginBtn()
        {
            Thread.Sleep(2000);
            IWebElement login = BaseClass.driver.FindElement(By.XPath(".//*[@class='btn btn--full']"));

            login.Click();
        }
    }
}

