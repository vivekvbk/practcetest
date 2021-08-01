using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartBusiness.resources
{
    [TestFixture]
    public class Base
    {
        public IWebDriver wd;
        
        [OneTimeSetUp]
        public void Initi()
        {
            LoginPage Lp = new LoginPage(wd);
            wd = new ChromeDriver();
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wd.Url = ("http://galaxy:5252");
            wd.Manage().Window.Maximize();
            ProductPurchasePage pp = new ProductPurchasePage(wd);
            pp.TypeUsername();
            pp.TypePassword();
            pp.SubmitClick();
            IWebElement ele = wd.FindElement(By.XPath("//Select[@id='slct']"));
            SelectElement sel = new SelectElement(wd.FindElement(By.XPath("//Select[@id='slct']")));
            sel.SelectByIndex(2);
            pp.Counter();
            Thread.Sleep(5000);
        }
        
        [OneTimeTearDown]
        public void TearDown()
        {
            wd.Quit();
        }

    }
}