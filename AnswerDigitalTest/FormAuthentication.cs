using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AnswerDigitalTest
{
    class FormAuthentication
    {
        IWebDriver driver;

        /*
         Test case 1: Automate Form Authentication         Scenario 1: Try to login with correct username and wrong password and assert login validation
         Scenario 2: Try to login with incorrect username and correct password and assert login validation
         Scenario 3: Try to login with correct username and password and then logout

        */

        [Test]
        public void Scenario1()
        {
            //Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();


            //Close browser - End Test
            driver.Close();


        }

        [Test]
        public void Scenario2()
        {
            //Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();



            //Close browser - End Test
            driver.Close();


        }

        [Test]
        public void Scenario3()
        {
            //Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();

            //Close browser - End Test
            driver.Close();
        }
    }
}
