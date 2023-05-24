using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.JobsPages
{
    public class Community_Page : BasePage
    {

        #region Constructor
        public Community_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement JobsMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[1]"));

        public void Community_Verification()

        {
            JobsMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[1]/a")));

            IWebElement Community_item = driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[6]/span"));
            new Actions(driver)
                .MoveToElement(Community_item)
                .Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[6]/div")));


        }


        public void Community_Access()
        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region  Community XPaths

            // Blog
            elementXPaths.Add("//*[@id=\"block-menu-blockcommunity\"]/ul/li[1]/a", "/html/body/main/div[1]/figure/div[2]");
            // Resources
            elementXPaths.Add("//*[@id=\"block-menu-blockcommunity\"]/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // FAQs
            elementXPaths.Add("//*[@id=\"block-menu-blockcommunity\"]/ul/li[3]/a", "/html/body/header/div[3]");
            // Our Teachers Around the World
            elementXPaths.Add("//*[@id=\"block-menu-blockcommunity\"]/ul/li[4]/a", "//*[@id=\"leaflet-map\"]");
            // Upcoming Events
            elementXPaths.Add("//*[@id=\"block-menu-blockcommunity\"]/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            
            #endregion


            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                Community_Verification();

            }


        }



    }
}
