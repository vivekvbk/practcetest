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

namespace SmartBusiness.testCases
{
    [TestFixture]
    class TC_1_Login : Tests
    {
        public ChromeDriver wd { get; private set; }

        [Test]
        public void LoginTest()
        {
            wd = new ChromeDriver();
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            wd.Url = ("http://shiv:8123");
            wd.Manage().Window.Maximize();
            //username
            wd.FindElement(By.Name("uname")).SendKeys("vivek@10001");
            //password
            wd.FindElement(By.Name("passwd")).SendKeys("Softcon@123");
            //Click on Login
            wd.FindElement(By.Id("idbtnUserLogin")).Click();
            //wait
            Thread.Sleep(2000);

            //  Counter Dropdown

            wd.FindElement(By.Id("slct")).Click();

            IWebElement ele = wd.FindElement(By.XPath("//Select[@id='slct']"));
            SelectElement sel = new SelectElement(wd.FindElement(By.XPath("//Select[@id='slct']")));
            sel.SelectByIndex(2);

            wd.FindElement(By.XPath("//*[@id=\"CounterModal\"]/div/div/div/app-common-counter-type/form/div[3]/button")).Click();
            Thread.Sleep(5000);

        }
        [Test]
        public void RetailSales()
        {
            IWebElement MasterSearch = wd.FindElement(By.XPath("//input[@id='idMenu2']"));
            MasterSearch.SendKeys("Retail Sales");

            MasterSearch.SendKeys(Keys.ArrowDown);
            MasterSearch.SendKeys(Keys.Enter);
            
            Thread.Sleep(2000);
           
            IWebElement Search = wd.FindElement(By.XPath("//input[@id='idMenu2']"));

            // Select Salesman


            wd.FindElement(By.XPath("//button[@class='btn btn-default btn-sm ng-star-inserted']")).Click();
            /*if (wd.findElement(By.id("SalesOrderdraftignore")) != null)
            {
                wd.findElement(By.id("SalesOrderdraftignore")).click();
            }
            else{	
            }*/
            wd.FindElement(By.XPath("//input[@id='SalesPersonID']")).Click();
            Thread.Sleep(4000);
            wd.FindElement(By.XPath("//input[@id='SalesPersonID']")).SendKeys("ashwini");
            wd.FindElement(By.XPath("//input[@id='SalesPersonID']")).SendKeys(Keys.Enter);

            //wd.findElement(By.xpath("//div[@id='mat-autocomplete-16']")).click();    


            //Enter SKU

            IWebElement SKU = wd.FindElement(By.XPath("//input[@id='sku']"));
            SKU.SendKeys("100010000124");
            SKU.SendKeys(Keys.Enter);

            //Enter Qty

            IWebElement QTY = wd.FindElement(By.XPath("//input[@id='DecimalQty-0-RetailSalesEntryTableCols_1']"));
            QTY.SendKeys("2");
            Console.WriteLine(QTY);

            //Card payment

            IWebElement Card = wd.FindElement(By.XPath("//input[@id='Card']"));
            Card.SendKeys("100");
        }

    }
}


