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
        //Set Variables before test
        IWebDriver driver;
        
        /*
         Test case 1: Automate Form Authentication

         Scenario 1: Try to login with correct username and wrong password and assert login validation
         Scenario 2: Try to login with incorrect username and correct password and assert login validation
         Scenario 3: Try to login with correct username and password and then logout

        */
        //[SetUp]
        //public void OpenBrowser()
        //{
        //    //Open the Chrome and go to Url
        //    driver = new ChromeDriver(@"C:\driver");
        //    driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        //    driver.Manage().Window.Maximize();
        //}


        [Test]
        public void Scenario1()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();

            System.Threading.Thread.Sleep(2000);

            //Find Username and type in "tomsmith"
            IWebElement Username = driver.FindElement(By.Id("username"));
            Username.SendKeys("tomsmith");

            System.Threading.Thread.Sleep(1000);

            //Find Password and type in "harvey"
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("harvey");

            System.Threading.Thread.Sleep(2000);

            //Find Login button and click
            IWebElement Login = driver.FindElement(By.XPath("//div[2]/div/div/form/button"));
            Login.Click();

            //Set a wait period
            System.Threading.Thread.Sleep(2000);

            //Verify username invalid error
            IWebElement Error = driver.FindElement(By.Id("flash"));

            //Set a wait period
            System.Threading.Thread.Sleep(2000);

            driver.Quit();
        }
        
        [Test]
        public void Scenario2()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();

            System.Threading.Thread.Sleep(2000);

            //Find Username and type in "tomsmith"
            IWebElement Username = driver.FindElement(By.Id("username"));
            Username.SendKeys("harveysembhy");

            System.Threading.Thread.Sleep(1000);

            //Find Password and type in "harvey"
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("SuperSecretPassword!");

            System.Threading.Thread.Sleep(2000);

            //Find Login button and click
            IWebElement Login = driver.FindElement(By.XPath("//div[2]/div/div/form/button"));
            Login.Click();
                        
            //Set a wait period
            System.Threading.Thread.Sleep(2000);

            //Verify Success message
            IWebElement Success = driver.FindElement(By.Id("flash"));

            //Set a wait period
            System.Threading.Thread.Sleep(2000);

            driver.Quit();
        }
                
        [Test]
        public void Scenario3()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Form Authentication
            driver.FindElement(By.XPath("//*[@id='content']/ul/li[18]/a")).Click();

            System.Threading.Thread.Sleep(2000);

            //Find Username and type in "tomsmith"
            IWebElement Username = driver.FindElement(By.Id("username"));
            Username.SendKeys("tomsmith");

            System.Threading.Thread.Sleep(1000);

            //Find Password and type in "harvey"
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("SuperSecretPassword!");

            System.Threading.Thread.Sleep(2000);

            //Find Login button and click
            IWebElement Login = driver.FindElement(By.XPath("//div[2]/div/div/form/button"));
            Login.Click();

            //Set a wait period
            System.Threading.Thread.Sleep(2000);

            //Logout button
            IWebElement LogOut = driver.FindElement(By.XPath("//div[2]/div/div/a"));
            LogOut.Click();                       

            //Verify you are on the Login Page
            IWebElement LoginPageText = driver.FindElement(By.XPath("//div[2]/div/div/h2"));

            //Set a wait period
            System.Threading.Thread.Sleep(2000);

            driver.Quit();
        }
       
    }
}
