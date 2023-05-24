using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAway_TA.TestCases.Pages.Login_Register_Pages
{
    public class RegisterPage : BasePage
    {

        #region Constructor(s)

        public RegisterPage(IWebDriver driver) : base(driver)
        {

        }

        #endregion
        public IWebElement RegisterMenu => driver.FindElement(By.XPath("//*[@id=\"register\"]"));
        public IWebElement FirstName_Field => driver.FindElement(By.XPath("//*[@id=\"first_name\"]"));
        public IWebElement LastName_Field => driver.FindElement(By.XPath("//*[@id=\"last_name\"]"));
        public IWebElement Email_Field => driver.FindElement(By.XPath("//*[@id=\"email\"]"));
        public IWebElement Password_Field => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        public IWebElement SignUpBTN => driver.FindElement(By.XPath("//*[@id=\"create_account_action\"]/div"));
        public IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id=\"hs-eu-confirmation-button\"]"));


        public void UserRegister()
        {
            RegisterMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__next\"]/div[2]/div[1]")));

            string email = RandomEmail();
            string password = RandomPassword();

            FirstName_Field.SendKeys("User");
            LastName_Field.SendKeys("User");


            Email_Field.SendKeys(email);
            Password_Field.SendKeys(password);

            Thread.Sleep(1000);

            SignUpBTN.Click();


            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait3.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div")));

            String ExpectedText = "Welcome, User!";
            String ActualText = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/h2")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);



        }

        static string RandomEmail()
        {
            string email = RandomString(5) + "@example.com";
            return email;
        }

        static string RandomPassword()
        {
            
            string password = RandomString(12);
            return password;
        }

        static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
