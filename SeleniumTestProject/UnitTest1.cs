using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;
using System.ComponentModel.Design;
namespace SeleniumTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://pastebin.com/");
            var code = driver.FindElement(By.Id("postform-text"));
            code.SendKeys("Hello from WebDriver");
            var expirationData = driver.FindElement(By.Id("postform-expiration"));
            driver.FindElement(By.ClassName("field-postform-expiration")).FindElement(By.ClassName("selection")).Click();
            driver.FindElement(By.ClassName("select2-results__options")).FindElements(By.TagName("li"))[2].Click();
            var title = driver.FindElement(By.Id("postform-name"));
            title.SendKeys("helloweb");
            var button = driver.FindElement(By.ClassName("btn"));
            button.Click();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}