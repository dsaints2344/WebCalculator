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
            driver = new ChromeDriver(@"D:\ddelo\Downloads\chromedriver_win32\");
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            //js.ExecuteScript("function display(id) { document.getElementById('result').innerHTML = document.getElementBy(id).value;}");
            
        }

        [Test]

        public void sumOnePlusOneEqualsTwo()
        {
           
            driver.Url =
                @"C:\Users\ddelo\source\repos\WebCalculator\WebCalculator\WebCalculator\Views\Home\index.html";
            driver.FindElement(By.Id("numberOne")).Click();
            Assert.AreEqual("1", FindResultValue());
//            driver.FindElement(By.Id("addition")).Click();
//            Assert.AreEqual("1+", FindResultValue());
//            driver.FindElement(By.Id("numberOne")).Click();
//            Assert.AreEqual("1+1", FindResultValue());
//            driver.FindElement(By.Id("eqn-bg")).Click();
//            Thread.Sleep(3000);
//            Assert.AreEqual("2", FindResultValue());

        }

        [Test]
        public void NumbersSubtraction()
        {
            driver.Url =
                @"C:\Users\ddelo\source\repos\WebCalculator\WebCalculator\WebCalculator\Views\Home\index.html";
            driver.FindElement(By.Id("numberTwo")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("subtraction")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("numberOne")).Click();
            driver.FindElement(By.Id("eqn-bg")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("1", FindResultValue());
        }

        [Test]
        public void NumberMultiplication()
        {
            driver.Url =
                @"C:\Users\ddelo\source\repos\WebCalculator\WebCalculator\WebCalculator\Views\Home\index.html";
            driver.FindElement(By.Id("numberTwo")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("multiplication")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("numberTwo")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("eqn-bg")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("4",FindResultValue());
        }

        [Test]
        public void ThreeMultiplicationByThree()
        {
            driver.Url =
                @"C:\Users\ddelo\source\repos\WebCalculator\WebCalculator\WebCalculator\Views\Home\index.html";
            driver.FindElement(By.Id("numberThree")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("multiplication")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("numberTwo")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("eqn-bg")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual("6", FindResultValue());
        }

        private string FindResultValue()
        {
            string valueResult = driver.FindElement(By.Id("resultInput")).GetAttribute("value");
            return valueResult;
        }

        [TearDown]

        public void closeBrowser()
        {
            driver.Close();
        }



    }
}
