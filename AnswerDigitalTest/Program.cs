﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AnswerDigitalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkLogin = new FormAuthentication();
            var checkScroll = new InfiniteScroll();
            var checkKeyPress = new KeyPresses();

            //Test

            try
            {
                Console.WriteLine("Checking Login Tests...");
                checkLogin.Scenario1();
                checkLogin.Scenario2();
                checkLogin.Scenario3();
                Console.WriteLine("Login Tests have PASSSED");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Login checks Failed");
            }

            try
            {
                Console.WriteLine("Checking Infinite Scrolling Tests...");
                checkScroll.ScrollTwice();
                Console.WriteLine("Scrolling tests have PASSED");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Scrolling tests have Failed");
            }

            try
            {
                Console.WriteLine("Checking Key Press Tests...");
                checkKeyPress.KeyPress();
                Console.WriteLine("Key Press tests PASSED");
            }

            catch (NoSuchElementException)
            {
                Console.WriteLine("Key Press test have Failed");
            }

            Console.ReadLine();
        }
        
        
    }
    
}
