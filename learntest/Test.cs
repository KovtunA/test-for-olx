using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace learntest
{
    [TestFixture] 
    public class Class1 
    {
        [Test] 
        public void go_to_home_page() 
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua/rabota/stroitelstvo/dnepr/");
            IWebElement button = browser.FindElement(By.CssSelector("#headerLogo"));
            button.Click();
            browser.Close();

        }
        [Test]
        public void submit_search()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement button = browser.FindElement(By.CssSelector("#submit-searchmain"));
            button.Click();
            browser.Close();
        }
        [Test]
        public void all_in_deti()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement button = browser.FindElement(By.CssSelector("#bottom36 > div"));
            button.Click();
            browser.Close();
        }
    }
}