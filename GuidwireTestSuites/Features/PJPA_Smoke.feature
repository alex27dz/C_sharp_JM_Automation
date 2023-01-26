Feature: PJPASmoke

@pjpasmoketest
@createPLpolicysmoke
Scenario Outline: TS01_PJPA_CreatePLPolicy
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
	Then I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application

Examples: 
	| Application | Target  | Browser | UserName    | Password       | FirstName | LastName | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible |
	| PC          | Desktop | IE      | pluwmanager | pluwmanagerpwd | Personal  | Smoke    | SYSTEMDATE+0  |         | No                   | No           | No               | REGISTRY    | Brooch | 1000        | 100        |

@pjpasmoketest
@achpaymentsmoke
Scenario Outline: TS02_PJPA_BC_ACH Payment and Reversal
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
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |


@pjpasmoketest	
@ccpaymentsmoke
Scenario Outline: TS03_PJPA_BC_CC Payment and Reversal
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
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | VISA   | TESTINGSYSTEMCLOCK+1 | REGISTRY      |

@pjpasmoketest
@CreateContactsmoke
Scenario Outline: TS04_PJPA_CM_CreateContact
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the CM Login page
	And I click search on Contacts Tab
	And I verify below search details on search page
	| ContactType | FirstName | LastName | CompanyName |
	| Person      | REGISTRY  | REGISTRY |             |
	And I Logout of the Claim Center application
    Examples: 
	| Application | Target  | Browser | UserName  | Password     |
	| CM          | Desktop | IE      | cmmanager | cmmanagerpwd |

@pjpasmoketest
@jpasmoke
Scenario Outline: TS05_PJPA_JPA_Smoke
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
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 0-100 lbs |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	 | deniedcoverage | reason       |
	| No             |        |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Ring    | Engagement     | Gents      | Yes          |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |           |              |               | No       |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I Issue the JPA Smoke test policy in PC9 
	And I Logout of the Policy Center application
	And I Kill Web Driver

	#BillingCenter
	Given I access the Guidewire BC on <Target> in <Browser>	
	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I fetch country name and total amount due
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 100	
	Then I Logout of the Billing Center application	
	And I Kill Web Driver


	#ClaimCenter
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the REGISTRY on Policy Search Page
	And In CC9 I Enter the CURRENT and Property on the policy search page
	And In CC9 I Enter the Default , Agent on the Basic Information page
	And In CC9 I Enter the Test Description and Fire on the Claim Information Page
	And In CC9 I Enter the Auto Assign to the Claim and Finish the Application
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to Use automated assignment
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select Jewelry Item from the New exposure page
	And In CC9 I click on return to Exposures
	And In CC9 I Add Reserves
	#And In CC9 I set Reserve
    #| Exposure | Reserve   | ReserveCategory    | NewAvailableReserves |
    #| (1)      | Indemnity | Indemnity Category | 500                  |
	And In CC9 I select Parties Involved from the left navigation menu
    And In CC9 I verify CM CC integration for Insured
	And In CC9 I Add a new contact
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	#And In CC9 I Pick create from template from the Actions menu
	#And In CC9 I create a new document with below details
	#| DocumentTemplate  | SendTo  |
	#| Agent_Loss_Notice | Insured |
	#And In CC9 I select Documents from the left navigation menu
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for PL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Logout of the Claim Center application

	Examples: 
	| Application | AccountNumber | ApplicationEnvironment | Target  | Browser | UserName    | Password       | FirstName | LastName  | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| PC          | REGISTRY      | PLP                    | Desktop | IE      | pluwmanager | pluwmanagerpwd | JPA       | SmokeTest | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
