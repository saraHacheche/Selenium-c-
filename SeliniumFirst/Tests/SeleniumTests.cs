using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeliniumFirst.Tests

{
    [TestFixture]

    class SeleniumTests

    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void startBrowser()
        {

            ChromeOptions opt = new ChromeOptions();
            opt.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            driver = new ChromeDriver(opt);

            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void testLogin()
        {
            Console.WriteLine("test  sara running..");
        }


    }



}

