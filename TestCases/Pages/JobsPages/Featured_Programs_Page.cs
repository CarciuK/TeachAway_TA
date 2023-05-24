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
    public class Featured_Programs_Page : BasePage
    { 
        public IWebElement JobsMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[1]/span"));
        public IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id=\"hs-eu-confirmation-button\"]"));
        public IWebElement  FeaturedPrograms_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[3]/span"));
 
        

        #region Constructor
        public Featured_Programs_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion




        public void FeaturedPrograms_Verification()

        {
            JobsMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[1]/a")));

            //*[@id=\"tb-megamenu-column-1\"]/div/ul/li[3]
            IWebElement FeaturedProgams_item = driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[3]/span"));
            new Actions(driver)
                .MoveToElement(FeaturedProgams_item)
                .Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[3]/div")));

            Thread.Sleep(1000);


        }

        public void Featured_Programs_Items()

        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();
           
            #region Featured Programs XPaths

            // Abu Dhabi Public Schools
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[1]/a", "/html/body/main/div[1]/figure/div[2]");
            // American Creativity Academy
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // BASIS International Schools
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[1]/div/div[2]");
            // Hawaii Public Schools
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // Online Job Fairs
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // Preply
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[6]/a", "//*[@id=\"block-tams-content\"]/div/article/div/div[1]");
            // Presidential Schools of Uzbekistan
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[7]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[1]/div/div[2]");
            // Emirates Schools Establishment
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[8]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // Skooli
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[9]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // Aldar Education
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[10]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[1]/div/div[2]");
            // Amity Business Division AEON Corporation
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[11]/a", "//*[@id=\"block-tams-content\"]/div/article/div/div[1]");
            //Canadian School of Bahrain
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[12]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[1]/div/div[2]");
            //NOVA
            elementXPaths.Add("//*[@id=\"block-menu-blockfeatured-programs\"]/ul/li[13]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[1]/div/div[2]");

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

                FeaturedPrograms_Verification();
               

            }



        }








    }
}
