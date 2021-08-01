using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SmartBusiness.resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartBusiness.testCases
{
    [TestFixture]
    [Parallelizable]

    public class TC_1_Login : Base
    {

        [Test]
        public void LoginTest()
        {
            LoginPage Lp = new LoginPage(wd);
            IWebElement MasterSearch = wd.FindElement(By.XPath("//input[@id='idMenu2']"));
            Lp.MasterSearch();
            Thread.Sleep(2000);
            MasterSearch.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IWebElement Search = wd.FindElement(By.XPath("//input[@id='idMenu2']"));

            // Select Salesman
            Lp.NewSales();
            if (wd.FindElement(By.Id("SalesOrderdraftignore")) != null)
            {
                wd.FindElement(By.Id("SalesOrderdraftignore")).Click();
            }
            else
            {
            }
            Lp.SalesPerson();
            wd.FindElement(By.XPath("//input[@id='SalesPersonID']")).SendKeys("Vivek");
            Thread.Sleep(1000);
            wd.FindElement(By.XPath("//input[@id='SalesPersonID']")).SendKeys(Keys.Enter);

            //wd.findElement(By.xpath("//div[@id='mat-autocomplete-16']")).click();    


            //Enter SKU

            IWebElement SKU = wd.FindElement(By.XPath("//input[@id='sku']"));
            SKU.SendKeys("100010080496");
            Thread.Sleep(1000);
            SKU.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            IWebElement Card = wd.FindElement(By.XPath("//input[@id='Card']"));
            Card.SendKeys("100");
            Thread.Sleep(3000);
            //Save Button
            Lp.Save();

        }

    }
}


