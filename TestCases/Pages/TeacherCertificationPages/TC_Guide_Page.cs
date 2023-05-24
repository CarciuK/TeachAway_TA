using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace TeachAway_TA.TestCases.Pages.TeacherCertificationPages
{
    public class TC_Guide_Page : BasePage
    {

        #region Constructor
        public TC_Guide_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement TCMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[3]"));
        public IWebElement TC_Guide_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-11\"]/div/ul/li[1]"));

        public void TC_Guide_Access()

        {
            TCMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[3]/div")));

            TC_Guide_Item.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));


            Thread.Sleep(1000);


            //WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            //wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"lp-pom-block-8\"]/div[2]")));

            //var popup_decline = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div[1]/button"));
            //Actions actions = new Actions(driver);
            //actions.MoveByOffset(0, 0).Click().Perform();
            


        }

       
    }
}
