using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeachAway_TA.TestCases.Pages.TeacherCertificationPages
{
    public class States_Page : BasePage
    {

        #region Constructor
        public States_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement TCMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[3]"));
        public IWebElement TC_Hawaii_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-11\"]/div/ul/li[3]"));
        public IWebElement TC_Arizona_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-11\"]/div/ul/li[4]"));

        public void TC_States_Access()

        {
            TCMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[3]/div")));

            TC_Hawaii_Item.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

            String ExpectedText = "Join our Nationally Accredited Hawai’i Teacher Certification Program";
            String ActualText = driver.FindElement(By.XPath("/html/body/main/div[1]/header/div/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


            driver.Navigate().Back();

            Thread.Sleep(1000);

            TCMenu.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[3]/div")));

            TC_Arizona_Item.Click();

            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait3.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

            String ExpectedText1 = "Get an Arizona state teacher certificate from anywhere in the world";
            String ActualText1 = driver.FindElement(By.XPath("/html/body/main/div[1]/header/div/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText1, ActualText1);

        }



    }
}
