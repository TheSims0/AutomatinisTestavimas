﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeleniumTestsWithoutPOM
{
    public class Google
    {
        [Test]
        public void OpenGoogle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            //IWebElement buttonRejecetCookies = driver.FindElement(By.Id("W0wltc"));
            //buttonRejecetCookies.Click();
            IWebElement buttonRejecetCookies = driver.FindElement(By.XPath("(//*[@id='CXQnmb']//button)[3]"));
            buttonRejecetCookies.Click();
        }
    }
}
