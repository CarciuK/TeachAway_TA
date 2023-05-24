using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.JobsPages
{
    public class JobBoard_Page : BasePage
    {

        public IWebElement JobsMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[1]/span"));
        public IWebElement JobBoard_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[1]"));
        public IWebElement AllCountries_Field => driver.FindElement(By.XPath("//*[@id=\"edit-location\"]"));     
        public IWebElement AllPositions_DropDown => driver.FindElement(By.XPath("//*[@id=\"job-board-advanced-filters\"]/div/div[1]/div/div/div/div[2]/fieldset/div/button"));
        public IWebElement SearchJobsBTN => driver.FindElement(By.XPath("//*[@id=\"edit-actions\"]"));

        public IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id=\"hs-eu-confirmation-button\"]"));

        #region Constructor
        public JobBoard_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion

        public void JobBoard_Verification()

        {
            JobsMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[1]/a")));

            JobBoard_Item.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[2]/div")));


        }



        public void JobBoard_JobSearch()

        {

            AllCountries_Field.Click();
            AllCountries_Field.SendKeys("Albania");

            Thread.Sleep(1000);

            SelectElement AllPositions_Dropdown = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"edit-position\"]")));
            AllPositions_Dropdown.SelectByText("Certified Teacher");

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));         

            SearchJobsBTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[2]/div/div/div/h1")));

        }



    }
}
