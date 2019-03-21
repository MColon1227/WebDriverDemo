using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox; 

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.google.com";
            
        }
    }
}
