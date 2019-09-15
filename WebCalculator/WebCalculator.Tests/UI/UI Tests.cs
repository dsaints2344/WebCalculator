using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace WebCalculator.Tests.UI
{
    public class UI_Tests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"D:\ddelo\Downloads\chromedriver_win32");
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript(
                "function display() {\r\n                    getElementById('result').innerHTML = 1;\r\n                }");
        }

        [Test]

        public void sumOnePlusOneEqualsTwo()
        {
            driver.Url =
                @"C:\Users\ddelo\Source\Repos\WebCalculator\WebCalculator\WebCalculator\Views\Home\index.html";
            driver.FindElement(By.Id("numberOne")).Click();
            Assert.AreEqual("1", driver.FindElement(By.Id("result")).Text);
            driver.FindElement(By.Id("addition")).Click();
            Assert.AreEqual("", driver.FindElement(By.Id("result")).Text);
            driver.FindElement(By.Id("numberOne")).Click();
            Assert.AreEqual("1", driver.FindElement(By.Id("result")).Text);
            driver.FindElement(By.Id("eqn-bg")).Click();
            Assert.AreEqual("2", driver.FindElement(By.Id("result")).Text);
            
        }

        [TearDown]

        public void closeBrowser()
        {
            driver.Close();
        }



    }
}
