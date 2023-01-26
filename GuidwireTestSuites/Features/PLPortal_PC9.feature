Feature: PLPortal_PC9


@PLRegressionStage
@PL1
Scenario Outline: Scenario01_AccountSettings
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1  | City         | State   | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 1981 Kings Rd | Jacksonville | Florida | 32209   | United States of America | Home     | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Issue the policy in PC9
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 6000        | 0          | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister adzhoharidze@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 32209 | adzhoharidze@jminsure.com | Pass123@ |
	And I login to PlPortal
	And I Select paper less delivery option
	 | PaperlessFlag       |
	 | NO                  |
	And I click on view details option of PL Portal 
	And I click on left navigation option
	| NavigationOption    |
	| Account Settings     |
	And I verify if paperless Delivery is mamaged correctly in Account settings 
	And I click on Auto Pay  link in Account Settings 
	And I make PLPOrtal payment using Card
	| paymentMethod       | Country         | paymentAmount       | PaymentType       | AutoPay          | paymentDate          |
	| credit card         | USA             | totaldue            | visa              |                  | TESTINGSYSTEMCLOCK   |
	And I click on left navigation option
	| NavigationOption    |
	| Account summary     |
	And I click on view details option of PL Portal 
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| premium             |
	And I set AutoPay on
	And I click on left navigation option
	| NavigationOption    |
	| Account summary     |
	And I Kill Web Driver
	And I waite for batch Cycle to execute
	And I access the Guidewire PC on Desktop in IE
    And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	#And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
	And I verify <DistributionSource> , <PreferredMethodOfCommunication> ,  , Yes , <ProducerCode> in Right Account Details page for PC9 for QNA Account
	And I logout of the PC9 application
	And I Kill Web Driver
    And I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	And I select Search from the Tab menu
	And search for account with <AccountNumber> and select from search results
	#Then I verify   ,   ,  , <GWPaymentPlan> ,  REGISTRY , REGISTRY , <GWPayment_Instrument> in Account Details page  
	And I select payment wallet from left navigation menu
	And I verify <GwPaymentMethod> in Payment Methods
	And I click on ManageAutoPay <GwPaymentMethod>
	And I Kill Web Driver


	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail     | SecondaryEmail     | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | GWPayment_Instrument | GWPaymentPlan |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |vbadvel@jminsure.com |sbandaru@jminsure.com| Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | visa ****1111        | Annual Pay    |

@PLRegressionStage
@PLRegressionQA
@Regression
@PL2
Scenario Outline: Scenario02_ChangeNameAddress_SubmitClaim_Upload Appraisal
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1 | AddressLine2 | City     | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	|  48 Jewelers Park Dr   |        | Neenah | Wisconsin | 54956   | United States of America | Home     | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister texlife@apptest.jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 54956 | texlife@apptest.jminsure.com | Pass1234 |
	When I login to PlPortal
	And I Select paper less delivery option
	 | PaperlessFlag       |
	 | NO                  |
	And I click on view details option of PL Portal 
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| claim               |
	And I Start a new Claim
	| LossDate            | ItemDescription | LossType            | LossCircumstances | Comments         |
	| 07/02/2018          | description     | Fire                | circumstance      | Yes              |
	And I click on view details option of PL Portal
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| information             |
	And I update personal information details in information section of PL Portal
	| lastname  | Email                 | Phonenumber  | Address1            | Address2 | City   | State | Zip        | ISMailingAddressSame | MailingAddress1 | MailingAddress2 | MailingCity | MailingState | MailingZip |
	| LastName2 | skumar@jminsure.com | 901-456-9256 | 24 Jewelers Park Dr |          | Neenah | WI    | 54956-3702 | yes                  |                 |                 |             |              |            |
	And I waite for batch Cycle to execute
	And I Kill Web Driver

	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail        | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | GWPolicy | GWCLaimNo | DocumentTypeName | FromDate | Todate | Documentsavailable |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | vbadvel@jminsure.com | sbandaru@jminsure.com | Male   |            | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | REGISTRY | REGISTRY  | Appraisal        |          |        | 2                  |



			
@PLRegressionStage
@PLRegressionQA
@Regression
@PL3
Scenario Outline: Scenario03_NameAddressChange_OpenWorkOrder
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1        | AddressLine2 | City   | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail         |
	| 48 Jewelers Park Dr |              | Neenah | Wisconsin | 54956   | United States of America | Home        | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
    And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
    | LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
    | Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Issue the policy in PC9
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate and Added Jewelry Items
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
    | LocatedWith | Class  | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
    | Self        | Brooch | 4000        | 500        | no                |               |
	And I click Quote on the Policy Review in PC9
	
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister adzhoharidze@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 54956 | adzhoharidze@jminsure.com | Pass123@ |
	And I login to PlPortal
	And I Select paper less delivery option
	 | PaperlessFlag       |
	 | NO                  |
	And I click on view details option of PL Portal 
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| information             |
	And I update personal information details in information section of PL Portal
	| lastname | Email                        | Phonenumber  | Address1            | Address2 | City   | State | Zip        | ISMailingAddressSame | MailingAddress1 | MailingAddress2 | MailingCity | MailingState | MailingZip |
	|          | skumar@jminsure.com | 901-456-9256 | 24 Jewelers Park Dr |          | Neenah | WI    | 54956-3703 | Yes                   |                 |                 |             |              |            |
	And I Kill Web Driver
	And I waite for batch Cycle to execute
    And I access the Guidewire PC on Desktop in IE
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify PLPOrtal NameChange , 48JewelersParkDrNeenah,WI54956 ,  , vbadvel@jminsure.com ,  ,  ,  , ,   in Left Account Details page for PC9 
	And I verify Activity <PCActivities> in PC9
	And I logout of the PC9 application 

	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail        | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | PCActivities                    |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | vbadvel@jminsure.com | sbandaru@jminsure.com | Male   | Other      | No             | TestCareOf | 48 Jewelers Park Dr  |         | Neenah | Wisconsin | 54956   | Winnebago | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | Straight Through Process Review | 






	
	
@Regression		
@PLRegressionStage
@PLRegressionQA
@PL6


Scenario Outline: Scenario06_NameAddressChange_StraightThrough
	Given I access the Guidewire <Application> on <Target> in <Browser>
    And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
		When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1        | AddressLine2 | City   | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail         |
	| 48 Jewelers Park Dr |              | Neenah | Wisconsin | 54956   | United States of America | Home        | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister adzhoharidze@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 54956 | adzhoharidze@jminsure.com | Pass123@ |
	And I login to PlPortal
	And I Select paper less delivery option
	 | PaperlessFlag       |
	 | NO                  |
	And I click on view details option of PL Portal 
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| information             |
	And I update personal information details in information section of PL Portal
	| lastname | Email                     | Phonenumber  | Address1            | Address2 | City   | State | Zip        | ISMailingAddressSame | MailingAddress1     | MailingAddress2 | MailingCity | MailingState | MailingZip |
	| last     | skumar@jminsure.com | 901-456-8975 | 24 Jewelers Park Dr |          | Neenah | WI    | 54956-3703 | NO                  | 48 Jewelers Park Dr |                 | Neenah      | WI           | 54956      |
	And I Kill Web Driver
	And I waite for batch Cycle to execute
    And I access the Guidewire PC on Desktop in IE
    And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	Then I verify  , 24JewelersParkDrNeenah,WI54956 , 9014568975 , skumar@jminsure.com ,  ,  ,  , ,   in Left Account Details page for PC9 
	And I logout of the PC9 application



	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail     | SecondaryEmail     | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |vbadvel@jminsure.com |sbandaru@jminsure.com | Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | 



	@Regression		
@PLRegressionStage
@PLRegressionQA
@PL8
Scenario Outline: Scenario08_AddJewelry_Validation
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1        | AddressLine2 | City     | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail         |
	#| 100 Main St         | Apt 2        | Waukesha | Wisconsin | 53189   | United States of America | Mailing     | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
	| 48 Jewelers Park Dr |              | Neenah   | Wisconsin | 54956   | United States of America | Home     | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister adzhoharidze@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 54956 | adzhoharidze@jminsure.com | Pass123@ |
	And I login to PlPortal
	And I Select paper less delivery option
	 | PaperlessFlag       |
	 | NO                  |
	 And I click on view details option of PL Portal 
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| jewelry             |
	And I manage my Jewelry Item 
	| ActionType | JewelryType | ReplacingItem | ValuedDate | ReplacementValue | Deductible | JewelryWearer       | JewelryStored | DateforCoverage | AdditionalInformation |
	| Add        | Bracelet    | Yes           | 05/25/2016 | 25001             | $100.00    | PLPOrtal AddJewelry | Jewelry Box   |                 | test                  |
	And I manage Additional Questions 
	| AdditionalQuestion |
	| Online             |
	And I enter the  Personal  History Details in UW question details for PL POrtal
    | DeniedCov | DeniedCovreason |
    |   no        |                 |
    And I enter  for Jewelry Storage Details in UW question details for PL POrtal
    | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
    | No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
    And I enter Travel Details in UW question details for PL POrtal
    | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
    | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
	And I click on Submit button of Review Add Jewelry screen 
	And I Verify if Item is added
	And I Kill Web Driver
	And I waite for batch Cycle to execute
	And I access the Guidewire PC on Desktop in IE
    And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	When I verify Activity  <PCActivities> in PC9
	Then I verfy   , In Force , REGISTRY in Policy Term  for PC9

	
   	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail        | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | PCActivities |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | AddJewelry | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | vbadvel@jminsure.com | sbandaru@jminsure.com | Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | Policy Change with issues  |



	
	
@Regression		
@PLRegressionStage
@PLRegressionQA
@PL12
Scenario Outline: Scenario12_AddJewelry_Gents5KOnline
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	And I manage Transport with below status
	| Status  |
	| Started |
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following mandatory details on create account page for Personal lines in PC9
	| AddressLine1 | AddressLine2 | City     | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	|  48 Jewelers Park Dr   |        | Neenah | Wisconsin | 54956   | United States of America | Home     | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 3000       | 100        | no                |               |
	| Self        | Gents Chain | 1000       | 100        | no                |               |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister adzhoharidze@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 54956 | adzhoharidze@jminsure.com | Pass123@ |
	And I login to PlPortal
	And I Select paper less delivery option
	 | PaperlessFlag       |
	 | NO                  |
	 And I click on view details option of PL Portal 
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| jewelry             |
	And I manage my Jewelry Item 
	| ActionType | JewelryType | ReplacingItem | ValuedDate | ReplacementValue | Deductible | JewelryWearer       | JewelryStored | DateforCoverage | AdditionalInformation |
	| Add        | Bracelet    | No           | 05/25/2016 | 25001             | $100.00    | PLPOrtal AddJewelry | Jewelry Box   |                 | test                  |
	And I manage Additional Questions 
	| AdditionalQuestion |
	| Online             |
	And I enter the  Personal  History Details in UW question details for PL POrtal
    | DeniedCov | DeniedCovreason |
    |   no        |                 |
    And I enter  for Jewelry Storage Details in UW question details for PL POrtal
    | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
    | No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
    And I enter Travel Details in UW question details for PL POrtal
    | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
    | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
	And I click on Submit button of Review Add Jewelry screen 
	And I Verify if Item is added
	And I Kill Web Driver
	And I waite for batch Cycle to execute
	And I access the Guidewire PC on Desktop in IE
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify Activity  <PCActivities> in PC9
	Then I verfy   , In Force , REGISTRY in Policy Term  for PC9
	And I logout of the PC9 application 

   	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail        | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | PCActivities              |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | AddJewelry | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | vbadvel@jminsure.com | sbandaru@jminsure.com | Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | Policy Change with issues | 



		
@PLRegressionStage
@Regression
@PL14
Scenario Outline: Scenario14_QnA_STP_PLPortal_Registration_NameAddressChange_StraightThrough
				Given I access the remove regeistration app in PLReg , <TargetType> ,  , Chrome and  " " 
				When  I unregister adzhoharidze@jminsure.com
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 5000  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Wearers details <WearerType> on Applicant and Wearer page
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's  |                |           |    
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO                | No               |
			    And I make payment using Card, set <AutoPay>  Confirmation page and policy number depending on Environment and <GW_PolicyStatus> and register for PL POrtal <PL_Password>
				| cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | USA     | You have successfully completed your application, and your jewelry is now insured. |
				And I access the PLPOrtal app in PLP , <TargetType> ,  , <BrowserType> and  " " 
				And I set PLPortal User <PL_Password>
				| Account  | Email    |
				| REGISTRY | REGISTRY |
				And I login to PlPortal
				And I Select paper less delivery option
				 | PaperlessFlag       |
				 | Yes                  |
				And I click on view details option of PL Portal 
				And I click  on Policy detail menu option
				| PolicyMenu          |
				| information             |
				And I update personal information details in information section of PL Portal
				| lastname | Email                     | Phonenumber  | Address1            | Address2 | City   | State | Zip        | ISMailingAddressSame | MailingAddress1     | MailingAddress2 | MailingCity | MailingState | MailingZip |
				| last     | skumar@jminsure.com | 901-456-8975 | 24 Jewelers Park Dr |          | Neenah | WI    | 54956-3703 | NO                  | 48 Jewelers Park Dr |                 | Neenah      | WI           | 54956      |
				And I Kill Web Driver
				And I waite for batch Cycle to execute
				And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				Then I verify  , 24JewelersParkDrNeenah,WI54956 , 9014568975 ,  skumar@jminsure.com ,  ,  ,  , ,   in Left Account Details page for PC9 
			 	#And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 

			
				And I logout of the PC9 application 
     Examples:
            | GWPassword | GWUserName | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EmailOrPhoneJMIS | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | PL_Password |
            | gw         | su         | QNA                    | desktop    |            | Chrome      |                 | Reg | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999  | adzhoharidze@jminsure.com | Phone             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | Phone            | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Pass1234    |





@PLRegressionStage
@Regression
@PL15
Scenario Outline: Scenario15_QnA_STP_PLPortal_Registration_AddJewelry_Gents50KOnline
				Given I access the remove regeistration app in PLReg , <TargetType> ,  , Chrome and  " " 
				When  I unregister adzhoharidze@jminsure.com
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 1000  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Wearers details <WearerType> on Applicant and Wearer page
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's  |                |           |    
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO                | Yes               |
			    And I make payment using Card, set <AutoPay>  Confirmation page and policy number depending on Environment and <GW_PolicyStatus> and register for PL POrtal <PL_Password>
				| cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | USA     | You have successfully completed your application, and your jewelry is now insured. |
				And I access the PLPOrtal app in PLP , <TargetType> ,  , <BrowserType> and  " " 
				And I set PLPortal User <PL_Password>
				| Account  | Email    |
				| REGISTRY | REGISTRY |
				And I login to PlPortal
				And I click on view details option of PL Portal 
				And I click  on Policy detail menu option
				| PolicyMenu          |
				| jewelry             |
				And I manage my Jewelry Item 
				| ActionType | JewelryType | ReplacingItem | ValuedDate | ReplacementValue | Deductible | JewelryWearer       | JewelryStored | DateforCoverage | AdditionalInformation |
				| Add        | Bracelet    | Yes           | 05/25/2016 | 50000             | $100.00    | REGISTRY | Jewelry Box   |                 | test                  |
				And I manage Additional Questions 
				| AdditionalQuestion |
				| Online             |
				And I enter the  Personal  History Details in UW question details for PL POrtal
				| DeniedCov | DeniedCovreason |
				|   no        |                 |
				And I enter  for Jewelry Storage Details in UW question details for PL POrtal
				| SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
				| No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
				And I enter Travel Details in UW question details for PL POrtal
				| TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
				| 1-3 trips           | yes          | I keep it in the hotel safe |                   |
				And I click on Submit button of Review Add Jewelry screen 
				And I Verify if Item is added
				And I Kill Web Driver
				And I waite for batch Cycle to execute

				And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify Activity  <PCActivities> in PC9
				Then I verfy   , In Force , REGISTRY in Policy Term  for PC9
				And I logout of the PC9 application 


     Examples:
            | GWPassword | GWUserName | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EmailOrPhoneJMIS | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | PL_Password | PCActivities                   |
            | gw         | su         | QNA                    | desktop    |            | Chrome      |                 | Reg | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999  | adzhoharidze@jminsure.com | Phone             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | Phone            | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Pass1234    |  Policy Change with issues  |


