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
            IWebElement button1 = browser.FindElement(By.CssSelector("#submit-searchmain"));
            button1.Click();
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
        //[Test]
        //public void all_in_deti()
        //{
        //    IWebDriver browser = new ChromeDriver();
        //    browser.Navigate().GoToUrl("https://www.olx.ua");
        //    IWebElement deti = browser.FindElement(By.CssSelector("//*[@id=\"searchmain - container\"]/div/div/div[1]/div[1]/div/a"));
        //    deti.Click();
        //    browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    IWebElement button = browser.FindElement(By.CssSelector("//*[@id=\"searchmain - container\"]/div/div/div[1]/div[1]/div/a"));
        //    button.Click();
        //    browser.Close();
        //}
    }
}