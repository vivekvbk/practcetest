using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SmartBusiness.testCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusiness.resources
{
    public class ProductPurchasePage
    {

    
    IWebDriver wd;

    By Username = By.Name("uname");
    By Password = By.Name("passwd");
    By SubmitButton = By.Id("idbtnUserLogin");
    By SupplierName = By.XPath("//input[@id='pp_txt_SupplierName']");
    By CounterSelect =By.XPath("//*[@id=\"CounterModal\"]/div/div/div/app-common-counter-type/form/div[3]/button");
    By ProductName = By.Id("pp_pw_txt_itemCode");

    public ProductPurchasePage(IWebDriver wd)
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

    public void Counter()
        {
            wd.FindElement(CounterSelect).Click();
        }
    public  void Suppliername()
        {
            wd.FindElement(SupplierName).SendKeys("Vivek");
           
        }
    public void Productname()
        {
            wd.FindElement(ProductName).SendKeys("Boxesss");
        }
    public void ProductSelect()
        {
            wd.FindElement(ProductName).Click();
        }

   
    }
    }
