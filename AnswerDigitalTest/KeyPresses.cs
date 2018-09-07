using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AnswerDigitalTest
{
    class KeyPresses
    {
        //Set Variables before test
        IWebDriver driver;

        ////*[@class='example']/p[@id='result']

        //Test case 3: Click on 4 keys and assert the text displayed after every key press

        [Test]
        public void KeyPress()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Key Press
            IWebElement KeyPress = driver.FindElement(By.XPath("//*[@id='content']/ul/li[27]/a"));
            KeyPress.Click();

            Thread.Sleep(1000);

            //Find the page body and SendKeys
            IWebElement PressA = driver.FindElement(By.XPath("/html/body"));
            PressA.SendKeys("a");
            
            Thread.Sleep(1000);

            //Assert for the new element after pressing a
            IWebElement EnteredA = driver.FindElement(By.XPath("//*[@id='content']/div/p[@id='result']"));

            

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}
