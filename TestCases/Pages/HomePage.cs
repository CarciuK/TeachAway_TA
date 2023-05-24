using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }


        public By MenuBar => By.XPath("/html/body/div[1]/nav");
        //public By AuthenticatedUserSelector => By.XPath("//*[@id=\"userName\"]");
        //public IWebElement AuthenticatedUser => this.driver.FindElement(AuthenticatedUserSelector);

        //public IWebElement AddNewServiceBtn => this.driver.FindElement(AddNewServiceSelector);

      
        public IWebElement Menu => this.driver.FindElement(MenuBar);
        public IWebElement JobsMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[1]/span"));

        public IWebElement Cookies => driver.FindElement(By.XPath("//*[@id=\"hs-eu-decline-button\"]"));
        public void PopUpRemove()
        {
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"hs-eu-confirmation-button\"]")));         
           
           Cookies.Click();
        }


        //public void PopUpRemove() => new Actions(driver).MoveByOffset(0, 0).Click().Perform();




    }
}
