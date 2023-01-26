using HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class HubSpotSteps : TestBase
    {
        string environment = "" ;
        [Given(@"I access the hubspot related tables in (.*)")]
        public void GivenIAccessTheHubspotRelatedTablesInEnvironment(string environment)
        {
            this.environment = environment;
            ScenarioContext.Current["Application"] = "HubSpot";
            ScenarioContext.Current["TargetType"] = "";
            ScenarioContext.Current["Capability"] = "";
            ScenarioContext.Current["BrowserType"] = "";
            ScenarioContext.Current["AUTEnv"] = "";
        }

        [When(@"I get the record counts of changed records produced from batches")]
        public void WhenIGetTheRecordCountsOfChangedRecordsProducedFromBatches()
        {
            
        }

        [Then(@"I verify the max record count is (.*)")]
        public void ThenIVerifyTheMaxRecordCountIs(int recordCount)
        {
            DataStorage hubspotRecords = new DataStorage();
            Console.WriteLine("Environment: " + environment);

            bool res = hubspotRecords.VerifyHubSpotRecords(environment, recordCount);

            if (res == false) 
                Assert.Fail("Please check the record count");
        }
               
    }
}
