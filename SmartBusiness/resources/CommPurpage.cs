using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusiness.resources
{

    public class CommPurpage
    {
        IWebDriver wd;
        By newPurchase = By.XPath("//button[normalize-space()='New']");
        By Suppliername = By.XPath("//app-root/app-home-layout[@class='ng-star-inserted']/app-navigation/mat-sidenav-container/mat-sidenav-content" +
            "[@class='mat-drawer-content mat-sidenav-content']/div[@class='row']/div[1]/app-erpcommercialpurchaseentry[@class='ng-star-inserted']" +
            "/form/div/div[2]/div/fieldset"+"[@class='scheduler-border']/div[@class='row']"+"/div[@class='col-lg-6 col" +
            "-md-6 col-sm-6 removePadding']" +
            "/div[1]/div[@class='col-lg-9 col-md-9 col-sm-9 removePadding']/div[@class='form-group has-search']/input[@role='combobox']");
        By BillNo = By.XPath("//input[@formcontrolname='BillNo']");
        By AddProduct = By.XPath("//button[normalize-space()='Add Product']");
        By SKU = By.XPath("//input[@name='ERPScancodeSKU']");
        By Add = By.XPath("//div[contains(@class,'modal-content SKUSacnningModal-content')]//button[contains(@type,'button')][normalize-space()='Add']");
        By Cancel = By.XPath("//div[@id='AddScanProduct']/div[@role='document']/div/div[@class='modal-footer']/div/div[2]/button[@type='button']");
        By FinalSave = By.XPath("//body/app-root/app-home-layout[@class='ng-star-inserted']/app-navigation/mat-sidenav-container/mat-sidenav-content" +
        "[@class='mat-drawer-content mat-sidenav-content']/div[@class='row']//app-erpcommercialpurchaseentry[@class='ng-star-inserted']" +
         "/form//div[@class='col-lg-5 col-md-4 col-sm-4']/div/div[1]/button[@type='button']");
        public CommPurpage(IWebDriver wd)
        {
            this.wd = wd;
        }
        public void NewPurchase()
        {
            wd.FindElement(newPurchase).Click();
        }
        public void SupplierName()
        {
            wd.FindElement(Suppliername).SendKeys("vivek");

        }
        public void SupplierSelect()
        {
            wd.FindElement(Suppliername).Click();
        }

        public void Billno()
        {
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy,MM,dd,hh,mm,ss");
            wd.FindElement(BillNo).SendKeys(formattedTime);

        }   
        public void SupplierEnter()
        {
            wd.FindElement(Suppliername).SendKeys(Keys.Enter);
        }
        public void Addproduct()
        {
            wd.FindElement(AddProduct).Click();
        }

        public void SKUsearch()
        {
            wd.FindElement(SKU).SendKeys("100010080496");
        }
        public void SKUEnter()
        {
            wd.FindElement(SKU).SendKeys(Keys.Enter);
        }
        public void add()
        {
            wd.FindElement(Add).Click();
        }
        public void cancel()
        {
            wd.FindElement(Cancel).Click();
        }
        public void Save()
        {
            wd.FindElement(FinalSave).Click();
        }
    }
}

