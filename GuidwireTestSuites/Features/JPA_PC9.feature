Feature: JPA_PC9

@JPA
@JPA1
@regression
Scenario Outline: 01_OOS_Polchange_SingleLocation_SingleWearer_Alarm_Central Station_UWQuestionYes_Article_with_Safe_Value_GreaterthenEqual_10K
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
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |      |       | Yes          |       |       | 2500        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	When I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
   And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Chain   |                | Gents      |              |       |       | 2500         | 100        | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	#And I click Quote on Risk Analysis Page for ST in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy change

	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+7 and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Cufflinks   |                | Gents      |              |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy change
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+3 and Removed Item(s)
	And I click ok on OOS Policy Change in PC9
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Delete below Multi Article details on personal articles page in PC9
	| InactiveArticle | InactiveReason |
	| Yes             | Other          |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy change
	Then I Logout of the Policy Center application


	#ClaimCenter
   Given I access the Guidewire CC on <Target> in <Browser>	
	And I enter pluwmanager and pluwmanagerpwd on the Login page of CC9
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
	| PrimaryPayeeName | PrimaryPayeeType | ReserveLineCategory | ReserveLine        | PaymentType | AddtoDeductible | Amount |
	| Insured          | Claimant         | Indemnity           | Indemnity Category | Partial     | no              | 100    |
	And In CC9 I select Workplan from the left navigation menu
	And I Complete all Activities in workplan
	And In CC9 I Pick Reserve from the Actions menu
	And I Update reserve with below details
	| ReserveCategory    | NewAvailReserves |
	| Indemnity Category | 250              |
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
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName  | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario1 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |



@JPA
@JPA2	
@regression
Scenario Outline: 02_Add_Del_Article_Single_Location_Single_Wearer_Alarm_CentralStation_UWQuestion_No__Article_with_Vault_Value_GreaterthenEqualto_10K
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
	| self        | Ring    | Engagement     | Gents      | Yes          |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               | Vault          |              |               | No       |          |            |                      |                    |                         |               |                   |               |            |                       |
	##And I add Vault details in personal articles page in PC9
	##| ItemFlag | ValutType          | Name      | CompanyJeweler | AddressType | Address1    | Address2 | City     | State     | ZipCode | ValutAddressType |
	##| Yes      | ADD NEW BANK VAULT | Scenario2 | yes            | new         |  931 S Green Bay Rd |    | Neenah | Wisconsin | 54956   |                  |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	#And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+2 and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Necklace   |                | Gents      |              |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy change
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+5 and Removed Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Delete below Multi Article details on personal articles page in PC9
	| InactiveArticle | InactiveReason |
	| No              |                |
	| Yes             | Other          |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy change
	Then I Logout of the Policy Center application


	#Claim Center
	Given I access the Guidewire CC on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the Login page of CC9
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
	And In CC9 I create New exposure with below detals
    | ExposureType             | ArticleType | Gender | Value |
    | Unscheduled Jewelry Item | Necklace    | Gents  | 2499  |
	And In CC9 I click on return to Exposures
	And In CC9 I Add Reserves
	And In CC9 I set Reserve
    | Exposure | Reserve | ReserveCategory | NewAvailableReserves |
    | (1) | Indemnity | Indemnity Category | 500 |
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
	Then In CC9 I close the claim with below details and Verify its status
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
	And I Logout of the Claim Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName  | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario2 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 54956   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA
@JPA3
@regression
Scenario Outline: 03_Flat_Cancel_Rewrite_Fullterm_Single_Location_Single_Wearer_Alarm_Local_UWQuestion_Yes_Article_with_Safe_lessthen_10000
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Local|
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 101-199 lbs |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Non-Payment |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Earrings    | Single     | Ladies      |           |       |       | 9999        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 101-199 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	#And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I start Cancel policy on Prorata basis with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy ReWrite
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | 
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA  | scenario3 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St  |                | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               | 


@JPA
@JPA4
@regression
Scenario Outline: 04_Flat_Cancel_Rewrite_Newterm_Single Location_Single_Wearer_Alarm_Local_UWQuestion_No_Article
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other | currentdate-33 |              |
	
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Local|
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
	| self        | Earrings    | Pair     | Ladies       |           |       |       | 9999         | 500        | NO                  |             |                    |                   |               |          |               |           |              |               | No       |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	#And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the JPA Smoke test policy in PC9 
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
	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I fetch country name and total amount due
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 21
	#And I make a direct bill payment of 1
	#And I make a direct bill payment of 22	
	And I Logout of the Billing Center application	
	And I Kill Web Driver
	And I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewritenewterm policy from actions menu of Policy Cenetrin PC9
	And I enter below details on the policy information page in PC9 for Policy Rewrite
	| Term   | PolicyEffDate  | ProducerCode |
	| Annual | currentdate-10 |              |
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy ReWrite
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | 
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA  | scenario2 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St  |             | Waukesha | Wisconsin | 54956   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               | 



Scenario Outline: 05_Flat_Cancel_Rewrite_Reminder_term_Multiple_Location_Multiple Wearers_Alarm_CentralStation_UWQuestion_Yes_Articles_with_Safe_ItemValue_Greaterthen_50K
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other | SYSTEMDATE-33 |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 0-100 lbs |
	And I update below new location details  on the policy location page in PC9
	| locationName | CareOf | Address1           | Address2 | City   | State     | ZipCode | phone |
	| Loc1          | new    | 931 S Green Bay Rd |          | Neenah | Wisconsin | 54956   |201-345-9876       |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 0-100 lbs |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I update below new contact details  on the policy contact page in PC9
	| contactFirstName | contactLastName | contactDOB | contactReleationship | contactLocation              | deniedcoverage | reason       |
	| ContactFirstName | ContactLastName | | Child                | 2: Loc1 | Yes            | Loss History |
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details for different locations on personal articles page in PC9
	| LocatedWith                      | Location | Article     | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self                             |          | Loose Stone |                | Gents      |           |       |       | 50001        | 5000       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| ContactFirstName ContactLastName |  2: Loc1        |Loose Stone |                | Gents      |           |       |       | 50001        | 5000       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I Update Contact details in Additional Underwriting question
	| Articleworn      | currentocuption | overnighttravel | travelaborod | safeguradwhiletraviling            |
	| 1-2 times a week | Art and Design  | 7-9 trips       | yes          | My jewelry is with me at all times |

	And I Update Location details in Additional Underwriting question
	| GatedEntrance | fenceSurround | guardatgate | guardpresentfrequency | communitypatrol | communitypatrolfrequency | enterancetocommunity | guestenterancetocommunity | domestichelp | helptype          | employmentlength     | resideathome | theycomehome | otherpersonresideathome | elsereside |
	| yes           | yes           | yes         | 24 hours              | yes             | 24 hours                 |card reader                 |  Keypad             | yes          | Medical Assistant | Less than 1 year ago | yes          | Daily        | yes                     | partner   |
	| yes           | yes           | yes         | 24 hours              | yes             | 24 hours                 |card reader                 |  Keypad             | yes          | Medical Assistant | Less than 1 year ago | yes          | Daily        | yes                     | partner   |
	And I Click next on Additional Underwriting question page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the JPA Smoke test policy in PC9 
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
	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I fetch country name and total amount due
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 76	
	And I Logout of the Billing Center application	
	And I Kill Web Driver
	And I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewriteremainderofterm Policy from actions menu of Policy Cenetrin PC9
	And I enter below details on the policy information page in PC9 for Policy Rewrite
	| Term   | PolicyEffDate  | ProducerCode |
	| Annual | currentdate-10 |              |
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details for different locations on personal articles page in PC9
	| LocatedWith                      | Location | Article     | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| ContactFirstName ContactLastName |  2: Loc1        |Earrings    | Pair     | Ladies        |           |       |       | 9999        | 500       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	#//And I click Quote on the Policy Review in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy ReWrite
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | 
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA  | scenario1 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St  |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               | 



@JPA
@JPA6	
@regression
Scenario Outline:06_Multiple_Location_Multiple_Wearers_Alarm_CentralStation_UWQuestion_No_ItemValue_GreaterThen_50K
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 0-100 lbs |
	And I update below new location details  on the policy location page in PC9
	| locationName | CareOf | Address1           | Address2 | City   | State     | ZipCode | phone |
	| Loc1          | new    | 931 S Green Bay Rd |          | Neenah | Wisconsin | 54956   |201-345-9876       |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 0-100 lbs |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	 | deniedcoverage | reason       |
	| no             |        |
	And I update below new contact details  on the policy contact page in PC9
	| contactFirstName | contactLastName | contactDOB | contactReleationship | contactLocation | deniedcoverage | reason       |
	| ContactFirstName | ContactLastName | 05/25/1976 | Child                | 2: Loc1         | Yes            | Loss History |
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith                      | Article   | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self                             | Cufflinks |                | Ladies     | No           |       |       | 51000        | 10000      | NO                  |             |                    |                   |               |          |               |           |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| ContactFirstName ContactLastName | Cufflinks |                | Ladies     | No           |       |       | 51000        | 10000      | NO                  |             |                    |                   |               |          |               |           |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I Update Location details in Additional Underwriting question
	| GatedEntrance | fenceSurround | guardatgate | guardpresentfrequency | communitypatrol | communitypatrolfrequency | enterancetocommunity | guestenterancetocommunity | domestichelp | helptype          | employmentlength     | resideathome | theycomehome | otherpersonresideathome | elsereside |
	| yes           | yes           | yes         | 24 hours              | yes             | 24 hours                 |card reader                 |  Keypad             | yes          | Medical Assistant | Less than 1 year ago | yes          | Daily        | yes                     | partner   |
	And I Update Contact details in Additional Underwriting question
	| Articleworn      | currentocuption | overnighttravel | travelaborod | safeguradwhiletraviling            |
	| 1-2 times a week | Art and Design  | 7-9 trips       | yes          | My jewelry is with me at all times |
	And I Click next on Additional Underwriting question page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the JPA Smoke test policy in PC9 
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA  | scenario1 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St  |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               | 



			
@JPA
@JPA7
@regression
Scenario Outline:07_Multiple_Location_Multiple_Wearers_Alarm_Local_UWQuestion_No_ItemValue_lessthenEqualto_25K
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType |
	| Local     |
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 0-100 lbs |
	And I update below new location details  on the policy location page in PC9
	| locationName | CareOf | Address1           | Address2 | City   | State     | ZipCode | phone |
	| Loc1          | new    | 931 S Green Bay Rd |          | Neenah | Wisconsin | 54956   |201-345-9876       |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	 | deniedcoverage | reason       |
	| no             |        |
	And I update below new contact details  on the policy contact page in PC9
	| contactFirstName | contactLastName | contactDOB | contactReleationship | contactLocation | deniedcoverage | reason       |
	| ContactFirstName | ContactLastName | 05/25/1976 | Child                | 2: Loc1         | Yes            | Loss History |
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| No            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith                      | Article   | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self                             | Chain |                | Gents     | No           |       |       | 25000        | 1000      | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| ContactFirstName ContactLastName | Cufflinks |                | Gents     | No           |       |       | 24999        | 1000      | NO                  |             |                    |                   |               |          |               |           |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the JPA Smoke test policy in PC9 
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA  | scenario1 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St  |               | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               | 




@JPA
@JPA8			
@regression
Scenario Outline:08_Multiple_Location_Multiple_Wearers_Alarm_Local)_UWQuestion_Yes_Articles_with_TotalitemValue_lessthen_50K
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType |
	| Local     |
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       |>500 lbs |
	And I update below new location details  on the policy location page in PC9
	| locationName | CareOf | Address1           | Address2 | City   | State     | ZipCode | phone |
	| Loc1          | new    | 931 S Green Bay Rd |          | Neenah | Wisconsin | 54956   |201-345-9876       |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	 | deniedcoverage | reason       |
	| no             |        |
	And I update below new contact details  on the policy contact page in PC9
	| contactFirstName | contactLastName | contactDOB | contactReleationship | contactLocation | deniedcoverage | reason       |
	| ContactFirstName | ContactLastName | 05/25/1976 | Child                | 2: Loc1         | Yes            | Loss History |
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith                      | Article     | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self                             | Loose Stone |                |            | Yes          |       |       | 25000        | 5000       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : >500 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| ContactFirstName ContactLastName | Cufflinks   |                | Gents      | No           |       |       | 24999        | 5000       | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 2 PAY      |
	And I Issue the JPA Smoke test policy in PC9 
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | 
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA  | scenario1 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf |100 E Main St  |               | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               | 


@JPA
@JPA9			
@regression


	Scenario Outline: 09_NoHit_SingleLocation_SingleWearer_Alarm_Central Station_UWQuestionYes_Article_with_Safe_Value_GreaterthenEqual_10K
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Pendant |                | Ladies     | No           |       |       | 5000         | 500        | NO                  |             |                    |                   |               |          |               |                |              | Retail  | Yes    |          |            |                      |                    |                         |               |                   |               |  Broken shank          |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I Issue the JPA Smoke test policy in PC9 
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName      | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City      | State    | ZipCode    | County | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | BOB       | KARASZKIEWICZ | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 164 S 66TH ST |              | MILWAUKEE | Wisconsin | 53214-1728 | MILWAUKEE       | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


	@JPA
@JPA10			
@regression


	Scenario Outline: 10_ValidScore_SingleLocation_SingleWearer_Alarm_Central Station_UWQuestionYes_Article_with_Safe_Value_GreaterthenEqual_10K
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| No            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Charms |                | Gents     | No           |       |       | 2500         | 100        | NO                  |             |                    |                   |               |          |               |                |              | Retail  | No    |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	#And I click next on the Risk Analysis in PC9
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I Issue the JPA Smoke test policy in PC9 
	Then I Logout of the Policy Center application
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName      | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City      | State    | ZipCode    | County | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |JOAN    | KARASZKIEWICZ | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 164 S 66TH ST |              | MILWAUKEE | Wisconsin | 53214-1728 | MILWAUKEE       | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@JPA
@JPA11
@regression
Scenario Outline: 11_Verify_Insurance_Score
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
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |      |       | Yes          |       |       | 2500        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	When I Issue the JPA Smoke test policy in PC9 
	And I verify insurance <Score>
	Then I Logout of the Policy Center application

	Examples: 
	| Places | Score | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1    | AddressLine2 | City             | State      | ZipCode | County       | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| IL     | 727   | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JACK      | ADA      | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1 DELAWARE E PL |              | CHICAGO          | Illinois   | 60611   | Cook         | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666981289 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| WA     | 120   | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | ROLANDO   | ACEVEDO  | 10/01/1989  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 523 MARION st W |              | ABERDEEN         | Washington | 98520   | Grays Harbor | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666813788 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| CO     | 244   | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JOSE      | ABITIA   | 10/01/1942  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 2008 E LAFAYETTE ST  |         | DENVER           | Colorado   | 80210   | DENVER       | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666381230 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| HI     |       | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | DEBBIE    | BRICKEN  | 03/01/1989  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | PO BOX 223498   |              | PRINCEVILLE      | Hawaii     | 96722   |              | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666259515 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| MD     |       | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | MELISSA   | ALEMAN   | 06/01/1990  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 39092 GOLDEN BEACH RD |     | MECHANICSVILLE| Maryland | 20659 |   | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD    | 666450008 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| WA_NoScore|    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | PAUL      | SETTER   | 10/01/1984  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 4625 45TH AVE |   Apt A11          | LACEY	           | Washington | 98503   | Thurston    | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666107453 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| MT_NoHit  |    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | MOUNTY    | HILLS    | 10/01/1957  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 301 S PARK AVE   |              | HELENA          | Montana   | 59620   | Lewis and Clark         | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 000000000	 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| GA_NoHit  |    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JOANNA    | RAGGIANI | 10/01/1992  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 2736 RYE PATCH RD	|              | LUDOWICI      | Georgia   | 31316   | Long         | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666468372		 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| PA  | 151    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JUVENTINO    | ACOSTA    | 10/01/1974  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 2209	E SERGEANT ST|              | PHILADELPHIA          | pennsylvania   | 19125   |       | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | HE001D         | 666107453	 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| ON  | 151    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Frank    | Smith    | 10/01/1974  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 383 Meadowvale rd|              | Waterloo          | Ontario   | N2k2K4   |       | Canada | Home        | TestDescription | septum docklands sympathy potomac foxings | HE001D         | 666107453	 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| MA  | 590    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | MARIELLA    | AARDEN    | 10/01/1959  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 	2 BERARD CT|              | WESTPORT          | massachusetts   | 02790   |       | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | HE001D         | 666107453	 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| NV  | 350    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | STEVEN    | BELL    | 10/01/1974  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf |672	SUMATRA PL|              | HENDERSON          | Nevada   | 89011   |       | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | HE001D         | 666107453	 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@JPA
#@JPA12
@regression
Scenario Outline: 12_No_Credit_Check_For
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
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |      |       | Yes          |       |       | 2500        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	When I Issue the JPA Smoke test policy in PC9 
	And I verify insurance score
	Then I Logout of the Policy Center application
#HI_MA_MD_CA
	Examples: 
	| Places | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City        | State  | ZipCode | County | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| HI     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | DEBBIE    | BRICKEN  | 03/01/1989  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | PO BOX 223498 |              | PRINCEVILLE | Hawaii | 96722   |        | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666259515 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| MA     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | MELISSA    | ALEMAN   | 06/01/1990  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 39092 GOLDEN BEACH RD |     | MECHANICSVILLE| Maryland | 20659 |   | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD    | 666450008 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |



@JPA
@JPA13
@regression
Scenario Outline: 13_JPA_KY_Taxes_Verify
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
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article		| ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone |				 |			  | Yes          |       |       | 2500        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I verify Taxes

	Examples: 
	| Places | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	|  KY    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario13 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 3165 Olivet Church Rd |      | Paducah  | Kentucky | 53189   | McCracken | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@JPA
@JPA14
@regression
Scenario Outline: 14_JPA_Verify_Prevent_IRPM_From
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 12000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click IRPM tab on personal articles page in PC9
	And I verify IRPM is prevented
	Then I Logout of the Policy Center application

	Examples: 
	| Places| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName      | DateOfBirth   | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender               | Occupation | Investigations | CareOf     | AddressLine1        | AddressLine2 | City        | State         | ZipCode    | County          | Country                  | AddressType              | Description     | ProducerOrganization                      | ProducerCode                              | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| MO    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-1  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 1705 Meadow View Dr |              | Kirksville  | Missouri      | 63501      | Adair           | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| HI    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-2  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 3754 Salt Lake Blvd |              | Honolulu    | Hawaii        | 96818      | Honolulu        | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| OH    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-3  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 7845 Wilderness Dr  |              | Mentor      | Ohio          | 44060      | Lake            | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| TX    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-4  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 610 NE 1400         |              | Andrews     | Texas         | 79714      | Andrews         | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| NV    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-5  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 877 Montera Ln      |              | Boulder     | Nevada        | 89005      | Clark           | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| CT    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-6  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 3 Sypher Rd         |              | Chester     | Connecticut   | 06412      | Middlesex       | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| LA    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-7  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 7340 Weaver Ave     |              | New Orleans | Louisiana     | 70127      | Orleans         | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| NE    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-8  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 3428 Lafayette Ave  |              | Omaha       | Nebraska      | 68131      | Douglas         | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| NH    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-9  | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 381 Webster Lake Rd |              | Franklin    | New Hampshire | 03235      | Merrimack       | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| VA    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-10 | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 4550 Strutfield Ln  | Apt 2407     | Alexandria  | Virginia      | 22311      | Alexandria City | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| WA    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | ROLANDO   | ACEVEDO       | 10/01/1989    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 523 MARION st W     |              | ABERDEEN    | Washington    | 98520      | Grays Harbor    | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666813788 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

	## NJ state PA is not ready yet
	#     | NJ            | REGISTRY               | PLP         | PC      | Desktop | IE       | su       | gw        | JPA           | scenario14-11 | 05/25/1976    | Single       | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |                      | vbadvel@jminsure.com | Male       | Other          | No         | TestCareOf          | 44 Spruce St |             | Jersey City   | New Jersey | 07306           | Hudson                   | United States of America | Home            | TestDescription                           | septum docklands sympathy potomac foxings | DIRD      | 666768133         | No                 | Other                          | Mail              | No         | yes                 | yes                       | yes       | 1234          | SYSTEMDATE+0     | PersonalArticles     | No           | No               | No |
	## MT state is not released yet
	#     | MT            | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario14-12| 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf |890 Constitution Ave |			    | Billings    |Montana     | 59105   |         | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |	

@JPA
@JPA15
@regression	
Scenario Outline: 15_JPA_Verify_IRPM_No_Residence_Location_for 
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 12000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click IRPM tab on personal articles page in PC9
	And I verify IRPM not prevented
	And I verify IRPM has no Residence Location
	Then I Logout of the Policy Center application

	Examples: 
	| Places | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| DC     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario15 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf |924 Perry Pine		|              | Washington  |District of Columbia    | 20017   | District of Columbia | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	
@JPA
@JPA16
@regression
Scenario Outline: 16_JPA_Verify_IRPM_No_Residence_Type_for
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 12000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click IRPM tab on personal articles page in PC9
	And I verify IRPM not prevented
	And I verify IRPM has no Residence Location
	And I verify IRPM has no Residence Type
	And I verify IRPM has no Age/Lifestyle
	Then I Logout of the Policy Center application

	Examples: 
	| Places | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| MD     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario16 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf |2445 Lyttonsville Rd| Apt 803     |Silver Spring| Maryland   | 20910   | Montgomery  | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	


@JPA
@JPA17
@regression	
Scenario Outline: 17_JPA_Verify_IRPM_Minus_And_Plus_40_percentage_in_Overall_for
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 12000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click IRPM tab on personal articles page in PC9
	And I verify IRPM not prevented
	And I verify IRPM has Minus And Plus 40 Percentage in Overall
	Then I Logout of the Policy Center application
	 
	Examples: 
	| Places | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName     | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1 | AddressLine2 | City     | State | ZipCode | County | Country                  | AddressType | Description     | ProducerOrganization                                  | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| MN     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario17-1 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | PO Box 788   |              | Rockport | Maine | 04856   | Knox   | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings             | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| ME     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario17-2| 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No              | TestCareOf | 638 Ontario St SE  |        | Minneapolis | Minnesota | 55414   |  Hennepin   | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	#| CO     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JOSE      | ABITIA   | 10/01/1942  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No                 | TestCareOf | 2008 E LAFAYETTE ST  |      | DENVER    | Colorado   | 80210   | DENVER       | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666381230 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	

@JPA
@JPA18
@regression	
Scenario Outline: 18_JPA_Verify_No_Rewrite_Fee_for_KY
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I Cancel policy with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click next on the Risk Analysis in PC9
	And I click Quote on the Policy Review for JPA in PC9
	And I Issue the JPA Smoke test policy in PC9 for policy ReWrite
	And I Logout of the Policy Center application
	###check rewrite fee in BC
	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu 
	And Verify there is no rewrite fee
	And I Logout of the Billing Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName    | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1		| AddressLine2 | City        | State     | ZipCode | County      | Country                  | AddressType | Description     | ProducerOrganization					     | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario18  | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1132 Fairview Ave|  Apt M7      |Bowling Green| Kentucky  | 42103   | Warren      | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |	


@JPA
@JPA19
@regression	
Scenario Outline: 19_JPA_Verify_No_Reinstate_Fee_for_KY
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I Cancel policy with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Reinstate Policy from actions menu of Policy Cenetrin PC9
	And I select reason on the start reinstatement page in PC9
	| ReinstatmentReason |
	| Policy Correction  |
	And I click Reinstate on the Policy reinstate Quote page
	And I click OK to confirm the policy Reinstatement
	And I Logout of the Policy Center application
	###check rewrite fee in BC
	And I access the Guidewire BC on <Target> in <Browser>	
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select Charges from left navigation menu 
	And Verify there is no reinstatement fee
	And I Logout of the Billing Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName    | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1		| AddressLine2 | City        | State     | ZipCode | County      | Country                  | AddressType | Description     | ProducerOrganization					    | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario19  | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1132 Fairview Ave|  Apt M7      |Bowling Green| Kentucky  | 42103   | Warren      | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |	


@JPA
@JPA20
@regression	
Scenario Outline: 20_JPA_Verify_NSF_Fee_for_NJ
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	And I Logout of the Policy Center application
	###check NSF fee in BC
	Given I access the Guidewire BC on <Target> in <Browser>	
	When I enter bcmanager and bcmanagerpwd on the BC Login page	
	When I select Desktop from the Tab menu
	And I select New Payment:Multiple Payment Entry from actions menu under Desktop tab
	And I Enter Payment information on Multiple Payment Entry Information page
	| AccountNum | PaymentInstrument | CheckNum | Amount |
	| REGISTRY   | Check             | 12345678 | 50     |
	And I click Next on Multiple Payment Entry Information page
	And I click Finish on Multiple Payment Entry Confirm page
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I select action on Account Details page in BC
	| Action   |
	| Reverse  |
	And I select reason on Confirm Payment Reversal page in BC
	| Reason             |
	| Returned Check/NSF |
	And I click OK on Confirm Payment Reversal page in BC 
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results
	And I select Charges from left navigation menu 
	And Verify the NSF fee is $15.00
	And I Logout of the Billing Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName    | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1		| AddressLine2 | City        | State     | ZipCode | County      | Country                  | AddressType | Description     | ProducerOrganization					    | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | ANUJ      | VERMA       | 04/01/1963  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 63 Riverside Dr  |  A           |Oakland      | New Jersey| 07436   | Bergen      | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666804961 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |	

@JPA
@JPA21
Scenario Outline: 21_Verify_PC_Send_Submission_Payload_When_PA_Submission_Issued_136892
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
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |      |       | Yes          |       |       | 2500        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	When I Issue the JPA Smoke test policy in PC9 
	And I verify below payload
	| Type |
	| Submission   |
	Then I Logout of the Policy Center application

	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName  | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail     | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1  | AddressLine2 | City     | State     | ZipCode | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JACK       | ADA      | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 | rparas@jminsure.com | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1 DELAWARE E PL |              | CHICAGO | Illinois | 60611   | Cook     | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666981289 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA
@JPA22
@regression	
Scenario Outline: 22_JPA_Verify_There_is_9_or_11_Payment_Plan_but_neither_8_nor_10_payment_plan
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 100000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I answer question in UW Questions page in PC9
	| CommunityInformation | DomesticHelpInformation | OtherResidenceInformation | HowOftenWornArticles | CurrentOccupation | TravelOvernighIn12Month | CancelledOrDeniedByAnInsuranceCompany |
	| No                   | No                      | No                        | Daily                | Management	    | Never                   | No                                    |
	And I Click next on UW Questions page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 
	And I click on left navigation option in PC9
    | NavigationOption |
    |  Payment         |
	And I verify there is 9 payment paln
	And I verify there is 11 payment paln
	And I verify there no 8 payment paln
	And I verify there no 10 payment paln
	And I Logout of the Policy Center application
	Then I Kill Web Driver
	 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1        | AddressLine2 | City      | State        | ZipCode    | County  | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |JPA		 | Scenario22 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 2025 Springhouse Rd |              | Broomall  | Pennsylvania | 19008-3202 | Delaware| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA	
@JPA23
@regression	
Scenario Outline: 23_JPA_Verify_PaymentScheduleDoc_can_be_generated_for_the_policy_with_a_paymentPaln
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I answer question in UW Questions page in PC9
	| CommunityInformation | DomesticHelpInformation | OtherResidenceInformation | HowOftenWornArticles | CurrentOccupation | TravelOvernighIn12Month | CancelledOrDeniedByAnInsuranceCompany |
	| No                   | No                      | No                        | Daily                | Management	    | Never                   | No                                    |
	And I Click next on UW Questions page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 
	And I Click Next on Quote Page in PC9
	And I click on left navigation option in PC9
    | NavigationOption |
    |  Payment         |
	And I select 4 Pay on Payment plan page
	And I Issue the JPA Smoke test policy in PC9 
	And I Logout of the Policy Center application
	## Generate payment schedule document in BC
	Given I access the Guidewire BC on <Target> in <Browser>	
	When I enter bcmanager and bcmanagerpwd on the BC Login page
	And I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results		
	## Verify the Payment Schedule document is generated
	And I select Documents from left navigation menu
	And I select New Business from list of document type names
	And I click on Search button on Document page in BC
	And Verify the New Business Formset document is generated
	And I Logout of the Billing Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1        | AddressLine2 | City      | State        | ZipCode    | County  | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |JPA		 | Scenario23 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 2025 Springhouse Rd |              | Broomall  | Pennsylvania | 19008-3202 | Delaware| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@JPA	
@JPA24
@regression	
Scenario Outline: 24_JPA_Verify_Misdermeanor_UWBlockingBind_When_Sherlock_ComeBack_with_records_in_last_7_years_in_NewBusiness
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 
	And I click on left navigation option in PC9
    | NavigationOption |
    | Risk Analysis    | 
	And I see <Rule> is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I see convict in recent 7 years is recorded under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| Places | Rule          | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1          | AddressLine2 | City   | State     | ZipCode    | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	#| WI     | Misdemeanor   | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Loreta    | Zahara   | 01/01/1938  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1155 W Winneconne Ave |              | Neenah | Wisconsin | 54956-3693 | Winnebago | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	#| WA     | Crime Activity| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Emily  	 | Young      | 01/26/1993   | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 200 Fake St    |                    | Anburn  | Washington | 98002     | King     | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	#| CO     | Crime Activity| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Olivia  	 | Wyatt      | 01/05/1993   | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 500 Fake St    |                    | Denver  | Colorado | 80091     | King     | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	|  AZ    | Crime Activity| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Sophia 	 | Owen      | 01/01/1993   |              |             |              |               |              |              |              |              |                |        | Other      | No             | TestCareOf | 100 Fake St    |              | Phoenix  | Arizona | 85001     | Maricopa     | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@JPA	
@JPA25
@regression	
Scenario Outline: 25_JPA_Verify_Misdermeanor_UWBlockingBind_When_Sherlock_ComeBack_with_records_in_last_7_years_in_PolicyChange
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	##do policy change
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+7 and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Cufflinks   |                | Gents      |              |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option in PC9 for policy change
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page for PolicyChange in PC9
	And I see convict in recent 7 years is recorded under Conviction tab on Risk Analysis Page for PolicyChange in PC9		
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| Places | Rule          | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf     | AddressLine1   | AddressLine2 | City   | State     | ZipCode   | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	|  AZ    | Crime Activity| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Sophia 	 | Owen      | 01/01/1993   |              |             |              |               |              |              |              |              |                |        | Other      | No             | TestCareOf | 100 Fake St    |              | Phoenix  | Arizona | 85001     | Maricopa  | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA	
@JPA26
@regression	
Scenario Outline: 26_JPA_Verify_No_Misdermeanor_UWBlockingBind_When_Sherlock_ComeBack_with_records_in_moreThen_7_years_in_NewBusiness
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 
	And I click on left navigation option in PC9
    | NavigationOption |
    | Risk Analysis    | 
	And I see Misdemeanor rule is not triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I do not see convict in recent 7 years is recorded under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1         | AddressLine2 | City    | State | ZipCode    | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 Purple Rd       |              | Castalia| Iowa  | 50001 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA	
@JPA27
@regression	
Scenario Outline: 27_JPA_Verify_No_Misdermeanor_UWBlockingBind_When_Sherlock_ComeBack_with_records_in_moreThen_7_years_in_PolicyChange
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	##do policy change
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+7 and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Cufflinks   |                | Gents      |              |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option in PC9 for policy change
    | NavigationOption |
    | RiskAnalysis    | 
	And I see Misdemeanor rule is not triggered under UW Issues tab on Risk Analysis Page for PolicyChange in PC9
	And I click Conviction tab on Risk Analysis Page for PolicyChange in PC9
	And I do not see convict in recent 7 years is recorded under Conviction tab on Risk Analysis Page for PolicyChange in PC9		
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1         | AddressLine2 | City    | State | ZipCode    | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 Purple Rd       |              | Castalia| Iowa  | 50001 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |



@JPA	
@JPA28
@regression	
Scenario Outline: 28_JPA_Verify_Misdermeanor_UWBlockingBind_When_Sherlock_ComeBack_with_records_in_last_7_years_in_PolicyRewrite
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	#cancel policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I Cancel policy with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	#rewrite policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option for policy rewrite in PC9
    | NavigationOption |
    | RiskAnalysis    | 
	And I see Misdemeanor is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I see convict in recent 7 years is recorded under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver	
		 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1         | AddressLine2 | City    | State     | ZipCode    | County   | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Loreta	 | Zahara      | 01/01/1938  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1155 W Winneconne Ave|              | Neenah  | Wisconsin | 54956-3693 | Winnebago| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA	
@JPA29
@regression	
Scenario Outline: 29_JPA_Verify_No_Misdermeanor_UWBlockingBind_When_Sherlock_ComeBack_with_records_in_last_7_years_in_PolicyRewrite
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	#cancel policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I Cancel policy with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	#rewrite policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option for policy rewrite in PC9
    | NavigationOption |
    | RiskAnalysis    | 
	And I see Misdemeanor rule is not triggered under UW Issues tab on Risk Analysis Page for PolicyChange in PC9
	And I click Conviction tab on Risk Analysis Page for PolicyChange in PC9
	And I do not see convict in recent 7 years is recorded under Conviction tab on Risk Analysis Page for PolicyChange in PC9		
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
		 
	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName   | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1         | AddressLine2 | City    | State | ZipCode    | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 120th Ave       |              | Castalia| Iowa  | 52133-8523 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@JPA	
@JPA30
@regression	
Scenario Outline: 30_JPA_Verify_ArticleValueExceedThreshold_UWBlockingBind_in_NewBusiness
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Ring           | Engagement     | Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Bracelet       |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Earrings       | Pair			| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Necklace       |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Watch          |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Chain          |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Cufflinks      |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pearl Strand   | Other			| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pendant        |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Brooch		   |  				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Charms         |				| Gents      |              |       |       | 2500         | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Ring           | Engagement     | Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Bracelet       |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Earrings       | Pair			| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Necklace       |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Watch          |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Chain          |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	#| self        | Cufflinks      |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pearl Strand   | Other			| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pendant        |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Brooch         | 			    | Ladies      |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |		
	| self        | Charms		   |				| Ladies      |              |       |       | 2500         | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Loose Stone    |				|		      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I Click next on personal articles page in PC9
	And I answer question in UW Questions page in PC9
	| CommunityInformation | DomesticHelpInformation | OtherResidenceInformation | HowOftenWornArticles | CurrentOccupation | TravelOvernighIn12Month | CancelledOrDeniedByAnInsuranceCompany |
	| No                   | No                      | No                        | Daily                | Management	    | Never                   | No                                    |
	And I Click next on UW Questions page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 
	And I click on left navigation option in PC9
    | NavigationOption |
    | Risk Analysis    | 
	And I see <Rule> is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| Places | Rule												 | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1          | AddressLine2 | City   | State     | ZipCode    | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| WI     | Article Value Exceeds Threshold : 22 : occurrence | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Loreta    | Zahara   | 01/01/1938  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1155 W Winneconne Ave |              | Neenah | Wisconsin | 54956-3693 | Winnebago | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	

@JPA	
@JPA31
@regression	
Scenario Outline: 31_JPA_Verify_ArticleValueExceedThreshold_UWBlockingBind_in_PolicyRewrite
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Ring           | Engagement     | Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Bracelet       |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Earrings       | Pair			| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Necklace       |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Watch          |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Chain          |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Cufflinks      |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pearl Strand   | Other			| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pendant        |				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Brooch		   |  				| Gents      |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Charms         |				| Gents      |              |       |       | 2500         | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Ring           | Engagement     | Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Bracelet       |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Earrings       | Pair			| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Necklace       |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Watch          |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Chain          |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pearl Strand   | Other			| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	| self        | Pendant        |				| Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Brooch         | 			    | Ladies     |              |       |       | 50000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |		
	| self        | Charms		   |				| Ladies     |              |       |       | 2500         | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |	
	| self        | Loose Stone    |				|		     |              |       |       | 10000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I answer question in UW Questions page in PC9
	| CommunityInformation | DomesticHelpInformation | OtherResidenceInformation | HowOftenWornArticles | CurrentOccupation | TravelOvernighIn12Month | CancelledOrDeniedByAnInsuranceCompany |
	| No                   | No                      | No                        | Daily                | Management	    | Never                   | No                                    |
	And I Click next on UW Questions page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I Cancel policy with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I click on left navigation option for policy rewrite in PC9
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
	 
	Examples: 
	| Places | Rule												 | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1          | AddressLine2 | City   | State     | ZipCode    | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| WI     | Article Value Exceeds Threshold : 22 : occurrence | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Loreta    | Zahara   | 01/01/1938  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1155 W Winneconne Ave |              | Neenah | Wisconsin | 54956-3693 | Winnebago | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	

@JPA	
@JPA32
@regression	
Scenario Outline: 32_JPA_Verify_Misdermeanor_UWBlockingBind_When_manually_add_records_in_last_7_years_in_NewBusiness
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click Risk tab on policy contact page in PC9 
	And I add a record into Manually Reported Records table
	| Record Date | Conviction Type | Conviction Category |
	| 10/01/2019  | Other           | Drug Crimes         |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 		
	And I click on left navigation option for policy rewrite in PC9
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I see convict in recent 7 years is recorded manually under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver	
		 
	Examples: 
	| Rule		  | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| Misdemeanor | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 120th Ave       |              | Castalia| Iowa  | 52133-8523 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	
@JPA	
@JPA33
@regression	
Scenario Outline: 33_JPA_Verify_Misdermeanor_UWBlockingBind_When_manully_add_records_in_last_7_years_in_PolicyChange
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click Risk tab on policy contact page in PC9 
	And I add a record into Manually Reported Records table
	| Record Date | Conviction Type | Conviction Category |
	| 10/01/2019  | Other           | Drug Crimes         |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	##do policy change
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+7 and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Cufflinks   |                | Gents      |              |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option in PC9 for policy change
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I see convict in recent 7 years is recorded manually under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver

	Examples: 
	| Rule      | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	|Misdemeanor| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 120th Ave       |              | Castalia| Iowa  | 52133-8523 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@JPA34
@regression
Scenario Outline: 34_JPA_submission_declined
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I update Alarm type  on the policy location page in PC9
	| AlarmType        |
	| Central Station|
	And I update Safe details on the policy location page in PC9
	| IsAnchred | Weight   |
	| yes       | 0-100 lbs |
	And I decline policy for <DeclineReason>


	Examples: 
	| DeclineReason			      | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| Other				          | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| Nature of the item/schedule | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| Level of Security			  | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| Credit;Loss history;Travel Risk | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| Travel Risk                 | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
@JPA35
@regression
Scenario Outline: 35_JPA_Policy_Change_Declined
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
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |      |       | Yes          |       |       | 2500        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	When I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I decline policy for <DeclineReason>


	Examples: 
	| DeclineReason			      | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| Other				          | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| Nature of the item/schedule | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| Level of Security			  | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| Credit;Travel Risk          | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |	
	| Travel Risk                 | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario33 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 100 E Main St |              | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA	
@JPA36
@regression	
Scenario Outline: 36_JPA_Verify_Misdermeanor_UWBlockingBind_When_manully_add_conviction_records_in_last_7_years_in_PolicyRewrite
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
    And I click Risk tab on policy contact page in PC9 
	And I add a record into Manually Reported Records table
	| Record Date | Conviction Type | Conviction Category |
	| 10/01/2019  | Other           | Drug Crimes         |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes              | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	#cancel policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I Cancel policy with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	#rewrite policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option for policy rewrite in PC9
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> is triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I see convict in recent 7 years is recorded manually under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
		  
	Examples: 
	| Rule      | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	|Misdemeanor| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 120th Ave       |              | Castalia| Iowa  | 52133-8523 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	

@JPA	
@JPA37
@regression	
Scenario Outline: 37_JPA_Verify_No_Misdermeanor_UWBlockingBind_When_manually_add_records_beyond_7_years_in_NewBusiness
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click Risk tab on policy contact page in PC9 
	And I add a record into Manually Reported Records table
	| Record Date | Conviction Type | Conviction Category |
	| 10/01/2009  | Other           | Drug Crimes         |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 		
	And I click on left navigation option for policy rewrite in PC9
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> rule is not triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I do not see convict in recent 7 years is recorded manually under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver	
		 
	Examples: 
	| Rule		  | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| Misdemeanor | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 120th Ave       |              | Castalia| Iowa  | 52133-8523 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	
@JPA	
@JPA38
@regression	
Scenario Outline: 38_JPA_Verify_No_Misdermeanor_UWBlockingBind_When_manully_add_records_beyond_7_years_in_PolicyChange
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click Risk tab on policy contact page in PC9 
	And I add a record into Manually Reported Records table
	| Record Date | Conviction Type | Conviction Category |
	| 10/01/2009  | Other           | Drug Crimes         |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	##do policy change
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+7 and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Cufflinks   |                | Gents      |              |       |       | 2499         | 100        | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes               | Yes                | Yes                   |
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option in PC9 for policy change
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> rule is not triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I do not see convict in recent 7 years is recorded manually under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application		
	Then I Kill Web Driver

	Examples: 
	| Rule      | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	|Misdemeanor| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 120th Ave       |              | Castalia| Iowa  | 52133-8523 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA	
@JPA39
@regression	
Scenario Outline: 39_JPA_Verify_No_Misdermeanor_UWBlockingBind_When_manully_add_conviction_records_beyond_7_years_in_PolicyRewrite
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
    And I click Risk tab on policy contact page in PC9 
	And I add a record into Manually Reported Records table
	| Record Date | Conviction Type | Conviction Category |
	| 10/01/2009  | Other           | Drug Crimes         |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 5000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| Yes              | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9 	
	And I Click Next on Quote Page in PC9
	And I Issue the JPA Smoke test policy in PC9 
	#cancel policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy cancel from actions menu of Policy Cenetrin PC9
	And I Cancel policy with below details in PC9 
	| Source  | Reason               | ReasonMethod | CancelEffDate |
	| Insured | Courtesy Flat Cancel |              | SYSTEMDATE    |
	And I Issue the canceled policy in PC9 
	#rewrite policy
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Rewrite Fullterm Policy from actions menu of Policy Cenetrin PC9
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
	And I Click next on personal articles page in PC9	
	And I click next on Additional Details in PC9 
	And I click Quote on the Policy Review for JPA in PC9
	And I click on left navigation option for policy rewrite in PC9
    | NavigationOption |
    | RiskAnalysis    | 
	And I see <Rule> rule is not triggered under UW Issues tab on Risk Analysis Page in PC9
	And I click Conviction tab on Risk Analysis Page in PC9
	And I do not see convict in recent 7 years is recorded manually under Conviction tab on Risk Analysis Page in PC9	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver
		  
	Examples: 
	| Rule      | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	|Misdemeanor| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |Gina  	 | Bobina      | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 120th Ave       |              | Castalia| Iowa  | 52133-8523 | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA	
@JPA40
@regression	
Scenario Outline: 40_JPA_Verify_Product_Availability_for_a_ProducerCode
    ## do clean up before adding product
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I go to Producer Code page through administration
	And I search a <Agency> on the Producer Codes search page
	And I click on the producer link from the search result on the Producer Codes search page
	And I click on Producer Availability tab on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I select the entered product on the Producer Code page
	And I delete the entered products on the Producer Code page
	And I click on update button on the Producer Code page
	And I Logout of the Policy Center application
	## end clean up
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I go to Producer Code page through administration
	And I search a <Agency> on the Producer Codes search page
	And I click on the producer link from the search result on the Producer Codes search page
	And I click on Producer Availability tab on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I enter product details on the Producer Code page with <Product>, <State>, <EffectiveDate>, <ExpiryDate>	
	And I click on update button on the Producer Code page
	And I see the products are entered successfully on the Producer Code page
	And I click Edit button on the Producer Code page
	And I select the entered product on the Producer Code page
	And I delete the entered products on the Producer Code page
	And I click on update button on the Producer Code page	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver

	Examples: 
	| ApplicationEnvironment | Application | Target | Browser | UserName | Password | Agency | Product			| State | EffectiveDate | ExpiryDate |
	| PLP                    | PC          | Desktop | IE      | su      | gw       |  F50   | Commercial Lines |		| 04/20/2020    |            |
	| PLP                    | PC          | Desktop | IE      | su      | gw       |  F50   | Personal Jewelry |		| 04/20/2020    |            |
	| PLP                    | PC          | Desktop | IE      | su      | gw       |  F50   | Personal Articles|		| 04/20/2020    |            |
	| PLP                    | PC          | Desktop | IE      | su      | gw       |  F50   | Commercial Lines |		| 04/20/2020    | 04/20/2022 |
	| PLP                    | PC          | Desktop | IE      | su      | gw       |  F50   | Personal Jewelry |		| 04/20/2020    | 04/20/2022 |
	| PLP                    | PC          | Desktop | IE      | su      | gw       |  F50   | Personal Articles|		| 04/20/2020    | 04/20/2022 |

@JPA	
@JPA41
@regression	
Scenario Outline: 41_JPA_Verify_No_Product_Availability_for_a_ProducerCode_with_any_state_having_overlapping_dates_as_NULL_state
	## do clean up before adding product
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I go to Producer Code page through administration
	And I search a <Agency> on the Producer Codes search page
	And I click on the producer link from the search result on the Producer Codes search page
	And I click on Producer Availability tab on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I select the entered product on the Producer Code page
	And I delete the entered products on the Producer Code page
	And I click on update button on the Producer Code page
	And I Logout of the Policy Center application
	## end clean up
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I go to Producer Code page through administration
	And I search a <Agency> on the Producer Codes search page
	And I click on the producer link from the search result on the Producer Codes search page
	And I click on Producer Availability tab on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I enter product details on the Producer Code page with <Product>, <State>, <EffectiveDate>, <ExpiryDate>	
	And I click on update button on the Producer Code page
	And I see the products are entered successfully on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I enter product details on the Producer Code page with <Product>, <State1:EnteredNumber>, <EffectiveDate1>, <ExpiryDate1>	
	And I click on update button on the Producer Code page
	And I do not see the products are entered successfully on the Producer Code page 
	And I select the entered product on the Producer Code page
	And I delete the entered products on the Producer Code page
	And I click on update button on the Producer Code page	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver

	Examples: 
	| ApplicationEnvironment | Application | Target  | Browser | UserName | Password | Agency | Product           | State   | EffectiveDate | ExpiryDate | State1:EnteredNumber | EffectiveDate1 | ExpiryDate1 |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Commercial Lines  |         | 01/01/2020    | 12/31/2022 | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Jewelry  |         | 01/01/2020    | 12/31/2022 | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Articles |         | 01/01/2020    | 12/31/2022 | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Commercial Lines  |         | 01/01/2020    |            | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Jewelry  |         | 01/01/2020    |            | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Articles |         | 01/01/2020    |            | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Commercial Lines  | Alabama | 01/01/2020    | 12/31/2022 | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Jewelry  | Alabama | 01/01/2020    | 12/31/2022 | Alabama:2            | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Articles | Alabama | 01/01/2020    | 12/31/2022 | Alabama:2            | 05/01/2020     | 12/01/2023  |

@JPA	
@JPA42
@regression	
	Scenario Outline: 42_JPA_Verify_No_Product_Availability_for_a_ProducerCode_with_diff_product_having_overlapping_dates_for_NULL_state
	## do clean up before adding product
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I go to Producer Code page through administration
	And I search a <Agency> on the Producer Codes search page
	And I click on the producer link from the search result on the Producer Codes search page
	And I click on Producer Availability tab on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I select the entered product on the Producer Code page
	And I delete the entered products on the Producer Code page
	And I click on update button on the Producer Code page
	And I Logout of the Policy Center application
	## end clean up
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I go to Producer Code page through administration
	And I search a <Agency> on the Producer Codes search page
	And I click on the producer link from the search result on the Producer Codes search page
	And I click on Producer Availability tab on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I enter product details on the Producer Code page with <Product>, <State>, <EffectiveDate>, <ExpiryDate>
	And I click on update button on the Producer Code page
	And I see the products are entered successfully on the Producer Code page
	And I click Edit button on the Producer Code page
	And I click Add button on the Producer Code page
	And I enter product details on the Producer Code page with <Product1:EnteredNumber>, <State>, <EffectiveDate1>, <ExpiryDate1>	
	And I click on update button on the Producer Code page
	And I do not see the products are entered successfully on the Producer Code page 
	And I select the entered product on the Producer Code page
	And I delete the entered products on the Producer Code page
	And I click on update button on the Producer Code page	
	And I Logout of the Policy Center application	
	Then I Kill Web Driver

	Examples: 
	| ApplicationEnvironment | Application | Target  | Browser | UserName | Password | Agency | Product          | State | EffectiveDate | ExpiryDate | Product1:EnteredNumber | EffectiveDate1 | ExpiryDate1 |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Commercial Lines |       | 01/01/2020    | 12/31/2022 | Personal Jewelry:2     | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Commercial Lines |       | 01/01/2020    | 12/31/2022 | Personal Articles:2    | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Jewelry |       | 01/01/2020    | 12/31/2022 | Commercial Lines:2    | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Jewelry |       | 01/01/2020    | 12/31/2022 | Personal Articles:2    | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Articles|       | 01/01/2020    | 12/31/2022 | Personal Jewelry:2     | 05/01/2020     | 12/01/2023  |
	| PLP                    | PC          | Desktop | IE      | su       | gw       | F50    | Personal Articles|       | 01/01/2020    | 12/31/2022 | Commercial Lines:2    | 05/01/2020     | 12/01/2023  |

@JPA
@JPA43
@regression
Scenario Outline: 43_JPA_Verify_IRPM_No_Age_Lifestyle_for
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 25000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click IRPM tab on personal articles page in PC9
	And I verify IRPM not prevented	
	And I verify IRPM has no Age/Lifestyle
	Then I Logout of the Policy Center application

	Examples: 
	| Places | AccountNumber | ApplicationEnvironment | Application | Target | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| MA     | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | JPA       | scenario43 | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf |1507 Francis Ave	  |             |Mansfield| Massachusetts   | 02048   | Bristol  | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA
@JPA44
@regression
Scenario Outline: 44_JPA_Verify_PC_New_Submission_9_Pay_12%_Renewal_
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
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Update Unschedule details on personal articles page in PC9
	| Unschedulelimit | UnscheduleDeductible |
	| 5000            | 100                  |
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |      |       | Yes          |       |       | 800000        | 100       | NO                  |             |                    |                   |               |          |               | Safe           | 1 : 0-100 lbs |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I Update Location details in Additional Underwriting question
	| GatedEntrance | fenceSurround | guardatgate | guardpresentfrequency | communitypatrol | communitypatrolfrequency | enterancetocommunity | guestenterancetocommunity | domestichelp | helptype          | employmentlength     | resideathome | theycomehome | otherpersonresideathome | elsereside |
	| yes           | yes           | yes         | 24 hours              | yes             | 24 hours                 |card reader                 |  Keypad             | yes          | Medical Assistant | Less than 1 year ago | yes          | Daily        | yes                     | partner   |
	And I Update Contact details in Additional Underwriting question
	| Articleworn      | currentocuption | overnighttravel | travelaborod | safeguradwhiletraviling            |
	| 1-2 times a week | Art and Design  | 7-9 trips       | yes          | My jewelry is with me at all times |
	And I Click next on Additional Underwriting question page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9
	And I Click Next on Quote Page in PC9
	And I check forms listed on Forms Page and click next in PC9
	And I enter below details on Payment Page in PC9
	| BilingMethod | InstallmentPlan |
	| Direct Bill  | 9 Pay - 12% Renewal |
	And I Issue the JPA Smoke test policy in PC9 
	Then I Logout of the Policy Center application

	Examples: 
	| Place | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName  | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1    | AddressLine2 | City             | State      | ZipCode | County       | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| OH    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Jack       | Ada		 | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 7845 Wilderness Dr  |              | Mentor      | Ohio          | 44060      | Lake            | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
	| LA    | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       | Jack       | Ada      | 05/25/1976    | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male                 | Other      | No             | TestCareOf | 7340 Weaver Ave     |              | New Orleans | Louisiana     | 70127      | Orleans         | United States of America | Home                     | TestDescription | septum docklands sympathy potomac foxings | DIRD                                      | 666768133 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA
@JPA45
@regression
Scenario Outline: 45_JPA_submission_declined_ReasonText_with_Other_Reason
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 12000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9	
	And I decline policy for <DeclineReason>
	And I click on Decline button
	Then I verify error message <Error> is shown up
	And I Logout of the Policy Center application

	Examples: 
	| DeclineReason		  | Error											  |  Places | Score | AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1    | AddressLine2 | City             | State      | ZipCode | County       | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| JPA:Other:CheckText | Missing required field "Reason Text (for letter)" | WA     | 120   | REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |JPA45FName  | JPA45LName  | 10/01/1989  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 523 MARION st W |              | ABERDEEN         | Washington | 98520   | Grays Harbor | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666813788 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@JPA
@JPA46
@regression
Scenario Outline: 46_JPA_Verify_KY_Taxes_Prorating_on_PolicyChange
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
	And I enter below details on the policy information page in PC9
	| Term  | PolicyEffDate | ProducerCode |
	| Other |               |              |
	And I click next on the policy location page in PC9
	And I enter <DateOfBirth> and denied coverage details on the policy contact page in PC9
	| deniedcoverage | reason       |
	| Yes            | Loss History |
	And I click next on the  policy contact page in PC9
	And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article        | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details  | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Loose Stone    |                |            |              |       |       | 12000        | 100        | NO                  |             |                    |                   |               |          |               |                |               |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9
	And I select Additional Details in Additional Details in PC9
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on Risk Analysis Page for ST in PC9	
	When I Issue the JPA Smoke test policy in PC9 
	When I select Accounts from the Search Tab menu of PC9
	And search for account with REGISTRY and select from search results in PC9 
	And I click on PolicyNo of Account detail screen in PC9
	And I select Policy Chnage from actions menu of Policy Cenetrin PC9
	And I Start Policy Change in PC9 with currentDate+200 and Added Item(s)
	And I enter the details on the policy information page in PC9
	And I click next on the policy location page in PC9
	And I click next on the  policy contact page in PC9
    And I Enter below Multi Article details on personal articles page in PC9
	| LocatedWith | Article | ArticleSubType | GenderType | WearableTech | Brand | Style | ArticleValue | Deductible | FullDescriptionFlag | Description | AppraisalRequested | AppraisalReceived | AppraisalDate | Retailer | ValuationType | Article Stored | Safe Details | ValuationType | Damage | CarePlan | CarePLanID | HowWasArticleAquired | ArticleAquiredYear | ArticleAquiredInsurance | ArticleStored | CarePlanExpirDate | AffinityGroup | Damagetype | Articleinsuredbyother |
	| self        | Chain   |                | Gents      |              |       |       | 6000         | 0          | NO                  |             |                    |                   |               |          |               |                |              |               | No     |          |            |                      |                    |                         |               |                   |               |            |                       |
	And I Click next on personal articles page in PC9	
	And I select Additional Details in Additional Details in PC9 for policy change
	| PossessionofItem | FaudWarningConsent | ConsumerReportConsent |
	| No               | Yes                | Yes                   |
	And I click Quote on the Policy Review for JPA in PC9
	And I verify the taxes are prorated correctly 
	And I Logout of the Policy Center application

	Examples: 
	| AccountNumber | ApplicationEnvironment | Application | Target  | Browser | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1    | AddressLine2 | City             | State      | ZipCode | County       | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN       | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PLP                    | PC          | Desktop | IE      | su       | gw       |JPA46FName  | JPA46LName  | 10/01/1989  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf |211 Monohan Dr |              | Louisville         | Kentucky | 40207   | Jefferson | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 666813788 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |
