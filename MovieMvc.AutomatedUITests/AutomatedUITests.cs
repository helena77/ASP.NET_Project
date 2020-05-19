using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace MovieMvc.AutomatedUITests
{
    public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        public AutomatedUITests()
        {
            _driver = new ChromeDriver(Directory.GetCurrentDirectory());
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void Index_WhenExecuted_ReturnsBingView()
        {
            _driver.Navigate().GoToUrl("https://www.bing.com/");

            Assert.Equal("Bing", _driver.Title);
        }

        [Fact]
        public void Bing_WhenClickImage_ReturnImageView()
        {
            //var CreateWait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(5));
            _driver.Navigate().GoToUrl("https://www.bing.com/");
            _driver.FindElement(By.LinkText("Images")).Click();

            Assert.Equal("Bing Image Trending", _driver.Title);
        }


    }
}
