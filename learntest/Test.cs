using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
namespace learntest
{
    [TestFixture]
    public class Class1
    {
        static string GoodsUrl = "https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7";
        static void pageWithgoods(ChromeDriver browser)
        {
            browser.Navigate().GoToUrl("https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7");
        }
        static void CategoriesOfMain(string nameOfCategoria, string buttonAll)
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement categoria = browser.FindElement(By.CssSelector(nameOfCategoria));
            categoria.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = browser.FindElement(By.CssSelector(buttonAll));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();
        }

        [Test]
        public void go_to_home_page()
        {
            ChromeDriver browser = new ChromeDriver();
            pageWithgoods(browser);
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
            var c = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(1) > div > a";
            var buttonall = "#bottom36 > div > a";
            CategoriesOfMain(c, buttonall);

            //IWebDriver browser = new ChromeDriver();
            //browser.Navigate().GoToUrl("https://www.olx.ua");
            //IWebElement deti = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(1) > div > a"));
            //deti.Click();
            //browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //IWebElement button = browser.FindElement(By.CssSelector("#bottom36 > div > a"));
            //button.Click();
            //browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //browser.Close();
        }

        [Test]
        public void nedviz()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(2) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom1 > div > a > strong");

            //IWebDriver browser = new ChromeDriver();
            //browser.Navigate().GoToUrl("https://www.olx.ua");
            //IWebElement nedvizh = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(2) > div"));
            //nedvizh.Click();
            //browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //IWebElement button = browser.FindElement(By.CssSelector("#bottom1 > div > a"));
            //button.Click();
            //browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //browser.Close();

        }

        [Test]
        public void cars()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(3) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom1532 > div > a > strong");
            //IWebDriver browser = new ChromeDriver();
            //browser.Navigate().GoToUrl("https://www.olx.ua");
            //IWebElement car = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(3) > div > a"));
            //car.Click();
            //browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //IWebElement button = browser.FindElement(By.CssSelector("#bottom1532 > div > a"));
            //button.Click();
            //browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //browser.Close();

        }

        [Test]
        public void zapchast()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(4) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom3 > div > a > strong");
        }

        [Test]
        public void animal()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(2) > div > a > span:nth-child(1)";
            var buttonAll = "#bottom35 > div > a > strong";
            CategoriesOfMain(nameOfCategoria, buttonAll);

        }

        [Test]
        public void dom()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(3) > div > a > span:nth-child(1)";
            var buttonAll = "#bottom899 > div > a > strong";
            CategoriesOfMain(nameOfCategoria, buttonAll);

        }

        [Test]
        public void electron()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(4) > div > a > span:nth-child(1)";
            var buttonAll = "#bottom37 > div > a > strong";
            CategoriesOfMain(nameOfCategoria, buttonAll);

        }

        [Test]
        public void rabota()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(1) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom6 > div > a > strong");
        }

        [Test]
        public void bussines()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(11) > div:nth-child(1) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom7 > div > a > strong");
        }

        [Test]
        public void moda()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(11) > div:nth-child(2) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom891 > div > a > strong");
        }

        [Test]
        public void hobbi()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(11) > div:nth-child(3) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom903 > div > a > strong");
        }

        [Test]
        public void darom()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement categoria = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(11) > div:nth-child(4) > div > a > span:nth-child(1)"));
            categoria.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();
        }

        [Test]
        public void obmen()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement categoria = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(16) > div.li.fleft > div > a > span:nth-child(1)"));
            categoria.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();
        }

        [Test]
        public void searchInCategory()
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
            browser.Close();
        }

        [Test]
        public void emailme()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            var element = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(1) > a > span"));
            Actions actions = new Actions(browser);
            actions.MoveToElement(element);
            actions.Perform();
            IWebElement mail = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(1) > a > span"));
            mail.Click();
            browser.Close();
        }


        [Test]
        public void contact()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            var element = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(2) > div"));
            Actions actions = new Actions(browser);
            actions.MoveToElement(element);
            actions.Perform();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement contac = browser.FindElement(By.CssSelector("#contact_methods > li:nth-child(2) > div"));
            contac.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            browser.Close();
        }

        [Test]
        public void otherads()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            IWebElement otherad = browser.FindElement(By.XPath("//*[@id=\"offeractions\"]/div[4]/div[2]/a"));
            otherad.Click();
            browser.Close();

        }

        [Test]
        public void addToBasket()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var element = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(1) > div > a"));
            Actions actions = new Actions(browser);
            actions.MoveToElement(element);
            actions.Perform();
            IWebElement star = browser.FindElement(By.CssSelector("#offerdescription > div:nth-child(1) > div > a"));
            star.Click();
            browser.Close();
        }

        [Test]
        public void logo()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement cont = browser.FindElement(By.Id("headerLogo"));
            cont.Click();
            browser.Close();
        }
    }
}