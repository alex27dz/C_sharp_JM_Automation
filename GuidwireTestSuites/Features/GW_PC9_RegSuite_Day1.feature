Feature: GW_PC9_RegSuite_Day1

@vm1
@D1Renwals
@D1Renwalscl1
@regression
Scenario Outline: CL_Renwls_Day1_TS01_JB_X99
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName             |
		| CLRenewalsTS01JBBDX99US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1       | City   | State | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 112 N Minnesota St | Algona | Iowa  | 50511-2806 | United States of America | Business    | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Jewelers Block |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-266 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | CHROME      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl2
@regression
Scenario Outline: CL_Renwls_Day1_TS02_JB_X75
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName             |
		| CLRenewalsTS02JBBDX75US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1       | City   | State | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 112 N Minnesota St | Algona | Iowa  | 50511-2806 | United States of America | Business    | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Jewelers Block |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-289 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 2 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | CHROME      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl3
@regression
Scenario Outline: CL_Renwls_Day1_TS03_JBP_X45_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| CLRenewalsTS03JBPUMBBDX45US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1        | City     | State  | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 3754 Salt Lake Blvd | Honolulu | Hawaii | 96818   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-321 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details and verify UnderWriting Page in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl4
@regression
Scenario Outline: CL_Renwls_Day1_TS04_JBP_X29_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| CLRenewalsTS04JBPUMBBDX29US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1        | City     | State  | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 3754 Salt Lake Blvd | Honolulu | Hawaii | 96818   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-336 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details and verify UnderWriting Page in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 4 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl5
@regression
Scenario Outline: CL_Renwls_Day1_TS05_JBP_X14_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| CLRenewalsTS05JBPUMBBDX14US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1        | City     | State  | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 3754 Salt Lake Blvd | Honolulu | Hawaii | 96818   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-351 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details and verify UnderWriting Page in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl6
@regression
Scenario Outline: CL_Renwls_Day1_TS06_BOP_X99_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| CLRenewalsTS06BOPBDX99US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City        | State      | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 1919 Davis St | San Leandro | California | 94577-1231 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Businessowners |
	And I add UMB line on line selection page for Businessowners in PC9
	And I enter no for all questions on qualification page for Businessowners in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-267 |              |                    |               |	
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on below Location on BO Locations Page
		| Location |
		| 1        |
	And I add below details for new BO Location with same address in PC9
		| RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl7
@regression
Scenario Outline: CL_Renwls_Day1_TS07_JS_X44
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName             |
		| CLRenewalsTS07JSBDX44US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1      | City          | State    | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 11431 Amherst Ave | Silver Spring | Maryland | 20902-9997 | United States of America | Business    | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering          |
		| Jewelers Standard |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-321 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | CHROME      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl8
@regression
Scenario Outline: CL_Renwls_Day1_TS08_JSP_X30_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| CLRenewalsTS08JSPUMBBDX30US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City        | State         | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 2105 Gihon Rd | Parkersburg | West Virginia | 26101   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-336 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB with modifier
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 2 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl9
@regression
Scenario Outline: CL_Renwls_Day1_TS09_JS_BD_X14
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName             |
		| CLRenewalsTS09JSBDX14US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1      | City          | State    | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 11431 Amherst Ave | Silver Spring | Maryland | 20902-9997 | United States of America | Business    | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering          |
		| Jewelers Standard |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-351 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | Yes           | 
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 4 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | CHROME      | cluwmanager | cluwmanagerpwd |

@vm1
@D1Renwals
@D1Renwalscl10
@regression
Scenario Outline: CL_Renwls_Day1_TS10_BOP_X28
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName              |
		| CLRenewalsTS10BOPBDX28US |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City        | State      | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 1919 Davis St | San Leandro | California | 94577-1231 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Businessowners |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page for Businessowners in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-338 |              |                    |               |	
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on below Location on BO Locations Page
		| Location |
		| 1        |
	And I add below details for new BO Location with same address in PC9
		| RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | Annual Pay      |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |


@vm4
@bop
@bop1
@regression
Scenario Outline: BOP_TS01_NB_ProrataCancel_Reinstate_Claim_USA
		
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                   |
		| BOP01NBBDAIMSVEComEQ1PayCAUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City        | State      | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 1919 Davis St | San Leandro | California | 94577-1231 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Businessowners |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page for Businessowners in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on below Location on BO Locations Page
		| Location |
		| 1        |
	And I add below details for new BO Location with same address in PC9
		| RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I enter below Additional Intrest at BOP Location in PC9 for BOP
		| Location | Interest_Type                                       | AI_Name   | Is_Jeweler | Address_Line1      | City   | State | ZipCode    |
		| 1        | Additional Named Insured (Liability Coverages Only) | BOP01BOAI | no         | 112 N Minnesota St | Algona | Iowa  | 50511-2806 |
	And I enter below details to add Ecomm Coverage
		| Location | Keyword                          | AnnualAggLimit | HazardGroup |
		| 1        | Electronic Commerce (E-Commerce) | 10,000         | Medium      |
	And I enter below details to add MSV Coverage
		| Location | AnnualSales | Keyword                      |
		| 1        | 5,000,000   | Manufactured Stock Valuation | 
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9 and add EQ Covg
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe | BuildingClass | EQTerritory |
		| 1        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            | 1C            | 21          |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | Annual Pay      |
	Then I Issue CL policy for after handling UW issues
	And I Logout of the Policy Center application



	#Billing Center Charges	
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu	
	Then I Should see the premium:bop:bop value displayed	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Billing Center Disbursements 	
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select new payment:new direct bill payment from actions menu 	
	And I make a direct bill payment of 100 	
	And I select new transaction:disbursement from actions menu 	
	And I make a disburse payment of 10 for Overpayment 	
	And I select disbursements from left navigation menu 	
	Then I Verify 10 status is Approved in Disbursements table 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver


	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              |               |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Employee Dishonesty from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Expense   | A&O Expense        | 500                  |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor    | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Logout of the Claim Center application
	And I Kill Web Driver


	#Policy Center - Policy Reinstate
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType       |
		| Reinstate Policy | 
	And I enter below details for policy reinstatement
		| Reason           |
		| Payment received |
	And I click Quote and Issue Policy Reinstatement
	Then I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm3
@bop
@bop2
@regression
Scenario Outline: BOP_TS02_NB_PolicyChnage_EPLI_OOS_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| BOP02UMBNBEPLICD8PayNJUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1     | City        | State      | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| New 44 Spruce St | Jersey City | New Jersey | 07306-3565 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Businessowners |
	And I add UMB line on line selection page for Businessowners in PC9
	And I enter no for all questions on qualification page for Businessowners in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on below Location on BO Locations Page
		| Location |
		| 1        |
	And I add below details for new BO Location with same address in PC9
		| RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I change EPLI details and verify Ratabase Error in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	
	#Billing Center Invoice Validation
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select summary from left navigation menu 	
	And I validate 8 pay  for the Policy	
	And I select invoices from left navigation menu	
	Then I verify the current and scheduled invoice payments for 8 pay 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver
	
	
	#Policy Center - Policy Change - Add 2ns BO Location and 1 buildings for 2nd Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Add Location     | Add Location         |
	And I Enter below location to add new BO Location for BOP
		| Location |
		| 2        |
	And I click on New Location on BO Locations Page
	And I add below details for new BO Location in PC9
		| AddressLine1        | City   | State     | ZipCode | Country                  | RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 1155 Winneconne Ave | Neenah | Wisconsin | 54956   | United States of America | 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application
	
	
	
	#Policy Center - Policy Change - Delete 2nd BO Location, including its Buildings
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory |
		| SYSTEMDATE+10       | Permanent Change | Delete Location  | Delete Location      |
	And I Enter below details for Businessowners to delete BO Location buidling for location 2
		| BldgToDelete |
		| 1            |
		| 2            |
	And I Enter below details to delete BO Location
		| SetActiveLoc | Location |
		| 1            | 2        |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Add 1 Building for 1st BO Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext               | ChangeReasonCategory             |
		| SYSTEMDATE          | Permanent Change | Businessowners Coverage Change | Coverage change - Building Level |
	And I Enter below Building details to add a Building
		| Change | Location | Building | Coverage        |
		| added  | 1        | 2        | Adding Building |
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit  | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 4,000,000 | Local Alarm  | Yes     | Yes       | No            |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Delete 1st BO Location's 2nd Building
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext               | ChangeReasonCategory             |
		| SYSTEMDATE          | Permanent Change | Businessowners Coverage Change | Coverage change - Building Level |
	And I Enter below Building details to add a Building
		| Change  | Location | Building | Coverage          |
		| removed | 1        | 2        | Deleting Building |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm4
@bop
@bop3
@regression
Scenario Outline: BOP_TS03_NB_ProrataCancel_Claim_RewriteReminder_CAD
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName        |
		| BOP03NBCD2PayONCAN |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City       | State   | ZipCode | Country | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 441 Maple Ave | Burlington | Ontario | L7S 2J8 | Canada  | Other       | LLC     | Yes       | ABZB         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Businessowners |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page for Businessowners in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-60 |              |                    |               |
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on below Location on BO Locations Page
		| Location |
		| 1        |
	And I add below details for new BO Location with same address in PC9
		| RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 2 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Employee Dishonesty from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Expense   | A&O Expense        | 500                  |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor    | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Logout of the Claim Center application
	And I Kill Web Driver


	#Billing Center - Direct Bill Payment
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 301
	And I Logout of the Billing Center application
	And I Kill Web Driver

#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason           | ReasonMethod | CancelEffDate |
		| Insured | Insured Deceased |              | SYSTEMDATE    |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application


	#Policy Center - Policy Rewrite New Term - remove Tradeshow and Inactive/Remove AI
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType                    |
		| RewriteRemainderofTerm policy |
	And I click next on CL Offerings Page 
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I click next on Policy Info Page for Businessowners
	And I click Quote and Issue policy RewriteRemainderOfTerm
	Then I Logout of the Policy Center application


Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm6
@jb
@jb1
@regression
Scenario Outline: JB_TS01_NB_FlatCancel_Reinstate_Change_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                     |
		| JB01NBFCancelReinstate8PayIAUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1       | City   | State | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 112 N Minnesota St | Algona | Iowa  | 50511-2806 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Jewelers Block |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1        | City   | State     | ZipCode    | Country                  |
		| 48 Jewelers Park Dr | Neenah | Wisconsin | 54956-3702 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application
	
	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              |               |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application


	#Policy Center - Policy Reinstate
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType       |
		| Reinstate Policy | 
	And I enter below details for policy reinstatement
		| Reason           |
		| Payment received |
	And I click Quote and Issue Policy Reinstatement
	Then I Logout of the Policy Center application
	
	#Policy Center - Policy Change - Add Tradeshow for New York state
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext  | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Trade Show Change | Add                  |
	And I Enter below details for Tradeshows policy change in PC9
		| Limit   | Deductible | ShowName_City_State   |
		| 200,000 | 2,500      | Tradeshow in New York |
	And I add Tradeshows with below details on ILM Off Premise Coverages tab
		| CoverageName                  | Tradeshow_City | Tradeshow_State | HowMerch_Transported | Transit_Days | Recurring | Limit   | Deductible | TempReason |
		| Tradeshows - To/From/While At | New York       | New York        | Approved Individual  | 2            | false     | 200,000 | 2,500      | No         |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application



Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm2
@jb
@jb2
@regression
Scenario Outline: JB_TS02_NB_Change_Add_Loc_Del_Loc_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                    |
		| JB02NBChangeAddDelLoc8PayMDCAD |
	And I enter below mandatory details on create account page for CL
		| AddressLine1         | City    | State            | ZipCode | Country | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 8826 Jim Bailey Cres | Kelowna | British Columbia | V4V 2L7 | Canada  | Other       | LLC     | Yes       | ABZB         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Jewelers Block |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Billing Center Charges	
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu	
	Then I Should see the premium:im:jb;policyfee:im:jb value displayed	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Billing Center Disbursements 	
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select new payment:new direct bill payment from actions menu 	
	And I make a direct bill payment of 100 	
	And I select new transaction:disbursement from actions menu 	
	And I make a disburse payment of 10 for Overpayment 	
	And I select disbursements from left navigation menu 	
	Then I Verify 10 status is Approved in Disbursements table 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Policy Center - Policy Change - Add 3rd ILM Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Add Location     | Add Location         |
	And I Enter below location to add new ILM Location
		| Location |
		| 2        |
	And I add below new ILM location on PC9
		| AddressLine1        | City        | State   | ZipCode | Country                  |
		| 5522 Lawrence Ave E | Scarborough | Ontario | M1C 3B2 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application
	
	#Policy Center - Policy Change - Delete 1st ILM Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory                   |
		| SYSTEMDATE+10       | Permanent Change | Delete Location  | Delete Location - One Line of Business |
	And I Enter below location to delete ILM Location for Canada
		| Location | Offering       |
		| 1        | Jewelers Block |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName | Password |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd   |

@vm1
@jb
@jb3
@regression
Scenario Outline: JB_TS03_NB_FlatCancel_Rewrite_FullTerm_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JB03NBCancelRewrite8PayIAUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1       | City   | State | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 112 N Minnesota St | Algona | Iowa  | 50511-2806 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering       |
		| Jewelers Block |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1        | City   | State     | ZipCode    | Country                  |
		| 48 Jewelers Park Dr | Neenah | Wisconsin | 54956-3702 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              |               |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application
	
	#Policy Center - Policy RewriteFullTerm
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType              |
		| Rewrite Fullterm Policy |  
	And I click Quote and Issue policy RewriteFullTerm
	Then I Logout of the Policy Center application

	#Billing Center Documents Check 
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select documents from left navigation menu 	
	And I search documents by selecting "" , Since , "" , "" , 30 days ago in document page   	
	Then I Verify if documents are Yes in document page 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm4
@jbpri
@jbpriusa
@regression
Scenario Outline: JBP_RI_TS01_Reinsurance_NewClaim_Cyber_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JBP01CLReinsuranceUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1       | City     | State     | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 2410 Springdale Rd | Waukesha | Wisconsin | 53186-2777 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I add below coverages on ILM Line for CL RI
		| CoverageType             | AvgDayilyLimit | AvgDayilyDed |
		| Maximum Travel Aggregate | 250,000        | 1,000        |
		| Property Otherwise Away  | 250,000        | 1,000        |
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 20,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I add below coverage on BO Line page
		| CoverageName | Limit     | Deductible |
		| EPLI         | 1,000,000 | 5,000      |
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I add below coverage on BO Line page
		| CoverageName        | OverrideLimit | RetainedLimitofInsurance | FacultativeReinsuranceCost | OverrideDeductible |
		| Employee Dishonesty | 500,000       | 250,000                  | 500,000                    | 2,500              |
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9 for CL RI
		| UmbrellaLimit | AdditionalPremium | SelfInsuredRetention |
		| 12,000,000    | 1,000             | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB with modifier
	And I click on Reinsurance link on left navigation bar
	And I verify below AgreementNumber for EPLI
		| AgreementNumber |
		| A617-20 End 1   |
	And I enter below details for CL Reinsurance
		| GroupCovg                | AggName  | AttachmentPoint | CoverageLimit | CededShare | CededPremium | CommissionPer | ContactName    | AddressLine1        | City   | State     | ZipCode    | Country |
		| Location 1:Property      | CLRIProp | 20,000,000.00   | 26,914,166.67 | 100        | 0            | 0             | LocPropContact | 1155 Winneconne Ave | Neenah | Wisconsin | 54956-3693 | USA     |
		| Property Otherwise Away  | CLRIPOA  | 50,000.00       | 25,000,000.00 | 100        | 0            | 0             | POAContact     | 1155 Winneconne Ave | Neenah | Wisconsin | 54956-3693 | USA     |
		| Employee Dishonesty      | CLRIED   | 50,000.00       | 25,000,000.00 | 100        | 0            | 0             | EDContact      | 1155 Winneconne Ave | Neenah | Wisconsin | 54956-3693 | USA     |
		| Umbrella Liability       | CLRIUL   | 10,000,000.00   | 12,000,000.00 | 100        | 0            | 0             | ULContact      | 1155 Winneconne Ave | Neenah | Wisconsin | 54956-3693 | USA     |
		| Maximum Travel Aggregate | CLRIMTA  | 50,000.00       | 20,000,000.00 | 100        | 0            | 0             | MTAContact     | 1155 Winneconne Ave | Neenah | Wisconsin | 54956-3693 | USA     |
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#ClaimCenter
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter below details for CL policy on search page
		| LossDate   | TypeofClaim              | ClaimsMade |
		| 07/05/2018 | commerciallinequickclaim | yes        |
	And In CC9 I Enter below CL claim details on the Basic Information page
		| ReportedByName | RelatedToInsured | Description      | LossCause       | SecondaryLossCause    | IncidentOnly | CoverageInQuestion | DateOfNotice       |
		| Insured        | Insured          | Test Description | Cyber Liability | Multi-Media Liability | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu	
	And In CC9 I Select Cyber Liability from the New exposure page	
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
		| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
		| (1)      | Indemnity | Indemnity Category | 75000                |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
		| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
		| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 75000  |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I select Exposures from the left navigation menu
	And I make below transaction on Explosures
		| Note           | Reason            | Transaction |
		| Close Exposure | Payments complete | Close       |
	And In CC9 I select Reinsurance from the left navigation menu
	And In CC9 I validate below details on Reinsurance Financials Summary page
		| DirectPaid | ReinsuranceFinancialsPaid |
		| $75000.00  | $0.00                     |	
	And I Logout of the Claim Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm5
@jbpri
@jbprican
@regression
Scenario Outline: JBP_RI_TS02_Reinsurance_NewClaim_Cyber_CAD
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName           |
		| JBP01CLReinsuranceCAD |
	And I enter below mandatory details on create account page for CL
		| AddressLine1 | City         | State                     | ZipCode | Country | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 221 Main St  | Stephenville | Newfoundland and Labrador | A2N 1J9 | Canada  | Other       | LLC     | Yes       | ABZB         | itqaautomation@jminsure.com |  
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I add below coverages on ILM Line for CL RI
		| CoverageType             | AvgDayilyLimit | AvgDayilyDed |
		| Maximum Travel Aggregate | 250,000        | 1,000        |
		| Property Otherwise Away  | 250,000        | 1,000        |
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 20,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I add below coverage on BO Line page
		| CoverageName        | OverrideLimit | RetainedLimitofInsurance | FacultativeReinsuranceCost | OverrideDeductible |
		| Employee Dishonesty | 500,000       | 250,000                  | 500,000                    | 2,500              |
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I click on Reinsurance link on left navigation bar
	And I enter below details for CL Reinsurance
		| GroupCovg                | AggName  | AttachmentPoint | CoverageLimit | CededShare | CededPremium | CommissionPer | ContactName    | AddressLine1         | City    | State            | ZipCode | Country |
		| Location 1:Property      | CLRIProp | 20,000,000.00   | 26,914,166.67 | 100        | 0            | 0             | LocPropContact | 8826 Jim Bailey Cres | Kelowna | British Columbia | V4V 2L7 | Canada  |
		| Property Otherwise Away  | CLRIPOA  | 50,000.00       | 25,000,000.00 | 100        | 0            | 0             | POAContact     | 8826 Jim Bailey Cres | Kelowna | British Columbia | V4V 2L7 | Canada  |
		| Employee Dishonesty      | CLRIED   | 50,000.00       | 25,000,000.00 | 100        | 0            | 0             | EDContact      | 8826 Jim Bailey Cres | Kelowna | British Columbia | V4V 2L7 | Canada  |
		| Maximum Travel Aggregate | CLRIMTA  | 50,000.00       | 20,000,000.00 | 100        | 0            | 0             | MTAContact     | 8826 Jim Bailey Cres | Kelowna | British Columbia | V4V 2L7 | Canada  |
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#ClaimCenter
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter below details for CL policy on search page
		| LossDate   | TypeofClaim              | ClaimsMade |
		| 07/05/2018 | commerciallinequickclaim | yes        |
	And In CC9 I Enter below CL claim details on the Basic Information page
		| ReportedByName | RelatedToInsured | Description      | LossCause       | SecondaryLossCause    | IncidentOnly | CoverageInQuestion | DateOfNotice       |
		| Insured        | Insured          | Test Description | Cyber Liability | Multi-Media Liability | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu	
	And In CC9 I Select Cyber Liability from the New exposure page	
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
		| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
		| (1)      | Indemnity | Indemnity Category | 75000                |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
		| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
		| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 75000  |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I select Exposures from the left navigation menu
	And I make below transaction on Explosures
		| Note           | Reason            | Transaction |
		| Close Exposure | Payments complete | Close       |
	And In CC9 I select Reinsurance from the left navigation menu
	And In CC9 I validate below details on Reinsurance Financials Summary page
		| DirectPaid | ReinsuranceFinancialsPaid |
		| $75000.00  | $0.00                     |	
	And I Logout of the Claim Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |



@vm1
@jbp
@jbp1
@regression
Scenario Outline: JBP_TS01_NB_Single_1Pay_ON_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName            |
		| JBP01NBSingle1PayONCAN |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City       | State   | ZipCode | Country | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 441 Maple Ave | Burlington | Ontario | L7S 2J8 | Canada  | Other       | LLC     | Yes       | ABZB         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm5
@jbp
@jbp2
@regression
Scenario Outline: JBP_TS02_NB_UMB_BD_ProR_Cncl_Reins_TmpChng_Claim
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP02NBBDMultiple8PayHIUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1        | City     | State  | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 3754 Salt Lake Blvd | Honolulu | Hawaii | 96814   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-150 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1        | City   | State     | ZipCode    | Country                  |
		| 48 Jewelers Park Dr | Neenah | Wisconsin | 54956-3702 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 9,000,000     |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details and verify UnderWriting Page in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason           | ReasonMethod | CancelEffDate |
		| Insured | Insured Deceased |              | SYSTEMDATE-1  |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	#Policy Center - Policy Reinstate
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType       |
		| Reinstate Policy | 
	And I enter below details for policy reinstatement
		| Reason           |
		| Payment received |
	And I click Quote and Issue Policy Reinstatement
	Then I Logout of the Policy Center application

	#Policy Center - Policy Change - Temp Endorse Tradeshow for New York state
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason          | ChangeReasonNext  | ChangeReasonCategory |
		| SYSTEMDATE          | Temporary Endorsement | Trade Show Change | Tradeshow Coverage   |
	And I Enter below details for Temp Endorse Tradeshows policy change in PC9
		| Tradeshow_Type   | Limit   | Deductible | ShowName_City_State   |
		| to/from/while at | 200,000 | 2,500      | Tradeshow in New York |
	And I add Tradeshows with below details on ILM Off Premise Coverages tab
		| CoverageName                  | Tradeshow_City | Tradeshow_State | HowMerch_Transported | Transit_Days | Recurring | Limit   | Deductible | TempReason |
		| Tradeshows - To/From/While At | New York       | New York        | Approved Individual  | 2            | false     | 200,000 | 2,500      | Yes        |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Employee Dishonesty from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Expense   | A&O Expense        | 500                  |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Logout of the Claim Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm3
@jbp
@jbp3
@regression
Scenario Outline: JBP_TS03_NB_UMB_FlatCncl_Rewrte_FullTerm_USA_Claim
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                      |
		| JBP03NBUMBSingleSPMSPTS4PayNMUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1          | City        | State      | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 2701 Carlisle Blvd NE | Albuquerque | New Mexico | 87110-2830 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I add Tradeshows with below details on ILM Off Premise Coverages tab
		| CoverageName                  | Tradeshow_City | Tradeshow_State | HowMerch_Transported | Transit_Days | Recurring | Limit   | Deductible | TempReason |
		| Tradeshows - To/From/While At | New York       | New York        | Approved Individual  | 2            | false     | 200,000 | 2,500      | No         |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I add below coverage on BO Line page
		| CoverageName                        | OverrideLimit | OverrideDeductable |
		| Money and Securities - Off Premises | 50,000        | 250                |
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB with modifier
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 4 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Billing Center Invoice Validation
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select summary from left navigation menu 	
	And I validate 4 Pay - Quarterly  for the Policy	
	And I select invoices from left navigation menu	
	Then I verify the current and scheduled invoice payments for 4 Pay - Quarterly 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver


	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              |               |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application


	#Policy Center - Policy RewriteFullTerm
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType              |
		| Rewrite Fullterm Policy |  
	And I click Quote and Issue policy RewriteFullTerm
	Then I Logout of the Policy Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Employee Dishonesty from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Expense   | A&O Expense        | 500                  |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Adjuster    | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome     | ForceClose | ClaimStatus |
	| Selenium Test Note | No coverage | Yes        | Closed      |
	And In CC9 I Pick Reopen Claim from the Actions menu
	And In CC9 I enter below details to reopen claim
	| Note                                         | Reason          |
	| This claim has been reopened - Selenium Test | New information |
	And In CC9 I select Exposures from the left navigation menu
	And I make below transaction on Explosures
	| Note                  | Reason          | Transaction |
	| Repen Closed Exposure | New information | ReOpen      |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 80     |
	And In CC9 I select Workplan from the left navigation menu
	Then In CC9 I verify below Activity
	| ActivitySubject                | VerifyButton |
	| Review and approve new payment | Approve      |
	And I Logout of the Claim Center application
Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm6
@jbp
@jbp4
@regression
Scenario Outline: JBP_TS04_NB_Multiple_Change_USA_Claim
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP04NBMultiple12PayFLUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1    | City     | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 100 Harrison Dr | Evanston | Wyoming | 82930   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com | 
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1                 | City     | State  | ZipCode | Country                  |
		| 1450 Ala Moana Blvd Ste 1006 | Honolulu | Hawaii | 96814   | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 9,000,000     |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application
	

	#Policy Center - Policy Change - add/increase Stock Peak
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext   | ChangeReasonCategory | 
		| SYSTEMDATE          | Permanent Change | Stock Limit Change | Stock Limit          | 
	And I enter below Policy Change Stockpeak details in PC9
		| ChoiceChange1 | SteakPeak_Limit | Location | SteakPeak_StartDate | SteakPeak_EndDate | SteakPeak_Deductible | SteakPeak_Recurring |
		| increased     | 200,000         | 2        | SYSTEMDATE          | SYSTEMDATE+30     | 12,500               | No                  |
	Then I click Quote and Issue policy change
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Increase Stock AOP
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext   | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Stock Limit Change | Stock Limit          |
	And I enter below Policy Change Stock AOP changes in PC9
		| ChoiceChange1 | StockAOP_Limit | Location | AOP_Deductible | Country |
		| increased     | 9,900,000      | 2        | 2,500          | USA     |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Policy Center - Policy Change - Add Additional Intrest in ILM, Add Additional Insured in BO Loc & Building
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext                       | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Additional Insured/Additional Interest | Add/Amend            |
	And I enter below Additional Intrest at ILM Location in PC9
		| Location | AI_Type                      | AI_Change_Type | Offering     | Description              | Interest_Type | AI_Name    | Is_Jeweler | Address_Line1       | City   | State     | ZipCode |
		| 2        | Additional Insured – Vendors | added          | Jewelers Pak | Adding AI to ILM and BOP | Loss Payee    | JBP04ILMAI | yes        | 24 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I enter below Additional Intrest at BOP Location in PC9
		| Location | Interest_Type                                       | AI_Name   | Is_Jeweler | Address_Line1 | City   | State     | ZipCode |
		| 2        | Additional Named Insured (Liability Coverages Only) | JBP04BOAI | no         | 101 Main St   | Neenah | Wisconsin | 54956   |
	And I enter below Additional Insured at BOP Location  Building in PC9
		| Location | Interest_Type | FirstName    | LastName  | Address_Line1       | City   | State     | ZipCode |
		| 2        | Mortgagee     | JBP04BOBldAI | Mortgagee | 48 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Policy Center - Policy Change - Delete Additional Insured at BOP Building
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext                       | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Additional Insured/Additional Interest | Delete               |
	And I delete below Additional Insured at BOP Building in PC9
		| Location | AI_Type                      | AI_Change_Type | Offering     | Description             | 
		| 2        | Additional Insured – Vendors | deleted        | Jewelers Pak | Deleting AI in BOP Bldg | 
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Policy Center - Policy Change - Decrease Stock AOP
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext   | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Stock Limit Change | Stock Limit          |
	And I enter below Policy Change Stock AOP changes in PC9
		| ChoiceChange1 | StockAOP_Limit | Location | AOP_Deductible | Country |
		| decreased     | 8,000,000      | 2        | 2,500          | USA     |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Policy Center - Policy Change - Add Tradeshow for New York state
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext  | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Trade Show Change | Add                  |
	And I Enter below details for Tradeshows policy change in PC9
		| Limit   | Deductible | ShowName_City_State   |
		| 200,000 | 2,500      | Tradeshow in New York |
	And I add Tradeshows with below details on ILM Off Premise Coverages tab
		| CoverageName                  | Tradeshow_City | Tradeshow_State | HowMerch_Transported | Transit_Days | Recurring | Limit   | Deductible | TempReason |
		| Tradeshows - To/From/While At | New York       | New York        | Approved Individual  | 2            | false     | 200,000 | 2,500      | No         |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu	
	And In CC9 I Select Employee Dishonesty from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Expense   | A&O Expense        | 500                  |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I Pick Reserve from the Actions menu
	And I Update reserve with below details
	| ReserveCategory    | NewAvailReserves |
	| Indemnity Category | 250              |
	| A&O Expense        | 150              |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 200    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Logout of the Claim Center application


Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm4
@jbp
@jbp5
@regression
Scenario Outline: JBP_TS05_NB_BD_Sche_Chng_Cncl_Rescind_CAN_Claim
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP05NBBDMultiple2PayNLCAN |
	And I enter below mandatory details on create account page for CL
		| AddressLine1 | City         | State                     | ZipCode | Country | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 221 Main St  | Stephenville | Newfoundland and Labrador | A2N 1J9 | Canada  | Other       | LLC     | Yes       | ABZB         | itqaautomation@jminsure.com |  
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-100 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1         | City    | State            | ZipCode | Country |
		| 8826 Jim Bailey Cres | Kelowna | British Columbia | V4V 2L7 | Canada  |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 9,000,000     |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Decrease Stock AOP
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext   | ChangeReasonCategory |
		| SYSTEMDATE+15       | Permanent Change | Stock Limit Change | Stock Limit          |
	And I enter below Policy Change Stock AOP changes in PC9
		| ChoiceChange1 | StockAOP_Limit | Location | AOP_Deductible | Country |
		| decreased     | 8,000,000      | 2        | 2,500          | Canada  |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Policy Center - Policy Scheduled Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason      | ReasonMethod | CancelEffDate |
		| Carrier | Non-Payment |              | SYSTEMDATE+25 |	
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	#Claim Center - Quick Claim
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And I Logout of the Claim Center application


	#Policy Center - Policy Rescind
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType           |
		| Rescind Cancellation |
	And I rescind Policy
	And I Logout of the Claim Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu	
	And In CC9 I Select Employee Dishonesty from the New exposure page	
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Expense   | A&O Expense        | 500                  |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 165    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Logout of the Claim Center application


Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm3
@jbp
@jbp6
@regression
Scenario Outline: JBP_TS06_NB_BD_Mult_Change_Rewrite_NewTerm_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName             |
		| JBP06NBBDMulti8PayNYUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1    | City     | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 1544 Central Ave | Albany | New York | 12205   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com | 
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-100 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1                 | City     | State  | ZipCode | Country                  |
		| 40580 Albrae St | Fremont | California | 91902   | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		| 2   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 2,500,000     |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


	#Policy Center - Policy Change - Add Additional Intrest in ILM, Add Additional Insured in BO Loc & Building
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext                       | ChangeReasonCategory |
		| SYSTEMDATE-10       | Permanent Change | Additional Insured/Additional Interest | Add/Amend            |
	And I enter below Additional Intrest at ILM Location in PC9
		| Location | AI_Type                      | AI_Change_Type | Offering     | Description              | Interest_Type | AI_Name    | Is_Jeweler | Address_Line1       | City   | State     | ZipCode |
		| 2        | Additional Insured – Vendors | added          | Jewelers Pak | Adding AI to ILM and BOP | Loss Payee    | JBP06ILMAI | yes        | 24 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I enter below Additional Intrest at BOP Location in PC9
		| Location | Interest_Type                                       | AI_Name   | Is_Jeweler | Address_Line1 | City   | State     | ZipCode |
		| 2        | Additional Named Insured (Liability Coverages Only) | JBP06BOAI | no         | 101 Main St   | Neenah | Wisconsin | 54956   |
	And I enter below Additional Insured at BOP Location  Building in PC9
		| Location | Interest_Type | FirstName    | LastName  | Address_Line1       | City   | State     | ZipCode |
		| 2        | Mortgagee     | JBP06BOBldAI | Mortgagee | 48 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Policy Center - Policy Change - Add Tradeshow for New York state
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext  | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Trade Show Change | Add                  |
	And I Enter below details for Tradeshows policy change in PC9
		| Limit   | Deductible | ShowName_City_State   |
		| 200,000 | 2,500      | Tradeshow in New York |
	And I add Tradeshows with below details on ILM Off Premise Coverages tab
		| CoverageName                  | Tradeshow_City | Tradeshow_State | HowMerch_Transported | Transit_Days | Recurring | Limit   | Deductible | TempReason |
		| Tradeshows - To/From/While At | New York       | New York        | Approved Individual  | 2            | false     | 200,000 | 2,500      | No         |
	And I click Quote and Issue policy change
	Then I Logout of the Policy Center application

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason                    | ReasonMethod | CancelEffDate |
		| Insured | Competition - Self Insure |              | SYSTEMDATE    |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	#Billing Center: making direct bill payment
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 6,873.00
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#Policy Center - Policy Rewrite New Term - remove Tradeshow and Inactive/Remove AI
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType            |
		| RewriteNewTerm Policy |
	And I click next on CL Offerings Page 
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I click next on Policy Info Page for Jewelers Block Pak
	And I delete Tradeshow coverage on ILM Off Premise Coverages tab
	And I navigate to BO Locations
	And I Inactive AI for below BO location
		| Location |
		| 2        |
	And I click Quote and Issue policy RewriteNewTerm
	Then I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm5
@jbp
@jbp7
@regression
Scenario Outline: JBP_TS07_NB_BD_Cancel_Rewrite_Remainder_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP07NBMultiple12PayTXUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1 | City    | State | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 845A Memorial City Way  | Houston | Texas | 77024 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-100 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 1           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1    | City    | State      | ZipCode | Country                  |
		| 40580 Albrae St | Fremont | California | 91902   | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 1           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
		| 2   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


	#Billing Center Charges	
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu	
	Then I Should see the premium:im:jbp;premium:bop:jbp value displayed	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Billing Center Disbursements 	
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select new payment:new direct bill payment from actions menu 	
	And I make a direct bill payment of 100 	
	And I select new transaction:disbursement from actions menu 	
	And I make a disburse payment of 10 for Overpayment 	
	And I select disbursements from left navigation menu 	
	Then I Verify 10 status is Approved in Disbursements table 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason                    | ReasonMethod | CancelEffDate |
		| Insured | Competition - Self Insure |              | SYSTEMDATE    |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 16804.00
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#Policy Center - Policy Rewrite New Term - remove Tradeshow and Inactive/Remove AI
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType                    |
		| RewriteRemainderofTerm policy |
	And I click next on CL Offerings Page 
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I click next on Policy Info Page for Jewelers Block Pak
	And I Add Employee Dishonesty coverage on ILM Coverages tab
		| EmpDisHonesty_Limit | EmpDisHonesty_Ded |
		| 75,000              | 1,000             |
	And I add Tradeshows with below details on ILM Off Premise Coverages tab
		| CoverageName                  | Tradeshow_City | Tradeshow_State | HowMerch_Transported | Transit_Days | Recurring | Limit   | Deductible | TempReason |
		| Tradeshows - To/From/While At | New York       | New York        | Approved Individual  | 2            | false     | 200,000 | 2,500      | No         |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I delete below ILM Location
		| Location |
		| 2        |
	And I enter below Stockpeak details in PC9
		| Location | SteakPeak_Limit | SteakPeak_StartDate | SteakPeak_EndDate | SteakPeak_Deductible | SteakPeak_Recurring |
		| 1        | 200,000         | SYSTEMDATE          | SYSTEMDATE+30     | 12,500               | No                  |
	And I enter below Additional Intrest details at ILM Location in PC9
		| Location | Interest_Type | AI_Name    | Is_Jeweler | Address_Line1       | City   | State     | ZipCode |
		| 1        | Loss Payee    | JBP07ILMAI | yes        | 24 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I navigate to BO Locations
	And I enter below Additional Intrest details at BOP Location in PC9
		| Location | Interest_Type                                       | AI_Name   | Is_Jeweler | Address_Line1 | City   | State     | ZipCode |
		| 2        | Additional Named Insured (Liability Coverages Only) | JBP07BOAI | no         | 101 Main St   | Neenah | Wisconsin | 54956   |
	And I enter below Additional Insured at BOP Location  Building in PC9
		| Location | Interest_Type | FirstName    | LastName  | Address_Line1       | City   | State     | ZipCode |
		| 2        | Mortgagee     | JBP07BOBldAI | Mortgagee | 48 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I navigate to BO Locations
	And I click on New Location on BO Locations Page
	And I add below details for new BO Location in PC9
		| AddressLine1       | City   | State | ZipCode    | Country                  | RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 112 N Minnesota St | Algona | Iowa  | 50511-2806 | United States of America | 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 3        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 3        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 3        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I click Quote and Issue policy RewriteRemainderOfTerm
	Then I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm2
@jbp
@jbp8
@regression
Scenario Outline: JBP_TS08_NB_BD_NB_Renewal_UMB_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP08NBMultiple1PayRIUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1   | City    | State        | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 805 W Shore Rd | Warwick | Rhode Island | 02889-7700 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-100 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1     | City        | State      | ZipCode    | Country                  |
		| New 44 Spruce St | Jersey City | New Jersey | 07306-3565 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
		| 2   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | Annual Pay      |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Renew
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType   |
		| Renew Policy |
	And I click next on CL Offerings Page 
	And I add UMB line on line selection page in PC9 for plcy Renew
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		|          |               |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I set below location as primary
		| Location |
		| 2        |
	And I delete below ILM Location
		| Location |
		| 1        |
	And I add below new ILM location on PC9
		| AddressLine1        | City   | State     | ZipCode    | Country                  |
		| 36 Jewelers Park Dr | Neenah | Wisconsin | 54956-5904 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		
	And I enter below Additional Intrest details at ILM Location in PC9
		| Location | Interest_Type | AI_Name    | Is_Jeweler | Address_Line1       | City   | State     | ZipCode |
		| 1        | Loss Payee    | JBP08ILMAI | yes        | 24 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I navigate to BO Locations
	And I enter below Additional Intrest details at BOP Location in PC9
		| Location | Interest_Type                                       | AI_Name   | Is_Jeweler | Address_Line1 | City   | State     | ZipCode |
		| 1        | Additional Named Insured (Liability Coverages Only) | JBP08BOAI | no         | 101 Main St   | Neenah | Wisconsin | 54956   |
	And I enter below Additional Insured at BOP Location  Building in PC9
		| Location | Interest_Type | FirstName    | LastName  | Address_Line1       | City   | State     | ZipCode |
		| 1        | Mortgagee     | JBP08BOBldAI | Mortgagee | 48 Jewelers Park Dr | Neenah | Wisconsin | 54956   |
	And I navigate to BO Locations
	And I Click Next on Business Owners Locations Page in PC9
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
	| UmbrellaLimit | SelfInsuredRetention |
	| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for Plcy Renewal
	And I click Quote and Issue policy Renewal
		| RenewalCode       |
		| Renew - good risk |
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm2
@jbp
@jbp9a
@regression
Scenario Outline: JBP_TS09a_NB_BD_Manual_Renewals_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP09aNBMultiple4PaySCUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1          | City      | State          | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 725 Cherry Rd Ste 169 | Rock Hill | South Carolina | 29732-3152 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-333 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1     | City  | State    | ZipCode    | Country                  |
		| 216 Crawford Ave | Dixon | Illinois | 61021-3136 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
		| 2   | 100,000        | 12/12/2016 | 4,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 4 Pay           |
	Then I Issue CL policy for after handling UW issues
	And I Logout of the Policy Center application

	#Policy Center - Policy Renew
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType   |
		| Renew Policy |
	And I click next on CL Offerings Page 
	And I click next on line selection page in PC9 and verify Plcy info page
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Other    |               |              |                    |               |
	And I Add below HotelMotel Coverage on ILM Line in PC9
		| Premium |
		| 400     |
	And I add below ShowCases Windows coverage with below details in PC9
		| ShowcaseLocationName        | ShowcaseAddress        | ItemDesc                  | ShowcaseLimit | ShowcaseDeductible |
		| Regression Testing Location | 1467 Tullar Rd, Neenah | Many items All Regression | 30,000        | 1,000              |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I enter below Stockpeak details in PC9
		| Location | SteakPeak_Limit | SteakPeak_StartDate | SteakPeak_EndDate | SteakPeak_Deductible | SteakPeak_Recurring |
		| 2        | 200,000         | SYSTEMDATE+40       | SYSTEMDATE+60     | 1,000                | No                  |
	And I add below new ILM location on PC9
		| AddressLine1       | City     | State     | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 3   | 100,000        | 12/12/2016 | 4,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
	And I navigate to BO Locations
	And I Click Next on Business Owners Locations Page in PC9
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	#And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	#And I click Quote on Risk Analysis Pages and verify for clear button for PolicyRenew
	#And I click Quote on Risk Analysis Page for Plcy Renewal
	#And I click Quote and Issue policy Renewal
	#	| RenewalCode       |
	#	| Renew - good risk |
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	Then I click Quote and Issue policy renew
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm2
@jbp
@jbp9b
@regression
Scenario Outline: JBP_TS09b_NB_BD_UMB_Manual_Renewals_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP09bNBMultiple8PayGAUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City       | State   | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 316 Pebble Ln | Blue Ridge | Georgia | 30513-3185 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-300 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1            | City      | State         | ZipCode    | Country                  |
		| 1663 Lenwood Ave Apt 20 | Green Bay | West Virginia | 54303-5315 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 2,000,000     |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 3,000,000     |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Renew
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType   |
		| Renew Policy |
	And I click next on CL Offerings Page 
	And I remove UMB line on line selection page in PC9 for plcy Renew
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		|          |               |              |                    |               |
	And I add Tradeshows with below details on ILM Off Premise Coverages tab
		| CoverageName                  | Tradeshow_City | Tradeshow_State | HowMerch_Transported | Transit_Days | Recurring | Limit   | Deductible | TempReason |
		| Tradeshows - To/From/While At | New York       | New York        | Approved Individual  | 2            | false     | 200,000 | 2,500      | No         |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I delete below ILM Location
		| Location |
		| 2        |
	And I navigate to BO Locations
	And I Click Next on Business Owners Locations Page in PC9
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for Plcy Renewal
	And I click Quote and Issue policy Renewal
		| RenewalCode       |
		| Renew - good risk |
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm6
@jbp
@jbp10
@regression
Scenario Outline: JBP_TS10_NB_PolicyChng_Locs_Bldgs_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName           |
		| JBP10NBMulti8PayCTUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1 | City    | State       | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 3 Sypher Rd  | Chester | Connecticut | 06412-1010 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 90%               | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 10711 Shallowbrook Ln   | Houston       | Texas | 77024   | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 200,000       |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 2 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Add 3rd ILM Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Add Location     | Add Location         |
	And I Enter below location to add new ILM Location
		| Location |
		| 3        |
	And I add below new ILM location on PC9
		| AddressLine1      | City  | State   | ZipCode | Country                  |
		| 1016 W Flagler St | Miami | Florida | 33130   | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 3   | 100,000        | 12/12/2016 | 3000000       | 10,000         | 10,000     | 100           | 10,000,000    |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Add 3rd BO Location and 3 buildings for 3rd Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Add Location     | Add Location         |
	And I Enter below location to add new BO Location
		| Location |
		| 3        |
	And I navigate to BO Locations
	And I click on New Location on BO Locations Page
	And I add below details for new BO Location in PC9
		| AddressLine1 | City     | State    | ZipCode    | Country                  | RetailPercent | CastingPercent | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | BOPPackageLevel |
		| 160 Broadway | New York | New York | 10038-4201 | United States of America | 100           | 100            | 1           | 2           | 3                | Strip mall   | Silver          |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 3        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 3        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 3        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Delete 1st ILM Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory                   |
		| SYSTEMDATE+10       | Permanent Change | Delete Location  | Delete Location - One Line of Business |
	And I Enter below location to delete ILM Location
		| Location | Offering       |
		| 1        | Jewelers Block |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

	#Policy Center - Policy Change - Delete 1st BO Location, including its Building
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory                   |
		| SYSTEMDATE+21       | Permanent Change | Delete Location  | Delete Location - One Line of Business |
	And I Enter below location to delete BO Location
		| Location | Offering       | SetActiveLoc | BldgToDelete |
		| 1        | Businessowners | 2            | 1            |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Employee Dishonesty from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 1000   |
	And In CC9 I select Workplan from the left navigation menu
	Then In CC9 I verify below Activity
	| ActivitySubject                | VerifyButton |
	| Review and approve new payment | Approve      |
	And I Logout of the Claim Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm2
@jbp
@jbp11
@regression
Scenario Outline: JBP_TS11_NB_OOS_Change_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP11NBMultiple12PayVTUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1        | City       | State   | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 11 Elmwood Ave Lbby | Burlington | Vermont | 05401-5799 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1                   | City         | State   | ZipCode    | Country                  |
		| 2245 Kessler Boulevard East Dr | Indianapolis | Indiana | 46220-2404 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
		| 2   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Billing Center Invoice Validation
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select summary from left navigation menu 	
	And I validate 12 pay  for the Policy	
	And I select invoices from left navigation menu	
	Then I verify the current and scheduled invoice payments for 12 pay 	
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#Policy Center - Policy Change - add/increase Stock Peak
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I enter below details for Policy change OOS in PC9 for SYSTEMDATE
		| ChangeReason          | ChangeReasonNext | ChangeReasonCategory                      | Integer1 | Integer2 | Integer3 | ShortText1  | ShortText2 | MediumText1               |
		| Temporary Endorsement | Shipment Change  | Shipment inside the territory - Specified | 200000   | 200000   | 2000     | Fed Ex      |            | 2                         |
		| Temporary Endorsement | Shipment Change  | Shipments Outside Territory               | 200000   | 2000     |          | Fed Ex      | USA        | 2                         |
		| Temporary Endorsement | Travel Change    | Travel in Territory                       | 200000   | 2000     |          | Traveller 1 | Exhibit    |                           |
		| Temporary Endorsement | Other Reason     | Other                                     |          |          |          |             |            | All Other Reasons Go Here |
	And I add below Temp Coverages in PC9
		| TempCoverage                |
		| Off Premise Travel          |
		| Shipments Inside Territory  |
		| Shipments Outside Territory |
		| All Other                   |
	Then I click Quote and Issue policy change
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm3
@jbp
@jbp12a
@regression
Scenario Outline: JBP_TS12a_NB_Blankets_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                     |
		| JBP12aNBMultiLocBlank2PayVA_USA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1      | City    | State    | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 13520 Mclearen Rd | Herndon | Virginia | 20171-3234 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |
	And I enter below ILM Blanket details on ILM Line page in PC9
		| StockLimit | Premium |
		| 500000     | 1200    |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1       | City     | State     | ZipCode    | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186-2725 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
		| 2   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | No        | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I add building coverage for below details
		| Location | Building |
		| 1        | 1        |
	And I Click Next on BO Location Building Page in PC9
	And I add a Blanket with Below details in PC9
		| BOP_Blanket_Type | BOP_Blanket_GroupType | 
		| Single Location  | Bldg/BPP              | 
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 2 Pay           |
	Then I Issue CL policy for after handling UW issues
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@jbp
@jbp12b
@regression
Scenario Outline: JBP_TS12b_NB_BD_Renewal_AddBlankets_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBP12bNBBDSingle4PayMNUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1      | City        | State     | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 638 Ontario St SE | Minneapolis | Minnesota | 55414-3118 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-300 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2          | 1          | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 3,000,000     | 10,000         | 10,000     | 100           | 10,000,000    |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 2 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center: Policy Renewal
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType   |
		| Renew Policy |
	And I click next on CL Offerings Page 
	And I click next on line selection page in PC9 and verify Plcy info page
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		|          |               |              |                    |               |
	And I enter below ILM Blanket details on ILM Line page in PC9
		| StockLimit | Premium |
		| 500000     | 1200    |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I navigate to BO Locations
	And I Click Next on Business Owners Locations Page in PC9
	And I add building coverage for below details
		| Location | Building |
		| 1        | 1        |
	And I Click Next on BO Location Building Page in PC9
	And I add a Blanket with Below details in PC9
		| BOP_Blanket_Type | BOP_Blanket_GroupType | 
		| Single Location  | Bldg/BPP              | 		
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for Plcy Renewal
	And I click Quote and Issue policy Renewal
		| RenewalCode       |
		| Renew - good risk |
	And I Logout of the Policy Center application


Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |


@vm2
@jbp
@jbp13
@regression
Scenario Outline: JBP_TS13_FL_Surcharge
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName               |
		| JBPFLSurcharge |
	And I enter below mandatory details on create account page for CL
		| AddressLine1   | City        | State   | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 402 Lutie Dr   | Valrico     | Florida | 33594-2924 | United States of America | Other       | LLC     | Yes       | T05D         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE+100 |              |                    |               |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I add below new ILM location on PC9
		| AddressLine1            | City      | State         | ZipCode    | Country                  |
		| 1663 Lenwood Ave Apt 20 | Green Bay | West Virginia | 54303-5315 | United States of America |
	And I enter below ILM location info details in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 2,000,000     |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 3,000,000     |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Silver level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I click on Add All Existing Locations in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
		| 2        |
	And I Click Next on Business Owners Locations Page in PC9
	And I add below Building details for each BO Location in PC9
		| Location | AddILMLoc | BldCodeEffGrade | TheftExec | BandLIndicator | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 1        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
		| 2        | Yes       | 2               | No        | No             | Frame            | 2000              | 1000         | 90%               | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


	#Billing Center Charges	
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu	
	Then I Should see the taxes:umb:jbp;taxes:umb:jbp;taxes:im:jbp;taxes:bop:jbp;taxes:bop:jbp;premium:umb:jbp;premium:im:jbp;premium:bop:jbp;policyfee:im:jbp;policyfee:bop:jbp value displayed	
	And I Logout of the Billing Center application	
	And I Kill Web Driver



Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |



@vm3
@js
@js1
@regression
Scenario Outline: JS_TS01_NB_StandardCancel_Reinstate_Change_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                     |
		| JS01NBCancelReinstate12PayMDUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1      | City          | State    | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 11431 Amherst Ave | Silver Spring | Maryland | 20902-9997 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering          |
		| Jewelers Standard |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 100,000       | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 100,000       | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              |               |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	#Policy Center - Policy Reinstate
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType       |
		| Reinstate Policy | 
	And I enter below details for policy reinstatement
		| Reason           |
		| Payment received |
	And I click Quote and Issue Policy Reinstatement
	Then I Logout of the Policy Center application
	
	#Policy Center - Policy Change - Add 3rd ILM Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Add Location     | Add Location         |
	And I Enter below location to add new ILM Location
		| Location |
		| 3        |
	And I add below new ILM location on PC9
		| AddressLine1                 | City          | State    | ZipCode | Country                  |
		| 2445 Lyttonsville Rd Apt 803 | Silver Spring | Maryland | 20910   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 3   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 100,000       | 100,000         |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application
	
	
	#Billing Center Payment Plan Change
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select details from left navigation menu 	
	And I select PolicyNumber from Account Details Screen 	
	And I select payment schedule from left navigation menu 	
	Then I change 4 Pay - Quarterly in Change Payment Plan Page 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver
	
	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Stock-AOP from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And I Logout of the Claim Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm4
@js
@js2
@regression
Scenario Outline: JS_TS02_NB_FlatCancel_Rewrite_FullTerm_USA_Claim
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                   |
		| JS02NBFCancelRewrite8PayNJUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1 | City        | State      | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 44 Spruce St | Jersey City | New Jersey | 07306-3565 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering          |
		| Jewelers Standard |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 100,000       | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 100,000       | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


	#Billing Center Charges	
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu	
	Then I Should see the taxes:im:js;premium:im:js;policyfee:im:js value displayed	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Billing Center Disbursements 	
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select new payment:new direct bill payment from actions menu 	
	And I make a direct bill payment of 100 	
	And I select new transaction:disbursement from actions menu 	
	And I make a disburse payment of 10 for Overpayment 	
	And I select disbursements from left navigation menu 	
	Then I Verify 10 status is Approved in Disbursements table 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Billing Center Payment Plan Change
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select details from left navigation menu 	
	And I select PolicyNumber from Account Details Screen 	
	And I select payment schedule from left navigation menu 	
	Then I change 12 Pay in Change Payment Plan Page 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver


	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              |               |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application
	
	#Policy Center - Policy RewriteFullTerm
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType              |
		| Rewrite Fullterm Policy |  
	And I click Quote and Issue policy RewriteFullTerm for JS
	Then I Logout of the Policy Center application

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Stock-Fire from the New exposure page
	And In CC9 I Select Stock-AOP from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (2)      | Indemnity | Indemnity Category | 5000                 |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 400    |
	| Insured          | Claimant         | Subrogation Cost    | A&O Expense        | Partial     | no              | 300    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome     | ForceClose | ClaimStatus |
	| Selenium Test Note | No coverage | Yes        | Open        |
	And In CC9 I Pick Recovery from the Actions menu
	And I create recovery with below details
	| RecoveryCategory | Comments | Payer   | Reserveline | PaymentMethod | Amount | Email                        | Credit_Card_No   | CVV | ExpiryDateMonth | ExpiryDateYear | Card_Holder_Name  |
	| Deductible       | 10000    | Insured | Indemnity   | Credit Card   | 125    | itqaautomation@jminsure.com | 5454545454545454 | 100 | 01 - January    | 2022           | Selenium Recovery |
	And I Logout of the Claim Center application


Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |
@js
@js3
Scenario Outline: JS_TS03_Verify_PC_Send_Submission_Payload_When_CL_Submission_Issued_136898
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
    And I manage Transport with below status
	| Status  |
	| Suspended |
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                   |
		| JS03SubmissionVerify |
	And I enter below mandatory details on create account page for CL
		| AddressLine1 | City        | State      | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 44 Spruce St | Jersey City | New Jersey | 07306-3565 | United States of America | Other       | LLC     | Yes       | DIRD         |rparas@jminsure.com      |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering          |
		| Jewelers Standard |
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE    |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 100,000       | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page and verify Risk analysis screen in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I verify below payload
	| Type |
	| Submission   |
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |
@vm5
@jsp
@jsp1
@regression
Scenario Outline: JSP_TS01_NB_FlatCancel_Reinstate_Change_USA_Claim
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JSP01NBSingle2PayWVUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City        | State         | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 2105 Gihon Rd | Parkersburg | West Virginia | 26101   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB with modifier
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 2 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Billing Center Invoice Validation
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select summary from left navigation menu 	
	And I validate 2 Pay - Semi Annually  for the Policy	
	And I select invoices from left navigation menu	
	Then I verify the current and scheduled invoice payments for 2 Pay - Semi Annually 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver


	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	#Policy Center - Policy Reinstate
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType       |
		| Reinstate Policy | 
	And I enter below details for policy reinstatement
		| Reason           |
		| Payment received |
	And I click Quote and Issue Policy Reinstatement
	Then I Logout of the Policy Center application

	#Policy Center - Policy Change - Add 3rd ILM Location
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	And I save Location address in SC Dictionary object
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I Enter below details for policy change in PC9
		| ChangeEffectiveDate | ChangeReason     | ChangeReasonNext | ChangeReasonCategory |
		| SYSTEMDATE          | Permanent Change | Add Location     | Add Location         |
	And I Enter below location to add new ILM Location
		| Location |
		| 3        |
	And I add below new ILM location on PC9
		| AddressLine1      | City  | State   | ZipCode | Country                  |
		| 1016 W Flagler St | Miami | Florida | 33130   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 3   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
	And I click Quote and Issue policy change
	And I Logout of the Policy Center application
	
	#Claim Center

	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and commerciallinequickclaim on the policy search page
	And In CC9 I Enter below CL claim details on the Basic Information page
	| ReportedByName | RelatedToInsured | Description      | LossCause | SecondaryLossCause | IncidentOnly | CoverageInQuestion | DateOfNotice       |
	| Insured        | Insured          | Test Description | Fire      |                    | No           | No                 | TESTINGSYSTEMCLOCK |
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Employee Dishonesty from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Pick Reserve from the Actions menu
	And In CC9 I set below Reserves for CL Policy
	| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
	| (1)      | Expense   | A&O Expense        | 500                  |
	| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact for CL Claim
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Adjuster      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick create from template from the Actions menu
	And In CC9 I create a new document with below details
	| DocumentTemplate  | SendTo  |
	| Agent_Loss_Notice | Insured |
	And In CC9 I select Documents from the left navigation menu
	#And In CC9 I verify that the document is created
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory            | ReserveLine | PaymentType | AddtoDeductible | Amount |
	| Insured          | Other            | Indemnity                      | Indemnity Category         | Partial     | no              | 100    |
	| Insured          | Other            | Litigation Management Expenses | D&CC Expense         | Partial     | no              | 10     |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome     | ForceClose | ClaimStatus |
	| Selenium Test Note | No coverage | Yes        | Closed      |
	And In CC9 I Pick Reopen Claim from the Actions menu
	And In CC9 I enter below details to reopen claim
	| Note                                         | Reason               |
	| This claim has been reopened - Selenium Test | Supplemental Payment |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for CL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category         | Supplement  | no              | 80     |
	And I Logout of the Claim Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm2
@jsp
@jsp2
@regression
Scenario Outline: JSP_TS02_NB_ST_Change_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JSP01NBSingle2PayWVUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1     | City  | State    | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 216 Crawford Ave | Dixon | Illinois | 61021-3136 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1       | City     | State     | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Pages and verify for clear button for UMB with modifier
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | Annual Pay      |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Billing Center Invoice Validation
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select summary from left navigation menu 	
	And I validate Annual pay  for the Policy	
	And I select invoices from left navigation menu	
	Then I verify the current and scheduled invoice payments for Annual pay 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Policy Center - Policy Change - add/increase Stock Peak
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Change Policy | 
	And I enter below details for Policy change OOS in PC9 for SYSTEMDATE
		| ChangeReason          | ChangeReasonNext | ChangeReasonCategory                      | Integer1 | Integer2 | Integer3 | ShortText1  | ShortText2 | MediumText1               |
		| Temporary Endorsement | Shipment Change  | Shipment inside the territory - Specified | 200000   | 200000   | 2000     | Fed Ex      |            | 2                         |
		| Temporary Endorsement | Shipment Change  | Shipments Outside Territory               | 200000   | 2000     |          | Fed Ex      | USA        | 2                         |
		| Temporary Endorsement | Travel Change    | Travel in Territory                       | 200000   | 2000     |          | Traveller 1 | Exhibit    |                           |
		| Temporary Endorsement | Other Reason     | Other                                     |          |          |          |             |            | All Other Reasons Go Here |
	And I add below Temp Coverages in PC9
		| TempCoverage                |
		| Off Premise Travel          |
		| Shipments Inside Territory  |
		| Shipments Outside Territory |
		| All Other                   |
	Then I click Quote and Issue policy change
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@jsp
@jsp3
@regression
Scenario Outline: JSP_TS03_NB_FlatCancel_Rewrite_FullTerm_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JSP03NBSingle4PayCAUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1             | City   | State      | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 4833 Butternut Hollow Ln | Bonita | California | 91902   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 4 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason               | ReasonMethod | CancelEffDate |
		| Carrier | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@vm1
@jsp
@jsp4
@regression
Scenario Outline: JSP_TS04_NB_FlatCancel_Rewrite_NewTerm_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JSP04NBBD12PayNYUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1     | City   | State    | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 1544 Central Ave | Albany | New York | 12205-5048 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-325 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason                    | ReasonMethod | CancelEffDate |
		| Insured | Competition - Self Insure |              | SYSTEMDATE-1  |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application

	#Billing Center make direct Payment
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 146501
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#Policy Center - Policy Rewrite New Term
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType            |
		| RewriteNewTerm Policy |
	And I click next on CL Offerings Page 
	And I click next on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	#And I click next on Policy Info Page for Jewelers Standard Pak
	And I click Quote and Issue policy RewriteNewTerm
	Then I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm2
@jsp
@jsp5
@regression
Scenario Outline: JSP_TS05_NB_FlatCancel_Rewrite_NewTerm_JBP
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JSP05NBBD12PayGAUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1  | City       | State   | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 316 Pebble Ln | Blue Ridge | Georgia | 30513-3185 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-150 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Billing Center Charges	
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu	
	Then I Should see the premium:umb:jsp;premium:im:jsp;premium:bop:jsp value displayed	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Billing Center Disbursements 	
	Given I access the Guidewire BC on <Target> in <Browser> 	
	And I enter bcmanager and bcmanagerpwd on the BC Login page 	
	When I select Search from the Tab menu 	
	And search for account with REGISTRY and select from search results 	
	And I select new payment:new direct bill payment from actions menu 	
	And I make a direct bill payment of 100 	
	And I select new transaction:disbursement from actions menu 	
	And I make a disburse payment of 10 for Overpayment 	
	And I select disbursements from left navigation menu 	
	Then I Verify 10 status is Approved in Disbursements table 	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason                    | ReasonMethod | CancelEffDate |
		| Insured | Competition - Self Insure |              | SYSTEMDATE-1  |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application


	#Billing Center direct bill payment
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 71393
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#Policy Center - Policy Rewrite New Term - Change LOB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType            |
		| RewriteNewTerm Policy |
	And I select below offering on the Offerings Page in PC9
		| Offering           |
		| Jewelers Block Pak |
	And I add UMB line on line selection page in PC9 for JSP
	And I enter no for all questions on qualification page in PC9
	And I click next on Policy Info Page for Jewelers Block Pak
	And I add below Property Otherwise Away Limit on ILM Line
	| PropOtherAwayLimit | AvgDayilyLimit | GdsAtJwlrExposure |
	| 500                | 500            | 500               |
	And I select the 1 location from existing locations in PC9
	And I enter below Safes Vaults and Stockroom details
	| TotalLocationInSafe | BankVault |
	| 50                  | 30        |
	And I select the 2 location from existing locations in PC9
	And I enter below Safes Vaults and Stockroom details
	| TotalLocationInSafe | BankVault |
	| 50                  | 30        |
	And I navigate to BO Locations
	And I Click Next on Business Owners Locations Page in PC9
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
	| UmbrellaLimit | SelfInsuredRetention |
	| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote and Issue policy RewriteNewTerm
	Then I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |

@vm1
@jsp
@jsp6
@regression
Scenario Outline: JSP_TS06_NB_Renew_MultipleChanges
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JSP06NBBD8PayTNUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1    | City      | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 1729 Mallory Ln | Brentwood | Tennessee | 37027   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-300 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 20,000,000    | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 20,000,000    | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 8 Pay           |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application


	#Policy Center - Policy Renew
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType   |
		| Renew Policy |
	##And I click on Edit Work Order For Policy Renewal in PC9
	And I click next on CL Offerings Page 
	And I click next on line selection page in PC9 and verify Plcy info page
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Other    |               |              |                    |               |
	And I add below ShowCases Windows coverage with below details in PC9
		| ShowcaseLocationName        | ShowcaseAddress        | ItemDesc                  | ShowcaseLimit | ShowcaseDeductible |
		| Regression Testing Location | 1467 Tullar Rd, Neenah | Many items All Regression | 30,000        | 1,000              |
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I add below new ILM location on PC9
		| AddressLine1        | City   | State     | ZipCode | Country                  |
		| 1155 Winneconne Ave | Neenah | Wisconsin | 54956   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 3   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 100,000       | 10,000          |
	And I navigate to BO Locations
	And I Click Next on Business Owners Locations Page in PC9
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for Plcy Renewal
	And I click Quote and Issue policy Renewal
		| RenewalCode       |
		| Renew - good risk |
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |


@vm1
@jsp
@jsp7
@regression
Scenario Outline: JSP_TS07_NB_Pro_Rate_Cancel_Cancelfee
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	When I select below Action type from Actions menu
		| ActionType  |
		| New Account |
	And I search for commercial account with below company name in PC9
		| CompanyName                 |
		| JSP07NBBD12PayNYUSA |
	And I enter below mandatory details on create account page for CL
		| AddressLine1     | City   | State    | ZipCode    | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
		| 1544 Central Ave | Albany | New York | 12205-5048 | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select below Action type from Actions menu
		| ActionType     |
		| New Submission |
	And I enter below details on CL New submission page
		| PolicyEffDate | Product          |
		| SYSTEMDATE+0  | Commercial Lines |
	And I select below offering on the Offerings Page in PC9
		| Offering              |
		| Jewelers Standard Pak |
	And I add UMB line on line selection page in PC9
	And I enter no for all questions on qualification page in PC9
	And I enter below Policy Info Details in PC9
		| TermType | PolicyEffDate  | ProducerCode | TerrorismSelection | PolicyExpDate |
		| Annual   | SYSTEMDATE-20 |              |                    |               |	
	And I enter Inland marine details on the Inland Marine line page in PC9
	And I select the 1 location from existing locations in PC9
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | 
		| 100              | 100               | 2           | 1           | 3                | Strip mall   | Frame            | 2000              | 1000         | 90%               | No             | Testing    | No           | 
	And I add below new ILM location on PC9
		| AddressLine1    | City           | State | ZipCode | Country                  |
		| 2400 Springdale Rd | Waukesha | Wisconsin | 53186   | United States of America |
	And I enter below ILM location info details for Jewelers Standard in PC9
		| SegmentationCode | GenBusinessRetail | FullTimeEmp | PartTimeEmp | PublicProtection | LocationType | ConstructionType | TotalBuildingArea | AreaOccupied | PercentSplinkered | SharedPremises | SharedWith | BurglarAlarm | TotalLocationInSafe | BankVault |
		| 100              | 100               | 2           | 1           | 2                | Strip mall   | Frame            | 10000             | 9000         | 100%              | No             | Testing    | No           | 50                  | 30        |
	And I Enter Below Jewelry Stock Information for JS in PC9
		| Loc | RecentInventry | TakenOn    | MaxStockValue | AvgAmtCustProp | AvgAmtMemo | LooseDiamonds | StockAOPLimit | StockOutOfLimit |
		| 1   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
		| 2   | 100,000        | 12/12/2016 | 100,000       | 10,000         | 10,000     | 100           | 10,000,000    | 100,000         |
	And I Click Next on ILM Location Page on PC9
	And I Click Next on Modifiers Page on PC9
	And I Click Next on Line Review Page for ST on PC9
	And I Enter Platinum level on Business Owners Line Page in PC9
	And I Click Next on Business Owners Lines Page in PC9
	And I add territory code by state for below locations
		| Location |
		| 1        |
	And I Click Next on Business Owners Locations Page in PC9
	And I Click on Add ILM Location Building in PC9
	And I add below Location details in PC9
		| BldCodeEffGrade | TheftExec | BandLIndicator | BPPLimit | BurglarAlarm | ExtProt | FireAlarm | OtherProtSafe |
		| 2               | No        | No             | 10,000   | Local Alarm  | Yes     | Yes       | No            |
	And I Click Next on BO Location Building Page in PC9
	And I Click Next on Bldg Blankets Page in PC9
	And I Click Next on Bldg Modifiers Page in PC9
	And I Click Next on Bldg Line Review Page for ST in PC9
	And I Enter below Umbrella Line Coverage Details in PC9
		| UmbrellaLimit | SelfInsuredRetention |
		| 1,000,000     | 0                    |
	And I Click Next on Umbrella Modifiers Page in PC9
	And I select No for all and Click Next on Umbrella Underwriting Page in PC9
	And I Click Next on Umbrella Line Review Page in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details to select Payment plan
		| BilingMethod | InstallmentPlan |
		| Direct Bill  | 12 Pay          |
	Then I Issue CL policy for after PaymentPlan Selection
	And I Logout of the Policy Center application

	#Policy Center - Policy Cancel
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I search and select for REGISTRY policy number in PC9
	When I select below Action type from Actions menu
		| ActionType    |
		| Cancel Policy | 
	And I start Cancel policy with below details
		| Source  | Reason                    | ReasonMethod | CancelEffDate |
		| Insured | Competition - Self Insure |              | SYSTEMDATE-1  |
	And I click Quote and Issue policy Cancel
	Then I Logout of the Policy Center application


	#Billing Center Charges	
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu	
	Then I Should see the premium:umb:jsp;premium:im:jsp;premium:bop:jsp;premium:umb:jsp;premium:im:jsp;premium:bop:jsp;cancelfee:umb:jsp;cancelfee:im:jsp;cancelfee:bop:jsp value displayed	
	And I Logout of the Billing Center application	
	And I Kill Web Driver


	

Examples: 
	| Application | Target  | Browser | UserName   | Password      |
	| PC          | Desktop | IE      | cldirector | cldirectorpwd |



