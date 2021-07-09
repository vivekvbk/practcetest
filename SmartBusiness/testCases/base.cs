using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusiness.testCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            IWebDriver wd = new ChromeDriver();

        }
    }
}
