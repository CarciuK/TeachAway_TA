using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.JobsPages
{
    public class Teach_US_Page : BasePage
    {

        #region Constructor
        public Teach_US_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement JobsMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[1]"));

        public void TeachUS_Verification()

        {
            JobsMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[1]/a")));

            IWebElement TeachUS_item = driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[5]/span"));
            new Actions(driver)
                .MoveToElement(TeachUS_item)
                .Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[5]/div")));


        }


        //Top Cities

        public void TeachUS_TopCities_Access()
        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region  Teach in Us Top Cities /Content XPaths

            // NewYork
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Atlanta
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Dallas
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Denver
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Chicago
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Las Vegas
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[6]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // San Francisco
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[7]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            //Boston
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[8]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Los Angeles
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[9]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Philadelphia
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[10]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Washington DC
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[11]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Seattle
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[12]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // View All Jobs
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-cities\"]/ul/li[13]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
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

                TeachUS_Verification();

            }


        }




        //Top States

        public void TeachUS_TopStates_Access()
        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region Teach in Us Top States /Content XPaths

            // Maine
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Florida
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // California
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Hawaii
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // New York
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Georgia
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[6]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Washington
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[7]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Pennsylvania
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[8]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Texas
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[9]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // View All States
            elementXPaths.Add("//*[@id=\"block-menu-blocktop-states\"]/ul/li[10]/a", "//*[@id=\"usa-jobs\"]");
           
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

                TeachUS_Verification();

            }


        }


    }
}
