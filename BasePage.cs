using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TeachAway_TA
{

    public abstract class BasePage
    {
        protected IWebDriver driver;


        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        protected BasePage()
            : this(new ChromeDriver($@"{Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory))}\Debug\netcoreapp2.1"))
        {


        }
    }
    //public class BasePage
    //{

    //    public static IWebDriver driver { get; set; }

    //    public void OpenBrowser(string url)
    //    {

    //        driver.Manage().Cookies.DeleteAllCookies();
    //        driver.Manage().Window.Maximize();
    //        driver.Navigate().GoToUrl(url);
    //    }

    //}
}
