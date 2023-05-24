using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.Courses_Hire_Pages
{
    public class HireTeachersPage : BasePage
    {

        #region Constructor
        public HireTeachersPage(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement HireTeachersMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[5]"));

        public void HireTeachers_Access()

        {
            HireTeachersMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

            String ExpectedText = "Start recruiting great teachers";
            String ActualText = driver.FindElement(By.XPath("/html/body/main/div[1]/header/div/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);

        }

    }
}
