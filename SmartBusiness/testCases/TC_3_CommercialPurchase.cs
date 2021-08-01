using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
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

    public class TC_3_CommercialPurchase : Base
    {
        [Test]
        public void CommercialPurchase()
        {
            CommPurpage CP = new CommPurpage(wd);
            IWebElement MasterSearch = wd.FindElement(By.XPath("//input[@id='idMenu2']"));
            MasterSearch.SendKeys("Commercial Purchase");
            Thread.Sleep(2000);
            MasterSearch.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            CP.NewPurchase();
            if (wd.FindElement(By.Id("SalesOrderdraftignore")) != null)
            {
                wd.FindElement(By.Id("SalesOrderdraftignore")).Click();
            }
            else
            {
            }
            CP.SupplierName();
            Thread.Sleep(2000);
            CP.SupplierEnter();
            CP.Billno();
            CP.Addproduct();
            Thread.Sleep(3000);
            CP.SKUsearch();
            Thread.Sleep(2000);
            CP.SKUEnter();
            Thread.Sleep(3000);
            CP.add();
            Thread.Sleep(2000);
            CP.cancel();
            Thread.Sleep(2000);
            CP.Save();






        }


    }
}
