using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusiness.resources
{
    public class LoginPage
    {
        IWebDriver wd;

        By Username = By.Name("uname");
        By Password = By.Name("passwd");
        By SubmitButton = By.Id("idbtnUserLogin");
        By Mastersearch = By.XPath("//input[@id='idMenu2']");
        By NewSalesButton = By.XPath("//button[@class='btn btn-default btn-sm ng-star-inserted']");
        By Salesperson = By.Id("SalesPersonID");
        By FinalSave = By.XPath("//app-root/app-home-layout[@class='ng-star-inserted']/app-navigation/mat-sidenav-container/mat-sidenav-content[@class='mat-drawer-content mat-sidenav-content']/div[@class='row']/div[1]/app-retail-sales-entry[@class='ng-star-inserted']//div[@class='col-lg-6 col-md-8 col-sm-8']/div/div[2]/div/span[@class='input-group-append']/button[3]");
        public LoginPage(IWebDriver wd)
        {
            this.wd = wd;
        }

        public void TypeUsername()
        {
            wd.FindElement(Username).SendKeys("Vivek@10001");
        }

        public void TypePassword()
        {
            wd.FindElement(Password).SendKeys("Softcon@123");
        }

        public void SubmitClick()
        {
            wd.FindElement(SubmitButton).Click();
        }
        public void MasterSearch()
        {
            wd.FindElement(Mastersearch).SendKeys("Retail Sales");
        }
        public void NewSales()
        {
            wd.FindElement(NewSalesButton).Click();
        }
        public void SalesPerson()
        {
            wd.FindElement(Salesperson);

        }
        public void Save()
        {
            wd.FindElement(FinalSave).Click();
        }
           
        }
    }

