using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.TEFLPages
{
    public class TEFL_Certification_Page : BasePage
    {


        #region Constructor
        public TEFL_Certification_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement TEFLMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[2]"));
        public IWebElement TEFL_Certification_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-10\"]/div/ul/li[2]"));

        public void TEFL_Certification_Access()

        {
            TEFLMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-10\"]/div")));

            TEFL_Certification_Item.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"hero-section\"]/div")));

            Thread.Sleep(1000);

        }




    }
}
