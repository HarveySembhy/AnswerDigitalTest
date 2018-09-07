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
         
        //Tutorial used: https://www.youtube.com/watch?v=qNfItrgJbYI

        [Test]
        public void ScrollTwice()
        {
            // Open the Chrome and go to Url
            driver = new ChromeDriver(@"C:\driver");
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();

            //Find and click on Infinite Scroll
            IWebElement InfiniteLink = driver.FindElement(By.XPath("//*[@id='content']/ul/li[23]/a"));
            InfiniteLink.Click();

            System.Threading.Thread.Sleep(1000);

            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            var firstScrollHeight = js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");
                        
            System.Threading.Thread.Sleep(1000);
                        
            var secondScrollHeight = js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");

            System.Threading.Thread.Sleep(1000);

            //IWebElement InfiniteHeader = driver.FindElement(By.XPath("//*[@id='content']/div/h3"));

            var thirdScrollHeight = js.ExecuteScript("arguments[0].scrollIntoView()", driver.FindElement(By.XPath("//*[@id='content']/div/h3")));
                        
            System.Threading.Thread.Sleep(1000);
            
            //IWebElement ThirdParagraph = driver.FindElement(By.XPath(""));
            //ThirdParagraph.SendKeys(Keys.PageDown);

            //Wait
            //System.Threading.Thread.Sleep(50);

            //Scroll down the page 'Twice'
            //javaScript.ExecuteScript("window.scrollBy(0, 0, 1000)");
            //System.Threading.Thread.Sleep(2000);

            
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

        //driver.get("http://www.flipkart.com/");
        //driver.manage().window().maximize();
        //driver.findElement(By.linkText("Trimmer")).click();
        //WebElement scroll = driver.findElement(By.id("brand"));
        //scroll.sendKeys(Keys.PAGE_DOWN);

    }
}
