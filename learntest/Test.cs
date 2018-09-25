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
        [Test]
        public void all_in_deti()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement deti = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(1) > div > a"));
            deti.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = browser.FindElement(By.CssSelector("#bottom36 > div > a"));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();

        }

        [Test]
        public void nedviz()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement nedvizh = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(2) > div"));
            nedvizh.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = browser.FindElement(By.CssSelector("#bottom1 > div > a"));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();

        }

        [Test]
        public void cars()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement car = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(3) > div > a"));
            car.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = browser.FindElement(By.CssSelector("#bottom1532 > div > a"));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();

        }

        [Test]
        public void zapchast()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement zapas = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(4)"));
            zapas.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = browser.FindElement(By.CssSelector("#bottom3 > div > a"));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.FindElement(By.CssSelector("#search-text"));
            IWebElement TextBox = browser.FindElement(By.CssSelector("#search-text"));
            TextBox.Clear();
            TextBox.SendKeys("резина");
            IWebElement pop = browser.FindElement(By.CssSelector("#paramsListOpt > div > div.fblock.fleft.olx-delivery-filter.last.olx-delivery-filter.js-highlight-element.highlight-element-active > div.highlight-container > div.highlight-text > span"));
            pop.Click();
            IWebElement searchbutton = browser.FindElement(By.CssSelector("#search-submit"));
            searchbutton.Click();
        }

        [Test]
        public void nobutton()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua/nedvizhimost/dnepr/");
            IWebElement notbut = browser.FindElement(By.CssSelector("#param_state > div > a > span.header.block"));
            Assert.False(notbut.Displayed);
            browser.Close();
        }

        [Test]
        public void choicephoto()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7");
            IWebElement hare = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(4) > div > img"));
            hare.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement button = browser.FindElement(By.CssSelector("#bigImage > div.lshownext.abs.cpointer.bigImageNext > a > span"));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            browser.Close();
        }

        [Test]
        public void contact()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7");
            IWebElement cont = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(2) > div > span"));
            cont.Click();
            Assert.True(cont.Displayed);
            browser.Close();
        }

        [Test]
        public void emailme()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7");
            IWebElement mail = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(1) > a > span"));
            mail.Click();
            Assert.True(mail.Displayed);
            browser.Close();
        }
    }
}