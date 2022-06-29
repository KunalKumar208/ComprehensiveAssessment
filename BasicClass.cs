using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace ComprehensiveAssesmentBddSpecflow.Utilities
{
    [Binding]
    public static class BaseClass
    {

        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static IWebDriver driver;

        [BeforeFeature]

        public static void LaunchBrowser(FeatureContext featureContext)
        {
            feature = extents.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }
        [AfterScenario]
        public static void CleanUp()
        {
            driver.Quit();

        }
        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter("C://Users//mindtreefeb69//source//repos//ComprehensiveAssesmentBddSpecflow//ComprehensiveAssesmentBddSpecflow//ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReporter);

        }
        [AfterTestRun]
        public static void CloseExtentReport()
        {
            extents.Flush();
        }
        [BeforeScenario]
        public static void LaunchBrowser(ScenarioContext scenariocontext)
        {
            scenario = feature.CreateNode<Scenario>(scenariocontext.ScenarioInfo.Title);

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bigsmall.in/");
           //driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(driver, 20);
            Thread.Sleep(1000);
        }


        [AfterStep]
        public static void InsertReportingStep(ScenarioContext scenariocontext)
        {
            if (scenariocontext.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }
            if (scenariocontext.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
            }
        }

    }
}
