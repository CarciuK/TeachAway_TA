using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.Login_Register_Pages
{
    public class LogInPage : BasePage
    {

        #region Constructor(s)

        public LogInPage(IWebDriver driver) : base(driver)
        {

        }

        #endregion
        public IWebElement LogInMenu => driver.FindElement(By.XPath("//*[@id=\"login\"]"));
        public IWebElement Email_Field => driver.FindElement(By.XPath("//*[@id=\"username\"]"));
        public IWebElement Password_Field => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        public IWebElement LogInBTN => driver.FindElement(By.Id("login_action"));
        public IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id=\"hs-eu-confirmation-button\"]"));


        public void UserLogIn_S()
        {
            LogInMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__next\"]/div[2]/div[1]/div[2]")));


            Email_Field.SendKeys("user@email.com");
            Password_Field.SendKeys("userpassword123");

            Thread.Sleep(1000);
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));          

            LogInBTN.Click();

            Thread.Sleep(1000);

        }


        public void UserLogIn_U()
        {
            LogInMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__next\"]/div[2]/div[1]/div[2]")));


            Email_Field.SendKeys("userere@email.com");
            Password_Field.SendKeys("userpassword1234");

            Thread.Sleep(1000);
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"stsform\"]/div[3]/div/div/div/div/div")));


            LogInBTN.Click();

            Thread.Sleep(1000);

            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait3.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div[1]/div")));

        }









    }
}
