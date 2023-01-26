Feature: Guidewire_Personal_Lines_PC9_Day1
	

		
@regression
@GWPL
@PCPL1
Scenario Outline:01_New_Submissions
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 25000000    | 1000       | no                |               |       |       |            |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | ANNUAL PAY      |
	#And I Click on Reinsurance link on left navigation bar in PC9
	#And I manage reinsurance in PC9
	And I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City        | State      | ZipCode | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan |
	| PC          | Desktop | IE      | su       | gw       | Jack | Ada | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |    | Other      | No             | TestCareOf | 1 DELAWARE E PL |              | CHICAGO | Illinois | 60611   |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |



@regression
@GWPL
@PCPL2

Scenario Outline: 02_NB_Change_OOS_Delete_Renew_USA
Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Ring | 25001        | 1000       | no                |               |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	#And I enter below details on Payment Page in PC9
	#| BilingMethod | InstallmentPlan |
	#| Direct Bill  | Annual Pay      |
	And I Issue the PL Smoke test policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate and Added Jewelry Items
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
    | LocatedWith | Class  | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
    | Self        | Gents Bracelet | 20000        | 500        | no                |               |
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review in PC9
	And I Issue the changed policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+5 and Added Jewelry Items
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
    | LocatedWith | Class  | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
    | Self        | Gents Chain | 10000       | 100        | no                |               |
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review in PC9
	And I Issue the changed policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+2 and Deleted Jewelry Items
	And I click ok on OOS Policy Change in PC9
	And I enter the details on the policy information page in PC9
	And I Delete Multi Jewelry items for Policy Change in PC9
	| InactiveArticle | InactiveReason |
	| Yes             | Other          |
	And I click Quote on the Policy Review in PC9
	And I Issue the changed policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Renew Policy from actions menu of Policy Cenetrin PC9
	And I enter the details on the policy information page in PC9
	And I click on Edit Work Order in Personal Jewelry Item screen in PC9
	And I click next on the Risk Analysis in PC9 for Renewal
	And I click Quote on the Policy Review in PC9 for Renewal
	Then I Renew PL policy in PC9 with below details
	| RenewCode         |
	| Renew - good risk |
	And I Logout of the Policy Center application

	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail        | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | GWPayment_Instrument | GWPaymentPlan |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |vbadvel@jminsure.com | sbandaru@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St  |        | Waukesha | Wisconsin | 53186-5007   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | visa ****1111        | Annual Pay    |



@regression
@GWPL
@PCPL3

Scenario Outline: 03_NB_Claim_UpdateReserve_Cancel_RewriteFullterm_Geico_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 5719 Kavanaugh Blvd | Little rock | Arkansas | 72207   | United States of America | Mailing     | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Ring | 5000        | 100       | no                |               |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	#And I enter below details on Payment Page in PC9
	#| BilingMethod | InstallmentPlan |
	#| Direct Bill  | Annual Pay      |
	And I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application
	And I Kill Web Driver

	#Claim Center

	And I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	#And In CC9 I set the authority profile limit of <UserName> to <Profile>
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the <PolicyNumber> on Policy Search Page
	And In CC9 I Enter the <LossDate> and <TypeOfClaim> on the policy search page
	And In CC9 I Enter the <Name> , <RelatedToInsured> on the Basic Information page
	And In CC9 I Enter the <Description> and <LossCause> on the Claim Information Page
	And In CC9 I Enter the Auto Assign to the Claim and Finish the Application
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to <AssginedClaim>
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select <NewExposureCoverage> from the New exposure page
	And In CC9 I click on return to Exposures
	#And In CC9 I Add Reserves
    #And In CC9 I set Reserve
    #| Exposure | Reserve | ReserveCategory | NewAvailableReserves |
    #| (1) | Indemnity | Indemnity Category | 500 |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for PL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Reserve from the Actions menu
	And I Update reserve with below details
	| ReserveCategory    | NewAvailReserves |
	| Indemnity Category | 250              |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for PL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory            | ReserveLine | PaymentType | AddtoDeductible | Amount |
	| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	And In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Kill Web Driver

	#Cancel and Rewrite Policy
	And I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I start Cancel policy on Prorata basis with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I click Quote on the policy information page in PC9
	And I Rewrite the canceled policy in PC9
	And I Logout of the Policy Center application

		Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1        | AddressLine2 | City        | State    | ZipCode | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan | Profile | PolicyNumber | LossDate | TypeOfClaim | LossCause | AssignClaim              | NewExposureCoverage | Name    | RelatedToInsured | AssginedClaim            |
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 5719 Kavanaugh Blvd |              | Little rock | Arkansas | 72207   |        | United States of America | Home        | TestDescription |                      | Z100D10      | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 8 PAY           | CEO     | REGISTRY     | CURRENT  | Property    | Fire      | Use automated assignment | Scheduled           | Insured | Insured     | Use automated assignment |



@regression
@GWPL
@PCPL4

Scenario Outline: 04_NB_Multi_SafeWithAlam_ScheduleCancel_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 5719 Kavanaugh Blvd | Little rock | Arkansas | 72207   | United States of America | Mailing     | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other | currentdate+4 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand   | Style    | ItemStored | Alarm   |
	| Self        | Gents Chain | 50000        | 100        | no                |               | Ritani  | Omega    | Safe       | Central Station |
	| Self        | Ladies Ring | 11000       | 250        | no                |               | Cartier | Eternity | Safe       |                 |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	#And I enter below details on Payment Page in PC9
	#| BilingMethod | InstallmentPlan |
	#| Direct Bill  | Annual Pay      |
	And I Issue the PL Smoke test policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I start Cancel policy on Prorata basis with below details in PC9 
	| Source  | Reason           | ReasonMethod | CancelEffDate |
	| Carrier | Criminal record |              | SYSTEMDATE+30    |
	And I Issue the canceled policy in PC9 


		Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail     | SecondaryEmail     | Gender | Occupation | Investigations | CareOf     | AddressLine1        | AddressLine2 | City        | State    | ZipCode | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan |
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 5719 Kavanaugh Blvd |              | Little rock | Arkansas | 72207   |        | United States of America | Home        | TestDescription |                      | Z100D10      | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 8 PAY           |


@regression
@GWPL
@PCPL5

Scenario Outline: 05_BD_Mult_ScheduleCancel_Claim_Reinstate_Change_CAN
Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other | currentdate-120 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand   | Style    | ItemStored | Alarm   |
	| Self        | Ladies Ring | 1100        | 250        | no                |               | Cartier | Eternity | Safe      | Central Station |
	| Self        | Gents Chain | 1500       | 100        | no                |               | Ritani  | Omega    | Safe     |                 |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	#And I enter below details on Payment Page in PC9
	#| BilingMethod | InstallmentPlan |
	#| Direct Bill  | 8 PAY      |
	And I Issue the PL Smoke test policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I start Cancel policy on Prorata basis with below details in PC9 
	| Source  | Reason          | ReasonMethod | CancelEffDate |
	| Insured | Insured Request - Price Not Competitive |              | SYSTEMDATE-1  |
	And I Issue the canceled policy in PC9 
	And I Logout of the Policy Center application
	And I Kill Web Driver
	And I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	When In CC9 I Search for the <PolicyNumber> on Policy Search Page
	And In CC9 I Enter the <LossDate> and <TypeOfClaim> on the policy search page
	And In CC9 I Enter the <Name> , <RelatedToInsured> on the Basic Information page
	And In CC9 I Enter the <Description> and <LossCause> on the Claim Information Page
	And In CC9 I Enter the Auto Assign to the Claim and Finish the Application
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to <AssginedClaim>
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I select lossdetails from the left navigation menu
	And  In CC9 I Update Coverage in Question <CoverageinQuestion>
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select <NewExposureCoverage> from the New exposure page
	And In CC9 I click on return to Exposures
	#And In CC9 I Add Reserves
    #And In CC9 I set Reserve
    #| Exposure | Reserve | ReserveCategory | NewAvailableReserves |
    #| (1) | Indemnity | Indemnity Category | 500 |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for PL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory            | ReserveLine | PaymentType | AddtoDeductible | Amount |
	| Insured          | Other            | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	And In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |
	And I Kill Web Driver
	And I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Reinstate Policy from actions menu of Policy Cenetrin PC9
	And  I set Reinstate reason in PC9
	| ReinstatementReason |
	| Payment received|
	And I Reinstate the canceled policy in PC9 
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1    | AddressLine2 | City    | State   | ZipCode | County | Country | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan | Profile | PolicyNumber | LossDate | TypeOfClaim | LossCause | AssignClaim              | NewExposureCoverage | Name    | RelatedToInsured | AssginedClaim            | CoverageinQuestion | OrgType |
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 1186 Queen St W |              | Toronto | Ontario | M6J 1J6 |        | Canada  | Home        | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 8 PAY           | CEO     | REGISTRY     | CURRENT  | Property    | Fire      | Use automated assignment | Scheduled           | Insured | Insured     | Use automated assignment | No                 | LLC     |



@regression
@GWPL
@PCPL6

Scenario Outline: 06_NB_Cancel_Rewrite_RemainderTerm_Claim_USA
Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other | currentdate-90 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 2000       | 100        | no                |               |       |       | Safe       |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	#And I enter below details on Payment Page in PC9
	#| BilingMethod | InstallmentPlan |
	#| Direct Bill  | 8 PAY      |
	And I Issue the PL Smoke test policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I start Cancel policy on Prorata basis with below details in PC9 
	| Source  | Reason          | ReasonMethod | CancelEffDate |
	| Insured | Insured Request - Price Not Competitive |              | SYSTEMDATE-10  |
	And I Issue the canceled policy in PC9 
	And I Logout of the Policy Center application
	And I Kill Web Driver
	
	#Billing Center
	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I fetch country name and total amount due
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 20	
	And I Logout of the Billing Center application	
	And I Kill Web Driver

	#Policy center
	And I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewritenewterm policy from actions menu of Policy Cenetrin PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9 for Policy Rewrite
	| Term   | PolicyEffDate  | ProducerCode |
	| Annual | currentdate-10 |              |
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Ladies Ring | 11000       | 250        | no                |               |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Policy Review Page in PC9
	And I Rewrite the canceled policy in PC9
	And I Logout of the Policy Center application

	#Claim Center
	And I access the Guidewire CC on <Target> in <Browser> 
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	And In CC9 I Search for the <PolicyNumber> on Policy Search Page
	And In CC9 I Enter the <LossDate> and <TypeOfClaim> on the policy search page
	And In CC9 I Enter the <Name> , <RelatedToInsured> on the Basic Information page
	And In CC9 I Enter the <Description> and <LossCause> on the Claim Information Page
	And In CC9 I Enter the Auto Assign to the Claim and Finish the Application
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to <AssginedClaim>
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select <NewExposureCoverage> from the New exposure page
	And In CC9 I click on return to Exposures
	#And In CC9 I Add Reserves
	#And In CC9 I set Reserve
    #| Exposure | Reserve | ReserveCategory | NewAvailableReserves |
    #| (1) | Indemnity | Indemnity Category | 500 |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for PL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory            | ReserveLine | PaymentType | AddtoDeductible | Amount |
	| Insured          | Other            | Indemnity                      | Indemnity Category          | Partial     | no              | 100    |
    And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	Then In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome           | ForceClose | ClaimStatus |
	| Selenium Test Note | Payments Complete | Yes        | Closed      |

	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1       | AddressLine2 | City     | State     | ZipCode    | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan | Profile | PolicyNumber | LossDate | TypeOfClaim | LossCause | AssignClaim              | NewExposureCoverage | Name    | RelatedToInsured | AssginedClaim            |
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 2400 Springdale Rd |              | Waukesha | Wisconsin | 53186-2725 |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 8 PAY           | CEO     | REGISTRY     | CURRENT  | Property    | Fire      | Use automated assignment | Scheduled           | Insured | Insured     | Use automated assignment |

@regression
@GWPL
@PCPL7

Scenario Outline: 07_NB_Convicted_Claim_Cancel_CashPayment_ReWriteNewTerm_Claim_USA
Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other | SYSTEMDATE-150 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 1500       | 100        | no                |               |       |       | Safe       |       |
	| Self        | Ladies Ring | 2000       | 100        | no                |               |       |       |            |       |
	And In Risk Analysis page I update convications details on the Risk Analysis section in PC9
	| ConvictedFelony | ConvictedMisdemeanor |
	| No              | Yes                  |
	And  In Risk Analysis page I update Sentence Completion Details in PC9
	| SentenceCompilationDate | ConvictionType | OtherConvictionType |
	| 10/05/2014               | Bribery        | Other Text          |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	#And I enter below details on Payment Page in PC9
	#| BilingMethod | InstallmentPlan |
	#| Direct Bill  | 2 PAY      |
	And I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application
	And I Kill Web Driver

	#Claim Center
	And I access the Guidewire CC on <Target> in <Browser>
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the Claim:New Claim Page
	And In CC9 I Search for the <PolicyNumber> on Policy Search Page
	And In CC9 I Enter the <LossDate> and <TypeOfClaim> on the policy search page
	And In CC9 I Enter the <Name> , <RelatedToInsured> on the Basic Information page
	And In CC9 I Enter the <Description> and <LossCause> on the Claim Information Page
	And In CC9 I Enter the Auto Assign to the Claim and Finish the Application
	And In CC9 I Pick Assign Claim from the Actions menu
	And In CC9 I Assign the claim to <AssginedClaim>
	And In CC9 I Pick Assign Claim from the Actions menu
	And IN CC9 I ReAssign the claim
	And In CC9 I Pick New Exposure from the Actions menu
	And In CC9 I Select <NewExposureCoverage> from the New exposure page
	And In CC9 I click on return to Exposures
	#And In CC9 I Add Reserves
	#And In CC9 I set Reserve
    #| Exposure | Reserve | ReserveCategory | NewAvailableReserves |
    #| (1) | Indemnity | Indemnity Category | 500 |
	And In CC9 I select Parties Involved from the left navigation menu
	And In CC9 I Add a new contact
	| ContactType | ContactRole | FirstName     | LastName      | TaxID     | CompanyName |
	| Person      | Vendor      | SeleniumFname | SeleniumLname | 213121334 |             |
	And In CC9 I Pick create from template from the Actions menu
	And In CC9 I create a new document with below details
	| DocumentTemplate  | SendTo  |
	| Agent_Loss_Notice | Insured |
	And In CC9 I select Documents from the left navigation menu
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for PL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory            | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Other            | Indemnity                      | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Close Claim from the Actions menu
	And In CC9 I close the claim with below details and Verify its status
	| Note               | OutCome     | ForceClose | ClaimStatus |
	| Selenium Test Note | No coverage | Yes        | Closed      |
	And In CC9 I Pick Reopen Claim from the Actions menu
	And In CC9 I enter below details to reopen claim
	| Note                                         | Reason               |
	| This claim has been reopened - Selenium Test | Supplemental Payment |
	And In CC9 I Pick Check from the Actions menu
	And I Enter below payment information for PL Claim
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Supplement  | no              | 80     |
	And I Kill Web Driver
	And I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I start Cancel policy on Prorata basis with below details in PC9 
	| Source  | Reason                  | ReasonMethod | CancelEffDate  |
	| Insured | Insured Request - Price Not Competitive |              | currentdate-10 |
	And I Issue the canceled policy in PC9 
	And I Logout of the Policy Center application
	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I fetch country name and total amount due
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 326	
	And I Logout of the Billing Center application	
	And I Kill Web Driver
	And I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewriteremainderofterm Policy from actions menu of Policy Cenetrin PC9
	And I enter below details on the policy information page in PC9 for Policy Rewrite
	| Term   | PolicyEffDate  | ProducerCode |
	| Annual | currentdate-10 |              |
 	And I Update Multi Jewelry items with Deatils in PC9
	| LocatedWith | FirstName  | LastName | AddressLine1          | City   | State     | ZipCode | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| New         | Additional | Wearer   | 1155 W Winneconne Ave | Neenah | Wisconsin | 54956   | Gents Chain |  1000           | 100        | no                |               |       |       | Safe  |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Policy Review Page in PC9
	And I Rewrite the canceled policy in PC9
	And I Logout of the Policy Center application

	
	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1       | AddressLine2 | City     | State     | ZipCode    | County | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan | Profile | PolicyNumber | LossDate | TypeOfClaim | LossCause | AssignClaim              | NewExposureCoverage | Name    | RelatedToInsured | AssginedClaim            |
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 2400 Springdale Rd |              | Waukesha | Wisconsin | 53186-2725 |        | United States of America | Other       | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | Yes              | Direct Bill  | 8 PAY           | CEO     | REGISTRY     | CURRENT  | Property    | Fire      | Use automated assignment | Scheduled           | Insured | Insured     | Use automated assignment |


@regression
@GWPL
@PCPL8

	Scenario Outline: 08_NB_Single_BD_X70_PRD
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Annual | currentdate-297 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 100000       | 100        | no                |               |       |       | Safe       |       |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the PL Smoke test policy in PC9 
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Pre-renewal direction from actions menu of Policy Cenetrin PC9
	And I Update Pre Renewal direction details in PC9
	| Direction | Text           | NonRenewReason              |
	| Non-Renew | TestAutomation | Non-Renew - Out of Business |
	And I Logout of the Policy Center application
	
	
	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1       | AddressLine2 | City     | State     | ZipCode    | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | 
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 2400 Springdale Rd |              | Waukesha | Wisconsin | 53186-2725 |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | 



@regression
@GWPL
@PCPL9

	Scenario Outline: 09_NB_Single_BD_X70
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Annual | currentdate-295 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 100000       | 100        | no                |               |       |       | Safe       |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application
	
	
	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1       | AddressLine2 | City     | State     | ZipCode    | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | 
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 2400 Springdale Rd |              | Waukesha | Wisconsin | 53186-2725 |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               |


@regression
@GWPL
@PCPL10

	Scenario Outline: 10_NB_Single_BD_X60
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Annual | currentdate-305 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 100000       | 100        | no                |               |       |       | Safe       |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application
	

	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1       | AddressLine2 | City     | State     | ZipCode    | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com | Male   | Other      | No             | TestCareOf | 2400 Springdale Rd |              | Waukesha | Wisconsin | 53186-2725 |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               |  

@GWPL
@PCPL11
Scenario Outline:11_Verify_PC_Send_Submission_Payload_When_PJ_Submission_Issued_136891
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
    And I manage Transport with below status
	| Status  |
	| Suspended |
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 25000000    | 1000       | no                |               |       |       |            |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | ANNUAL PAY      |
	#And I Quote the PL Smoke test policy in PC9 
	#And I Click on Reinsurance link on left navigation bar in PC9
	#And I manage reinsurance in PC9
	And I Issue the PL Smoke test policy in PC9 
	And I verify below payload
	| Type |
	| Submission   |
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City        | State      | ZipCode | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan |
	| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com            | rparas@jminsure.com |                  | Other      | No             | TestCareOf | 217 N Hill St |              | Los Angeles | California | 90012   |            | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |

@GWPL
@PCPL12
Scenario Outline: 12_PJ_submission_declined
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Annual | currentdate-305 |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 10000       | 100        | no                |               |       |       | Safe       |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I decline policy for <DeclineReason>

	Examples:
	| DeclineReason             | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan |
	| Loss history               | PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com            | rparas@jminsure.com |                  | Other      | No             | TestCareOf | 217 N Hill St |              | Los Angeles | California | 90012   |            | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| Nature of the item/schedule| PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com            | rparas@jminsure.com |                  | Other      | No             | TestCareOf | 217 N Hill St |              | Los Angeles | California | 90012   |            | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| Level of Security	         | PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com            | rparas@jminsure.com |                  | Other      | No             | TestCareOf | 217 N Hill St |              | Los Angeles | California | 90012   |            | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| Travel Risk				 | PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com            | rparas@jminsure.com |                  | Other      | No             | TestCareOf | 217 N Hill St |              | Los Angeles | California | 90012   |            | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| Credit    				 | PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com            | rparas@jminsure.com |                  | Other      | No             | TestCareOf | 217 N Hill St |              | Los Angeles | California | 90012   |            | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |

@regression
@GWPL
@PCPL13
Scenario Outline:13_PJ_Verify_Insurance_Score
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 1000    | 0       | no                |               |       |       |            |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | ANNUAL PAY      |
	And I Issue the PL Smoke test policy in PC9 
	And I verify insurance <Score>
	And I Logout of the Policy Center application

	Examples: 
	| Location | Score | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail                | SecondaryEmail              | Gender | Occupation | Investigations | CareOf     | AddressLine1      | AddressLine2 | City        | State    | ZipCode | County | Country                  | AddressType | Description     | ProducerOrganization | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan |
	| IL       | 727   | PC          | Desktop | IE      | su       | gw       | Jack      | Ada      | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |        | Other      | No             | TestCareOf | 1 DELAWARE E PL   |              | CHICAGO     | Illinois | 60611   |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| HI       |       | PC          | Desktop | IE      | su       | gw       | DEBBIEA    | BRICKENA  | 03/01/1989  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |        | Other      | No             | TestCareOf | PO BOX 223498     |              | PRINCEVILLE | Hawaii   | 96722   |        | United States of America | Other       | TestDescription |                      | DIRD         | 666259515   | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| ON       |       | PC          | Desktop | IE      | su       | gw       | Zhao     | Li       | 05/27/1992  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |        | Other      | No             | TestCareOf | 381 meadowvale rd |              | Waterloo    | Ontario  | N2k 2k4 |        | Canada                   | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| PA       | 109    | PC         | Desktop | IE      | su       | gw       | CANICIUS    | ACHOLONU  | 10/01/1989  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |        | Other      | No             | TestCareOf | 5833 CHEW AV	     	     |              | PHILADELPHIA | Pennsylvania   | 19138   |        | United States of America | Other       | TestDescription |                      | HE001D         | 666259515   | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| IL_STP   |       | PC          | Desktop | IE      | su       | gw       | FraedR       | King     | 06/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |    | Other      | No             | TestCareOf | 15 DELAWARE E PL |              | CHICAGO | Illinois | 60611   |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| MA      |  500     | PC          | Desktop | IE      | su       | gw       | MARIELLA       | AARDEN     | 10/01/1959  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |    | Other      | No             | TestCareOf | 2 BERARD CT |              | WESTPORT | massachusetts | 02790   |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	| NV      |  293     | PC          | Desktop | IE      | su       | gw       | Steven       | Bell     | 10/01/1974  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | itqaautomation@jminsure.com | itqaautomation@jminsure.com |    | Other      | No             | TestCareOf |672 SUMATRA PL |              | HENDERSON | Nevada | 89011   |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           |
	


@regression
@GWPL
@PCPL14
Scenario Outline: 14_PJ_submission_declined_ReasonText_with_Other_Reason
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter below details on the policy information page in PC9
	| Term   | PolicyEffDate | ProducerCode |
	| Annual | currentdate   |              |
	And I Add Multi Jewelry items in PC9 with Alarm Details 
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate | Brand | Style | ItemStored | Alarm |
	| Self        | Gents Chain | 10000       | 100        | no                |               |       |       | Safe       |       |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I decline policy for <DeclineReason>
	And I click on Decline button
	Then I verify error message <Error> is shown up
	And I Logout of the Policy Center application

	Examples:
	| DeclineReason   | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | BilingMethod | InstallmentPlan | Error |
	| Other:CheckText |  PC         | Desktop | IE      | su       | gw       | PCPL14FirName | PCPL14LastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com | rparas@jminsure.com |        | Other      | No             | TestCareOf | 217 N Hill St |              | Los Angeles | California | 90012   |        | United States of America | Other       | TestDescription |                      | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Direct Bill  | 2 PAY           | Missing required field "Reason Text (for letter)" |
