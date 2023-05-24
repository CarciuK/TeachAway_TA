using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeachAway_TA.TestCases.Pages.Courses_Hire_Pages
{
    public class CoursesPage : BasePage
    {

        #region Constructor
        public CoursesPage(IWebDriver driver) : base(driver)
        {

        }

        #endregion


        public IWebElement CoursesMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[4]"));
      
        public void Courses_Access()

        {
            CoursesMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/figure/div/img")));

            String ExpectedText1 = "Courses and Certifications";
            String ActualText1 = driver.FindElement(By.XPath("/html/body/main/div[1]/header/div/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText1, ActualText1);

            Thread.Sleep(1000);

        }

    }
}
