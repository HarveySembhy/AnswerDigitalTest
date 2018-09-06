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
    class InfiniteScroll
    {
        //Set Variables before test
        IWebDriver driver;
        
        /*Test case 2: scroll to the bottom of the page twice and scroll back to the top of the page and assert "Infinite Scroll" text
         */

        //*[@id="content"]/ul/li[23]/a

        //Tutorial used: https://www.youtube.com/watch?v=qNfItrgJbYI

        [Test]
        public void ScrollTwice()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Form Authentication
            IWebElement InfiniteLink = driver.FindElement(By.XPath("//*[@id='content']/ul/li[23]/a"));
            InfiniteLink.Click();

            System.Threading.Thread.Sleep(2000);

            //Scroll down the page 'Once'
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //System.Threading.Thread.Sleep(500);            
            //js.ExecuteScript("window.scrollBy(0, 0, 50)");

            //Wait
            System.Threading.Thread.Sleep(500);

            //Scroll down the page 'Twice'
            js.ExecuteScript();
            //System.Threading.Thread.Sleep(2000);

            driver.Close();
        }

        

    }
}
