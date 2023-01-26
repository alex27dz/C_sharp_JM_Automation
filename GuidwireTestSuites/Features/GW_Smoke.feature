Feature: GW_Smoke

@gwsmoketest
@smoketest
@gwsmokepcPL
Scenario Outline: TS01_CreatePLPolicy
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I manage Transport with below status
	| Status  |
	| Started |
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 1981 Kings Rd | Jacksonville | Florida | 32209   | United States of America | Mailing     | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I manage Transport with below status
	| Status  |
	| Started |
	And I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 1981 Kings Rd | Jacksonville | Florida | 32209   | United States of America | Mailing     | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I add below Additional Insured details with unique name in PC9
	| AddType   | CompanyName | IsJeweler | FirstName   | LastName   | AddrLine1      | City     | State     | ZipCode |
	| NewPerson | SmokeTest   | Yes       | AIFirstName | AILastName | 955 Mutual Way | Appleton | Wisconsin | 54913   |
	And I enter the details on the policy information page in PC9
	And I Add Jewelry item in PC9 with <LocatedWith> , <Class> , <ValueOfItem> , <Deductible>
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | Annual Pay      |
	Then I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       | FirstName | LastName | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible |
	| PC          | Desktop | IE      | pluwmanager | pluwmanagerpwd | Personal  | Smoke    | SYSTEMDATE+0  |         | No                   | No           | No               | REGISTRY    | Brooch | 1000        | 100        |



@gwsmoketest
@smoketest
@gwsmokepcCL	
Scenario Outline: TS02_Create CL BlockPak Policy
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I manage Transport with below status
	| Status  |
	| Started |
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for commercial account with below company name in PC9
	| CompanyName       |
	| Selenium CL Smoke |
	And I enter below mandatory details on create account page for CL
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 1981 Kings Rd | Jacksonville | Florida | 32209   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I Set Territory code 009 for Location in PC9
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
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 12 Pay          |
	Then I Issue the CL policy for ST in PC9
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |

@gwsmoketest
@smoketest
@gwsmokeCCcl	
Scenario Outline: TS03_Create Claim
	Given I access the Guidewire <Application> on <Target> in <Browser>
    And I enter <UserName> and <Password> on the Login page of CC9
	#And In CC9 I set the authority profile limit of <UserName> to <Profile>
	#And In CC9 I set passwords and authority profiles for below users
	#| CCUserName | CCPassword | CCProfile |
	#| mvangomp   | gw         | CEO       |
	#| lvancuyk   | gw         | CEO       |
    And In CC9 I navigate to the Claim:New Claim Page
    When In CC9 I Search for the <PolicyNumber> on Policy Search Page
    And In CC9 I Enter the <LossDate> and <TypeOfClaim> on the policy search page
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
    And In CC9 I verify CM CC integration for Insured
    And In CC9 I Add a new contact for CL Claim
    | ContactType    | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
    | Vendor:Jeweler | Jeweler     | SeleniumFname | SeleniumLname | 213121334 | Unique      |
    ##And In CC9 I Pick create from template from the Actions menu
    ##And In CC9 I create a new document for <Name>
    ##And In CC9 I select Documents from the left navigation menu
    ##Then In CC9 I verify that the document is created
    And In CC9 I Pick Check from the Actions menu
    And I Enter below payment information for CL Claim
    | PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
    | Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
    And In CC9 I Pick Close Claim from the Actions menu
    Then In CC9 I close the claim with below details and Verify its status
    | Note               | OutCome           | ForceClose | ClaimStatus |
    | Selenium Test Note | Payments Complete | Yes        | Closed      |
    And I Logout of the Claim Center application


	Examples: 
	| Application | Target  | Browser | UserName    | Password       | Profile | PolicyNumber | LossDate | TypeOfClaim              | Description      | LossCause | AssignClaim              | NewExposureCoverage | Name    | RelatedToInsured | AssginedClaim            |
	| CC          | Desktop | IE      | ccclmanager | ccclmanagerpwd | CEO     | REGISTRY     | CURRENT  | commerciallinequickclaim | Test Description | Fire      | Use automated assignment | Employee Dishonesty | Default | Insured          | Use automated assignment |
	
@gwsmoketest
@smoketest
@gwsmokebcclACH
	Scenario Outline: TS04_BC_ACH Payment and Reversal
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the BC Login page
	When I select Search from the Tab menu
	And search for account with <AccountNumber> and select from search results
	And I fetch country name and total amount due
	And I select new payment:Payment Request from actions menu
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>
	And I select payment wallet from left navigation menu
	And I remove the stored payment methods for smoketest
	And I select Payments:Payment History from left navigation menu for smoketest
	Then I verify <ACH> payment methods for smoketest
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversal
	And I Logout of the Billing Center application
	And I Kill Web Driver
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | IE      | bcmanager | bcmanagerpwd | TotalDue      | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |


	
@gwsmoketest
@smoketest
@gwsmokebcclCC
	Scenario Outline: TS05_BC_CC Payment and Reversal
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the BC Login page
	When I select Search from the Tab menu
	And search for account with <AccountNumber> and select from search results
	And I fetch country name and total amount due
	And I select new payment:Payment Request from actions menu
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>
	And I select Payments:Payment History from left navigation menu for smoketest
	Then I verify <CCType> payment methods for smoketest
	And I select Payments:Payments from left navigation menu for smoketest
	And I Logout of the Billing Center application
	And I Kill Web Driver

	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate        | AccountNumber |
	| BC          | Desktop | IE      | bcmanager | bcmanagerpwd | TotalDue      | VISA   | TESTINGSYSTEMCLOCK+1 | REGISTRY      |

@gwsmoketest
@smoketest
@ts06CMCreateContact
	Scenario Outline: TS06_CM_CreateContact
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the CM Login page
	And I click search on Contacts Tab
	And I verify below search details on search page
	| ContactType | FirstName | LastName | CompanyName |
	| Jeweler     |           |          | REGISTRY    |
	And I Logout of the Claim Center application

	Examples: 
	| Application | Target  | Browser | UserName  | Password     |
	| CM          | Desktop | IE      | cmmanager | cmmanagerpwd |


@jenkinsgwsmoketestPL	
Scenario Outline: TS07_CreatePLPolicy_Jenkins
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I manage Transport with below status
	| Status  |
	| Started |
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 1981 Kings Rd | Jacksonville | Florida | 32209   | United States of America | Mailing     | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I add below Additional Insured details with unique name in PC9
	| AddType   | CompanyName | IsJeweler | FirstName   | LastName   | AddrLine1      | City     | State     | ZipCode |
	| NewPerson | SmokeTest   | Yes       | AIFirstName | AILastName | 955 Mutual Way | Appleton | Wisconsin | 54913   |
	And I enter the details on the policy information page in PC9
	And I Add Jewelry item in PC9 with <LocatedWith> , <Class> , <ValueOfItem> , <Deductible>
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | Annual Pay      |
	Then I Issue the PL Smoke test policy in PC9
	And I Logout of the Policy Center application
	And I Kill Web Driver

#	#ClaimCenter
#	Given I access the Guidewire CC on <Target> in <Browser>
#	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
#	And In CC9 I set the authority profile limit of <UserName> to CEO
#	And In CC9 I navigate to the Claim:New Claim Page
#	When In CC9 I Search for the REGISTRY on Policy Search Page
#	And In CC9 I Enter the CURRENT and Property on the policy search page
#	And In CC9 I Enter the Default , Agent on the Basic Information page
#	And In CC9 I Enter the Test Description and Fire on the Claim Information Page
#	And In CC9 I Enter the Auto Assign to the Claim and Finish the Application
#	And In CC9 I Pick Assign Claim from the Actions menu
#	And In CC9 I Assign the claim to Use automated assignment
#	And In CC9 I Pick Assign Claim from the Actions menu
#	And IN CC9 I ReAssign the claim
#	And In CC9 I Pick New Exposure from the Actions menu
#	And In CC9 I Select Scheduled from the New exposure page
#	And In CC9 I click on return to Exposures
#	And In CC9 I Add Reserves
#	And In CC9 I select Parties Involved from the left navigation menu
#	And In CC9 I Add a new contact
#	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
#	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
#	And In CC9 I Pick create from template from the Actions menu
#	And In CC9 I create a new document with below details
#	| DocumentTemplate  | SendTo  |
#	| Agent_Loss_Notice | Insured |
#	And In CC9 I select Documents from the left navigation menu
#	And In CC9 I Pick Check from the Actions menu
#	And I Enter below payment information for PL Claim
#	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
#	| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 100    |
#	And In CC9 I select Workplan from the left navigation menu
#	And I Complete all Activities in workplan
#	And In CC9 I Pick Close Claim from the Actions menu
#	Then In CC9 I close the claim with below details and Verify its status
#	| Note               | OutCome           | ForceClose | ClaimStatus |
#	| Selenium Test Note | Payments Complete | Yes        | Closed      |
#	And I Logout of the Claim Center application
#
#	#Billing Center - ACH payment
#	Given I access the Guidewire BC on <Target> in <Browser>
#	And I enter bcmanager and bcmanagerpwd on the BC Login page
#	When I select Search from the Tab menu
#	And search for account with REGISTRY and select from search results
#	And I fetch country name and total amount due
#	And I select new payment:Payment Request from actions menu
#	And I pay premium of TotalDue using E-check with Checking on TESTINGSYSTEMCLOCK
#	And I select payment wallet from left navigation menu
#	And I remove the stored payment methods for smoketest
#	And I select Payments:Payment History from left navigation menu for smoketest
#	Then I verify ACH payment methods for smoketest
#	And I select Payments:Payments from left navigation menu for smoketest
#	And I perform payment reversal
#	And I Logout of the Billing Center application
#	And I Kill Web Driver
#
#	#Billing Center - CC payment
#	Given I access the Guidewire BC on <Target> in <Browser>
#	And I enter bcmanager and bcmanagerpwd on the BC Login page
#	When I select Search from the Tab menu
#	And search for account with REGISTRY and select from search results
#	And I fetch country name and total amount due
#	And I select new payment:Payment Request from actions menu
#	And I pay premium of TotalDue using Credit Card with VISA on TESTINGSYSTEMCLOCK+1
#	And I select Payments:Payment History from left navigation menu for smoketest
#	Then I verify VISA payment methods for smoketest
#	And I select Payments:Payments from left navigation menu for smoketest
#	And I Logout of the Billing Center application
#	And I Kill Web Driver

	#Contact Manager
	Given I access the Guidewire CM on <Target> in <Browser>
	And I enter cmmanager and cmmanagerpwd on the CM Login page
	And I click search on Contacts Tab
	And I verify below search details on search page
	| ContactType | FirstName | LastName | CompanyName |
	| Person      | REGISTRY  | REGISTRY |             |
	And I Logout of the Claim Center application
Examples: 
	| Application | Target  | Browser | UserName    | Password       | FirstName | LastName | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible |
	| PC          | Desktop | IE      | pluwmanager | pluwmanagerpwd | Personal  | Smoke    | SYSTEMDATE+0  |         | No                   | No           | No               | REGISTRY    | Brooch | 1000        | 100        |



@jenkinsgwsmoketestCL
Scenario Outline: TS08_CreateCLJBPPolicy_Jenkins
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I get the system date in PC9
	And I manage Transport with below status
	| Status  |
	| Started |
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for commercial account with below company name in PC9
	| CompanyName       |
	| Selenium CL Smoke |
	And I enter following mandatory details on create account page for commercial lines for ST in PC9
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 1981 Kings Rd | Jacksonville | Florida | 32209   | United States of America | Other       | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
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
	And I Set Territory code 009 for Location in PC9
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
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 12 Pay          |
	Then I Issue the CL policy for ST in PC9
	And I Logout of the Policy Center application
	And I Kill Web Driver

	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
    And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
    And In CC9 I set the authority profile limit of <UserName> to CEO
	And In CC9 I set passwords and authority profiles for below users
	| CCUserName | CCPassword | CCProfile |
	| mvangomp   | gw         | CEO       |
	| lvancuyk   | gw         | CEO       |
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
    And In CC9 I verify CM CC integration for Insured
    And In CC9 I Add a new contact for CL Claim
    | ContactType    | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
    | Vendor:Jeweler | Jeweler     | SeleniumFname | SeleniumLname | 213121334 | Unique      |
    #And In CC9 I Pick create from template from the Actions menu
    #And In CC9 I create a new document for <Name>
    #And In CC9 I select Documents from the left navigation menu
    #Then In CC9 I verify that the document is created
    And In CC9 I Pick Check from the Actions menu
    And I Enter below payment information for CL Claim
    | PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
    | Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
    And In CC9 I Pick Close Claim from the Actions menu
    Then In CC9 I close the claim with below details and Verify its status
    | Note               | OutCome           | ForceClose | ClaimStatus |
    | Selenium Test Note | Payments Complete | Yes        | Closed      |
    And I Logout of the Claim Center application

	#Billing Center - ACH payment
	Given I access the Guidewire BC on <Target> in <Browser>
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	When I select Search from the Tab menu
	And search for account with REGISTRY and select from search results
	And I fetch country name and total amount due
	And I select new payment:Payment Request from actions menu
	And I pay premium of TotalDue using E-check with Checking on TESTINGSYSTEMCLOCK
	And I select payment wallet from left navigation menu
	And I remove the stored payment methods for smoketest
	And I select Payments:Payment History from left navigation menu for smoketest
	Then I verify ACH payment methods for smoketest
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversal
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#Billing Center - CC payment
	Given I access the Guidewire BC on <Target> in <Browser>
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	When I select Search from the Tab menu
	And search for account with REGISTRY and select from search results
	And I fetch country name and total amount due
	And I select new payment:Payment Request from actions menu
	And I pay premium of TotalDue using Credit Card with VISA on TESTINGSYSTEMCLOCK+1
	And I select Payments:Payment History from left navigation menu for smoketest
	Then I verify VISA payment methods for smoketest
	And I select Payments:Payments from left navigation menu for smoketest
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#Contact Manager
	Given I access the Guidewire CM on <Target> in <Browser>
	And I enter cmmanagerpwd and cmmanagerpwd on the CM Login page
	And I click search on Contacts Tab
	And I verify below search details on search page
	| ContactType | FirstName | LastName | CompanyName |
	| Jeweler     |           |          | REGISTRY    |
	And I Logout of the Claim Center application


Examples: 
	| Application | Target  | Browser | UserName    | Password       |
	| PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd |


##@gwsmoketest
#@smoketest
#@ts09JPASmoke
#Scenario Outline: TS09_JPA_Smoke
#	Given I access the Guidewire <Application> on <Target> in <Browser>
#	And I enter <UserName> and <Password> on the Login page in PC9
#	And I get the system date in PC9
#	And I manage Transport with below status
#	| Status  |
#	| Started |
#	When I select below Action type from Actions menu
#	| ActionType  |
#	| New Account |
#	And I search for personal account in PC9 using <FirstName> and <LastName>
#	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
#	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
#	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
#	And I select New Submission from the Actions menu in PC9
#	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
#	And I enter below details on the policy information page in PC9
#	| Term  | PolicyEffDate | ProducerCode |
#	| Other |               |              |
#	And I update Alarm type  on the policy location page in PC9
#	| AlarmType        |
#	| Central Station|
#	And I update Safe details on the policy location page in PC9
#	| IsAnchred | Weight   |
#	| yes       | 0-100 lbs |
#	And I click next on the policy location page in PC9
#	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
#	 | deniedcoverage | reason       |
#	| No             |        |
#	And I click next on the  policy contact page in PC9
#	And I Update Unschedule details on personal articles page in PC9
#	| Unschedulelimit | UnscheduleDeductible |
#	| 5000            | 100                  |
#	And I Enter below Multi Article details on personal articles page in PC9
#	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
#	| self        | Ring    | Engagement     | Gents      | Yes          |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |           |              |               | No       |          |            |                      |                    |                         |               |                   |               |            |                       |
#	And I Click next on personal articles page in PC9
#	And I select Additional Details in Additional Details in PC9
#	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
#	| No               | Yes                | Yes                   |
#	#And I click next on the Risk Analysis in PC9
#	And I click Quote on Risk Analysis Page for ST in PC9
#	And I Click Next on Quote Page in PC9
#	And I check forms listed on Forms Page and click next in PC9
#	And I Issue the JPA Smoke test policy in PC9 
#	And I Logout of the Policy Center application
#	And I Kill Web Driver
#
#	#BillingCenter
#	Given I access the Guidewire BC on <Target> in <Browser>	
#	And I access the Guidewire BC on <Target> in <Browser>	
#	And I enter bcmanager and bcmanagerpwd on the BC Login page	
#	When I select Search from the Tab menu	
#	And search for account with REGISTRY and select from search results	
#	And I fetch country name and total amount due
#	And I select new payment:new direct bill payment from actions menu	
#	And I make a direct bill payment of 100	
#	Then I Logout of the Billing Center application	
#	And I Kill Web Driver
#
#
#	#ClaimCenter
#	Given I access the Guidewire CC on <Target> in <Browser>
#	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
#	And In CC9 I navigate to the Claim:New Claim Page
#	When In CC9 I Search for the REGISTRY on Policy Search Page
#	And In CC9 I Enter the CURRENT and Property on the policy search page
#	And In CC9 I Enter the Default , Agent on the Basic Information page
#	And In CC9 I Enter the Test Description and Fire on the Claim Information Page
#	And In CC9 I Enter the Auto Assign to the Claim and Finish the Application
#	And In CC9 I Pick Assign Claim from the Actions menu
#	And In CC9 I Assign the claim to Use automated assignment
#	And In CC9 I Pick Assign Claim from the Actions menu
#	And IN CC9 I ReAssign the claim
#	And In CC9 I Pick New Exposure from the Actions menu
#	And In CC9 I Select Jewelry Item from the New exposure page
#	And In CC9 I click on return to Exposures
#	And In CC9 I Add Reserves
#	And In CC9 I set Reserve
 #   | Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
  #  | (1)      | Indemnity | Indemnity Category | 500                  |
	#And In CC9 I select Parties Involved from the left navigation menu
#    And In CC9 I verify CM CC integration for Insured
#	And In CC9 I Add a new contact
#	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
#	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
#	#And In CC9 I Pick create from template from the Actions menu
#	#And In CC9 I create a new document with below details
#	#| DocumentTemplate  | SendTo  |
#	#| Agent_Loss_Notice | Insured |
#	#And In CC9 I select Documents from the left navigation menu
#	And In CC9 I Pick Check from the Actions menu
#	And I Enter below payment information for PL Claim
#	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
#	| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 100    |
#	And In CC9 I select Workplan from the left navigation menu
#	And I Complete all Activities in workplan
#	And In CC9 I Pick Close Claim from the Actions menu
#	Then In CC9 I close the claim with below details and Verify its status
#	| Note               | OutCome           | ForceClose | ClaimStatus |
##	| Selenium Test Note | Payments Complete | Yes        | Closed      |
#	And I Logout of the Claim Center application

#	Examples: 
#	| Application | AccountNumber | ApplicationEnvironment | Target  | Browser | UserName    | Password       | FirstName | LastName  | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
#	| PC          | REGISTRY      | PLP                    | Desktop | IE      | pluwmanager | pluwmanagerpwd | JPA       | SmokeTest | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

