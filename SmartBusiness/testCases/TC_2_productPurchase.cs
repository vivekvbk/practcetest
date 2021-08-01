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
   
    public class TC_2_productPurchase:Base
    {
        [Test]
        public void ProductPurchase()
        {
           
            ProductPurchasePage pp = new ProductPurchasePage(wd);
            IWebElement MasterSearch = wd.FindElement(By.XPath("//input[@id='idMenu2']"));
            MasterSearch.SendKeys("Product Purchase");
            Thread.Sleep(2000);
            MasterSearch.SendKeys(Keys.Enter);
            pp.Suppliername();            
            wd.FindElement(By.XPath("//input[@id='pp_txt_SupplierName']")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy,MM,dd,hh,mm,ss");
            wd.FindElement(By.Id("pp_txt_billNo")).SendKeys(formattedTime);
            wd.FindElement(By.Id("pp_btn_addProduct")).Click();
            Thread.Sleep(2000);
            pp.Productname();
            pp.ProductSelect();
            Thread.Sleep(2000);
            wd.FindElement(By.Id("ColorCode-0-ProductWiseInternalCols")).SendKeys("Red");
            wd.FindElement(By.Id("ColorCode-0-ProductWiseInternalCols")).SendKeys(Keys.Enter);
            wd.FindElement(By.Id("Qty5 - 0 - ProductWiseInternalCols")).SendKeys("10");
            wd.FindElement(By.Id("Qty5 - 0 - ProductWiseInternalCols")).SendKeys(Keys.Tab);
            wd.FindElement(By.Id("pp_pw_btn_saveOrUpdate")).Click();
            wd.FindElement(By.Id("pp_pw_btn_footerCancel")).Click();
            wd.FindElement(By.Id("DraftCancel123")).Click();
            wd.FindElement(By.Id("pp_btn_generate")).Click();

        }
    }
}