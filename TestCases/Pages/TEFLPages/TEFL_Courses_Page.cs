using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.TEFLPages
{
    public class TEFL_Courses_Page: BasePage
    {

        #region Constructor
        public TEFL_Courses_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement TEFLMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[2]"));
        public IWebElement TEFL_Courses_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-10\"]/div/ul/li[1]"));

        public void TEFL_Courses_Access()

        {
            TEFLMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-10\"]/div")));

            //IWebElement TEFL_Courses_item = driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[5]/span"));
            //new Actions(driver)
            //    .MoveToElement(TEFL_Courses_item)
            //    .Perform();

            TEFL_Courses_Item.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

            Thread.Sleep(1000);

        }




    }
}
