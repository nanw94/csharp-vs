﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace OnlineStore_1.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.store.demoqa.com";

            // Find the element that's ID attribute is 'account'(My Account) 
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();

            // Find the element that's ID attribute is 'log' (Username)
            // Enter Username on the element found by above desc.
            driver.FindElement(By.Id("log")).SendKeys("testuser_1");

            // Find the element that's ID attribute is 'pwd' (Password)
            // Enter Password on the element found by the above desc.
            driver.FindElement(By.Id("pwd")).SendKeys("Test@123");

            // Now submit the form.
            driver.FindElement(By.Id("login")).Click();

            // Close the driver
            driver.Quit();

            //push?
        }
    }
}