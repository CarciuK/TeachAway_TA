using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace TeachAway_TA.TestCases.Pages.JobsPages
{
    public class Job_Openings_Page : BasePage
    {
        public IWebElement JobsMenu => driver.FindElement(By.XPath("//*[@id=\"block-mainnavigation-2\"]/div/div/div/ul/li[1]"));
        public IWebElement JobOpenings_Item => driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[2]/span"));
       
        public IWebElement ViewAllJobs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-block-content3e1135cd-6ce8-4"));
        public IWebElement GetCertified_BTN => driver.FindElement(By.XPath("//*[@id=\"block-block-content3e1135cd-6"));

        //Licensed Teachers
        public IWebElement LicensedTeachers_ViewAllJobs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[1]/div/a"));
        public IWebElement LicensedTeachers_GetCertified_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[3]/div/a"));

        //ESL Teaching Jobs
        public IWebElement ESL_ViewAllJObs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[2]/div/div/div[1]/div/a"));
        public IWebElement ESL_GetCertified_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[2]/div/div/div[2]/div/a"));

        //TEFL Teaching Jobs

        public IWebElement TEFL_ViewAllJObs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]/div/div/div[1]/div/a"));
        public IWebElement TEFL_GetCertified_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]/div/div/div[2]/div/a"));

        //K12 Teaching jobs

        public IWebElement K12_ViewAllJObs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[1]/div/a"));
        public IWebElement K12_GetCertified_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[2]/div/a"));


        //College Teaching Jobs
        public IWebElement OnlineCollegeJobs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[7]/div/div/div[1]/div/a"));
        
        public IWebElement  College_ViewAllJobs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[7]/div/div/div[2]/div/a"));

        //Vocational Teaching Jobs
        public IWebElement Vocational_ViewAllJobs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[8]/div/div/div[1]/div/a"));
        public IWebElement Vocational_Places_ViewAllJobs_BTN => driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[8]/div/div/div[2]/div/a"));


        //public IWebElement  => driver.FindElement(By.XPath(""));

        #region Constructor
        public Job_Openings_Page(IWebDriver driver) : base(driver)
        {

        }

        #endregion




        public void JobOpenings_Verification()

        {
            JobsMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[1]/a")));

            IWebElement JobOpenings_item = driver.FindElement(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[4]/span"));
            new Actions(driver)
                .MoveToElement(JobOpenings_item)
                .Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"tb-megamenu-column-1\"]/div/ul/li[4]/div")));


        }



        public void JobOpenings_Item_Hovering()
        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region Job Openings Items XPaths

            // Licensed Teachers
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]");
            // ESL Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]");
            // Online Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]");
            // TEFL Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]");
            // K12 Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[5]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]");
            // Principal and School Administrator Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[6]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]");
            // College Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[7]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[7]");
            // Vocational Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[8]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[8]");
            // View All
            //elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[9]/a", "//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[9]");

            #endregion

            foreach (var elementXPath in elementXPaths.Keys)
            {
                //var element = driver.FindElement(By.XPath(elementXPath));
                //element.Click();

                IWebElement element = driver.FindElement(By.XPath(elementXPath));
                new Actions(driver)
                    .MoveToElement(element)
                    .Perform();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(2000);
            }

        }

        public void JobOpenings_Item_Access()
        {

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region Job Openings Items/Content XPaths

            // Licensed Teachers
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[1]");
            // ESL Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // Online Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[1]");
            // TEFL Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // K12 Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");
            // Principal and School Administrator Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[6]/a", "//*[@id=\"block-tams-content\"]/div");
            // College Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[7]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[1]");
            // Vocational Teaching Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[8]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]");
            // View All
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[9]/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]");

            #endregion


            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

            }


        }


        public void JobOpenings_LicensedTeachers()
        {
            IWebElement LicensedTeachers_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[1]/a"));
            new Actions(driver)
                .MoveToElement(LicensedTeachers_item)
                .Perform();

            Thread.Sleep(1000);

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region Licensed Teachers-Types of Jobs XPaths

            // Early Childhood
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
            // Elemantary
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // Middle School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div/div[1]/div");
            // High School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");
            // University
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");

            #endregion

            #region Licensed Teachers-Popular Subjects XPaths
            // English
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");
            // Science
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");
            // Maths
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div");
            // Business
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div/div[1]/div");
            // Chemistry
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div/div[1]/div");

            #endregion



            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement LicensedTeachers_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[1]/a"));
                new Actions(driver)
                    .MoveToElement(LicensedTeachers_item1)
                    .Perform();

            }


        }



        public void LicensedTeachers_BTNs()

        {
            IWebElement LicensedTeachers_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[1]/a"));
            new Actions(driver)
                .MoveToElement(LicensedTeachers_item)
                .Perform();

            LicensedTeachers_ViewAllJobs_BTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[2]")));

            Thread.Sleep(1500);

            driver.Navigate().Back();

            Thread.Sleep(1000);

            JobOpenings_Verification();

            IWebElement LicensedTeachers_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[1]/a"));
            new Actions(driver)
                .MoveToElement(LicensedTeachers_item1)
                .Perform();

            LicensedTeachers_GetCertified_BTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

            Thread.Sleep(2000);
        }


        //ESL Teachin Jobs

        public void JobOpenings_ESLTeachingJobs()
        {
            IWebElement ESLTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[2]/a"));
            new Actions(driver)
                .MoveToElement(ESLTeachingJobs_item)
                .Perform();

            Thread.Sleep(1000);

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region ESL Teaching Jobs-Types of Jobs XPaths

            // Early Childhood
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[2]/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");
            // Elemantary
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[2]/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");
            // Middle School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[2]/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");
            // High School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[2]/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");
            // University
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[2]/div/div/div[1]/div/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[4]/div/div");

            #endregion

           

            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement ESLTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[2]/a"));
                new Actions(driver)
                    .MoveToElement(ESLTeachingJobs_item1)
                    .Perform();

            }


        }



        public void ESLTeachingJobs_BTNs()

        {
            IWebElement ESLTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[2]/a"));
            new Actions(driver)
                .MoveToElement(ESLTeachingJobs_item)
                .Perform();

            ESL_ViewAllJObs_BTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[2]")));

            Thread.Sleep(1500);

            driver.Navigate().Back();

            Thread.Sleep(1000);

            JobOpenings_Verification();

            IWebElement ESLTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[2]/a"));
            new Actions(driver)
                .MoveToElement(ESLTeachingJobs_item1)
                .Perform();

            ESL_GetCertified_BTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

            Thread.Sleep(2000);
        }



        //Online Teaching Jobs


        public void JobOpenings_OnlineTeachingJobs()
        {
            IWebElement OnlineTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[3]/a"));
            new Actions(driver)
                .MoveToElement(OnlineTeachingJobs_item)
                .Perform();

            Thread.Sleep(1000);

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region Online Teaching Jobs-Types of Jobs XPaths

            // Online college teaching jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[2]/div");
            // K12 online teaching jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
            // Online tutoring jobs for teachers
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
            // Online ESL teaching jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
            // View All Jobs BTN
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[1]/div/a", "//*[@id=\"block-tams-content\"]/div/div[1]");

            #endregion

            #region Online Teaching Jobs-Teacher Certifications XPaths
            // Get TEFL certified
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[2]/div/ul/li[1]/a", "/html/body/main/div[1]/header");
            // Become digitally literate
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[2]/div/ul/li[2]/a", "/html/body/main/div[1]/header");
            // Level-up online teaching skills
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[2]/div/ul/li[3]/a", "/html/body/main/div[1]/header");
            // Become K-12 certified
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[2]/div/ul/li[4]/a", "/html/body/main/div[1]/header");
            // Get Certified BTN
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[3]/div/div/div[2]/div/a", "/html/body/main/div[1]");
            #endregion



            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement OnlineTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[3]/a"));
                new Actions(driver)
                    .MoveToElement(OnlineTeachingJobs_item1)
                    .Perform();

                Thread.Sleep(1000);

            }


        }


        //TEFL Teaching Jobs

        public void JobOpenings_TEFLTeachingJobs()
        {
            IWebElement TEFLTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[4]/a"));
            new Actions(driver)
                .MoveToElement(TEFLTeachingJobs_item)
                .Perform();

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region TEFL Teaching Jobs-Types of Jobs XPaths

            // Early Childhood
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // Elemantary
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // Middle School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // High School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // University
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[4]/div/div/div[1]/div/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");

            #endregion



            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

               // Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement TEFLTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[4]/a"));
                new Actions(driver)
                    .MoveToElement(TEFLTeachingJobs_item1)
                    .Perform();
            }


        }



        public void TEFLTeachingJobs_BTNs()

        {

            IWebElement TEFLTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[4]/a"));
            new Actions(driver)
                .MoveToElement(TEFLTeachingJobs_item)
                .Perform();

            TEFL_ViewAllJObs_BTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]")));


            driver.Navigate().Back();

            Thread.Sleep(1000);

            JobOpenings_Verification();


            IWebElement TEFLTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[4]/a"));
            new Actions(driver)
                .MoveToElement(TEFLTeachingJobs_item1)
                .Perform();

            TEFL_GetCertified_BTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

        }


        //K12 Teching Jobs

        public void JobOpenings_K12TeachingJobs()
        {
            IWebElement K12TeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[5]/a"));
            new Actions(driver)
                .MoveToElement(K12TeachingJobs_item)
                .Perform();

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region K12 Teaching Jobs-Popular K12 Locations XPaths

            // Japan
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[2]");

            // China
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[2]");

            // Thailand
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"job-board-advanced-filters\"]/div/div[1]/div");

            // Europe
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"job-board-advanced-filters\"]/div/div[1]/div");

            // Middle East
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[1]/div/ul/li[5]/a", "/html/body/main/div[1]/header");

            // UAE
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[5]/div/div/div[1]/div/ul/li[6]/a", "//*[@id=\"job-board-advanced-filters\"]/div/div[1]/div");

            #endregion



            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                // Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement K12TeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[5]/a"));
                new Actions(driver)
                    .MoveToElement(K12TeachingJobs_item1)
                    .Perform();
            }


        }



        public void K12TeachingJobs_BTNs()

        {

            IWebElement K12TeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[5]/a"));
            new Actions(driver)
                .MoveToElement(K12TeachingJobs_item)
                .Perform();

            K12_ViewAllJObs_BTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div[1]")));


            driver.Navigate().Back();

            Thread.Sleep(1000);

            JobOpenings_Verification();


            IWebElement K12TeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[5]/a"));
            new Actions(driver)
                .MoveToElement(K12TeachingJobs_item1)
                .Perform();

            K12_GetCertified_BTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[1]/header")));

        }




        

        //Principal and School Admin Jobs

        public void JobOpenings_PrincipalTeachingJobs()
        {
            IWebElement PrincipalTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[6]/a"));
            new Actions(driver)
                .MoveToElement(PrincipalTeachingJobs_item)
                .Perform();

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region  Principal and School Admin Jobs-Types of Jobs XPaths

            // Early Childhood
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[1]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]/div[2]");
            // Elemantary
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[1]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // Middle School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[1]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // High School
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[1]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            // University
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[1]/div/ul/li[5]/a", "//*[@id=\"block-tams-content\"]/div/div/div[1]");
            //View All jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[1]/div/a", "//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[2]");
            #endregion

            #region  Principal and School Admin Jobs-Popular Locations XPaths

            // China
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[2]/div/ul/li[1]/a", "//*[@id=\"job-board-advanced-filters\"]/div/div[1]/div");
            // Dubai
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[2]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // UAE
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[2]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            // Kuwait
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[2]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[1]");
            // View All Jobs
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[6]/div/div/div[2]/div/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            #endregion



            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement PrincipalTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[6]/a"));
                new Actions(driver)
                    .MoveToElement(PrincipalTeachingJobs_item1)
                    .Perform();
            }


        }


        // College Teaching Jobs


        public void JobOpenings_CollegeTeachingJobs()
        {
            IWebElement CollegeTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[7]/a"));
            new Actions(driver)
                .MoveToElement(CollegeTeachingJobs_item)
                .Perform();

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region  College Teaching Jobs-Popular Places XPaths

            // UAE
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[7]/div/div/div[2]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
            // Saudi Arabia
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[7]/div/div/div[2]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");

            #endregion


            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement CollegeTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[7]/a"));
                new Actions(driver)
                    .MoveToElement(CollegeTeachingJobs_item1)
                    .Perform();
            }

            IWebElement CollegeTeachingJobs_item2 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[7]/a"));
            new Actions(driver)
                .MoveToElement(CollegeTeachingJobs_item2)
                .Perform();


            OnlineCollegeJobs_BTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[2]/div")));


            driver.Navigate().Back();

            Thread.Sleep(1000);

            JobOpenings_Verification();

            IWebElement CollegeTeachingJobs_item3 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[7]/a"));
            new Actions(driver)
                .MoveToElement(CollegeTeachingJobs_item3)
                .Perform();

            College_ViewAllJobs_BTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]")));

        }



        //Vocational Teaching Jobs


        public void JobOpenings_VocationalTeachingJobs()
        {
            IWebElement VocationalTeachingJobs_item = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[8]/a"));
            new Actions(driver)
                .MoveToElement(VocationalTeachingJobs_item)
                .Perform();

            Dictionary<string, string> elementXPaths = new Dictionary<string, string>();

            #region  Vocational Teaching Jobs-Popular Places XPaths

            // China
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[8]/div/div/div[2]/div/ul/li[1]/a", "//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[1]/div/div[2]");
            //UAE
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[8]/div/div/div[2]/div/ul/li[2]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
            //Saudi Arabia
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[8]/div/div/div[2]/div/ul/li[3]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
           //Dubai
            elementXPaths.Add("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[2]/div[8]/div/div/div[2]/div/ul/li[4]/a", "//*[@id=\"block-tams-content\"]/div/div[1]");
           
            #endregion


            foreach (var elementXPath in elementXPaths.Keys)
            {
                var element = driver.FindElement(By.XPath(elementXPath));
                element.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
                string contentXPath = elementXPaths[elementXPath];
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(contentXPath)));

                Thread.Sleep(1500);

                driver.Navigate().Back();

                Thread.Sleep(1000);

                JobOpenings_Verification();

                IWebElement VocationalTeachingJobs_item1 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[8]/a"));
                new Actions(driver)
                    .MoveToElement(VocationalTeachingJobs_item1)
                    .Perform();
            }

            IWebElement VocationalTeachingJobs_item2 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[8]/a"));
            new Actions(driver)
                .MoveToElement(VocationalTeachingJobs_item2)
                .Perform();


            Vocational_ViewAllJobs_BTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div/div/div[1]/div[1]/div[2]")));


            driver.Navigate().Back();

            Thread.Sleep(1000);

            JobOpenings_Verification();

            IWebElement VocationalTeachingJobs_item3 = driver.FindElement(By.XPath("//*[@id=\"block-job-list-filters-block\"]/div/div/div/div[1]/div/ul/li[8]/a"));
            new Actions(driver)
                .MoveToElement(VocationalTeachingJobs_item3)
                .Perform();

            Vocational_Places_ViewAllJobs_BTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-tams-content\"]/div/div[1]")));

        }






    }
}
