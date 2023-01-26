Feature: PLPortal_PC9_QA



@PLRegression
Scenario Outline: Scenario01_AccountSettings
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
	| 1981 Kings Rd | Jacksonville | Florida | 32209   | United States of America | Home     | LLC     | Yes       | DIRD         | itqaautomation@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review in PC9
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
	And I click Quote on the Policy Review in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister vsharma@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 32209 | vsharma@jminsure.com | Pass123@ |
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
    And I enter <UserName> and <Password> on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	#And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
	And I verify <DistributionSource> , <PreferredMethodOfCommunication> ,  , Yes , <ProducerCode> in Right Account Details page for PC9 for QNA Account
	And I logout of the PC9 application
	And I Kill Web Driver
    And I access the Guidewire BC on Desktop in IE
	And I enter <UserName> and <Password> on the BC Login page
	And I select Search from the Tab menu
	And search for account with <AccountNumber> and select from search results
	#Then I verify   ,   ,  , <GWPaymentPlan> ,  REGISTRY , REGISTRY , <GWPayment_Instrument> in Account Details page  
	And I select payment wallet from left navigation menu
	And I verify <GwPaymentMethod> in Payment Methods
	And I click on ManageAutoPay <GwPaymentMethod>
	And I Kill Web Driver


	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail     | SecondaryEmail     | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | GWPayment_Instrument | GWPaymentPlan |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |vbadvel@jminsure.com |sbandaru@jminsure.com| Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | visa ****8291        | Annual Pay    |


@PLRegression
Scenario Outline: Scenario02_ChangeNameAddress_SubmitClaim_Upload Appraisal
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
	| AddressLine1 | AddressLine2 | City     | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 100 Main St  | Apt 2        | Waukesha | Wisconsin | 53189   | United States of America | Home     | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on the Policy Review in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister vsharma@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 53189 | vsharma@jminsure.com | Pass123@ |
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
	And I manage Preferred jeweler
	| preferredjeweler    | JewelerName     | JewelerAddress      | JewelerCity       | JewelerState     | JewelerPhone         | JewelerEmail                     |
	| Yes                 | JewelerName     | 24 Jewelers Park Dr | Neenah            | WI               | 908-456-8744         | vbadvel@jminsure.com        |
	And I submit Claim Contact information
	| ContactAddress1     | ContactAddress2 | ContactCity         | ContactState      | ContactPhone     | ContactEmail         | ContactZip                       | IsNewAddress  |
	| 24 Jewelers Park Dr |                 | Neenah              | WI                | 901-789-7866     | vbadvel@jminsure.com | 54956                            | yes           |
	And I verify if claim is successfully submited
	And I click on left navigation option
	| NavigationOption    |
	| Account summary     |
	And I click on view details option of PL Portal
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| appraisal             | 
	And I Upload a  <Documentsavailable> apprisial in Pl Portal
	And I verify if Apprisial is uploaded
	And I click on left navigation option
	| NavigationOption    |
	| Account summary     |
	And I click on view details option of PL Portal
	And I click  on Policy detail menu option
	| PolicyMenu          |
	| information             |
	And I update personal information details in information section of PL Portal
	| lastname  | Email                 | Phonenumber  | Address1            | Address2 | City   | State | Zip        | ISMailingAddressSame | MailingAddress1 | MailingAddress2 | MailingCity | MailingState | MailingZip |
	| LastName2 | skumar@jminsure.com | 901-456-9256 | 24 Jewelers Park Dr |          | Neenah | WI    | 54956-3702 | yes                  |                 |                 |             |              |            |
	And I waite for batch Cycle to execute
	And I Kill Web Driver
	And I access the Guidewire CC on Desktop in IE
	And I enter <UserName> and <Password> on the Login page of CC9
	And In CC9 I navigate to the search:Claim Page
	And I Search for claim number <GWCLaimNo> on Claim Search Page of CC9
	And I Verify If Claim Number is referred to correct policy number  REGISTRY  in Cc9
	And I Kill Web Driver
	 And I access the Guidewire PC on Desktop in IE
    And I enter <UserName> and <Password> on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	Then I verify PLPOrtal LastName2 , 24JewelersParkDrNeenah,WI54956 , 9014569256 , skumar@jminsure.com , Active  ,  ,  , ,   in Left Account Details page for PC9 
	And I Click on documents link on left navigation bar in PC9
	And I search documents by selecting <DocumentTypeName> , <FromDate> , <Todate>  in document page of PC9
	And I Verify if documents are <Documentsavailable> in document page of PC9


	And I logout of the PC9 application


#
#	And I enter <GW_UserName> and <GW_Password> on the PC9 Login page
#    And I select Accounts from the Search Tab menu of PC9
#    And search for account with <AccountNumber> and select from search results in PC9
#	And I verify PLPOrtal LastName2 , 24JewelersParkDrNeenah,WI54956 , 901-456-9256 , skumar@jminsure.com , Active , <AddressType> , <Gender> , <Occupation>, <DateOfBirth>  in Left Account Details page for PC9 
	#And I click on documents on Left NavMenu Screen 
	#And I search documents by selecting <DocumentTypeName> , <FromDate> , <Todate>  in document page of Policy Center
	#And I Verify if documents are <Documentsavailable> in document page of Policy center
	#And I logout of the application
	#And I Kill Web Driver

	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail        | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | GWPolicy | GWCLaimNo | DocumentTypeName | FromDate | Todate | Documentsavailable |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | vbadvel@jminsure.com | sbandaru@jminsure.com | Male   |            | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | REGISTRY | REGISTRY  | Appraisal        |          |        | 2                  |


			
@PLRegression
Scenario Outline: Scenario03_NameAddressChange_OpenWorkOrder
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
	| AddressLine1 | AddressLine2 | City     | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail         |
	| 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | United States of America | Home     | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
    And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
    | LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
    | Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on the Policy Review in PC9
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
	And  I unregister vsharma@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 53189 | vsharma@jminsure.com | Pass123@ |
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
	And I enter <UserName> and <Password> on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify PLPOrtal NameChange , 100MainStApt#2Waukesha,WI53189 ,  , vbadvel@jminsure.com ,  ,  ,  , ,   in Left Account Details page for PC9 
	And I verify Activity <PCActivities> in PC9
	And I logout of the PC9 application 

	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail         | SecondaryEmail        | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible | PCActivities                    |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | vbadvel@jminsure.com | sbandaru@jminsure.com | Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | Straight Through Process Review | 





	
			
@PLRegression
Scenario Outline: Scenario06_NameAddressChange_StraightThrough
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
	| AddressLine1 | AddressLine2 | City     | State     | ZipCode | Country                  | AddressType | OrgType | IsJeweler | ProducerCode | PrimaryEmail                |
	| 100 Main St  | Apt 2        | Waukesha | Wisconsin | 53189   | United States of America | Home     | LLC     | Yes       | DIRD         | vbadvel@jminsure.com |
	And I select New Submission from the Actions menu in PC9
	And I enter <PolicyEffDate> and <Product> on the New Submission page in PC9
	And I enter <ProfessionalAthelete> , <PreviousLoss> , <ConvictedOfCrime> for questions on qualification page in PC9
	And I enter the details on the policy information page in PC9
	And I Add Multi Jewelry items in PC9
	| LocatedWith | Class       | ValueOfItem | Deductible | AppraisalReceived | AppraisalDate |
	| Self        | Gents Chain | 10000       | 100        | no                |               |
	| Self        | Gents Chain | 20000       | 100        | no                |               |
	And I click Quote on the Policy Review in PC9
	And I Issue the policy in PC9
	And I Kill Web Driver
	And I access the remove regeistration app in PLReg , <Target> ,  , Chrome and  " " 
	And  I unregister vsharma@jminsure.com
	And I Kill Web Driver
	And I access the PLPOrtal app in <ApplicationEnvironment> , <Target> ,  , Chrome and  " " 
	And I Register PLPortal User
	| Account  | FirstName | LastName | Zip   | Email          | Password |
	| REGISTRY | REGISTRY  | REGISTRY | 53189 | vsharma@jminsure.com | Pass123@ |
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
    And I enter <UserName> and <Password> on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	Then I verify  , 24JewelersParkDrNeenah,WI54956 , 9014568975 , skumar@jminsure.com ,  ,  ,  , ,   in Left Account Details page for PC9 
	And I logout of the PC9 application



	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail     | SecondaryEmail     | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | LocatedWith | Class  | ValueOfItem | Deductible |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |vbadvel@jminsure.com |sbandaru@jminsure.com | Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings |              | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | Self        | Brooch | 1000        | 100        | 


