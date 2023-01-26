Feature: QuickClaimsApp

@QCregression
@regression
@QC1
Scenario Outline: 01_Scenario_Claims_App_Full 

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
	And I Issue the PL Smoke test policy in PC9 
	And I Logout of the Policy Center application
	And I Kill Web Driver
	Given I access the Quick Claim App app in <ApplicationEnvironment> , <Target> , <Capability> , Chrome and <OperatingSystem>
	When I enter Policy Number using REGISTRY
	And I enter Last Name using REGISTRY
	And I enter Zip Code using <ZipCode>
	And I disable Captcha
	And I click continue
	And I enter date of loss of today
	And I click continue
	And I Enter Claim Details 
	| FirstName | phoneNumber | streetAddress    | city      | state |
	| test      | 3453453452  | 240 Longview Ave | Green Bay | WI    |
	And I Enter person's relationship <relationship>
	And I Select Checkbox this is a new Address
	And I click continue
	And I click loss
	And I click loss type
	| LossType        |
	| Accidental Loss |
	And I click Continue on Loss/Damage Screen
	And I enter description for Lost Item <LossDescription>
	And I enter description for what happened <WhatHappenDescription>
	And I click on continue on Loss/Damage Screen
	And I Enter Jeweler Details 
	| Name         | streetAddress    | city      | state |
	| Jeweler test | 240 Longview Ave | Green Bay | WI    |
	And I click on continue button in Jeweler Details Page
	And I store claim number
	And I Kill Web Driver
	And I access the Guidewire CC on Desktop in IE
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the search:Claim Page
	And I Search for claim number <GWCLaimNo> on Claim Search Page of CC9
	Then I Verify If Claim Number is referred to correct policy number  REGISTRY  in Cc9


	Examples: 
	| Capability | OperatingSystem | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail      | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | WhatHappenDescription | LossDescription | GWCLaimNo |
	|            |                 | CA                     | PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com | skumar@jminsure.com | Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53186   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |   DIRD           | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | Test What Happen      | Loss Test       | REGISTRY  |
	
@QCregression
	@regression
	@QC2
	Scenario Outline: 02_Scenario_Claims_App_Multi_WorkOrder
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
	| Self        | Ladies Ring | 11000        | 250        | no                |               | Cartier | Eternity | Safe      | Central Station |
	| Self        | Gents Chain | 15000       | 100        | no                |               | Ritani  | Omega    | Safe     |                 |
	And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	# And I enter below details on Payment Page in PC9
	# | BilingMethod | InstallmentPlan |
	# | Direct Bill  | 8 PAY      |
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
	And I access the Quick Claim App app in <ApplicationEnvironment> , <Target> , <Capability> , Chrome and <OperatingSystem>
	And I enter Policy Number using REGISTRY
	And I enter Last Name using REGISTRY
	And I enter Zip Code using <ZipCode>
	And I disable Captcha
	And I click continue
	And I enter date of loss of today
	And I click continue
	And I Enter Claim Details 
	| FirstName | phoneNumber | streetAddress    | city      | state |
	| test      | 3453453452  | 240 Longview Ave | Green Bay | WI    |
	And I Enter person's relationship <relationship>
	And I Select Checkbox this is a new Address
	And I click continue
	And I click loss
	And I click loss type
	| LossType        |
	| Accidental Loss |
	And I click Continue on Loss/Damage Screen
	And I enter description for Lost Item <LossDescription>
	And I enter description for what happened <WhatHappenDescription>
	And I click on continue on Loss/Damage Screen
	And I click on continue button in Jeweler Details Page
	And I store claim number
	And I Kill Web Driver
	And I access the Guidewire CC on Desktop in IE
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the search:Claim Page
	And I Search for claim number <GWCLaimNo> on Claim Search Page of CC9
	Then I Verify If Claim Number is referred to correct policy number  REGISTRY  in Cc9


	Examples: 
	| Capability | OperatingSystem | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName       | LastName         | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | WhatHappenDescription | LossDescription | GWCLaimNo | BilingMethod | InstallmentPlan |
	|            |                 | CA                     | PC          | Desktop | IE      | su       | gw       | SeleniumFirName | SeleniumLastName | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53186   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | Test What Happen      | Loss Test       | REGISTRY  | Direct Bill  | Annual PAY      |
	
@QCregression
	@regression
	@QC3
	Scenario Outline: 03_Scenario_Claims_App_Existing_Account
	Given I access the Guidewire <Application> on <Target> in <Browser>
    When I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I get Policynumber, LastName and zipcode from summary Page in PC9
	And I Logout of the Policy Center application
	And I Kill Web Driver
	And I access the Quick Claim App app in <ApplicationEnvironment> , <Target> , <Capability> , Chrome and <OperatingSystem>
	And I enter Policy Number using REGISTRY
	And I enter Last Name using REGISTRY
	And I enter Zip Code using REGISTRY
	And I disable Captcha
	And I click continue
	And I enter date of loss of today
	And I click continue
	And I Enter Claim Details 
	| FirstName | phoneNumber | streetAddress    | city      | state |
	| test      | 3453453452  | 240 Longview Ave | Green Bay | WI    |
	And I Enter person's relationship <relationship>
	And I Select Checkbox this is a new Address
	And I click continue
	And I click loss
	And I click loss type
	| LossType        |
	| Accidental Loss |
	And I click Continue on Loss/Damage Screen
	And I enter description for Lost Item <LossDescription>
	And I enter description for what happened <WhatHappenDescription>
	And I click on continue on Loss/Damage Screen
	And I click on continue button in Jeweler Details Page
	And I store claim number
	And I Kill Web Driver
	And I access the Guidewire CC on Desktop in IE
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the search:Claim Page
	And I Search for claim number <GWCLaimNo> on Claim Search Page of CC9
	Then I Verify If Claim Number is referred to correct policy number  REGISTRY  in Cc9


	Examples: 
	| Capability | OperatingSystem | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | WhatHappenDescription | LossDescription | GWCLaimNo | BilingMethod | InstallmentPlan | AccountNumber |
	|            |                 | CA                     | PC          | Desktop | IE      | su       | gw       | Test What Happen      | Loss Test       | REGISTRY  | Direct Bill  | Annual PAY      | 3000002610   |

	@QCregression
	@regression
	@QC4
	Scenario Outline: 04_Scenario_Claims_App_Email_QNA
	Given I access the QuoteAndApp app in QNA , <Target> , <Capability> , Chrome and <OperatingSystem>
    And I verify Quote Page error validation messages
    When I Enter the Quote Page Details
    | ZipCode | JewelryType | Value |
    | 53189   | Ring        | 15000 |
    And I click on NewExisting Customer Page  
    And I verify Applicant Wearer Page error validation messages
    And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
    And I Enter the Applicant or Wearers details with respect to wearing items 
    | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
    | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
    And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
    And I Check the <TermsAndConditions> on Applicant and Wearer page
    And I Enter the jewelry information Jewelry Details page
    | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
    | Engagement Ring | Women's | 01/04/2017     | NO       |
    And I select <EffectiveDate> in Jewelry Details page 
    And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
    And I Review the application
    | Submitapplication | PaperlessDelivery |
    | NO               | Yes               |
    And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
	| cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
    | VISA     | USA     | You have successfully completed your application, and your jewelry is now insured. |
	And I Kill Web Driver
	And  I access the Guidewire <Application> on <Target> in <Browser>
    And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I get Policynumber, LastName and zipcode from summary Page in PC9
	And I Logout of the Policy Center application
	And I Kill Web Driver
	And I access the Quick Claim App app in <ApplicationEnvironment> , <Target> , <Capability> , Chrome and <OperatingSystem>
	And I enter Policy Number using EMAILREGISTRY
	And I enter Last Name using REGISTRY
	And I enter Zip Code using REGISTRY
	And I disable Captcha
	And I click continue
	And I enter date of loss of today
	And I click continue
	And I Enter Claim Details 
	| FirstName | phoneNumber | streetAddress    | city      | state |
	| test      | 3453453452  | 240 Longview Ave | Green Bay | WI    |
	And I Enter person's relationship <relationship>
	And I Select Checkbox this is a new Address
	And I click continue
	And I click loss
	And I click loss type
	| LossType        |
	| Accidental Loss |
	And I click Continue on Loss/Damage Screen
	And I enter description for Lost Item <LossDescription>
	And I enter description for what happened <WhatHappenDescription>
	And I click on continue on Loss/Damage Screen
	And I click on continue button in Jeweler Details Page
	And I store claim number
	And I Kill Web Driver
	And I access the Guidewire CC on Desktop in IE
	And I enter ccclmanager and ccclmanagerpwd on the Login page of CC9
	And In CC9 I navigate to the search:Claim Page
	And I Search for claim number <GWCLaimNo> on Claim Search Page of CC9
	Then I Verify If Claim Number is referred to correct policy number  REGISTRY  in Cc9
	Examples: 
	| Capability | OperatingSystem | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | WhatHappenDescription | LossDescription | GWCLaimNo | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | GWPaperlessDelivery | GWDateofBirth | AutoPay | GW_PolicyStatus |
	|            |                 | CA                     | PC          | Desktop | IE      | su       | gw       | Test What Happen      | Loss Test       | REGISTRY  | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 53189          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Yes                 | 05/01/1977    | Yes     | In Force        |
