Feature: GW_PC9_RegressionSuite_Day1


@regression
Scenario Outline: JBP_TS01_NB_Single_1Pay_ON_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for commercial account with below company name in PC9
	| CompanyName       |
	| Selenium CL Smoke |
	And I enter following mandatory details on create account page for commercial lines for ST in PC9
	| AddressLine1  | City       | State   | ZipCode | Country | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 441 Maple Ave | Burlington | Ontario | L7S 2J8 | Canada  | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
	| ActionType     |
	| New Submission |
	And I enter below details on CL New submission page
	| PolicyEffDate | Product          |
	| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
	| Offering           |
	| Jewelers Block Pak |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter the policy details on the commercial lines policy information page for ST in PC9
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location details in PC9
	| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
	| 100              | 100               | 20          | 10          | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
	| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
	| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	#And I Set Territory code 009 for Location in PC9
	#And I Click Next on Business Owners Locations Page in PC9
	#And I Click on Add ILM Location Building in PC9
	#And I add below Location details in PC9
	#| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
	#| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	#And I Click Next on BO Location Building Page in PC9
	#And I Click Next on Bldg Blankets Page in PC9
	#And I Click Next on Bldg Modifiers Page in PC9
	#And I Click Next on Bldg Line Review Page for ST in PC9
	#And I click Quote on Risk Analysis Page for ST in PC9
	#And I Click Next on Quote Page in PC9
	#And I check forms listed on Forms Page and click next in PC9
	#And I enter below details on Payment Page in PC9
	#| BilingMethod | InstallmentPlan |
	#| Direct Bill  | 8 Pay          |
	#Then I Issue the CL policy for ST in PC9
	#And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName | Password |
	| PC          | Desktop | IE      | su       | gw       |
