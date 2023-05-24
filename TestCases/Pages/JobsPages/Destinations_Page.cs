using NUnit.Framework;
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
    public class Destinations_Page : BasePage
    {
        
        public IWebElement JobsMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[1]"));
        public IWebElement Destinations_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[2]/span"));
        public IWebElement ViewAllOnlineJobs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[3]/div[1]/a"));       

        //public IWebElement  => driver.FindElement(By.XPath(""));

        #region Constructor
        public Destinations_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion




        public void Destinations_Verification()

        {
            JobsMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[1]/a")));

            IWebElement Destinations_item = driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[2]/span"));
            new Actions(driver)
                .MoveToElement(Destinations_item)
                .Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[2]/div/div/div")));


        }

        public void Destination_Countries()

        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();
            #region Countries XPaths

            // Online
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[2]");
            // China
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[2]/a", "/html/body/main/div[1]/figure/div[2]");
            //UAE
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
           //Dubai
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[4]/a", "/html/body/main/div[1]");
           //Saudi Arabia 
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[5]/a", "/html/body/main/div[1]/figure/div[2]");
           //Japan
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[6]/a", "/html/body/main/div[1]/figure/div[2]");
           //Qatar
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[7]/a", "/html/body/main/div[1]/header");
           //Abu Dhabi
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[8]/a", "/html/body/main/div[1]/figure/div[2]");
           //Kuwait
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[9]/a", "/html/body/main/div[1]");
           //South Korea
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[10]/a", "/html/body/main/div[1]/figure/div[2]");
           //Thailand
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[11]/a", "/html/body/main/div[1]/figure/div[2]");
           //Spain
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[12]/a", "/html/body/main/div[1]/header");
           //Taiwan 
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[13]/a", "/html/body/main/div[1]/header");
          //Mexico 
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[14]/a", "/html/body/main/div[1]/figure/div[2]");
          //USA 
            elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[15]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[2]/div");
          //View All
             elementXPaths.Add("//*[@id=\"block-menu-blockcountries\"]/ul/li[16]/a", "//*[@id=\"block-tams-content\"]/div/div/div");
            #endregion

            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();


                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));


                //string expectedTitle = driver.FindElement(By.XPath(contentXPath)).Text;
                //string actualTitle = driver.Title;
                //Assert.AreEqual(expectedTitle, actualTitle);

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                Destinations_Verification();

            }



        }


        public void Destination_Regions()

        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();
            #region Regions XPaths

           //South America
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[1]/a", "/html/body/main/div[1]/header");
            //Central Asia
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[2]/a", "/html/body/main/div[1]/header");
            //East Asia
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[3]/a", "/html/body/main/div[1]/header");
            //South Asia
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[4]/a", "/html/body/main/div[1]/header");
            //SouthEast Asia
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[5]/a", "/html/body/main/div[1]/header");
           //Europe
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[6]/a", "/html/body/main/div[1]/figure/div[2]");
            //North America
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[7]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]");
            //Middle East
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[8]/a", "/html/body/main");
            //Mexico
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[9]/a", "/html/body/main/div[1]/header");
            //Australia
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[10]/a", "/html/body/main/div[1]/header");
            //Africa 
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[11]/a", "/html/body/main/div[1]");
            //View All
            elementXPaths.Add("//*[@id=\"block-menu-blockregions\"]/ul/li[12]/a", "/html/body/main/div[1]/figure/div[2]");

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

                Destinations_Verification();

            }



        }



        public void Destination_PopularTeachingLocation()

        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();
            #region Popular Teaching Location XPaths

            //Japan         
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[1]/div[1]/ul/li[1]", "//*[@id=\"block-tams-content\"]/div/div[1]");
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[1]/div[1]/ul/li[2]", "//*[@id=\"block-tams-content\"]/div/div[1]");

            //UAE
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[1]/div[2]/ul/li[1]", "//*[@id=\"block-tams-content\"]/div/div[1]");
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[1]/div[2]/ul/li[2]", "//*[@id=\"block-tams-content\"]/div/div[1]");

            //China
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[2]/div[1]/ul/li[1]", "//*[@id=\"block-tams-content\"]/div/div[1]");
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[2]/div[1]/ul/li[2]", "//*[@id=\"block-tams-content\"]/div/div[1]");


            //USA
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[2]/div[2]/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
            elementXPaths.Add("//*[@id=\"block-block-content3e1135cd-6ce8-44a6-8eb3-346e23a5179f\"]/div/div/div/div[2]/div[2]/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");



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

                Destinations_Verification();

            }



        }



        public void Destination_ViewAllOnlineJobs()

        {

            ViewAllOnlineJobs_BTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]")));

            Thread.Sleep(2000);
        }



        // elementXPaths.Add("", "");


    }
}
