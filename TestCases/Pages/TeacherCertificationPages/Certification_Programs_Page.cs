using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.TeacherCertificationPages
{
    public class Certification_Programs_Page : BasePage
    {

        #region Constructor
        public Certification_Programs_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement TCMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[3]"));
        public IWebElement Certification_Programs_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-11\"]/div/ul/li[2]"));

        public void Certification_Programs_Access()

        {
            TCMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[3]/div")));

            Certification_Programs_Item.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

            Thread.Sleep(1000);

        }




    }
}
