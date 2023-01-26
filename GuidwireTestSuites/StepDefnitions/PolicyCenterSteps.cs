using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.IO;
using GuidewireTestSuites.UIScreenMapping;
using TechTalk.SpecFlow.Assist;
using Microsoft.Win32;
using HelperClasses;
using System.Globalization;
using PolicyCenterPages.Pages.Common;
using PolicyCenterPages.Pages.CreateAccount;
using PolicyCenterPages.Pages.NewSubmission;
using PolicyCenterPages.Pages.Transaction;
using PolicyCenterPages.Pages.Search;
//using TestContext = SupportCore.TestContext;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class PolicyCenterSteps : WebCommonCore.TestBase
    {
		static readonly DateTime StartTime = DateTime.Now;
		[BeforeScenario]

		public void cleanUpBeforeTest()
        {
            //TestContext.setTestContextValue("Test", "Sample Test Message");
            //  InitializeWEbDriver()
            ScenarioContext.Current["RegionAffected"] = false;
            Console.WriteLine("Start Time: " + StartTime.ToString("s", CultureInfo.CreateSpecificCulture("en-US")));
            KillWEbDriver();
        }

        [AfterScenario]
        public void cleanUpAfter()
        {
            //Console.WriteLine("Test Context value: " + TestContext.getTestContextValue("Test"));
            string fileBaseName = "";
			string screenShorFilePath = "";
			if (ScenarioContext.Current.TestError != null)
            {
                //  CaptureApplicationSnapshot("error");
                IWebDriver currDriver = (IWebDriver)ScenarioContext.Current["WebDriver"];

                fileBaseName = string.Format("error_{0}_{1}", ScenarioContext.Current.ScenarioInfo.Title.ToString(), DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                string pageSource = currDriver.PageSource;

                Console.WriteLine("Page Source:" + pageSource);

                string sourceFilePath = Path.Combine(@"c:\Tmp\Errors", fileBaseName+ "_source.html");

                Console.WriteLine("File Path:" + sourceFilePath);

                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);

                Screenshot takescreenshot = ((ITakesScreenshot)currDriver).GetScreenshot();

                if (takescreenshot != null)
                {

                    screenShorFilePath = Path.Combine(@"c:\Tmp\Errors", fileBaseName+"_screenshot.png");

                    Console.WriteLine("screenShorFilePath:" + screenShorFilePath);


                    takescreenshot.SaveAsFile(screenShorFilePath, ScreenshotImageFormat.Png);
                }
            
        }

            Console.WriteLine("After scenario");

            string text = System.IO.File.ReadAllText(@"C:\Tmp\BuildInfo.txt");
			string ReleaseInfo = System.IO.File.ReadAllText(@"C:\Tmp\ReleaseInfo.txt");


			// Display the file contents to the console. Variable text is a string.
			System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            string featureName = FeatureContext.Current.FeatureInfo.Title;

            string userStory = "TBD";

            string[] tags = ScenarioContext.Current.ScenarioInfo.Tags;

            string tag = null;

            foreach (string val in tags)
                tag = val + ";" + tag;

            string scenarioName = ScenarioContext.Current.ScenarioInfo.Title;

            string application = ScenarioContext.Current["Application"].ToString();

            string platform = ScenarioContext.Current["TargetType"].ToString();

            string environment = ScenarioContext.Current["AUTEnv"].ToString();

            string buildNumber = text;

            string result = "Pass";

            if (ScenarioContext.Current.TestError != null)
                result = "Fail";

            string account_Policy = "";
            if (ScenarioContext.Current.ContainsKey("ACCOUNT") && ScenarioContext.Current.ContainsKey("POLICY"))
                account_Policy = ScenarioContext.Current["ACCOUNT"].ToString() + ":" + ScenarioContext.Current["POLICY"].ToString();
            else if (ScenarioContext.Current.ContainsKey("ACCOUNT"))
                account_Policy = ScenarioContext.Current["ACCOUNT"].ToString();

            string executionDate = DateTime.Now.ToShortDateString();

            string stackTrace = "TBD";

            string executionTime = DateTime.Now.ToString();

            DataStorage resultsData = new DataStorage();
            resultsData.WriteTestResults("Insert into TestResults(FeatureName, UserStory , Tags , ScenarioName, Application,Platform, Environment, BuildNumber, Result, Account_Policy,ExecutionDate,StackTrace,ExecutionTime) values ('" + featureName + "','" + userStory + "','" + tag + "','" + scenarioName + "','" + application + "','" + platform + "','" + environment + "','" + buildNumber + "','" + result + "','" + account_Policy + "','" + executionDate + "','" + stackTrace + "','" + executionTime + "')");

			//KillWEbDriver();
			/*DateTime EndTime = DateTime.Now;
			TimeSpan duration = EndTime - StartTime;
			Console.WriteLine("End Time: " + EndTime.ToString("s", CultureInfo.CreateSpecificCulture("en-US")));
			string sRallyDate = DateTime.Now.ToString("s", CultureInfo.CreateSpecificCulture("en-US"));
			long theOID = 0;
			string RallyUser = "";
			string TCNotes = "";
			string RallyEnv = "";
			if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Contains("qa") == true)
			{
				string CurrQAEnv = ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim().Replace("qa", "");
				if (CurrQAEnv.Length == 1)
					CurrQAEnv = "0" + CurrQAEnv;
				RallyEnv = "TEST" + CurrQAEnv;
			}
			else if (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Contains("stage") == true)
			{
				RallyEnv = "STAGE";
			}
			RallyRestApi restApi = new RallyRestApi();
            restApi.AuthenticateWithApiKey("_cnRNX5OUQBazBKT0WmsyzAlMHLcYIkhSqNSC3zflK8", "https://rally1.rallydev.com", proxy: null);
            long RallyTestSetID =0;
			string TestSetCount = "";
            if (featureName == "Digital")
            {
                ReleaseInfo = "";
            }
			if (ReleaseInfo!="")
			{
				try
				{
					Request TestSetRequest = new Request("Testset");
					TestSetRequest.Fetch = new List<string>() { "ObjectID" };
					TestSetRequest.Query = new Query("Name", Query.Operator.Equals, ReleaseInfo);
					QueryResult queryReleaseResults = restApi.Query(TestSetRequest);
					TestSetCount = queryReleaseResults.Results.Count().ToString();
					RallyTestSetID = queryReleaseResults.Results.First()["ObjectID"];
					Console.WriteLine("TestSet ID:" + RallyTestSetID);
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception Caught: {0}\n RallyTestSetCount: {1}",e, TestSetCount);
				}

			}


			Request userRequest = new Request("user");
			userRequest.Fetch = new List<string>() { "UserName" };
			userRequest.Query = new Query("UserName", Query.Operator.Equals, Environment.UserName + "@jminsure.com");
			QueryResult queryUserResults = restApi.Query(userRequest);
			RallyUser = queryUserResults.Results.First()["_ref"];
			Request testCaseRequest = new Request("testcase");
			testCaseRequest.Fetch = new List<string>() { "ObjectID" };
			testCaseRequest.Query = new Query("Name", Query.Operator.Equals, scenarioName);
			QueryResult testCaseResult = restApi.Query(testCaseRequest);
			if (testCaseResult.Results.Count()!=0)
			{
				theOID = testCaseResult.Results.First()["ObjectID"];
				if (theOID != 0)
				{
					DynamicJsonObject toCreate = new DynamicJsonObject();
					toCreate["TestCase"] = "/testcase/" + theOID + "";
					if (ReleaseInfo!="")
					{
						if ((RallyTestSetID != 0) && (result == "Pass"))
						{
							toCreate["TestSet"] = "/testset/" + RallyTestSetID + "";
						}
					}
					toCreate["Build"] = buildNumber;
					toCreate["Date"] = sRallyDate;
					toCreate["Tester"] = RallyUser;
					toCreate["c_Environment"] = RallyEnv;
					toCreate["c_RunMode"] = "Auto";
					toCreate["Verdict"] = result;
					if (duration.Minutes == 0)
					{
						toCreate["Duration"] = "0." + duration.Seconds;
					}
					else
					{
						toCreate["Duration"] = duration.Minutes;
					}
					if (account_Policy != "")
					{
						if (ScenarioContext.Current.ContainsKey("ACCOUNT"))
						{
							TCNotes = "Account # : " + ScenarioContext.Current["ACCOUNT"].ToString() + "<br/>";
							if (ScenarioContext.Current.ContainsKey("POLICY"))
							{
								TCNotes = TCNotes + "Policy  #     : " + ScenarioContext.Current["POLICY"].ToString() + "<br/>";
							}
						}
						if (ScenarioContext.Current.ContainsKey("CLAIM"))
						{
							TCNotes = TCNotes + "Claim   #      : " + ScenarioContext.Current["CLAIM"].ToString() + "<br/>";
						}
						toCreate["Notes"] = TCNotes;
					}
					CreateResult createResult = restApi.Create("testcaseresult", toCreate);



					if ((ScenarioContext.Current.TestError != null) && (screenShorFilePath.ToString() != ""))
					{
                        //Adding attachment to Rally
                        string resultResponse = createResult.Object["_ref"].ToString();
                        char[] dBackSlash = { '/' };
                        string[] reference = resultResponse.Split(dBackSlash);
                        string RallyTCResultRef = reference[reference.Length - 1];
                        Image imageObject = Image.FromFile(screenShorFilePath);
						string imageBase64String = "";
						using (MemoryStream ms = new MemoryStream())
						{
							imageObject.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
							byte[] imageBytes = ms.ToArray();
							string base64String = Convert.ToBase64String(imageBytes);
							imageBase64String = imageBase64String + base64String;
						}
						var imageNumberBytes = Convert.FromBase64String(imageBase64String).Length;
						DynamicJsonObject attachmentContent = new DynamicJsonObject();
						attachmentContent["Content"] = imageBase64String;
						CreateResult AttCreateResult = restApi.Create("AttachmentContent", attachmentContent);
						String myAttachmentContentRef = AttCreateResult.Reference;
						DynamicJsonObject newAttachment = new DynamicJsonObject();
						newAttachment["TestCaseResult"] = "/testcaseresult/" + RallyTCResultRef;
						newAttachment["Content"] = myAttachmentContentRef;
						newAttachment["Name"] = fileBaseName + "_screenshot.png";
						newAttachment["ContentType"] = "image/png";
						newAttachment["Size"] = imageNumberBytes;
						newAttachment["User"] = RallyUser;
						AttCreateResult = restApi.Create("Attachment", newAttachment);
					}
				}
			}
			restApi.Logout();*/
		}



        [Given(@"I access the Guidewire (.*) on (.*) in (.*)")]
        [Then(@"I access the Guidewire (.*) on (.*) in (.*)")]
        [When(@"I access the Guidewire (.*) on (.*) in (.*)")]

        public void GivenIAccessTheGuidewireApplication(string applicationType, string target, string browser)
        {
            Console.WriteLine(Unique.ID.Substring(15));

            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];

            ScenarioContext.Current["Application"] = applicationType;

            DataStorage tempData = new DataStorage();

            switch (applicationType.ToLower().Trim())
            {
                case "pc":
                    tempData.StoreTempValue("guidewire", "PC-APPENV", "PC-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                case "cc":
                    tempData.StoreTempValue("guidewire", "CC-APPENV", "CC-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                case "cm":
                    tempData.StoreTempValue("guidewire", "CM-APPENV", "CM-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                case "kentico":
                    tempData.StoreTempValue("guidewire", "CM-APPENV", "CM-" + ScenarioContext.Current["AUTEnv"].ToString().ToUpper().Trim());
                    break;
                default:
                    break;
            }




            ScenarioContext.Current["TargetType"] = target;

            ScenarioContext.Current["BrowserType"] = browser;

            //  DataStorage temp = new DataStorage();

            //  temp.StoreTempValue("guidewire", "key", "value");

            /*   RegistryKey regKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationSelenium");

               regKey.SetValue("key", "value");

               regKey.Close(); */

        }

        [Given(@"I enter (.*) and (.*) on the Login page")]
        [When(@"I enter (.*) and (.*) on the Login page")]
        [Then(@"I enter (.*) and (.*) on the Login page")]
        public void GivenIEnterLoginDetails(string userName, string password)
        {
            LoginPage loginPg = new LoginPage(getDriver());

            loginPg.EnterLoginDetails(userName, password);

        }

        [When(@"I enter the following details on the on the Login page")]
        [Then(@"I enter the following details on the on the Login page")]
        [Given(@"I enter the following details on the on the Login page")]
        public void LoginPageDetails(Table table)
        {
            GWPCLoginPageDetails loginDetails = table.CreateInstance<GWPCLoginPageDetails>();

            LoginPage loginPg = new LoginPage(getDriver());

            loginPg.EnterLoginDetails(loginDetails.UserName, loginDetails.Password);

        }


        [Given(@"I get the system date")]
        [When(@"I get the system date")]
        public void GivenIGetTheSystemDate()
        {
            AdminTools adminToolsPage = new AdminTools(getDriver());

            adminToolsPage.getSystemDate();

            Console.WriteLine(ScenarioContext.Current["SYSTEMDATE"].ToString());

            DateTime tempDate = Convert.ToDateTime(ScenarioContext.Current["SYSTEMDATE"].ToString());
            //DateTime tempDate = Convert.ToDateTime("11/14/2017");
            //ScenarioContext.Current["SYSTEMDATE"] = tempDate;
            string currSysDate = tempDate.ToString("MM/dd/yyyy");
            Console.WriteLine("currSysDate is " + currSysDate);
            DataStorage tempData = new DataStorage();

            //   DateTime sysDate = ScenarioContext.Current["SYSTEMDATE"]
            //   tempData.StoreTempValue("guidewire", "SYSDATE", currSysDate);
            tempData.StoreTempValue("guidewire", "TESTINGSYSTEMCLOCK", currSysDate);
        }

        [Given(@"I manage Transport")]
        public void GivenIManageTransport()
        {
            string Environmenttoexe = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];
            AdminPage adminPage = new AdminPage(getDriver());
            adminPage.ManageTrasport(Environmenttoexe);
            //homePage.SelectActionMenu(menuItem);
        }


        [When(@"I select (.*) from the Actions menu")]
        public void WhenISelectFromTheActionsMenu(string menuItem)
        {
            HomePage homePage = new HomePage(getDriver());

            homePage.SelectActionMenu(menuItem);
        }

        [When(@"I search for personal account using (.*) and (.*)")]
        public void WhenISearchForPersonalAccountUsing(string firstName, string lastName)
        {
            EnterAccountInformation searchAcc = new EnterAccountInformation(getDriver());

            searchAcc.SearchPersonalAccount(firstName, lastName);

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "FNAME", firstName);

            tempData.StoreTempValue("guidewire", "LNAME", lastName);
        }

        [When(@"I search for commercial account using (.*)")]
        public void WhenISearchForCommercialAccount(string CompanyName)
        {
            EnterAccountInformation searchAcc = new EnterAccountInformation(getDriver());

            searchAcc.SearchCompany(CompanyName);

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "COMPNAME", CompanyName);
        }

        [When(@"I search for commercial account with below company name")]
        public void WhenISearchForCommercialAccountWithBelowCompanyName(Table table)
        {
            WhenISearchForCommercialAccount(table.Rows[0]["CompanyName"]);
        }

        [When(@"I enter following details on create account page (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterDetailsFollowingOnCreateAccountPage(string DOB, string maritalStatus, string primaryPhone, string homePhone, string workPhone, string mobilePhone, string otherPhone, string faxPhone, string primaryEmail, string secondaryEmail, string gender, string occupation, string investigations)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterAccountDetails(DOB, maritalStatus, primaryPhone, homePhone, workPhone, mobilePhone, otherPhone, faxPhone, primaryEmail, secondaryEmail, gender, occupation, investigations);

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "EMAIL", primaryEmail);
        }

        [When(@"I enter following details on create account page for commercial lines (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterFollowingDetailsOnCreateAccountPageForCommercialLines(string officePhone, string faxPhone, string primaryEmail, string secondaryEmail)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterAccountDetailsCL(officePhone, faxPhone, primaryEmail, secondaryEmail);

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "EMAIL", primaryEmail);
        }

        [When(@"I enter following details on create account page for commercial lines")]
        public void WhenIEnterFollowingDetailsOnCreateAccountPageForCommercialLines(Table table)
        {
            string officePhone = table.Rows[0]["OfficePhone"];
            string faxPhone = table.Rows[0]["FaxPhone"];
            string primaryEmail = table.Rows[0]["PrimaryEmail"];
            string secondaryEmail = table.Rows[0]["SecondaryEmail"];
            WhenIEnterFollowingDetailsOnCreateAccountPageForCommercialLines(officePhone, faxPhone, primaryEmail, secondaryEmail);
        }

        [When(@"I update (.*)")]
        public void WhenIUpdateZ(string producerCode)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());
            creatAcc.UpdateProducerCode(producerCode);
        }


        [When(@"For CA I enter Address details on the create account page (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenForCAIEnterAddressDetailsOnTheCreateAccountPage(string careOf, string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string description)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterAddressDetailsCA(careOf, addressLine1, addressLine2, city, state, zipCode, county, country, addressType, description);

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "BASE_STATE", state);
            tempData.StoreTempValue("guidewire", "ZIPCODE", zipCode);
        }



        [When(@"I enter Address details on the create account page (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterAddressDetailsOnTheCreateAccountPage(string careOf, string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string description)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterAddressDetails(careOf, addressLine1, addressLine2, city, state, zipCode, county, country, addressType, description);

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "BASE_STATE", state);
            tempData.StoreTempValue("guidewire", "ZIPCODE", zipCode);
        }

        [When(@"I enter Address details on the create account page for commercial lines")]
        public void WhenIEnterAddressDetailsOnTheCreateAccountPageForCommercialLines(Table table)
        {
            string addressLine1 = table.Rows[0]["AddressLine1"];
            string addressLine2 = table.Rows[0]["AddressLine2"];
            string city = table.Rows[0]["City"];
            string state = table.Rows[0]["State"];
            string zipCode = table.Rows[0]["ZipCode"];
            string county = table.Rows[0]["County"];
            string country = table.Rows[0]["Country"];
            string addressType = table.Rows[0]["AddressType"];
            string orgType = table.Rows[0]["OrgType"];
            WhenIEnterAddressDetailsOnTheCreateAccountPageForCommercialLines(addressLine1, addressLine2, city, state, zipCode, county, country, addressType, orgType);
        }

        [When(@"I enter Address details on the create account page for commercial lines (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterAddressDetailsOnTheCreateAccountPageForCommercialLines(string addressLine1, string addressLine2, string city, string state, string zipCode, string county, string country, string addressType, string orgType)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterAddressDetailsCL(addressLine1, addressLine2, city, state, zipCode, county, country, addressType, orgType);

            DataStorage tempData = new DataStorage();

            tempData.StoreTempValue("guidewire", "BASE_STATE", state);
            tempData.StoreTempValue("guidewire", "ZIPCODE", zipCode);
        }


        [When(@"I enter official id details on the create account page (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterOfficialIdDetails(string SSN, string isAccountAJeweler, string distributionSource, string preferredMethodOfCommunication, string paperlessDelivery, string okToSurvey, string markettingMaterials, string recieveConfirmationEmails, string jewelerID)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterOfficialIDDetails(SSN, isAccountAJeweler, distributionSource, preferredMethodOfCommunication, paperlessDelivery, okToSurvey, markettingMaterials, recieveConfirmationEmails, jewelerID);

            DataStorage tempData = new DataStorage();

            //  tempData.StoreTempValue("guidewire", "PL_Account", ScenarioContext.Current["ACCOUNT"].ToString());
            tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());

        }

        [When(@"I enter official id details on the create account page for commercial lines (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterOfficialIdDetailsOnTheCreateAccountPageForCommercialLines(string EIN, string isAccountAJeweler, string distributionSource, string preferredMethodOfCommunication, string okToSurvey)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterOfficialIDDetailsCL(EIN, isAccountAJeweler, distributionSource, preferredMethodOfCommunication, okToSurvey);
        }

        [When(@"I enter official id details on the create account page for commercial lines")]
        public void WhenIEnterOfficialIdDetailsOnTheCreateAccountPageForCommercialLines(Table table)
        {
            string EIN = table.Rows[0]["EIN"];
            string isAccountAJeweler = table.Rows[0]["IsCompanyAJeweler"];
            string distributionSource = table.Rows[0]["DistributionSource"];
            string preferredMethodOfCommunication = table.Rows[0]["PreferredMethodOfCommunication"];
            string okToSurvey = table.Rows[0]["OkToSurvey"];
            WhenIEnterOfficialIdDetailsOnTheCreateAccountPageForCommercialLines(EIN, isAccountAJeweler, distributionSource, preferredMethodOfCommunication, okToSurvey);
        }

        [When(@"I select (.*) for commercial lines account and create an account")]
        public void WhenISelectProducerForCommercialLinesAccount(string producerCode)
        {
            CreateAccount creatAcc = new CreateAccount(getDriver());

            creatAcc.EnterProducerDetailsCL(producerCode);

            DataStorage tempData = new DataStorage();

            //  tempData.StoreTempValue("guidewire", "CL_Account", ScenarioContext.Current["ACCOUNT"].ToString());
            tempData.StoreTempValue("guidewire", "ACCNO", ScenarioContext.Current["ACCOUNT"].ToString());
        }

        [When(@"I select below producer code for the CL account and Create an account")]
        public void WhenISelectBelowProducerCodeForTheCLAccountAndCreateAnAccount(Table table)
        {
            WhenISelectProducerForCommercialLinesAccount(table.Rows[0]["ProducerCode"]);
        }

        [When(@"I enter (.*) and (.*) on the New Submission page")]
        public void WhenIEnterAndOnTheNewSubmissionPage(string policyEffDate, string product)
        {
            NewSubmissions startNew = new NewSubmissions(getDriver());

            startNew.StartNewSubmission(policyEffDate, product);

            DataStorage tempData = new DataStorage();

            //  tempData.StoreTempValue("guidewire", "CL_Account", ScenarioContext.Current["PCLYEFFDATE"].ToString());
            tempData.StoreTempValue("guidewire", "EFFDATE", ScenarioContext.Current["PCLYEFFDATE"].ToString());
            tempData.StoreTempValue("guidewire", "EXPDATE", ScenarioContext.Current["PCLYEXPFDATE"].ToString());

        }

        [When(@"I enter below details on the New Submission page")]
        public void WhenIEnterBelowDetailsOnTheNewSubmissionPage(Table table)
        {
            WhenIEnterAndOnTheNewSubmissionPage(table.Rows[0]["PolicyEffDate"], table.Rows[0]["Product"]);
        }

        [When(@"I enter (.*) , (.*) , (.*) for questions on qualification page")]
        public void WhenIEnterForQuestionsOnQualificationPage(string professionalAthelete, string previousLoss, string convictedOfCrime)
        {
            PL_Qualification plQualification = new PL_Qualification(getDriver());

            plQualification.selectQualitifications(professionalAthelete, previousLoss, convictedOfCrime);
        }

        [When(@"I add below Additional Insured details with unique name")]
        public void WhenIAddBelowAdditionalInsuredDetailsWithUniqueName(Table table)
        {
            PL_AddAdditionalInsured PL_AddAI = new PL_AddAdditionalInsured(getDriver());

            PL_AddAI.AddAdditionalInsured(table);
        }

        [When(@"I enter the details on the policy information page")]
        public void WhenIEnterTheDetailsOnThePolicyInformationPage()
        {
            PL_PolicyInfo plPolicyInfo = new PL_PolicyInfo(getDriver());

            plPolicyInfo.EnterPolicyInfo();
        }


        [When(@"I enter below PL Policy Info Details")]
        public void WhenIEnterBelowPLPolicyInfoDetails(Table table)
        {
            string policyTermType = table.Rows[0]["Term"];
            string policyEffDt = table.Rows[0]["PolicyEffDate"];
            string PolicyProducerCode = table.Rows[0]["ProducerCode"];
            PL_PolicyInfo plPolicyInfo = new PL_PolicyInfo(getDriver());
            plPolicyInfo.EnterPolicyInfoDetails(policyTermType, policyEffDt, PolicyProducerCode);
            plPolicyInfo.EnterPolicyInfo();


        }



        [When(@"I Update Policy Address in Policy Info Pages")]
        public void WhenIUpdatePolicyAddressInPolicyInfoPages(Table table)
        {
            string policyActionAddressType = table.Rows[0]["ActionAddressType"];
            string policyAddressLIne1 = table.Rows[0]["AddressLIne1"];
            string PolicyCity = table.Rows[0]["City"];
            string PolicyState = table.Rows[0]["State"];
            string PolicyZipCode = table.Rows[0]["ZipCode"];
            PolicyChange plPolicyInfo = new PolicyChange(getDriver());
            plPolicyInfo.ActionPolicyAddressCA(policyActionAddressType, policyAddressLIne1, PolicyCity, PolicyState, PolicyZipCode);

        }


        [When(@"I enter the policy details on the commercial lines policy information page")]
        public void WhenIEnterThePolicyDetailsOnTheCommercialLinesPolicyInformationPage()
        {
            CL_PolicyInfo clPolicyInfo = new CL_PolicyInfo(getDriver());

            clPolicyInfo.EnterPolicyInfo();
        }

        [When(@"I enter below Policy Info Details")]
        public void WhenIEnterBelowPolicyInfoDetails(Table table)
        {
            string policyTermType = table.Rows[0]["TermType"];
            string policyEffDt = table.Rows[0]["PolicyEffDate"];
            string PolicyProducerCode = table.Rows[0]["ProducerCode"];
            string policyTerrSel = table.Rows[0]["TerrorismSelection"];
            string policyExpDt = table.Rows[0]["PolicyExpDate"];
            CL_PolicyInfo clPolicyInfo = new CL_PolicyInfo(getDriver());
            clPolicyInfo.EnterPolicyInfoDetails(policyTermType, policyEffDt, PolicyProducerCode, policyTerrSel);
            clPolicyInfo.ClickNextButton();
        }




        [When(@"I click on tab in Inland Marine Line")]
        public void WhenIClickOnTabInInlandMarineLine(Table table)
        {
            CL_InlandMarineLine clILM = new CL_InlandMarineLine(getDriver());
            clILM.ClickTabILM(table.Rows[0]["Tab"]);
        }

        [When(@"I Update coverage in Off Premise Coverages")]
        public void WhenIUpdateCoverageInOffPremiseCoverages(Table table)
        {
            CL_InlandMarineLine clILM = new CL_InlandMarineLine(getDriver());
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                clILM.Updatecoverage(temp[0], temp[1], temp[2]);
            }
        }



        [When(@"I Update Maximum Travel Aggregate in Off Premise Coverages")]
        public void WhenIUpdateMaximumTravelAggregateInOffPremiseCoverages(Table table)
        {


        }


        [When(@"I enter Inland marine details on the Inland Marine line page")]
        public void WhenIEnterInlandMarineDetailsOnTheInlandMarineLinePage()
        {
            CL_InlandMarineLine clILM = new CL_InlandMarineLine(getDriver());

            //clILM.EnterInlandMarineDetails();
            clILM.ClickNextButton();
        }

        [When(@"I select the (.*) location from existing locations")]
        public void WhenISelectTheFirstLocationFromExistingLocations(string locationNumber)
        {
            CL_Locations clLocations = new CL_Locations(getDriver());

            clLocations.AddExistingLocation(locationNumber);
        }

        [When(@"I add (.*) new ILM location")]
        public void WhenIAddNewILMLocation(int noOfLocs)
        {
            CL_Locations clILMNewLocations = new CL_Locations(getDriver());
            clILMNewLocations.AddNewILMLocations(noOfLocs);
        }

        [When(@"I enter Address details for CL")]
        public void WhenIEnterAddressDetailsForCL(Table table)
        {
            string addressLine1 = table.Rows[0]["AddressLine1"];
            string addressLine2 = table.Rows[0]["AddressLine2"];
            string city = table.Rows[0]["City"];
            string state = table.Rows[0]["State"];
            string zipCode = table.Rows[0]["ZipCode"];
            string county = table.Rows[0]["County"];
            string country = table.Rows[0]["Country"];
            CL_LocationDetails clLocationDetails = new CL_LocationDetails(getDriver());
            clLocationDetails.EnterAddressDetails(addressLine1, addressLine2, city, state, zipCode, county, country);
        }


        [When(@"I Enter the Location details (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIEnterTheLocationDetails(string segmentationCode, string GeneralInformation, string FTEmployees, string PTEmployees, string PublicProtection, string LocationType, string ConstructionType, string TotalBuildingArea, string AreaOccupied, string PercentSplinkered, string SharedPremises, string BurglarAlarm, string TotalLocationInSafe)
        {
            CL_LocationDetails clLocationDetails = new CL_LocationDetails(getDriver());

            clLocationDetails.EnterLocationDetails(segmentationCode, GeneralInformation, FTEmployees, PTEmployees, PublicProtection, LocationType, ConstructionType, TotalBuildingArea, AreaOccupied, PercentSplinkered, SharedPremises);
        }

        [When(@"I click on Edit Work Order in Personal Jewelry Item screen")]
        public void WhenIClickOnEditWorkOrderInPersonalJewelryItemScreen()
        {
            PolicyChange plJewelryItems = new PolicyChange(getDriver());
            plJewelryItems.ClickEditWorkOrder();
            plJewelryItems.ClickRenewalNextButton();
        }



        [When(@"I Dele Multi Jewelry items for POlicy Change")]
        public void WhenIDeleMultiJewelryItemsForPOlicyChange(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PLPChange_JewelryItems plJewelryItems = new PLPChange_JewelryItems(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryInactiveFlag = table.Rows[Itemcounter]["InactiveArticle"];
                string InactiveReason = table.Rows[Itemcounter]["InactiveReason"];
                if (JewelryInactiveFlag.ToLower().Equals("yes"))
                {
                    plJewelryItems.MakeJewelryItemInactive(InactiveReason, Itemcounter + 1);
                }
                Itemcounter = Itemcounter + 1;
            }
            plJewelryItems.ClickPolicyChangeNextButton();
        }


        [When(@"I Add Multi Jewelry items with Deatils")]
        public void WhenIAddMultiJewelryItemsWithDeatils(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PL_JewelryItems plJewelryItems = new PL_JewelryItems(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string JewelryClass = table.Rows[Itemcounter]["Class"];
                string JewelryValueOfItem = table.Rows[Itemcounter]["ValueOfItem"];
                // string JewelryDeductible = Convert.ToInt32(table.Rows[Itemcounter]["Deductible"]);
                string JewelryDeductible = table.Rows[Itemcounter]["Deductible"];
                string JewelryAppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string JewelryAppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];
                string JewelryBrand = table.Rows[Itemcounter]["Brand"];
                string JewelryItemStored = table.Rows[Itemcounter]["ItemStored"];
                string JewelryStyle = table.Rows[Itemcounter]["Style"];


                Console.WriteLine("item counter is " + Itemcounter);
                plJewelryItems.AddMultiJewelryItemDetails(JewelryLocatedWith, JewelryClass, JewelryValueOfItem, JewelryDeductible, JewelryAppraisalReceived, JewelryAppraisalDate, JewelryBrand, JewelryStyle, JewelryItemStored, Itemcounter);
                Itemcounter = Itemcounter + 1;
            }
            if (table.Rows[0]["Alarm"].Length > 1)
            {
                plJewelryItems.UpdateAlarm(table.Rows[0]["Alarm"]);
            }

            plJewelryItems.ClickNextButton();
        }






        [When(@"I enter below ILM location details")]
        public void WhenIEnterBelowILMLocationDetails(Table table)
        {
            string segmentationCode = table.Rows[0]["segmentationCode"];
            string GeneralInformation = table.Rows[0]["GeneralInformation"];
            string FTEmployees = table.Rows[0]["FTEmployees"];
            string PTEmployees = table.Rows[0]["PTEmployees"];
            string PublicProtection = table.Rows[0]["PublicProtection"];
            string LocationType = table.Rows[0]["LocationType"];
            string ConstructionType = table.Rows[0]["ConstructionType"];
            string TotalBuildingArea = table.Rows[0]["TotalBuildingArea"];
            string AreaOccupied = table.Rows[0]["AreaOccupied"];
            string PercentSplinkered = table.Rows[0]["PercentSplinkered"];
            string SharedPremises = table.Rows[0]["SharedPremises"];
            string BurglarAlarm = string.Empty;
            string TotalLocationInSafe = string.Empty;
            WhenIEnterTheLocationDetails(segmentationCode, GeneralInformation, FTEmployees, PTEmployees, PublicProtection, LocationType, ConstructionType, TotalBuildingArea, AreaOccupied, PercentSplinkered, SharedPremises, BurglarAlarm, TotalLocationInSafe);
        }

        [When(@"I Enter the Location details")]
        public void WhenIEnterTheLocationDetails(Table table)
        {
            string segmentationCode = table.Rows[0]["segmentationCode"];
            string GeneralInformation = table.Rows[0]["GeneralInformation"];
            string FTEmployees = table.Rows[0]["FTEmployees"];
            string PTEmployees = table.Rows[0]["PTEmployees"];
            string PublicProtection = table.Rows[0]["PublicProtection"];
            string LocationType = table.Rows[0]["LocationType"];
            string ConstructionType = table.Rows[0]["ConstructionType"];
            string TotalBuildingArea = table.Rows[0]["TotalBuildingArea"];
            string AreaOccupied = table.Rows[0]["AreaOccupied"];
            string PercentSplinkered = table.Rows[0]["PercentSplinkered"];
            string SharedPremises = table.Rows[0]["SharedPremises"];
            string BurglarAlarm = table.Rows[0]["BurglarAlarm"];
            string TotalLocationInSafe = table.Rows[0]["TotalLocationInSafe"];
            WhenIEnterTheLocationDetails(segmentationCode, GeneralInformation, FTEmployees, PTEmployees, PublicProtection, LocationType, ConstructionType, TotalBuildingArea, AreaOccupied, PercentSplinkered, SharedPremises, BurglarAlarm, TotalLocationInSafe);
        }

        [When(@"I Add jewelry items")]
        public void WhenIAddJewelryItems()
        {
            PL_JewelryItems plJewelryItems = new PL_JewelryItems(getDriver());

            plJewelryItems.AddJewelryItems();


        }

        [When(@"I Add Multi Jewelry items for POlicy Change")]
        public void WhenIAddMultiJewelryItemsForPOlicyChange(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PLPChange_JewelryItems plJewelryItems = new PLPChange_JewelryItems(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string JewelryClass = table.Rows[Itemcounter]["Class"];
                string JewelryValueOfItem = table.Rows[Itemcounter]["ValueOfItem"];
                // string JewelryDeductible = Convert.ToInt32(table.Rows[Itemcounter]["Deductible"]);
                string JewelryDeductible = table.Rows[Itemcounter]["Deductible"];
                string JewelryAppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string JewelryAppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];

                Console.WriteLine("item counter is " + Itemcounter + 1);
                plJewelryItems.AddMultiJewelryItem(JewelryLocatedWith, JewelryClass, JewelryValueOfItem, JewelryDeductible, JewelryAppraisalReceived, JewelryAppraisalDate, Itemcounter + 1);
                Itemcounter = Itemcounter + 1;
            }
            plJewelryItems.ClickPolicyChangeNextButton();
        }



        [When(@"I Add Multi Jewelry items")]
        public void WhenIAddMultiJewelryItems(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PL_JewelryItems plJewelryItems = new PL_JewelryItems(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string JewelryClass = table.Rows[Itemcounter]["Class"];
                string JewelryValueOfItem = table.Rows[Itemcounter]["ValueOfItem"];
                // string JewelryDeductible = Convert.ToInt32(table.Rows[Itemcounter]["Deductible"]);
                string JewelryDeductible = table.Rows[Itemcounter]["Deductible"];
                string JewelryAppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string JewelryAppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];

                Console.WriteLine("item counter is " + Itemcounter);
                plJewelryItems.AddMultiJewelryItem(JewelryLocatedWith, JewelryClass, JewelryValueOfItem, JewelryDeductible, JewelryAppraisalReceived, JewelryAppraisalDate, Itemcounter);
                Itemcounter = Itemcounter + 1;
            }
            plJewelryItems.ClickNextButton();
        }



        [When(@"I Add Jewelry item with (.*) , (.*) , (.*) , (.*)")]
        public void WhenIAddJewelryItemWithSelfBrooch(string LocatedWith, string Class, string ValueOfItem, string Deductible)
        {
            PL_JewelryItems plJewelryItems = new PL_JewelryItems(getDriver());

            plJewelryItems.AddJewelryItem(LocatedWith, Class, ValueOfItem, Deductible);

        }


        [When(@"I click next on the Risk Analysis")]
        public void WhenIClickNextOnTheRiskAnalysis()
        {
            PL_RiskAnalysis plRiskAnalysis = new PL_RiskAnalysis(getDriver());

            plRiskAnalysis.ClickNext();
        }

        [When(@"I click Quote on the Policy Review")]
        public void WhenIClickQuoteOnThePolicyReview()
        {
            PL_PolicyReview plPolicyReview = new PL_PolicyReview(getDriver());

            plPolicyReview.QuotePolicy();

        }
        [When(@"I verify policy rewrite Bound")]
        public void WhenIVerifyPolicyRewriteBound()
        {
            Console.WriteLine("Verify Policy");
            PolicyRewriteFullTerm VerifyIssuedRewrite = new PolicyRewriteFullTerm(getDriver());
            VerifyIssuedRewrite.VerifyRewritePolicy();
        }

        [When(@"I Issue the policy")]
        [Then(@"I Issue the policy")]
        public void WhenIIssueThePolicy()
        {
            PL_Quote plQuote = new PL_Quote(getDriver());
            //plQuote.IssuePolicy();
            plQuote.PLIssuePolicy();
            DataStorage tempData = new DataStorage();

            //  tempData.StoreTempValue("guidewire", "PL_Policy", ScenarioContext.Current["POLICY"].ToString());
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }


        [Then(@"I special Approve all existing Blocking Bind issues")]
        [When(@"I special Approve all existing Blocking Bind issues")]
        public void WhenISpecialApproveAllExistingBlockingBindIssues()
        {
            CL_Quote clQuote = new CL_Quote(getDriver());
            clQuote.SpecialApproveBlockingBindissues();
        }


        [When(@"I Issue the CL policy")]
        [Then(@"I Issue the CL policy")]
        public void ThenIIssueTheCLPolicy()
        {
            CL_Quote clQuote = new CL_Quote(getDriver());

            clQuote.IssuePolicy();

            DataStorage tempData = new DataStorage();

            // tempData.StoreTempValue("guidewire", "CL_Policy", ScenarioContext.Current["POLICY"].ToString());
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }

        [When(@"I select issued policy")]
        public void WhenISelectIssuedPolicy()
        {
            PCSubmissionBound cl_SubmissionBound = new PCSubmissionBound(getDriver());
            cl_SubmissionBound.ClickIssuedPolicy();

        }

        //[Given(@"I select policy of searched account")]
        //public void GivenISelectPolicyOfSearchedAccount()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        [Given(@"I logout of the application")]
        [Then(@"I logout of the application")]
        [When(@"I logout of the application")]
        public void WhenILogoutOfTheApplication()
        {
            HomePage homePage = new HomePage(getDriver());

            homePage.Logout();
            KillWEbDriver();

            ScenarioContext.Current.Remove("WebDriver");
        }

        [When(@"I select (.*) on the Offerings page")]
        public void WhenISelectOffering(string offering)
        {
            CL_Offerings offeringsPage = new CL_Offerings(getDriver());

            offeringsPage.SelectOffering(offering);
        }

        [When(@"I select below offering on the Offerings Page")]
        public void WhenISelectBelowOfferingOnTheOfferingsPage(Table table)
        {
            WhenISelectOffering(table.Rows[0]["Offering"]);
        }

        [When(@"I select (.*) on the Line Selection page")]
        public void WhenISelectOnTheLineSelectionPage(string lineItems)
        {
            CL_LineSelection lineSelection = new CL_LineSelection(getDriver());

            lineSelection.SelectLines(lineItems);
        }

        [When(@"I select below line items on line selection page")]
        public void WhenISelectBelowLineItemsOnLineSelectionPage(Table table)
        {
            WhenISelectOnTheLineSelectionPage(table.Rows[0]["LineItems"]);
        }

        [When(@"I enter (.*) for all questions on qualification page")]
        public void WhenIEnterNoForAllQuestionsOnQualificationPage(string radioOption)
        {
            CL_Qualification qualificationPage = new CL_Qualification(getDriver());

            qualificationPage.selectQualitifications(radioOption);
        }

        [When(@"I enter below security information details for location")]
        public void IEnterBelowSecurityInformationDetailsForLocation(Table table)
        {
            CL_LocationSecurityInformation clSecurityInfo = new CL_LocationSecurityInformation(getDriver());

            clSecurityInfo.EnterSecurityInfo(table.Rows[0]["BurglarAlarm"]);
        }

        [When(@"I Enter the Security Information Details (.*)")]
        public void WhenIEnterTheSecurityInformationDetails(string alarm)
        {
            CL_LocationSecurityInformation clSecurityInfo = new CL_LocationSecurityInformation(getDriver());

            clSecurityInfo.EnterSecurityInfo(alarm);
        }




        [When(@"I Enter the Safes Vaults and Stockroom details (.*) and (.*)")]
        public void WhenIEnterTheSafesVaultsAndStockroomDetails(string TotalLocationInSafe, string BankVault)
        {
            CL_SafesVaultsStockrooms clSafesVaults = new CL_SafesVaultsStockrooms(getDriver());

            clSafesVaults.EnterSafesVaults(TotalLocationInSafe, BankVault);
        }

        [When(@"I enter below details for Safe Vault and Stock Room")]
        public void WhenIEnterBelowDetailsForSafeVaultAndStockRoom(Table table)
        {
            WhenIEnterTheSafesVaultsAndStockroomDetails(table.Rows[0]["TotalLocationInSafe"], table.Rows[0]["BankVault"]);
        }

        [When(@"I Enter below listed Jewelry Stock Information details")]
        public void WhenIEnterBelowListedJewelryStockInformationDetails(Table table)
        {
            CL_JewelryStock clJewelryStock = new CL_JewelryStock(getDriver());
            clJewelryStock.EnterJewelryStockInfoDetails(table.Rows[0]["LastInvTotal"], table.Rows[0]["StockValue"], table.Rows[0]["AvgAmtCustomersProperty"], table.Rows[0]["AvgAmtMemoConsignment"], table.Rows[0]["LooseDiamonds"], table.Rows[0]["stockAOPLimit"]);
        }



        [When(@"I Enter the Jewelry Stock Information")]
        public void WhenIEnterTheJewelryStockInformation()
        {
            CL_JewelryStock clJewelryStock = new CL_JewelryStock(getDriver());
            clJewelryStock.EnterJewelryStockInfo();
        }




        [When(@"I Click Next on Location Page")]
        public void WhenIClickNextOnLocationPage()
        {
            CL_Locations clLocations = new CL_Locations(getDriver());

            clLocations.LocationsNext();
        }

        [When(@"I Click Next on Modifiers Page")]
        public void WhenIClickNextOnModifiersPage()
        {
            CL_Modifiers clModifiers = new CL_Modifiers(getDriver());

            clModifiers.ModifiersNext();
        }

        [When(@"I Click Next on Line Review Page")]
        public void WhenIClickNextOnLineReviewPage()
        {
            CL_LineReview clLineReview = new CL_LineReview(getDriver());

            clLineReview.LineReviewNext();
        }

        [When(@"I Enter Employment-Related Practices Liability")]
        public void WhenIEnterEmployment_RelatedPracticesLiability(Table table)
        {
            CL_BusinessOwnersLine clBOLine = new CL_BusinessOwnersLine(getDriver());
            clBOLine.UpdateEmploymentRelatedPracticesLiability(table.Rows[0]["PerClaimLimit"], table.Rows[0]["Deductible"]);
        }


        [When(@"I Enter below details on Business Owners Line Page")]
        public void WhenIEnterBelowDetailsOnBusinessOwnersLinePage(Table table)
        {
            CL_BusinessOwnersLine clBOLine = new CL_BusinessOwnersLine(getDriver());

            clBOLine.UpdateBusinnessOwnerLineDetails(table.Rows[0]["RetroDate"], table.Rows[0]["PackageType"]);
            clBOLine.Updatecoverage(table.Rows[0]["Coveragetype"], table.Rows[0]["IncludedLimit"], table.Rows[0]["OverrideLimit"], table.Rows[0]["RetainedLimitofInsurance"], table.Rows[0]["FacultativeReinsuranceCost"], table.Rows[0]["IncludedDeductible"], table.Rows[0]["OverrideDeductible"]);
            clBOLine.clickNextButton();

        }


        [When(@"I Enter (.*) on the Business Owners Line Page")]
        public void WhenIEnterInBusinessOwnersLinePage(string retroDate)
        {
            CL_BusinessOwnersLine clBOLine = new CL_BusinessOwnersLine(getDriver());

            clBOLine.EnterBusinnessOwnerLineDetails(retroDate);
        }

        [When(@"I Set Territory code (.*) for Location")]
        public void WhenISetTerritoryCodeForLocation(string TerriotryCode)
        {
            CL_BOLocations clBOLocations = new CL_BOLocations(getDriver());

            clBOLocations.BOLOcationSetTerritoryCode(TerriotryCode);
        }



        [When(@"I Click Next on Business Owners Locations Page")]
        public void WhenIClickNextOnBusinessOwnersLocationsPage()
        {
            CL_BOLocations clBOLocations = new CL_BOLocations(getDriver());

            clBOLocations.BOLOcationsNext();
        }

        [When(@"I Click on Add Inland Marine Location Building")]
        public void WhenIClickOnAddInlandMarineLocationBuilding()
        {
            CL_BOBuildings clBOBuildings = new CL_BOBuildings(getDriver());

            clBOBuildings.BOAddILMLocation();
        }

        [When(@"I Click on Add All Existing ILM Locations the Business Owners Line Page")]
        public void WhenIClickOnAddAllExistingILMLocationsTheBusinessOwnersLinePage()
        {
            CL_BOBuildings clBOBuildings = new CL_BOBuildings(getDriver());

            clBOBuildings.BOAddAllILMLocations();
        }

        [When(@"I verify all existing locations for validation messages")]
        public void WhenIVerifyAllExistingLocationsForValidationMessages()
        {
            CL_BOBuildings clBOBuildings = new CL_BOBuildings(getDriver());

            clBOBuildings.VerifyBOLocSegmentationCode();
        }

        [When(@"I Enter the Building Details")]
        public void WhenIEnterTheBuildingDetails()
        {
            CL_BOBuildingDetails clBuildingDetails = new CL_BOBuildingDetails(getDriver());

            clBuildingDetails.AddBuildingDetails();
        }




        [When(@"I Enter BPP Coverages Details")]
        public void WhenIEnterBPPCoveragesDetails()
        {
            CL_BOBuildings_BPPCoverages bppCoverages = new CL_BOBuildings_BPPCoverages(getDriver());

            bppCoverages.EnterBPPCoverages();

            //
        }

        [When(@"I Add ILM Building and its details for each location")]
        public void WhenIAddILMBuildingAndItsDetailsForEachLocation()
        {
            WhenIClickOnAddInlandMarineLocationBuilding();
            WhenIEnterTheBuildingDetails();
            WhenIEnterBPPCoveragesDetails();
            CL_BOBuildings clBOBuildings = new CL_BOBuildings(getDriver());
            clBOBuildings.SelectBOLocation(2);
            WhenIClickOnAddInlandMarineLocationBuilding();
            WhenIEnterTheBuildingDetails();
            WhenIEnterBPPCoveragesDetails();
        }


        [When(@"I Enter below Security Information Details")]
        public void WhenIEnterBelowSecurityInformationDetails(Table table)
        {
            CL_BOBuildings_SecurityInformation siCoverages = new CL_BOBuildings_SecurityInformation(getDriver());
            siCoverages.EnterSecurityInformation(table.Rows[0]["FireAlarm"], table.Rows[0]["ProtectiveSafeGuard"], table.Rows[0]["servicecontract"], table.Rows[0]["WatchManservice"], table.Rows[0]["Alarmsystem"], table.Rows[0]["ExtentofprotecationHigh"], table.Rows[0]["ExtentofprotecationMid"], table.Rows[0]["ExtentofprotecationLow"]);
        }

        [When(@"I Enter Security Information Details")]
        public void WhenIEnterSecurityInformationDetails()
        {
            CL_BOBuildings_SecurityInformation siCoverages = new CL_BOBuildings_SecurityInformation(getDriver());
        // siCoverages.EnterSecurityInformation("Yes", "No", "", "no watchman service", "Local Alarm", "yes", "", "");
           siCoverages.EnterSecurityInformation();
        }


        [When(@"I Click next on the Business owners Building page")]
        public void WhenIClickNextOnTheBusinessOwnersBuildingPage()
        {
            CL_BOBuildings clBOBuildings = new CL_BOBuildings(getDriver());

            clBOBuildings.BOBuildingNext();
        }

        [When(@"I Click next on the Business owners Blankets page")]
        public void WhenIClickNextOnTheBusinessOwnersBlanketsPage()
        {
            CL_BOBlankets clBoBlankets = new CL_BOBlankets(getDriver());

            clBoBlankets.BOBlanketsNext();
        }

        [When(@"I Click next on the Business owners Modifiers page")]
        public void WhenIClickNextOnTheBusinessOwnersModifiersPage()
        {
            CL_BOModifiers clBoModifiers = new CL_BOModifiers(getDriver());

            clBoModifiers.BOModifiersNext();

        }

        [When(@"I Click next on the Business owners Line Review page")]
        public void WhenIClickNextOnTheBusinessOwnersLineReviewPage()
        {
            CL_BOLineReview clBOLineReview = new CL_BOLineReview(getDriver());
            clBOLineReview.BOLineReviewNext();
        }


        [When(@"I Update Standard coverages for Umbrella Line")]
        public void WhenIUpdateStandardCoveragesForUmbrellaLine(Table table)
        {
            CL_UmbrellaLine clUmbrella = new CL_UmbrellaLine(getDriver());
            clUmbrella.UpdateStandardCoverages(table.Rows[0]["UmbrellaLimit"], table.Rows[0]["AdditionalPremium"], table.Rows[0]["SelfInsuredRetention"]);
        }


        [When(@"I Enter the Umbrella Line Coverage Details")]
        public void WhenIEnterTheUmbrellaLineCoverageDetails()
        {
            CL_UmbrellaLine clUmbrella = new CL_UmbrellaLine(getDriver());

            clUmbrella.BOUmbrellaLineDetails();
        }


        [When(@"I Click Next on Umbrella Modifiers Page")]
        public void WhenIClickNextOnUmbrellaModifiersPage()
        {
            CL_UmbrellaModifiers clUmbrellaModifiers = new CL_UmbrellaModifiers(getDriver());

            clUmbrellaModifiers.BOUmbrellaModifiersNExt();
        }

        [When(@"I Enter the Umbrella Underwritings details")]
        public void WhenIEnterTheUmbrellaUnderwritingsDetails()
        {
            CL_UmbrellaUnderwriting clUmbrellaUnderwriting = new CL_UmbrellaUnderwriting(getDriver());

            clUmbrellaUnderwriting.BOUmbrellaUnderwritingDetails();
        }

        [When(@"I Click Next on the Line Review Page")]
        public void WhenIClickNextOnTheLineReviewPage()
        {
            CL_UmbrellaLineReview clUmbrellaLineReview = new CL_UmbrellaLineReview(getDriver());

            clUmbrellaLineReview.BOUmbrellaLineReviewNext();
        }

        [When(@"I Click on Next on the Risk analysis Page")]
        public void WhenIClickOnNextOnTheRiskAnalysisPage()
        {
            CL_RiskAnalysis clRiskAnalysis = new CL_RiskAnalysis(getDriver());
            clRiskAnalysis.RiskAnalysisQuote();
        }

        [When(@"I select (.*) from the Tab menu of Policy Center")]
        [Given(@"I select (.*) from the Tab menu of Policy Center")]
        public void WhenISelectSearchFromTheTabMenuOfPolicyCenter(string p0)
        {
            HomePage PCHomePage = new HomePage(getDriver());

            PCHomePage.NavigateTabBar(p0, string.Empty);

        }

        [Given(@"search for account with (.*) and select from search results in Policy Center")]
        [When(@"search for account with (.*) and select from search results in Policy Center")]
        public void WhenSearchForAccountWithAndSelectFromSearchResultsInPolicyCenter(string accountNumber)
        {
            DataStorage temp = new DataStorage();

            string accNum = null;
            switch (accountNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    accNum = temp.GetTempValue("ACCNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    accNum = UFTRegKey.GetValue("ACCNO").ToString();
                    break;
                default:
                    accNum = accountNumber;
                    break;
            }

            SearchAccounts searchAccounts = new SearchAccounts(getDriver());

            searchAccounts.SearchAccount(accNum);
            searchAccounts.SelectAccount();
        }

        [Given(@"I search for (.*) and select from search results")]
        [When(@"I search for (.*) and select from search results")]
        public void GivenISearchForAndSelectFromSearchResults(string policyNumber)
        {
            DataStorage temp = new DataStorage();

            string policyNum = null;
            switch (policyNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    policyNum = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    policyNum = UFTRegKey.GetValue("PLCYNO").ToString();
                    break;
                default:
                    policyNum = policyNumber;
                    break;
            }

            SearchAccounts searchAccounts = new SearchAccounts(getDriver());

            searchAccounts.SearchPolicy(policyNum);

            searchAccounts.SelectPolicy();
        }


        [When(@"I get Policynumber, LastName and zipcode from summary Page")]
        public void WhenIGetPolicynumberLastNameAndZipcodeFromSummaryPage()
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            PCDetailsPage.getDetailsforQuickClaim();
        }



        [When(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*), (.*) in Left Account Details page for policy center")]
        [Then(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*), (.*) in Left Account Details page for policy center")]
        public void ThenIVerifyInLeftAccountDetailsPageForPolicyCenter(string PrimaryInsured, string Address, string PhonNo, string Email, string Status, string AddressType, string Gender, string Occupation, string DateofBirth)
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            DataStorage temp = new DataStorage();
            string PriInsured = null;
            string Addr = null;
            switch (PrimaryInsured.ToUpper().Trim())
            {
                case "REGISTRY":
                    PriInsured = temp.GetTempValue("PRIMARY_INSURED");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PriInsured = UFTRegKey.GetValue("PRIMARY_INSURED").ToString();
                    break;
                default:
                    PriInsured = PrimaryInsured;
                    break;
            }

            switch (Address.ToUpper().Trim())
            {
                case "REGISTRY":
                    Addr = temp.GetTempValue("ACC_ADDRESS");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Addr = UFTRegKey.GetValue("ACC_ADDRESS").ToString();
                    break;
                default:
                    Addr = Address;
                    break;
            }


            switch (Email.ToUpper().Trim())
            {
                case "UNIQUE":
                    Email = temp.GetTempValue("EMAIL");
                    break;

                default:
                    Email = Email;
                    break;
            }


            Console.WriteLine("Reg Values: {0},{1},{2},{3},{4}", PriInsured, Address, PhonNo, Email, Status);
            PCDetailsPage.VerifyLeftAccountDetails(PriInsured, Addr, PhonNo, Email, Status, AddressType, Gender, Occupation, DateofBirth);
        }


        [When(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) in Right Account Details page for policy center for QNA Account")]
        [Then(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) in Right Account Details page for policy center for QNA Account")]
        public void ThenIVerifyInRightAccountDetailsPageForPolicyCenterForQNAAccount(string DistributionSource, string MethodofCommunication, string ApplicationTakenBy, string Paperless, string ProducerCode)
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            DataStorage temp = new DataStorage();
            switch (ProducerCode.ToUpper().Trim())
            {
                case "REGISTRY":
                    ProducerCode = temp.GetTempValue("PRODUCERCODE");
                    break;

              
            }
            PCDetailsPage.VerifyRightAccountDetailsQNA(DistributionSource, MethodofCommunication, ApplicationTakenBy, Paperless, ProducerCode);

        }



        [Then(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) in Right Account Details page for policy center")]
        public void ThenIVerifyInRightAccountDetailsPageForPolicyCenter(string DistributionSource, string MethodofCommunication, string ApplicationTakenBy, string Paperless, string OktoSurvey, string MarketingMaterials, string ReceiveConfirmationEmails, string ProducerCode)
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            DataStorage temp = new DataStorage();
            PCDetailsPage.VerifyRightAccountDetails(DistributionSource, MethodofCommunication, ApplicationTakenBy, Paperless, OktoSurvey, MarketingMaterials, ReceiveConfirmationEmails, ProducerCode);

        }



        //[Then(@"I verify (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)  in Right Account Details page for policy center")]
        //public void ThenIVerifyInRightAccountDetailsPageForPolicyCenter(string DistributionSource, string MethodofCommunication, string Paperless, string OktoSurvey, string MarketingMaterials, string ReceiveConfirmationEmails, string ProducerCode)
        //{
        //    PCDetails bCDetailsPage = new PCDetails(getDriver());
        //    DataStorage temp = new DataStorage();
        //    bCDetailsPage.VerifyRightAccountDetails(DistributionSource, MethodofCommunication, Paperless, OktoSurvey, MarketingMaterials, ReceiveConfirmationEmails, ProducerCode);
        //    bCDetailsPage.VerifyRightAccountDetails(DistributionSource, MethodofCommunication, Paperless, OktoSurvey, MarketingMaterials, ReceiveConfirmationEmails, ProducerCode);
        //}



        [Then(@"I verfy   (.*) , (.*) , (.*) in Policy Term  for policy center")]
        [When(@"I verfy   (.*) , (.*) , (.*) in Policy Term  for policy center")]
        public void ThenIVerfyInPolicyTermForPolicyCenter(string PolicyNumber, string Status, string EffectiveDate)
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            DataStorage temp = new DataStorage();
            string Policyno = null;
            string PolicyStatus = null;
            string PolicyEffectiveDate = null;

            switch (PolicyNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    Policyno = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    Policyno = UFTRegKey.GetValue("PolicyNumber").ToString();
                    break;
                default:
                    Policyno = PolicyNumber;
                    break;
            }

            switch (Status.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyStatus = temp.GetTempValue("Status");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyStatus = UFTRegKey.GetValue("Status").ToString();
                    break;
                default:
                    PolicyStatus = Status;
                    break;
            }

            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyEffectiveDate = temp.GetTempValue("EFFDATE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyEffectiveDate = UFTRegKey.GetValue("EFFDATE").ToString();
                    break;
                default:
                    PolicyEffectiveDate = EffectiveDate;
                    break;
            }

            Console.WriteLine(Policyno + PolicyStatus + PolicyEffectiveDate);
            PCDetailsPage.VerifyPolicyTerm(Policyno, PolicyStatus, PolicyEffectiveDate);
        }


        [Then(@"I click on PolicyNo of Account detail screen")]
        [When(@"I click on PolicyNo of Account detail screen")]

        public void ThenIClickOnPolicyNoOfAccountDetailScreen()
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            PCDetailsPage.SelectPolicyNumber();
        }

        [Given(@"I select (.*) from actions menu of Policy Cenetr")]
        [When(@"I select (.*) from actions menu of Policy Cenetr")]
        [Then(@"I select (.*) from actions menu of Policy Cenetr")]
        public void WhenISelectFromActionsMenuOfPolicyCenetr(string option)
        {

            HomePage PCHomePage = new HomePage(getDriver());
            PCHomePage.SelectActionMenuForWorkOrder(option);
        }


        [Then(@"I verify (.*) , (.*) , (.*) in Policy Summary page of policy center")]
        public void ThenIVerifyInPolicySummaryPageOfPolicyCenter(string Product, string TransactionType, string TotalCost)
        {
            PolicySummary PCSummaryPage = new PolicySummary(getDriver());
            PCSummaryPage.VerifyPolicySummary(Product, TransactionType, TotalCost);



        }


        [Then(@"I verfy   (.*) , (.*) in Policy Term  for WorkOrders in policy center")]
        [When(@"I verfy   (.*) , (.*) in Policy Term  for WorkOrders in policy center")]
        public void IVerfyInForceInPolicyTermForWorkOrdersInPolicyCenter(string Status, string EffectiveDate)
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            DataStorage temp = new DataStorage();
            string PolicyStatus = null;
            string PolicyEffectiveDate = null;

            switch (Status.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyStatus = temp.GetTempValue("Status");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyStatus = UFTRegKey.GetValue("Status").ToString();
                    break;
                default:
                    PolicyStatus = Status;
                    break;
            }

            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    PolicyEffectiveDate = temp.GetTempValue("EFFDATE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    PolicyEffectiveDate = UFTRegKey.GetValue("EffectiveDate").ToString();
                    break;
                default:
                    PolicyEffectiveDate = EffectiveDate;
                    break;
            }


            PCDetailsPage.VerifyQuoteTerm(PolicyStatus, PolicyEffectiveDate);
        }

        [Then(@"I click workorder number of Account detail screen")]
        [When(@"I click workorder number of Account detail screen")]
        public void ThenIClickWorkorderNumberOfAccountDetailScreen()
        {
            PCDetails PCDetailsPage = new PCDetails(getDriver());
            PCDetailsPage.SelectWorkOrderNumber();
        }

        [Then(@"I click on (.*) on Left NavMenu Screen")]
        [When(@"I click on (.*) on Left NavMenu Screen")]
        public void ThenIClickOnTabOnLeftNavMenuScreen(string leftNavMenu)
        {
            HomePage PCNavigation = new HomePage(getDriver());
            PCNavigation.selectLeftNavMenu(leftNavMenu);
        }

        [When(@"I verify  (.*) in GW policy Center")]
        public void WhenIVerifyInGWPolicyCenter(string CreditConsent)
        {

            Contacts PCContacts = new Contacts(getDriver());
            PCContacts.VerifyCreditConsent(CreditConsent);
        }


        [When(@"I verify (.*) in the Risk Analysis screen")]
        [Then(@"I verify (.*) in the Risk Analysis screen")]
        public void ThenIVerifyInTheRiskAnalysisScreen(string activities)
        {
            RiskAnalysis PCRiskPage = new RiskAnalysis(getDriver());
            string actualVal = PCRiskPage.VerifyActivities(activities);
            string coampre_flag = "";
            string actual_value_temp = actualVal;
            if (activities.Contains(";"))
            {
                int expect_counter = 1;
                int Actual_counter = 1;
                char[] delimiterChars = { ';' };
                string[] Expectedactivity = activities.Split(delimiterChars);
                string[] actualactivity = actualVal.Split(delimiterChars);
                foreach (string expected in Expectedactivity)
                {
                    Console.WriteLine(expect_counter + " expected value " + expected);
                    coampre_flag = "false";
                    foreach (string actual in actualactivity)
                    {
                        Console.WriteLine(Actual_counter + " actual value " + actual);
                        if (actual.ToLower().Trim().Contains(expected.ToLower().Trim()))
                        {
                            coampre_flag = "true";
                            actual_value_temp = actual;
                            break;
                        }
                        Actual_counter = Actual_counter + 1;
                    }
                    if (string.Equals(coampre_flag, "true"))
                    {
                        //  Assert.AreEqual(expected.ToLower(), actual_value_temp.ToLower());
                        Console.WriteLine("expected value match " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                    }
                    else
                    {
                        Console.WriteLine("expected value do not match " + expected.ToLower() + "actual value is " + actual_value_temp.ToLower());
                        Assert.AreEqual(expected.ToLower(), actualVal.ToLower());

                    }
                    Actual_counter = 0;
                    expect_counter = expect_counter + 1;
                }
            }
            else
            {
                if (actualVal.Contains(activities))
                {

                    Console.WriteLine("Activities matches expected value is " + activities.ToLower() + "actual value is " + activities.ToLower());
                    // Assert.AreEqual(activities.ToLower(), actual_value_temp.ToLower());
                }
                else
                {
                    Console.WriteLine("Activities do not matches expected value is " + activities.ToLower() + "actual value is " + actualVal.ToLower());
                    Assert.AreEqual(activities.ToLower(), actual_value_temp.ToLower());
                }
            }
        }

        [When(@"I select (.*) from the (.*) Tab menu of Policy Center")]
        public void WhenISelectFromTheTabMenuOfPolicyCenter(string submenu, string menu)
        {
            HomePage PCHomePage = new HomePage(getDriver());
            if (string.IsNullOrEmpty(submenu))
            {
                PCHomePage.NavigateTabBar(menu, string.Empty);
            }
            else
            {
                PCHomePage.NavigateTabBar(menu, submenu);
            }
        }

        [When(@"I Update Pre Renewal direction details")]
        [Then(@"I Update Pre Renewal direction details")]
        public void WhenIUpdatePreRenewalDirectionDetails(Table table)
        {
            PolicyChange PreRenewalDirection = new PolicyChange(getDriver());
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string Direction = temp[0];
                string Text = temp[1];
                string NonRenewReason = temp[2];
                PreRenewalDirection.UpdatePreRenewal(Direction, Text, NonRenewReason);
            }
        }



        [Then(@"I verify Personal Jewelry Items details")]
        public void ThenIVerifyPersonalJewelryItemsDetails(Table table)
        {
            PersonalJewelryItem PCItemPage = new PersonalJewelryItem(getDriver());
            DataStorage temp = new DataStorage();
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp1 = row.Values.ToList();
                string LocatedWith = temp1[0];
                switch (LocatedWith.ToUpper().Trim())
                {
                    case "REGISTRY":
                        LocatedWith = temp.GetTempValue("FNAME") + " " + temp.GetTempValue("LNAME");
                        break;
                    //case "UFTREGISTRY":
                    //    RegistryKey UFTRegKey;
                    //    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    //    PriInsured = UFTRegKey.GetValue("PRIMARY_INSURED").ToString();
                    //    break;
                    default:
                        LocatedWith = LocatedWith;
                        break;
                }
                string value = temp1[1];
                string Deductiable = temp1[2];
                string JeweleryItemsDescription = temp1[3];
                string Appraisal = temp1[4];
                string Alarm = temp1[5];
                string Location = temp1[6];
                //     PCItemPage.VerifyAlarm(Alarm);
                PCItemPage.verifyItemDetails(LocatedWith, value, Deductiable, JeweleryItemsDescription, Appraisal, Alarm, Location, Itemcounter);
                Itemcounter = Itemcounter + 1;
            }




        }



        [Then(@"I Verify contact details")]
        public void ThenIVerifyContactDetails(Table table)
        {
            Contacts AccountContacts = new Contacts(getDriver());
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string Name = temp[0];
                string Role = temp[1];
                string Phone = temp[2];
                string Email = temp[3];
                AccountContacts.verifyContactDetails(Name, Role, Phone, Email, Itemcounter);
                Itemcounter = Itemcounter + 1;
                Console.WriteLine("Counter Value is " + Itemcounter);
            }
        }

        [Then(@"I Verify location details")]
        public void ThenIVerifyLocationDetails(Table table)
        {
            Locations AccountLocations = new Locations(getDriver());
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string Active = temp[0];
                string Loc = temp[1];
                string AddreeType = temp[2];
                string Address = temp[3];
                AccountLocations.verifyLocationDetails(Active, Loc, AddreeType, Address, Itemcounter);
                Itemcounter = Itemcounter + 1;
                Console.WriteLine("Counter Value is " + Itemcounter);
            }
        }


        [Then(@"I verify Current Activities")]
        public void ThenIVerifyCurrentActivities(Table table)
        {
            PCDetails PCObj = new PCDetails(getDriver());
            int Itemcounter = 1;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string Subject = temp[0];
                PCObj.VerifyCurrentActivities(Subject, Itemcounter);
                Itemcounter = Itemcounter + 1;
                Console.WriteLine("Counter Value is " + Itemcounter);
            }

        }

        [When(@"I Start Policy Chnage with (.*) and (.*)")]
        public void WhenIStartPolicyChnageWithAnd(string EffectiveDate, string ChangeReason)
        {
            PolicyChange PCChanges = new PolicyChange(base.getDriver());
            DataStorage temp = new DataStorage();
            switch (EffectiveDate.ToUpper().Trim())
            {
                case "REGISTRY":
                    EffectiveDate = temp.GetTempValue("EFFDATE");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    EffectiveDate = UFTRegKey.GetValue("EFFDATE").ToString();
                    break;
                default:

                    break;
            }
            PCChanges.updatePOlicyCHange(EffectiveDate, ChangeReason);
        }

        [Then(@"I search documents by selecting (.*) , (.*) , (.*)  in document page of Policy Center")]
        [When(@"I search documents by selecting (.*) , (.*) , (.*)  in document page of Policy Center")]
        public void WhenISearchDocumentsBySelectingInDocumentPageOfPolicyCenter(string DocumentTypeName, string FromDate, string Todate)
        {
            PolicyDocuments PLDocuments = new PolicyDocuments(base.getDriver());
            PLDocuments.DocumentSearch(DocumentTypeName, FromDate, Todate);

        }

        [Then(@"I Verify if documents are (.*) in document page of Policy center")]
        public void ThenIVerifyIfDocumentsAreInDocumentPageOfPolicyCenter(int Documentsavailable)
        {
            PolicyDocuments PLDocuments = new PolicyDocuments(base.getDriver());
            PLDocuments.VerifyDocuments(Documentsavailable);
        }

        [When(@"I Click Next on Quote Page")]
        public void WhenIClickNextOnQuotePage()
        {
            CL_Quote clQuote = new CL_Quote(getDriver());

            clQuote.ClickQuoteNextButton();
        }

        [When(@"I visit a location in Business owners page")]
        public void WhenIVisitALocationInBusinessOwnersPage()
        {
            CL_BOLocations clBOLocations = new CL_BOLocations(getDriver());
            clBOLocations.VisitBOLocation();
            clBOLocations.BOLOcationsNext();
        }

        [When(@"I Click on Clear button to close all validation messages")]
        public void WhenIClickOnClearButtonToCloseAllValidationMessages()
        {
            HomePage PCHomePage = new HomePage(getDriver());
            PCHomePage.ClickClearButton();
        }


        [When(@"I Update Reinsurance logic")]
        public void WhenIUpdateReinsuranceLogic()
        {
            CLReinsurancePage ReinsurancePage = new CLReinsurancePage(getDriver());
            ReinsurancePage.ManageClReinsurance();

        }


        [When(@"I Click on Reinsurance link on left navigation bar")]
        public void WhenIClickOnReinsuranceLinkOnLeftNavigationBar()
        {
            HomePage PCHomePage = new HomePage(getDriver());
            PCHomePage.selectLeftNavMenu("reinsurance");
        }


        [When(@"I Click on Busness owners link on left navigation bar")]
        public void WhenIClickOnBusnessOwnersLinkOnLeftNavigationBar()
        {
            HomePage PCHomePage = new HomePage(getDriver());
            PCHomePage.selectLeftNavMenu("businessowners");
        }

        [When(@"I verify forms listed on Forms Page and click next")]
        public void WhenIVerifyFormsListedOnFormsPageAndClickNext()
        {
            CL_Forms clForms = new CL_Forms(getDriver());
            clForms.VerifyFormsList();
            clForms.ClickNextOnFormsPage();
        }
        [When(@"I select (.*) and (.*) on Payment Page")]
        public void WhenISelectDirectBillAndPayOnPaymentPage(string billingMethod, string InstallmentPlan)
        {
            CL_Payment clPayment = new CL_Payment(getDriver());
            clPayment.SelectBillingMethod(billingMethod);
            clPayment.SelectInstallmentPlan(InstallmentPlan);
        }

        [Given(@"I start Cancel policy on Prorata basis with below details")]
        [When(@"I start Cancel policy on Prorata basis with below details")]
        public void WhenIStartCancelPolicyOnProrataBasisWithBelowDetails(Table table)
        {
            string sSource = table.Rows[0]["Source"];
            string sReason = table.Rows[0]["Reason"];
            string sReasonMethod = table.Rows[0]["ReasonMethod"];
            string sCancelEffDt = table.Rows[0]["CancelEffDate"];
            PolicyStartCancel clPolicyStartCancel = new PolicyStartCancel(getDriver());
            clPolicyStartCancel.EnterPolicyCancelDetails(sSource, sReason, sReasonMethod, sCancelEffDt);
            clPolicyStartCancel.ClickStartCancellation();
        }

        [When(@"I Cancel PL Policy")]
        public void WhenICancelPLPolicy()
        {
            PolicyCancel plPolicyCancel = new PolicyCancel(getDriver());
            plPolicyCancel.PLPolicyCancel();
        }



        [Given(@"I Cancel Policy")]
        [When(@"I Cancel Policy")]
        public void WhenICancelPolicy()
        {
            PolicyCancel clPolicyCancel = new PolicyCancel(getDriver());
            clPolicyCancel.CLPolicyCancel();
        }
        [Given(@"I select cancelled policy")]
        [When(@"I select cancelled policy")]
        public void WhenISelectCancelledPolicy()
        {
            PCSubmissionBound cl_SubmissionBound = new PCSubmissionBound(getDriver());
            cl_SubmissionBound.ClickIssuedPolicy();
        }

        [Given(@"I select (.*) to start policy reinstatement")]
        [When(@"I select (.*) to start policy reinstatement")]
        public void WhenISelectToStartPolicyReinstatement(string ReinstateReason)
        {
            PolicyStartReinstatement PolicyReinstate = new PolicyStartReinstatement(getDriver());
            PolicyReinstate.EnterReinstatementDetails(ReinstateReason);
            //PolicyReinstate.ClickNext();
        }

        [Given(@"I Click next on Start Reinstatement page")]
        [When(@"I Click next on Start Reinstatement page")]
        public void WhenIClickNextOnStartReinstatementPage()
        {
            PolicyStartReinstatement PolicyReinstate = new PolicyStartReinstatement(getDriver());
            PolicyReinstate.ClickNext();
        }
        [Given(@"I click Quote on Risk Analysis Page")]
        [When(@"I click Quote on Risk Analysis Page")]
        public void WhenIClickQuoteOnRiskAnalysisPage()
        {
            PolicyStartReinstatement PolicyReinstate = new PolicyStartReinstatement(getDriver());
            PolicyReinstate.ClickQuote();
        }
        [Given(@"I Reinstate Cancelled Policy")]
        [When(@"I Reinstate Cancelled Policy")]
        [Then(@"I Reinstate Cancelled Policy")]
        public void ThenIReinstateCancelledPolicy()
        {
            PolicyStartReinstatement PolicyReinstate = new PolicyStartReinstatement(getDriver());
            PolicyReinstate.ClickReinstate();
        }
        [Given(@"I select Reinstated policy")]
        [When(@"I select Reinstated policy")]
        public void WhenISelectReinstatedPolicy()
        {
            PCSubmissionBound cl_SubmissionBound = new PCSubmissionBound(getDriver());
            cl_SubmissionBound.ClickIssuedPolicy();
        }
        [Given(@"I Enter below details for temporary Tradeshows policy change")]
        [When(@"I Enter below details for temporary Tradeshows policy change")]
        public void WhenIEnterBelowDetailsForTemporaryTradeshowsPolicyChange(Table table)
        {
            //string sChangeEffectiveDate = table.Rows[0]["ChangeEffectiveDate"];
            //string sChangeReason = table.Rows[0]["ChangeReason"];
            //string sChangeReasonNext = table.Rows[0]["ChangeReasonNext"];
            //string sChangeReasonCategory = table.Rows[0]["ChangeReasonCategory"];
            //string sTradeshow_Type = table.Rows[0]["Tradeshow_Type"];
            //string sLimit = table.Rows[0]["Limit"];
            //string sDeductible = table.Rows[0]["Deductible"];
            //string sShowName_City_State = "";
            //string sTradeshow_State = "";
            //string sHowMerch_Transported = "";
            //string sTransit_Days = "";
            //string sRecurring = "";
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            //CL_TempChangeTradeshows.ClickNext();

            //CL_TempChangeTradeshows.TempChangeTradeshow_JBP(sChangeReason, sChangeReasonNext, sChangeReasonCategory, sTradeshow_Type, sLimit, sDeductible, sShowName_City_State, sTradeshow_State, sHowMerch_Transported, sTransit_Days, sRecurring);
            CL_TempChangeTradeshows.TempChangeTradeshow_JBP(table);

        }
        [Given(@"I click on Indland Marine Line Link")]
        [When(@"I click on Indland Marine Line Link")]
        public void WhenIClickOnIndlandMarineLineLink()
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            CL_TempChangeTradeshows.ClickILMLink();
        }

        [When(@"I Click on Off Premise Coverages tab on ILM Page")]
        [Given(@"I Click on Off Premise Coverages tab on ILM Page")]
        public void GivenIClickOnOffPremiseCoveragesTabOnILMPage()
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            CL_TempChangeTradeshows.ClickOffPremiseCoveragesTab();
        }
        [When(@"I add new coverage with below details")]
        [Given(@"I add new coverage with below details")]
        public void GivenIAddNewCoverageWithBelowDetails(Table table)
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            CL_TempChangeTradeshows.AddTradeshowCoverage(table);
        }

        [When(@"I Click Next button on all the pages")]
        [Given(@"I Click Next button on all the pages")]
        public void GivenIClickNextButtonOnAllThePagesUntil()
        {
            PolicyChange ClickNextBtn = new PolicyChange(getDriver());
            ClickNextBtn.ClickAllNextButtons();
        }
        [When(@"I click Quote on PolicyReview Page")]
        [Given(@"I click Quote on PolicyReview Page")]
        public void GivenIClickQuoteOnPolicyReviewPage()
        {
            PolicyChange ClickQuoteBtn = new PolicyChange(getDriver());
            ClickQuoteBtn.ClickQuote();
        }
        [Given(@"I Issue Changed CL policy")]
        [When(@"I Issue Changed CL policy")]
        public void WhenIIssueChangedCLPolicy()
        {
            PolicyChange IssuePolicyChange = new PolicyChange(getDriver());
            IssuePolicyChange.IssueCLPolicyChange();
        }
        [Given(@"I Withdraw Work Order for Changed CL policy")]
        [When(@"I Withdraw Work Order for Changed CL policy")]
        public void WhenIWithdrawWorkOrderForChangedCLPolicy()
        {
            PolicyChange IssuePolicyChange = new PolicyChange(getDriver());
            IssuePolicyChange.WithDraworkOder();
        }

        [Given(@"I verify policy change Bound")]
        [When(@"I verify policy change Bound")]
        public void WhenIVerifyPolicyChangeBound()
        {
            PolicyChange VerifyPolicyChange = new PolicyChange(getDriver());
            VerifyPolicyChange.VerifyCLPolicyChange();
        }

        [Given(@"I verify policy Cancel Scheduled")]
        [When(@"I verify policy Cancel Scheduled")]
        public void GivenIVerifyPolicyCancelScheduled()
        {
            PolicyChange VerifyPolicyChange = new PolicyChange(getDriver());
            VerifyPolicyChange.VerifyCLPolicyCancelSchedule();
        }


        //[When(@"I enter below additional coverage for location (.*) on Inventry page")]
        //public void WhenIEnterBelowAdditionalCoverageForLocationOnInventryPage(int iLocationNum)
        //{
        //    CL_JewelryStock clJewelryStock = new CL_JewelryStock(getDriver());

        //}
        [When(@"I enter below StockPeak additional coverages on inverntry page")]
        public void WhenIEnterBelowStockPeakAdditionalCoveragesOnInverntryPage(Table table)
        {
            CL_JewelryStock clILMLocAddlCovg = new CL_JewelryStock(getDriver());
            clILMLocAddlCovg.AddStockPeakCovg(table);
        }
        [When(@"I click next on ILM Line page")]
        public void WhenIClickNextOnILMLinePage()
        {
            CL_InlandMarineLine clILM = new CL_InlandMarineLine(getDriver());
            clILM.ClickNextButton();
        }

        [When(@"I click Quote and Issue Rewrite Fullterm CL policy")]
        public void WhenIClickQuoteAndIssueRewriteFulltermCLPolicy()
        {
            PolicyRewriteFullTerm IssueRewritePolicy = new PolicyRewriteFullTerm(getDriver());
            IssueRewritePolicy.ClickQuote();
            IssueRewritePolicy.IssuePolicy();
        }

        [When(@"I Issue the policy for Rewrite")]
        public void WhenIIssueThePolicyForRewrite()
        {
            //PL_Quote plQuote = new PL_Quote(getDriver());
            //plQuote.PLIssuePolicyRewrite();

            PolicyChange plRewriteQuote = new PolicyChange(getDriver());
            plRewriteQuote.PLIssuePolicyRewrite();
        }

        [Given(@"I Enter below details for Stock Peak policy change")]
        [When(@"I Enter below details for Stock Peak policy change")]
        public void WhenIEnterBelowDetailsForStockPeakPolicyChange(Table table)
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.PermChangeStockPeak_JBP(table);
        }
        [Given(@"I select bound policy")]
        [When(@"I select bound policy")]
        public void GivenISelectBoundPolicy()
        {
            PCSubmissionBound cl_SubmissionBound = new PCSubmissionBound(getDriver());
            cl_SubmissionBound.ClickIssuedPolicy();
        }
        [Given(@"I Enter below details for Stock AOP policy change")]
        [When(@"I Enter below details for Stock AOP policy change")]
        public void WhenIEnterBelowDetailsForStockAOPPolicyChange(Table table)
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.PermChangeStockAOP_JBP(table);
        }
        [Given(@"I Enter below details for Add AI policy change")]
        [When(@"I Enter below details for Add AI policy change")]
        public void GivenIEnterBelowDetailsForAddAIPolicyChange(Table table)
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.PermChangeAddAI_JBP(table);
            CL_TempChangeTradeshows.NavigatetoBOLocs();
            CL_TempChangeTradeshows.PermChangeAddAI_BOP(table);
        }
        [Given(@"I Enter below details for deleting AI policy change")]
        [When(@"I Enter below details for deleting AI policy change")]
        public void GivenIEnterBelowDetailsForDeletingAIPolicyChange(Table table)
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.PermChangeDeleteAI_JBP(table);
        }
        [Given(@"I Enter below details for Tradeshows policy change")]
        [When(@"I Enter below details for Tradeshows policy change")]
        public void GivenIEnterBelowDetailsForTradeshowsPolicyChange(Table table)
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_TempChangeTradeshows.PermChangeTradeshow_JBP(table);
        }

        [Given(@"I rescind policy")]
        [When(@"I rescind policy")]
        public void GivenIRescindPolicy()
        {
            PolicyChange CL_RescindPolicy = new PolicyChange(getDriver());
            CL_RescindPolicy.RescindPolicy();
        }

        [Given(@"I verify Policy Rescind")]
        [When(@"I verify Policy Rescind")]
        public void GivenIVerifyPolicyRescind()
        {
            PolicyChange CL_RescindPolicy = new PolicyChange(getDriver());
            CL_RescindPolicy.VerifyCLPolicyRescind();
        }


        [When(@"I Click on Renew Next button  on all the pages")]
        public void WhenIClickOnRenewNextButtonOnAllThePages()
        {
            PolicyChange ClickNextBtn = new PolicyChange(getDriver());
            ClickNextBtn.ClickRenewalNextButton();
        }


        [Then(@"I click RenewQuote on PolicyReview Page")]
        [When(@"I click RenewQuote on PolicyReview Page")]
        public void WhenIClickRenewQuoteOnPolicyReviewPage()
        {
            PolicyChange ClickQuoteBtn = new PolicyChange(getDriver());
            ClickQuoteBtn.ClickRevewiQuote();
        }

        [When(@"I Issue Changed PL policy")]
        public void WhenIIssueChangedPLPolicy()
        {
            PolicyChange IssuePolicyChange = new PolicyChange(getDriver());
            IssuePolicyChange.IssuePLPolicyChange();
        }

        [When(@"I Renew PL policy")]
        public void WhenIRenewPLPolicy()
        {
            PolicyRenew PolicyRenew = new PolicyRenew(getDriver());
            PolicyRenew.IssuePLPolicyRenew();
        }

        [When(@"I set Renew code for Pl policy")]
        public void WhenISetRenewCodeForPlPolicy(Table table)
        {
            PolicyRenew PolicyRenew = new PolicyRenew(getDriver());
            PolicyRenew.SetRenewCode(table.Rows[0]["RenewCode"]);

        }

        [When(@"I Verify policy renew bound")]
        [Then(@"I Verify policy renew bound")]
        [Given(@"I Verify policy renew bound")]
        public void WhenIVerifyPolicyRenewBound()
        {
            PolicyRenew VerifyPolicyRenew = new PolicyRenew(getDriver());
            VerifyPolicyRenew.VerifyPolicyRenew();
        }

        [When(@"I verify all existing locations for validation messages for NewYork State")]
        public void WhenIVerifyAllExistingLocationsForValidationMessagesForNewYorkState()
        {
            CL_BOBuildings clBOBuildings = new CL_BOBuildings(getDriver());

            clBOBuildings.VerifyBOLocSegmentationCode_NewYork();
        }

        [When(@"I enter below ILM location details for New York State")]
        public void WhenIEnterBelowILMLocationDetailsForNewYorkState(Table table)
        {
            string segmentationCode = table.Rows[0]["segmentationCode"];
            string GeneralInformation = table.Rows[0]["GeneralInformation"];
            string FTEmployees = table.Rows[0]["FTEmployees"];
            string PTEmployees = table.Rows[0]["PTEmployees"];
            string PublicProtection = table.Rows[0]["PublicProtection"];
            string LocationType = table.Rows[0]["LocationType"];
            string ConstructionType = table.Rows[0]["ConstructionType"];
            string TotalBuildingArea = table.Rows[0]["TotalBuildingArea"];
            string AreaOccupied = table.Rows[0]["AreaOccupied"];
            string PercentSplinkered = table.Rows[0]["PercentSplinkered"];
            string SharedPremises = table.Rows[0]["SharedPremises"];
            string BurglarAlarm = string.Empty;
            string TotalLocationInSafe = string.Empty;
            CL_LocationDetails clLocationDetails = new CL_LocationDetails(getDriver());
            clLocationDetails.EnterLocationDetailsNewYork(segmentationCode, GeneralInformation, FTEmployees, PTEmployees, PublicProtection, LocationType, ConstructionType, TotalBuildingArea, AreaOccupied, PercentSplinkered, SharedPremises);
        }
        [Given(@"I enter below security information details for location for New York State")]
        [When(@"I enter below security information details for location for New York State")]
        public void WhenIEnterBelowSecurityInformationDetailsForLocationForNewYorkState(Table table)
        {
            CL_LocationSecurityInformation clSecurityInfo = new CL_LocationSecurityInformation(getDriver());

            clSecurityInfo.EnterSecurityInfoNewYork(table.Rows[0]["BurglarAlarm"]);
        }
        [Given(@"I Navigate through ILM Line and all its Locations")]
        [When(@"I Navigate through ILM Line and all its Locations")]
        public void WhenINavigateThroughILMLineAndAllItsLocations()
        {
            HomePage PCHomePage = new HomePage(getDriver());
            PCHomePage.NavigateAll_ILM_Pages();
        }
        [Given(@"I Navigate through BOP Line and all its Locations and Buildings")]
        [When(@"I Navigate through BOP Line and all its Locations and Buildings")]
        public void WhenINavigateThroughBOPLineAndAllItsLocationsAndBuildings()
        {
            HomePage PCHomePage = new HomePage(getDriver());
            PCHomePage.NavigateAll_BO_Pages();
        }

        [When(@"I remove Tradeshow coverage on ILM Line")]
        public void WhenIRemoveTradeshowCoverageOnILMLine()
        {
            PolicyChange CL_RemoveTradeshows = new PolicyChange(getDriver());
            CL_RemoveTradeshows.removeTradeshow();
        }

        [When(@"I Inactivate AI for below location")]
        public void WhenIInactivateAIForBelowLocation(Table table)
        {
            PolicyChange InactivateAIOnLoc = new PolicyChange(getDriver());
            InactivateAIOnLoc.InactiveAIOnLocation(table);
        }

        [When(@"I enter (.*) for all questions on qualification page for Policy Transactions")]
        public void WhenIEnterNoForAllQuestionsOnQualificationPageForPolicyTransactions(string radioOption)
        {
            CL_Qualification qualificationPage = new CL_Qualification(getDriver());

            qualificationPage.Transct_selectQualitifications(radioOption);
        }
        [When(@"I click next on current Page")]
        public void WhenIClickNextOnCurrentPage()
        {
            PolicyChange ClCurentPage = new PolicyChange(getDriver());
            ClCurentPage.ClickNextButton();
        }

        [When(@"I Issue Rewrite New term CL policy")]
        public void WhenIIssueRewriteNewTermCLPolicy()
        {
            PolicyRewriteFullTerm IssueRewritePolicy = new PolicyRewriteFullTerm(getDriver());
            IssueRewritePolicy.issueRewriteNewterm();
        }


        [Given(@"I verify policy Cancel")]
        [When(@"I verify policy Cancel")]
        public void WhenIVerifyPolicyCancel()
        {
            PolicyChange VerifyPolicyChange = new PolicyChange(getDriver());
            VerifyPolicyChange.VerifyCLPolicyCancel();
        }

        [When(@"I verify all existing locations for validation messages with state segmentation code")]
        public void WhenIVerifyAllExistingLocationsForValidationMessagesWithStateSegmentationCode()
        {
            CL_BOBuildings clBOBuildings = new CL_BOBuildings(getDriver());

            clBOBuildings.VerifyBOLocSegmentationCode_NoSegCode();
        }

        [When(@"I Add Employee Dishonesty coverage with below details")]
        public void WhenIAddEmployeeDishonestyCoverageWithBelowDetails(Table table)
        {
            PolicyRewriteFullTerm AddILMCoverage = new PolicyRewriteFullTerm(getDriver());
            AddILMCoverage.RewriteRemainderAddILMEmpDisHon(table);
        }

        [When(@"I remove Location number (.*) on ILM Locations")]
        public void WhenIRemoveLocationNumberOnILMLocations(int locationNumber)
        {
            PolicyRewriteFullTerm clILMremoveLocs = new PolicyRewriteFullTerm(getDriver());
            clILMremoveLocs.DeleteILMLocations(locationNumber);
        }

        [When(@"I change StockAOP and Stock Peak with below details on ILM locations")]
        public void WhenIChangeStockAOPAndStockPeakWithBelowDetailsOnILMLocations(Table table)
        {
            PolicyRewriteFullTerm ChangeStockAOP = new PolicyRewriteFullTerm(getDriver());
            ChangeStockAOP.UpdateStockAOPLimit_StockPeak(table);
        }

        [When(@"I Add AI with below details on ILM and BO Locations")]
        public void WhenIAddAIWithBelowDetailsOnILMAndBOLocations(Table table)
        {
            PolicyRewriteFullTerm AddAIILM_BO = new PolicyRewriteFullTerm(getDriver());
            AddAIILM_BO.AddAIonILMBOLocs(table);

        }

        [When(@"I add (.*) new BO Location with below details")]
        public void WhenIAddNewBOLocationWithBelowDetails(int p0, Table table)
        {
            PolicyRewriteFullTerm AddNewBO_Loc = new PolicyRewriteFullTerm(getDriver());
            AddNewBO_Loc.AddNewBOLocs(table);
        }

        [When(@"I add new buildings with below details")]
        public void WhenIAddNewBuildingsWithBelowDetails(Table table)
        {
            PolicyRewriteFullTerm AddNewBO_LocBldg = new PolicyRewriteFullTerm(getDriver());
            AddNewBO_LocBldg.AddBOLocBldgs(table);
        }

        [When(@"I enter (.*) , (.*) , (.*) for questions on qualification page for Rewrite")]
        public void WhenIEnterForQuestionsOnQualificationPageForRewrite(string professionalAthelete, string previousLoss, string convictedOfCrime)
        {
            PolicyChange plQualificationChange = new PolicyChange(getDriver());

            plQualificationChange.selectQualitificationsRetrieve(professionalAthelete, previousLoss, convictedOfCrime);
        }

        [When(@"I enter below PL Policy Info Details for Rewrite Process")]
        public void WhenIEnterBelowPLPolicyInfoDetailsForRewriteProcess(Table table)
        {
            string policyTermType = table.Rows[0]["Term"];
            string policyEffDt = table.Rows[0]["PolicyEffDate"];
            string PolicyProducerCode = table.Rows[0]["ProducerCode"];
            PL_PolicyInfo plPolicyInfo = new PL_PolicyInfo(getDriver());
            plPolicyInfo.EnterPolicyInfoDetailsforRewrite(policyTermType, policyEffDt, PolicyProducerCode);
            plPolicyInfo.EnterPolicyInfo();
        }


        [When(@"I Update Multi Jewelry items with Deatils")]
        public void WhenIUpdateMultiJewelryItemsWithDeatils(Table table)
        {
            var dictionoary = new Dictionary<string, string>();
            PL_JewelryItems plJewelryItems = new PL_JewelryItems(getDriver());
            PLPChange_JewelryItems plJewelryItemsupdate = new PLPChange_JewelryItems(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string JewelryLocatedWith = table.Rows[Itemcounter]["LocatedWith"];
                string WearerFirstName = table.Rows[Itemcounter]["FirstName"];
                string WearerLastName = table.Rows[Itemcounter]["LastName"];
                string WearerAddressLine1 = table.Rows[Itemcounter]["AddressLine1"];
                string WearerCity = table.Rows[Itemcounter]["City"];
                string WearerState = table.Rows[Itemcounter]["State"];
                string WearerZipCode = table.Rows[Itemcounter]["ZipCode"];
                string JewelryClass = table.Rows[Itemcounter]["Class"];
                string JewelryValueOfItem = table.Rows[Itemcounter]["ValueOfItem"];
                string JewelryDeductible = table.Rows[Itemcounter]["Deductible"];
                string JewelryAppraisalReceived = table.Rows[Itemcounter]["AppraisalReceived"];
                string JewelryAppraisalDate = table.Rows[Itemcounter]["AppraisalDate"];
                string JewelryBrand = table.Rows[Itemcounter]["Brand"];
                string JewelryItemStored = table.Rows[Itemcounter]["ItemStored"];
                string JewelryStyle = table.Rows[Itemcounter]["Style"];


                Console.WriteLine("item counter is " + Itemcounter);
                plJewelryItemsupdate.UpdateMultiJewelryItemDetails(JewelryLocatedWith, WearerFirstName, WearerLastName, WearerAddressLine1, WearerCity, WearerState, WearerZipCode, JewelryClass, JewelryValueOfItem, JewelryDeductible, JewelryAppraisalReceived, JewelryAppraisalDate, JewelryBrand, JewelryStyle, JewelryItemStored, Itemcounter + 1);
                Itemcounter = Itemcounter + 1;
            }
            plJewelryItemsupdate.clckNextButtonRewrite();


            //plJewelryItems.ClickNextButton();
        }

        [When(@"In Risk Analysis page I update convications details on the Risk Analysis section")]
        public void WhenInRiskAnalysisPageIUpdateConvicationsDetailsOnTheRiskAnalysisSection(Table table)
        {
            PL_RiskAnalysis plRiskAnalysis = new PL_RiskAnalysis(getDriver());
            plRiskAnalysis.UpdateConvictionDetails(table.Rows[0]["ConvictedFelony"], table.Rows[0]["ConvictedMisdemeanor"]);
        }


        [When(@"In Risk Analysis page I update Sentence Completion Details")]
        public void WhenInRiskAnalysisPageIUpdateSentenceCompletionDetails(Table table)
        {
            PL_RiskAnalysis plRiskAnalysis = new PL_RiskAnalysis(getDriver());
            int Itemcounter = 0;
            foreach (var row in table.Rows)
            {
                var temp = row.Values.ToList();
                string SentenceCompilationDate = temp[0];
                string ConvictionType = temp[1];
                string OtherConvictionType = temp[2];
                plRiskAnalysis.UpdateSentenceCompilationDetails(SentenceCompilationDate, ConvictionType, OtherConvictionType, Itemcounter);
                Itemcounter = Itemcounter + 1;
                Console.WriteLine("Counter Value is " + Itemcounter);
            }


        }


        [When(@"I click Quote on PolicyReview Page for PL Rewrite")]
        [Given(@"I click Quote on PolicyReview Page for PL Rewrite")]
        public void WhenIClickQuoteOnPolicyReviewPageForPLRewrite()
        {
            PolicyChange ClickQuoteBtn = new PolicyChange(getDriver());
            ClickQuoteBtn.ClickQuoteRewrite();
        }




        [When(@"I Issue the policy for Rewrite Fullterm")]
        public void WhenIIssueThePolicyForRewriteFullterm()
        {
            PolicyChange IssuePolicyChange = new PolicyChange(getDriver());
            IssuePolicyChange.issuePolicyTransaction("Rewrite Fullterm");

        }




        [When(@"search for Policy with (.*) and select from search results in Policy Center")]
        public void SearchForPolicyWithAndSelectFromSearchResultsInPolicyCenter(string policyNumber)
        {
            DataStorage temp = new DataStorage();

            string policyNum = null;
            switch (policyNumber.ToUpper().Trim())
            {
                case "REGISTRY":
                    policyNum = temp.GetTempValue("PLCYNO");
                    break;
                case "UFTREGISTRY":
                    RegistryKey UFTRegKey;
                    UFTRegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AutomationQTP\Guidewire");
                    policyNum = UFTRegKey.GetValue("PLCYNO").ToString();
                    break;
                default:
                    policyNum = policyNumber;
                    break;
            }

            SearchAccounts searchAccounts = new SearchAccounts(getDriver());

            searchAccounts.SearchPolicy(policyNum);
            searchAccounts.SelectPolicy();
        }

        [When(@"I verify (.*) in Work Orders page")]
        [Then(@"I verify (.*) in Work Orders page")]
        public void IVerifyInWorkOrdersPage(string ExpectedWorkOrderStatus)
        {
            WorkOrder WorkOrderPage = new WorkOrder(getDriver());
            WorkOrderPage.VerifyWorkOrderStatus(ExpectedWorkOrderStatus);
        }


        [When(@"I Add below HotelMotel Coverage on ILM Line")]
        public void WhenIAddBelowHotelMotelCoverageOnILMLine(Table table)
        {
            PolicyRenew AddHotelCovg = new PolicyRenew(getDriver());
            AddHotelCovg.AddHotelMotelCoverage_ILM(table);
        }

        [When(@"I enter below Policy Info Details for policy renewal")]
        public void WhenIEnterBelowPolicyInfoDetailsForPolicyRenewal(Table table)
        {
            PolicyRenew AddPolicyInfo = new PolicyRenew(getDriver());
            AddPolicyInfo.AddPolicyInfo(table);
        }

        [When(@"I add below ShowCases Windows coverage with below details")]
        public void WhenIAddBelowShowCasesWindowsCoverageWithBelowDetails(Table table)
        {
            PolicyRenew AddTradeShowcases = new PolicyRenew(getDriver());
            AddTradeShowcases.AddTradeShowcasesCovg(table);
        }
        [When(@"I add Stock Peak with below details for Policy Renewal")]
        public void WhenIAddStockPeakWithBelowDetailsForPolicyRenewal(Table table)
        {
            PolicyRenew AddStockpeak = new PolicyRenew(getDriver());
            AddStockpeak.AddStockPeak(table);
        }

        [When(@"I add new ILM location with below details")]
        public void WhenIAddNewILMLocationWithBelowDetails(Table table)
        {
            PolicyRenew AddILMLoc = new PolicyRenew(getDriver());
            AddILMLoc.AddILMLocation(table);
        }
        [When(@"I remove UMB line of Business")]
        public void WhenIRemoveUMBLineOfBusiness()
        {
            PolicyRenew DeleteUMB = new PolicyRenew(getDriver());
            DeleteUMB.RemoveUMB();
        }

        [When(@"I Enter below details policy change and Add ILM Location")]
        public void WhenIEnterBelowDetailsPolicyChangeAndAddILMLocation(Table table)
        {
            PolicyChange CL_AddILMLoc = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddILMLoc.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddILMLoc.permChng_AddILMLoc(table);
        }

        [When(@"I Enter below details policy change and Delete ILM Location")]
        public void WhenIEnterBelowDetailsPolicyChangeAndDeleteILMLocation(Table table)
        {
            PolicyChange CL_AddILMLoc = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddILMLoc.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddILMLoc.permChng_DeleteILMLoc(table);
        }



        [When(@"I add (.*) new BO Location with below details for NewYork state")]
        public void WhenIAddNewBOLocationWithBelowDetailsForNewYorkState(int p0, Table table)
        {
            PolicyRewriteFullTerm AddNewBO_Loc = new PolicyRewriteFullTerm(getDriver());
            AddNewBO_Loc.AddNewBOLocsNewyork(table);
        }

        [When(@"I set loc num (.*) as primary by removing Loc num (.*) and it's (.*) Building")]
        public void WhenISetLocNumAsPrimaryByRemovingLocNumAndItSBuilding(int PrimaryLoc, int locationNum, int LocBuildings)
        {
            PolicyRewriteFullTerm CL_DeleteBOLoc = new PolicyRewriteFullTerm(getDriver());
            CL_DeleteBOLoc.DeleteBOLocBld(PrimaryLoc, locationNum, LocBuildings);
        }

        [When(@"I enter below details for Policy change OOS for (.*)")]
        public void WhenIEnterBelowDetailsForPolicyChangeOOSFor(string ChangeEffectiveDate, Table table)
        {
            PolicyChange CL_AddILMLoc = new PolicyChange(getDriver());
            Console.WriteLine(ChangeEffectiveDate);
            CL_AddILMLoc.ChangeEffectiveDate(ChangeEffectiveDate);
            CL_AddILMLoc.TempEndorse_OOSPlcyChange(table);
        }

        [When(@"I Click on Temp Coverages tab on ILM Page")]
        public void WhenIClickOnTempCoveragesTabOnILMPage()
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            CL_TempChangeTradeshows.ClickTempCoveragesTab();
        }
        [When(@"I add below Temp Coverages")]
        public void WhenIAddBelowTempCoverages(Table table)
        {
            PolicyChange CL_TempChangeTradeshows = new PolicyChange(getDriver());
            CL_TempChangeTradeshows.AddILMTempCoverages(table);
        }

        [When(@"I enter below ILM Blanket details on ILM Line page")]
        public void WhenIEnterBelowILMBlanketDetailsOnILMLinePage(Table table)
        {
            CL_InlandMarineLine clILM = new CL_InlandMarineLine(getDriver());
            clILM.AddILMBlankets(table);
        }

        [When(@"I Enter BPP Coverages Details with Building Coverage")]
        public void WhenIEnterBPPCoveragesDetailsWithBuildingCoverage()
        {
            CL_BOBuildings_BPPCoverages bppCoverages = new CL_BOBuildings_BPPCoverages(getDriver());

            bppCoverages.EnterBPPCoveragesWithBldCovg();
        }

        [When(@"I add a Blanket with Below details")]
        public void WhenIAddABlanketWithBelowDetails(Table table)
        {
            CL_BOBlankets clBoBlankets = new CL_BOBlankets(getDriver());

            clBoBlankets.BOAddBlanket(table);
        }

        [When(@"I Issue the CL policy for blankets")]
        public void WhenIIssueTheCLPolicyForBlankets()
        {
            CL_Quote clQuote = new CL_Quote(getDriver());
            clQuote.IssuePolicy_Blankets();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }
        [When(@"I Enter Add Building Coverage for locationNumber (.*)")]
        public void WhenIEnterAddBuildingCoverageForLocationNumber(string locNum)
        {
            PolicyRenew AddBldCovg = new PolicyRenew(getDriver());
            AddBldCovg.AddBldgCovg(locNum);
        }
        [When(@"I add a Blanket with Below details for policy Renewal")]
        public void WhenIAddABlanketWithBelowDetailsForPolicyRenewal(Table table)
        {
            PolicyRenew AddBlanket = new PolicyRenew(getDriver());
            AddBlanket.Renew_BOAddBlanket(table);
        }

        [When(@"I enter below ILM Blanket details on ILM Line page for Policy Renewal")]
        public void WhenIEnterBelowILMBlanketDetailsOnILMLinePageForPolicyRenewal(Table table)
        {
            PolicyRenew AddILMBlanket = new PolicyRenew(getDriver());
            AddILMBlanket.Renew_AddILMBlankets(table);
        }

        [When(@"I Quote and Issue Renewed CL policy")]
        public void WhenIQuoteAndIssueRenewedCLPolicy()
        {
            PolicyRenew issuePolicyRenew = new PolicyRenew(getDriver());
            issuePolicyRenew.issueCLRenewPolicy();
        }

        [When(@"I change below line itmes for policy transaction")]
        public void WhenIChangeBelowLineItmesForPolicyTransaction(Table table)
        {
            PolicyRenew LineSelection = new PolicyRenew(getDriver());
            string slineItems = table.Rows[0]["LineItems"];
            LineSelection.SelectLines_Renewal(slineItems);
        }

        [When(@"I enter below new Address details for ILM Location")]
        public void WhenIEnterBelowNewAddressDetailsForILMLocation(Table table)
        {
            PolicyRenew VerifyPolicyRenew = new PolicyRenew(getDriver());
            VerifyPolicyRenew.ChangeAddressDetails(table);
        }
        [When(@"I Add AI with below details on ILM and BO Locations for policy renewal")]
        public void WhenIAddAIWithBelowDetailsOnILMAndBOLocationsForPolicyRenewal(Table table)
        {
            PolicyRenew AddAIILM_BO = new PolicyRenew(getDriver());
            AddAIILM_BO.AddAIonILMBOLocs(table);
        }
        [When(@"I Enter Umbrella Line Coverage Details for Policy Renewal")]
        public void WhenIEnterUmbrellaLineCoverageDetailsForPolicyRenewal()
        {
            PolicyRenew AddUMBDetails = new PolicyRenew(getDriver());
            AddUMBDetails.BOUmbrellaLineDetails();
        }


        [When(@"I select location number (.*)")]
        public void WhenISelectLocationNumber(int locNum)
        {
            CL_BOLocations clBOLocations = new CL_BOLocations(getDriver());
            clBOLocations.SelectBOPLocation(locNum);
        }

        [When(@"I Enter below Location details to Add AI, Ecomm and MSV")]
        public void WhenIEnterBelowLocationDetailsToAddAIEcommAndMSV(Table table)
        {
            CL_LocationDetails clLocationDetails = new CL_LocationDetails(getDriver());
            clLocationDetails.EnterLocDetails_AI_ECOMM_MSV(table);
        }

        [When(@"I add below addition coverage for BO buldings")]
        public void WhenIAddBelowAdditionCoverageForBOBuldings(Table table)
        {
            PolicyChange clLocationDetails = new PolicyChange(getDriver());
            clLocationDetails.BOBuildingAddCovg(table);
        }

        [When(@"I Issue BOP CL policy")]
        public void WhenIIssueBOPCLPolicy()
        {
            CL_Quote clQuote = new CL_Quote(getDriver());
            clQuote.IssueBOPPolicy();
            DataStorage tempData = new DataStorage();
            tempData.StoreTempValue("guidewire", "PLCYNO", ScenarioContext.Current["POLICY"].ToString());
        }

        [When(@"I Enter the Location details for BOP")]
        public void WhenIEnterTheLocationDetailsForBOP(Table table)
        {
            CL_LocationDetails clLocationDetails = new CL_LocationDetails(getDriver());
            clLocationDetails.EnterLocDetails_BOP(table);
        }

        [When(@"I change EPLI details and verify Ratabase Error")]
        public void WhenIChangeEPLIDetailsAndVerifyRatabaseError()
        {
            CL_BusinessOwnersLine clBOLine = new CL_BusinessOwnersLine(getDriver());

            clBOLine.UpdateBOPEPLI_Verify();
        }

        [When(@"I remove location and all its Buildings for location num (.*)")]
        public void WhenIRemoveLocationAndAllItsBuildingsForLocationNum(int locationNum)
        {
            PolicyRewriteFullTerm CL_DeleteBOLoc = new PolicyRewriteFullTerm(getDriver());
            CL_DeleteBOLoc.DeleteALLBldinLoc(locationNum);
        }

        [When(@"I Enter below details policy change and Add a Building")]
        public void WhenIEnterBelowDetailsPolicyChangeAndAddABuilding(Table table)
        {
            PolicyChange CL_AddBuilding = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddBuilding.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddBuilding.permChng_AddBuilding(table);
        }

        [When(@"I delete buildings with below details")]
        public void WhenIDeleteBuildingsWithBelowDetails(Table table)
        {
            PolicyRewriteFullTerm CL_DeleteLocBuilding = new PolicyRewriteFullTerm(getDriver());
            CL_DeleteLocBuilding.DeleteBOLocBld(table);
        }

        [When(@"I add below Location Addl Coverage")]
        public void WhenIAddBelowLocationAddlCoverage(Table table)
        {
            CL_LocationDetails clLocationAddlCovg = new CL_LocationDetails(getDriver());
            clLocationAddlCovg.LocationAddlCoverage(table);
        }

        [When(@"I click on next button on line selection page")]
        public void WhenIClickOnNextButtonOnLineSelectionPage()
        {
            CL_LineSelection lineSelection = new CL_LineSelection(getDriver());
            lineSelection.ClickNextbutton();
        }

        [When(@"I Enter the Jewelry Stock Information for JS")]
        public void WhenIEnterTheJewelryStockInformationForJS()
        {
            CL_JewelryStock clJewelryStock = new CL_JewelryStock(getDriver());
            clJewelryStock.EnterJewelryStockInfoJS();
        }

        [When(@"I Enter below details policy change and Add ILM Location for JS")]
        public void WhenIEnterBelowDetailsPolicyChangeAndAddILMLocationForJS(Table table)
        {
            PolicyChange CL_AddILMLoc = new PolicyChange(getDriver());
            Console.WriteLine(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddILMLoc.ChangeEffectiveDate(table.Rows[0]["ChangeEffectiveDate"]);
            CL_AddILMLoc.permChng_AddILMLocJS(table);
        }

        [When(@"I click OK on ILM Location page")]
        public void WhenIClickOKOnILMLocationPage()
        {
            CL_SafesVaultsStockrooms CLClickOK = new CL_SafesVaultsStockrooms(getDriver());

            CLClickOK.ClickOKButton();
        }

        [When(@"I Enter below listed Jewelry Stock Information details for JSP")]
        public void WhenIEnterBelowListedJewelryStockInformationDetailsForJSP(Table table)
        {
            CL_JewelryStock clJewelryStock = new CL_JewelryStock(getDriver());
            clJewelryStock.EnterJewelryStockInfoDetails_JSP(table.Rows[0]["LastInvTotal"], table.Rows[0]["StockValue"], table.Rows[0]["AvgAmtCustomersProperty"], table.Rows[0]["AvgAmtMemoConsignment"], table.Rows[0]["LooseDiamonds"], table.Rows[0]["stockAOPLimit"]);
        }

        [When(@"I click Handle UW issues for JSP policy")]
        public void WhenIClickHandleUWIssuesForJSPPolicy()
        {
            PolicyRewriteFullTerm IssueRewritePolicy = new PolicyRewriteFullTerm(getDriver());

            IssueRewritePolicy.IssuePolicy_JSPSCR3();
        }

        [When(@"Enter below Property Otherwise Away Limit")]
        public void WhenEnterBelowPropertyOtherwiseAwayLimit(Table table)
        {
            PolicyRewriteFullTerm PropOtherwiseAway = new PolicyRewriteFullTerm(getDriver());

            PropOtherwiseAway.propertyOtherwiseAway(table);
        }

        [When(@"I Enter the Umbrella Line Coverage Details for PlcyRewrite")]
        public void WhenIEnterTheUmbrellaLineCoverageDetailsForPlcyRewrite()
        {
            PolicyRewriteFullTerm UMBCovg = new PolicyRewriteFullTerm(getDriver());
            UMBCovg.BOUmbrellaLineDetails();
        }

        [When(@"I Enter the Umbrella Underwritings details for PlcyRewrite")]
        public void WhenIEnterTheUmbrellaUnderwritingsDetailsForPlcyRewrite()
        {
            PolicyRewriteFullTerm UMBCovg = new PolicyRewriteFullTerm(getDriver());
            UMBCovg.BOUmbrellaUnderwritingDetails();
        }
        [When(@"I select below offering on the Offerings Page for JSP Scenario")]
        public void WhenISelectBelowOfferingOnTheOfferingsPageForJSPScenario(Table table)
        {
            PolicyRewriteFullTerm Offering = new PolicyRewriteFullTerm(getDriver());
            Offering.SelectOffering(table.Rows[0]["Offering"]);
        }

        [When(@"I select below line items on line selection page for JSP Scenario")]
        public void WhenISelectBelowLineItemsOnLineSelectionPageForJSPScenario(Table table)
        {
            PolicyRewriteFullTerm LineItems = new PolicyRewriteFullTerm(getDriver());
            LineItems.SelectLines(table.Rows[0]["LineItems"]);
        }
        [When(@"For JSP Scenario I Select Location (.*)")]
        public void WhenForJSPScenarioISelectLocation(int LocaNum)
        {
            PolicyRewriteFullTerm SelectLoc = new PolicyRewriteFullTerm(getDriver());
            SelectLoc.SelectBOPLocation(LocaNum);
        }

        [When(@"I click on Edit Work Order For Policy Renewal")]
        public void WhenIClickOnEditWorkOrderForPolicyRenewal()
        {
            PolicyRenew EditWrkOrdr = new PolicyRenew(getDriver());
            EditWrkOrdr.EditWorkOrder();
        }
        [When(@"I add below ShowCases Windows coverage with below details for JSP")]
        public void WhenIAddBelowShowCasesWindowsCoverageWithBelowDetailsForJSP(Table table)
        {
            PolicyRenew AddTradeShowcases = new PolicyRenew(getDriver());
            AddTradeShowcases.AddTradeShowcasesCovg_JSP(table);
        }
        [When(@"I click OK button on current page")]
        public void WhenIClickOKButtonOnCurrentPage()
        {
            PolicyRenew ClickBtn = new PolicyRenew(getDriver());
            ClickBtn.ClickOKButton();
        }

        [When(@"I Quote and Issue Renewed CL policy for JSP")]
        public void WhenIQuoteAndIssueRenewedCLPolicyForJSP()
        {
            PolicyRenew issuePolicyRenew = new PolicyRenew(getDriver());
            issuePolicyRenew.issueCLRenewPolicy_JSP();
        }
        [When(@"I select below line items on line selection page for BOP Select")]
        public void WhenISelectBelowLineItemsOnLineSelectionPageForBOPSelect(Table table)
        {
            PolicyChange BOPSelectLine = new PolicyChange(getDriver());

            BOPSelectLine.SelectLines_BOPSelect(table.Rows[0]["LineItems"]);
        }

        [When(@"I Enter below RetroDate on the Business Owners Line Page for BOPSelect")]
        public void WhenIEnterBelowRetroDateOnTheBusinessOwnersLinePageForBOPSelect(Table table)
        {
            CL_BusinessOwnersLine clBOLine = new CL_BusinessOwnersLine(getDriver());

            clBOLine.EnterBusinnessOwnerLineDetails_BOPSelect(table.Rows[0]["RetroDate"]);
        }
		
		 [When(@"I verify CL renewal for (.*)")]
        public void WhenIVerifyCLRenewalFor(string Offering)
        {
            HomePage PCNavigation = new HomePage(getDriver());
            PCNavigation.verifyCLRenewal(Offering);
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    int DateDiff = Convert.ToInt32(ScenarioContext.Current["DateDiff"]);
                    PCNavigation.selectLeftNavMenu("documentspolicy");
                    PolicyDocuments PCDocument = new PolicyDocuments(getDriver());
                    PCDocument.CLRenewDocument(DateDiff, Offering);
                    break;
                case "default":

                    break;
            }

          
        }

		
    }
}
