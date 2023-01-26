Feature: BOLT_QNA_PC9
	
@STP
@regression
@BoltregressionStage
@BL01
                Scenario Outline: 01_BOLT_DefaultProducer_STP_LessThan16kWithAppraisals_US
				Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
                | Description | Value |
                | Ring        | 15000 |
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress>
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          |   B99-PerfAgent            |        |
				And I create API request with Policy Details
					| method | jsonrpc |
					|        |         |
				And I get API response
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I enetr ApplicationID
				# # And I click on NewExisting Customer Page 
				And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> in applicant wearer page for BOLT
				And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
				And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's | 01/04/2017     | Yes       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
                And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | USA     | You have successfully completed your application, and your jewelry is now insured. |
				And I access the Guidewire PC on Desktop in IE
              	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
                And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I logout of the PC9 application 
				And I Kill Web Driver
                And I access the Guidewire BC on Desktop in IE
                And I enter bcmanager and bcmanagerpwd on the BC Login page
                And I select Search from the Tab menu 
                And search for account with <AccountNumber> and select from search results for QNA 
                And I select details from left navigation menu 
                Then I verify <GWPrimaryInsured> , <GWAddress> , " " , <GWPaymentPlan> ,  REGISTRY , REGISTRY , <GWPayment_Instrument> in Account Details page  
                And I Logout of the Billing Center application
                Examples:
                | APIName             | APIOperation | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                | fullquotecreatebolt | POST         | QNABLT                 | desktop    |            | Chrome      |                 | BOLT      | STP      | 48 Jewelers Park Dr |           | Neenah | Wi    | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Phone             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | B99-PerfAgent         | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | No                |

@NonSTP                               
@regression
@BoltregressionStage
@BL02
                Scenario Outline: 02_BOLT_Producer_KL001D_NonSTP_38kWithAppraisals_US
			Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
                | Description | Value |
                | Necklace        | 38000 |
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress>
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          | KL001D        |        |
				And I create API request with Policy Details
					| method | jsonrpc |
					|        |         |
				And I get API response
                And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I enetr ApplicationID
            	And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> in applicant wearer page for BOLT
				And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        | 01/04/2017     | Yes       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I enter the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                |   no        |                 |
                And I enter  for Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
                And I enter Travel Details in UW question details
                | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
                | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the confirmation page with the account number
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                 |
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. |
				And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
			    And search for account with <AccountNumber> and select from search results in PC9
               	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
                And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9    
                And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 
                Examples:
                | APIName             | APIOperation | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address          | Apartment | City           | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                            | TermsAndConditions |
                | fullquotecreatebolt | POST         | QNABLT                 | desktop    |            | Chrome      |                 | BOLT      | NonSTP   | 302 Millers Xing | Ste 11    | Harker Heights | TX    | 76548          | Yes              | 2025352871  | adzhoharidze@jminsure.com | Phone             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | KL001D       | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines | No                 |


				 
@NonSTP                      
@regression
@BoltregressionStage
@BL03
                Scenario Outline: 03_BOLT_Producer_B99D_STP_ScheduleTotalLessThen10k_Virg
			Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
                | Description | Value |
                | Watch       | 1000  |
                | Chain       | 1500  |
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress>
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          | B99-PerfAgent          |        |
				And I create API request with Policy Details
					| method | jsonrpc |
					|        |         |
				And I get API response
                And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I enetr ApplicationID
				And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> in applicant wearer page for BOLT
				And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
				And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |         |          |      |           |         |             |       |            |              |        |
                | Wearer           | WearerFName1 | WearerLName | Yes             |         |          |      |           |         |             |       | 07/07/1985 | Child        | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                | Rolex          | men's  |                |           |
                |                | men's  |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				 And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				 And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | USA     | You have successfully completed your application, and your jewelry is now insured. |
			    And I access the Guidewire PC on Desktop in IE
              	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
                And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I logout of the PC9 application 
				And I Kill Web Driver
                And I access the Guidewire BC on Desktop in IE
                 And I enter bcmanager and bcmanagerpwd on the BC Login page
                And I select Search from the Tab menu 
                And search for account with <AccountNumber> and select from search results for QNA 
                And I select details from left navigation menu 
                Then I verify <GWPrimaryInsured> , <GWAddress> , " " , <GWPaymentPlan> ,  REGISTRY , REGISTRY , <GWPayment_Instrument> in Account Details page  
                And I Logout of the Billing Center application
                Examples:
                     | APIName             | APIOperation | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                     | fullquotecreatebolt | POST         | QNABLT                 | desktop    |            | Chrome      |                 | Golden4   | NonSTP   | 48 Jewelers Park Dr |           | Neenah | WI | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Phone             | Male   | wearer     | No                    | No                       | Yes           | No               | currentdate   | B99-PerfAgent         | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | No                 |
   

@NonSTP                               
@regression
@BoltregressionStage
@BL04
                Scenario Outline: 04_BOLT_Producer_S18D_NonSTP_SingleitemGreaterthen50k_US
				Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
				| Description | Value |
				| Pendant     | 51000 | 
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress>
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          | S18D          |        |
				And I create API request with Policy Details
				| method | jsonrpc |
				|        |         |
				And I get API response				
                And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I enetr ApplicationID
				And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> in applicant wearer page for BOLT
				And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter Malling Address of Appplicant
                | Address     | Apartment | City   | State    | Zip   |
                | 900 13th St |           | Denver | Colorado | 80204 |
               And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I enter the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                |   no        |                 |
                And I enter  for Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | Yes            | test12              | Address            | Yes            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | Yes          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | Yes                   | children                | Never          |
                And I enter Travel Details in UW question details
                | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
                | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the confirmation page with the account number
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                 |
                |Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken.|
				And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
			    And search for account with <AccountNumber> and select from search results in PC9
               	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
                And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9    
                And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application  

                Examples:
                | APIName             | APIOperation | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address      | Apartment | City   | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                           | TermsAndConditions |
                | fullquotecreatebolt | POST         | QNABLT                 | desktop    |            | Chrome      |                 | Golden5   | NonSTP   | 1250 14th St |           | Denver | CO    | 80202          | No               | 9205352871  | adzhoharidze@jminsure.com | Phone             | FeMale | wearer     | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | item value exceeds underwriting guidelines;total schedule exceeds $50,000 | No                 |


@NonSTP                               
@regression
@BoltregressionStage
@BL05
                Scenario Outline: 05_BOLT_DefaultProducer_NonSTP_lessthen16KFelonyDUI_US
			Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
                | Description | Value |
                | Ring        | 6000 |
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress>
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          | B99D              |        |
				And I create API request with Policy Details
				| method | jsonrpc |
				|        |         |
				And I get API response
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                And I enetr ApplicationID
				And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> in applicant wearer page for BOLT
				And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr Sentence completion details
                | Date       | Type  |
                | 08/06/2018 | Drugs |
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType  | Gender   | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the confirmation page with the account number
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                 |
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. |
				And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
			    And search for account with <AccountNumber> and select from search results in PC9
               	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
                And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9    
                And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application  
  

                Examples:
                  | APIName             | APIOperation | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                        | TermsAndConditions |
                  | fullquotecreatebolt | POST         | QNABLT                 | desktop    |            | Chrome      |                 | Golden7   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | WI    | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Phone             | Female | felony                | No                       | Yes           | No               | currentdate   | B99D         | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Applicant convicted of a felony | No                 |


@NonSTP                               
@regression
@BoltregressionStage
@BL06
                Scenario Outline: 06_BOLT_Producer_S18D_NonSTP_lessthen16KLossGreaterthen7_5K
			Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
				| Description | Value |
				| Brooch     | 3000 | 
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress>
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          | S18D          |        |
				And I create API request with Policy Details
				| method | jsonrpc |
				|        |         |
				And I get API response
                And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
               And I enetr ApplicationID
				# And I click on NewExisting Customer Page  
            	And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> in applicant wearer page for BOLT
				And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr loss details
                | Loss_Date  | Type  | LossAmount |
                | 04/05/2015 | Theft | 3500      |
                | 12/10/2016 | Theft | 4001      |
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the confirmation page with the account number
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                 |
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. |
				And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
			    And search for account with <AccountNumber> and select from search results in PC9
               	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
                And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9    
                And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application  
 

                Examples:
                  | APIName             | APIOperation | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                     | TermsAndConditions |
                  | fullquotecreatebolt | POST         | QNABLT                 | desktop    |            | Chrome      |                 | Golden8   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | WI    | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Phone             | Female | No                    | yes                      | Yes           | No               | currentdate   | S18D         | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       |  Loss or Claim Activity  | No                 |



@NonSTP 
@regression
@BoltregressionStage
@BL07
Scenario Outline: 07_BOLT_DefaultProducer__NonSTP_Over_75k_RightPanelEdit
			Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
				| Description | Value |
				| Watch       | 60000  |
                | Pendant     | 5000  |
                | Other       | 8000  |
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress>
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          | B99D              |        |
				And I create API request with Policy Details
					| method | jsonrpc |
					|        |         |
				And I get API response
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I enetr ApplicationID
				# And I click on NewExisting Customer Page 
				And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> in applicant wearer page for BOLT
				And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                 And I Enter the Applicant or Wearers details with respect to wearing items for BOLT  
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
               And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
                | Rolex          | Women's |                |           |
                |                |         |                |           |
                | Other          |         |                |           |
				And I Edit jewelry information in Jewelry Details page
				| Item_Value |
				| 70000      |
		    	And I select <EffectiveDate> in Jewelry Details page 
				And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I enter the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                | no        |                 |
                And I enter  for Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
                And I enter Travel Details in UW question details
                | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
                | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the confirmation page with the account number
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                  |
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. |
				And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
			    And search for account with <AccountNumber> and select from search results in PC9
               	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
                And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9    
                And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application  

                Examples:
                 | APIName             | APIOperation | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName        | LastName | Address          | Apartment | City           | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                       | TermsAndConditions |
                 | fullquotecreatebolt | POST         | QNABLT                 | desktop    |            | Chrome      |                 | RegularQnAGolden | NonSTP   | 302 Millers Xing | Ste 11    | Harker Heights | TX    | 76548          | Yes              | 2025352871  | adzhoharidze@jminsure.com | Phone             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | B99D         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines;Item Type = Other - Item #3;Total Schedule Exceeds $50,000 | No                 |




@NonSTP 
@regression
@BoltregressionStage
@BL08
Scenario Outline: 08_BOLT_WrongProducer__Verify response
			 Given I execute BOLT API <APIName> to perform <APIOperation>
				When I add Jewelry Item Details
				| Description | Value |
				| Watch       | 60000  |
                | Pendant     | 5000  |
                | Other       | 8000  |
				And I Add other Details  <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> 
				| countryId | agentId   | agentFirstName | agentLastName | agentproducer | county |
				| 0         | PerfAgent | Performance    | Test          |   QQQQ            |        |
				And I create API request with Policy Details
					| method | jsonrpc |
					|        |         |
			   Then I get API response with failure
				| Errormessage                         |
				| The Agency Producer Code is invalid. |
	     		And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>

				   Examples:
                 | APIName             | APIOperation | FirstName        | LastName | Address          | Apartment | City           | State | AddressZipCode | PhoneNumber | EmailAddress         | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem |
                 | fullquotecreatebolt | POST         | RegularQnAGolden | NonSTP   | 302 Millers Xing | Ste 11    | Harker Heights | TX    | 76548          | 2025352871  | adzhoharidze@jminsure.com | QNABLT                 | desktop    |            | Chrome      |                 |

