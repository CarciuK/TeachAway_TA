using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TeachAway_TA.TestCases.Pages;
using TeachAway_TA.TestCases.Pages.Courses_Hire_Pages;
using TeachAway_TA.TestCases.Pages.JobsPages;
using TeachAway_TA.TestCases.Pages.Login_Register_Pages;
using TeachAway_TA.TestCases.Pages.TeacherCertificationPages;
using TeachAway_TA.TestCases.Pages.TEFLPages;

namespace TeachAway_TA.TestCases
{
    public class Tests: BaseTestPage
    {


        [Test, Order(1)]
        public void Home_Page_Access()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            string pageTitle = driver.Title;
            Assert.AreEqual("Teach Abroad or Online | Your Dream Teaching Job Awaits", pageTitle);

        }



        [Test, Order(2)]
        public void Jobs_JobBoard_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(2000);

            JobBoard_Page jobboard_Page = new JobBoard_Page(driver);
            jobboard_Page.JobBoard_Verification();

        }

        //Extra test for Job Board item
        [Test, Order(3)]
        public void JobBoard_SearchJobs()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            JobBoard_Page jobboard_Page = new JobBoard_Page(driver);
            jobboard_Page.JobBoard_Verification();

            Thread.Sleep(1000);

            jobboard_Page.JobBoard_JobSearch();

        }

        [Test, Order(4)]
        public void Jobs_Destinations_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);
          

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Thread.Sleep(1000);

            Destinations_Page destinations_Page = new Destinations_Page(driver);
            destinations_Page.Destinations_Verification();


            Thread.Sleep(3000);

        }

        [Test, Order(5)]
        public void Jobs_Destinations_Countries_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Destinations_Page destinations_Page = new Destinations_Page(driver);
            destinations_Page.Destinations_Verification();

            destinations_Page.Destination_Countries();

            Thread.Sleep(3000);

        }


        [Test, Order(6)]
        public void Jobs_Destinations_Region_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Destinations_Page destinations_Page = new Destinations_Page(driver);
            destinations_Page.Destinations_Verification();

            destinations_Page.Destination_Regions();

            Thread.Sleep(3000);

        }




        [Test, Order(7)]
        public void Jobs_Destinations_Popular_Locations_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Destinations_Page destinations_Page = new Destinations_Page(driver);
            destinations_Page.Destinations_Verification();

            destinations_Page.Destination_PopularTeachingLocation();

            Thread.Sleep(3000);

        }


        [Test, Order(8)]
        public void Jobs_Destinations_ViewAllOnlineJobs_Button_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));
            
            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Destinations_Page destinations_Page = new Destinations_Page(driver);
            destinations_Page.Destinations_Verification();

            destinations_Page.Destination_ViewAllOnlineJobs();

            String ExpectedText = "Online Teaching Positions";
            String ActualText = driver.FindElement(By.XPath("//*[@id=\"block-tams-content\"]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[2]/div/div/div[1]/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);

            Thread.Sleep(1000);


        }


        [Test, Order(9)]
        public void Jobs_Featured_Programs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Featured_Programs_Page featuredprograms_Page = new Featured_Programs_Page(driver);
            featuredprograms_Page.FeaturedPrograms_Verification();

            Thread.Sleep(3000);

        }



        [Test, Order(10)]
        public void Jobs_FeaturedPrograms_Items_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Featured_Programs_Page featuredprograms_Page = new Featured_Programs_Page(driver);
            featuredprograms_Page.FeaturedPrograms_Verification();

            Thread.Sleep(1000);

            featuredprograms_Page.Featured_Programs_Items();

        }


        [Test, Order(11)]
        public void Jobs_Openings_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(2000);

        }


        [Test, Order(12)]
        public void Jobs_Openings_Item_Hovering_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(2000);

            jobOpenings_Page.JobOpenings_Item_Hovering();

        }


        [Test, Order(13)]
        public void Jobs_Openings_Item_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(2000);

            jobOpenings_Page.JobOpenings_Item_Access();

        }


        [Test, Order(14)]
        public void Jobs_Openings_LicensedTeachers_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(1000);

            jobOpenings_Page.JobOpenings_LicensedTeachers();

        }


        [Test, Order(15)]
        public void Jobs_Openings_LicensedTeachers_BTN_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            jobOpenings_Page.LicensedTeachers_BTNs();

        }


        [Test, Order(16)]
        public void Jobs_Openings_ESLTeachingJobs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(2000);

            jobOpenings_Page.JobOpenings_ESLTeachingJobs();

        }


        [Test, Order(17)]
        public void Jobs_Openings_ESLTeachingJobs_BTN_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            jobOpenings_Page.ESLTeachingJobs_BTNs();

        }



        [Test, Order(18)]
        public void Jobs_Openings_OnlineTeachingJobs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(2000);

            jobOpenings_Page.JobOpenings_OnlineTeachingJobs();

        }



        [Test, Order(19)]
        public void Jobs_Openings_TEFLTeachingJobs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(1000);

            jobOpenings_Page.JobOpenings_TEFLTeachingJobs();

        }


        [Test, Order(20)]
        public void Jobs_Openings_TEFLTeachingJobs_BTN_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
        

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            jobOpenings_Page.TEFLTeachingJobs_BTNs();

        }



        [Test, Order(21)]
        public void Jobs_Openings_K12TeachingJobs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(1000);

            jobOpenings_Page.JobOpenings_K12TeachingJobs();

        }

        [Test, Order(22)]
        public void Jobs_Openings_K12TeachingJobs_BTN_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            jobOpenings_Page.K12TeachingJobs_BTNs();

        }


        [Test, Order(23)]
        public void Jobs_Openings_PrincipalTeachingJobs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(1000);

            jobOpenings_Page.JobOpenings_PrincipalTeachingJobs();

        }




        [Test, Order(24)]
        public void Jobs_Openings_CollegeTeachingJobs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(1000);

            jobOpenings_Page.JobOpenings_CollegeTeachingJobs();

        }


        [Test, Order(25)]
        public void Jobs_Openings_VocationalTeachingJobs_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Job_Openings_Page jobOpenings_Page = new Job_Openings_Page(driver);
            jobOpenings_Page.JobOpenings_Verification();

            Thread.Sleep(1000);

            jobOpenings_Page.JobOpenings_VocationalTeachingJobs();

        }



        [Test, Order(26)]
        public void Jobs_TeachUS_TopCities_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Teach_US_Page teachUS_Page = new Teach_US_Page(driver);
            teachUS_Page.TeachUS_Verification();

            Thread.Sleep(1000);

            teachUS_Page.TeachUS_TopCities_Access();

        }

        [Test, Order(27)]
        public void Jobs_TeachUS_TopStates_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Teach_US_Page teachUS_Page = new Teach_US_Page(driver);
            teachUS_Page.TeachUS_Verification();

            Thread.Sleep(1000);

            teachUS_Page.TeachUS_TopStates_Access();

        }



        [Test, Order(28)]
        public void Jobs_Community_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Community_Page community_Page = new Community_Page(driver);
            community_Page.Community_Verification();

            Thread.Sleep(1000);

            community_Page.Community_Access();

        }



        [Test, Order(29)]
        public void TEFL_Courses_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            TEFL_Courses_Page courses_Page = new TEFL_Courses_Page(driver);
            courses_Page.TEFL_Courses_Access();

            String ExpectedText = "Online TEFL certification";
            String ActualText = driver.FindElement(By.XPath("/html/body/main/div[1]/header/div/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


        }


        [Test, Order(30)]
        public void TEFL_Certification_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            TEFL_Certification_Page certification_Page = new TEFL_Certification_Page(driver);
            certification_Page.TEFL_Certification_Access();

            String ExpectedText = "TEFL Certification";
            String ActualText = driver.FindElement(By.XPath("//*[@id=\"hero-section\"]/div/section/div[2]/div[1]/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


        }


        [Test, Order(31)]
        public void Teacher_Certification_Guide_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));
            
            homePage.PopUpRemove();

            TC_Guide_Page certificationguide_Page = new TC_Guide_Page(driver);
            certificationguide_Page.TC_Guide_Access();

            String ExpectedText = "Alternative Teacher Certification";
            String ActualText = driver.FindElement(By.XPath("/html/body/main/div[1]/header/div/div/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


        }


        [Test, Order(32)]
        public void Teacher_Certification_Program_Verification()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            Certification_Programs_Page certificationprograms_Page = new Certification_Programs_Page(driver);
            certificationprograms_Page.Certification_Programs_Access();

            String ExpectedText = "Alternative Teacher Certification Programs";
            String ActualText = driver.FindElement(By.XPath("/html/body/main/div[1]/header/div/h1")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


        }


        [Test, Order(33)]
        public void Teacher_Certification_States_Verification()
        {
            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            States_Page states_Page = new States_Page(driver);
            states_Page.TC_States_Access();


        }



        [Test, Order(34)]
        public void Courses_Verification()
        {
            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            CoursesPage courses_Page = new CoursesPage(driver);
            courses_Page.Courses_Access();

        }

        [Test, Order(35)]
        public void Hire_Teachers_Verification()
        {
            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();

            HireTeachersPage hireTeachers_Page = new HireTeachersPage(driver);
            hireTeachers_Page.HireTeachers_Access();

        }





        //Extra Tests/LogIn & Register
        [Test, Order(36)]
        public void LogIn_Unsuccessfull()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            LogInPage logInPage = new LogInPage(driver);
            logInPage.UserLogIn_U();

            String ExpectedText = "Sorry, unrecognized e-mail or password. Please try again.";
            String ActualText = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div[1]/div")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


        }


        [Test, Order(37)]
        public void Register_user()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.UserRegister();


        }


        [Test, Order(38)]
        public void LogIn_Successfull()
        {

            this.OpenBrowser();
            HomePage homePage = new HomePage(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(homePage.MenuBar));

            homePage.PopUpRemove();
            Thread.Sleep(1000);

            LogInPage logInPage = new LogInPage(driver);
            logInPage.UserLogIn_S();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div")));

        }



    }
}