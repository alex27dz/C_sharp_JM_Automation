﻿Feature: SuperQAPM_Flag_ON

@STP 
@regression
                Scenario Outline: 01_Super_QAPMGEICO_STP_LessThan16kWithAppraisals_Virg
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I login to super partner mode
                | UserName           | Password |
                | jmtestpartner+801@gmail.com | Pass1234! |
				And I verify Quote Page error validation messages for Partner Mode
                And I Enter <FirstName> , <LastName> , <PhoneNumber> , <EmailAddress>  in the Quote Page Details for Partner Mode
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Ring        | 15000 |
     			And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring               | Women's | 01/04/2017     | Yes       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				And I make Card payment, Set <AutoPay> and Later I verify confirmation message depending on Environment for Partner Mode and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | USA     | You have successfully completed your application for jewelry insurance. Thank you for choosing Jewelers Mutual Insurance Group to protect your jewelry and the precious moments it represents. |
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                | QPS                    | desktop    |            | Chrome      |                 | QAPMGolden      | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com        | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D20      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****8291        | Yes      | In Force        | No                 |


@NonSTP 
@regression
                Scenario Outline: 02_Super_QAPMGEICO_NonSTP_to38kWithAppraisalsFred
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I login to super partner mode
                | UserName                 | Password |
                | jmtestpartner+801@gmail.com | Pass1234! |
                And I Enter <FirstName> , <LastName> , <PhoneNumber> , <EmailAddress>  in the Quote Page Details for Partner Mode
			    And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Necklace    | 38000 |
                And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
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
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify Activity  <PCActivities> in PC9
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
				And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address          | Apartment | City           | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                 | TermsAndConditions | PCActivities         |
                | QPS                     | desktop    |            | Chrome      |                 | QIMGolden | NonSTP   | 302 Millers Xing | Ste 11    | Harker Heights | Texas | 76548          | Yes              | 2025352871  |rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D20      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted        | Item Value Exceeds Underwriting Guidelines | No                 | Submission with issues |


@NonSTP                      
@regression
                Scenario Outline: 03_Super_QAPMGEICO_NonSTP_ScheduleTotalGreaterThen2.5k_Virg
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I login to super partner mode
                | UserName           | Password |
                | jmtestpartner+801@gmail.com | Pass1234! |
				And I Enter <FirstName> , <LastName> , <PhoneNumber> , <EmailAddress>  in the Quote Page Details for Partner Mode
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Watch       | 1000  |
                |         | Chain       | 1500  |
                And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
				And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |         |          |      |           |         |             |       |            |              |        |
                | Wearer           | WearerFName1 | WearerLName | Yes             |         |          |      |           |         |             |       | 07/07/1985 | Child        | Male   |
              And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                | Rolex          | men's  |                |           |
                |                | men's  |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				 And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				And I make Card payment, Set <AutoPay> and Later I verify confirmation message depending on Environment for Partner Mode and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | USA     | You have successfully completed your application for jewelry insurance. Thank you for choosing Jewelers Mutual Insurance Group to protect your jewelry and the precious moments it represents. |
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                | QPS                     | desktop    |            | Chrome      |                 | Golden4   | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | Male   | wearer     | No                    | No                       | Yes           | No               | currentdate   | Z100D20      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force        | No                 |
              
              
@NonSTP 
@regression
                Scenario Outline: 04_Super_QAPMGEICO_NonSTP_SingleItemGreaterThen50k_Virg
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I login to super partner mode
                | UserName           | Password |
                | jmtestpartner+801@gmail.com | Pass1234! |
				And I Enter <FirstName> , <LastName> , <PhoneNumber> , <EmailAddress>  in the Quote Page Details for Partner Mode
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 80202   | Pendant     | 51000 |
				And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
                And I Enter Malling Address of Appplicant
                | Address     | Apartment | City   | State    | Zip   |
                | 900 13th St |           | Denver | Colorado | 80204 |
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the No on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
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
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. |
                And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify Activity  <PCActivities> in PC9
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
				And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address      | Apartment | City   | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                | PCActivities                   |
                | QPS                     | desktop    |            | Chrome      |                 | Golden5   | NonSTP   | 1250 14th St |           | Denver | Colorado | 80202          | No               | 9205352871  | rparas@jminsure.com | Email             | FeMale | wearer     | No                    | No                       | Yes           | No               | currentdate   | Z100D20      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | Item Value Exceeds Underwriting Guidelines;Total Schedule Exceeds $50,000 | Submission with issues |
          

@NonSTP 
@regression
                Scenario Outline: 05_Super_QAPMGEICO_NonSTP_lessthen16KFelonyDUI_Virg
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                 When I login to super partner mode
                | UserName           | Password |
                | jmtestpartner+801@gmail.com | Pass1234! |
				And I Enter <FirstName> , <LastName> , <PhoneNumber> , <EmailAddress>  in the Quote Page Details for Partner Mode
                And I Enter the Quote Page Details
	            | ZipCode | JewelryType | Value |
                | 54956   | Ring        | 6000  |
				And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr Sentence completion details
                | Date       | Type  |
                | 08/06/2018 | Drugs |
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
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
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify Activity  <PCActivities> in PC9
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
				And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                        | TermsAndConditions | PCActivities |
                | QPS                     | desktop    |            | Chrome      |                 | Golden6   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | Female | felony                | No                       | Yes           | No               | currentdate   | Z100D20      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted        | Approval Needed - Applicant convicted of a felony | No                 |Submission with issues|


@NonSTP 
@regression
                Scenario Outline: 06_Super_QAPMGEICO_NonSTP_lessthen16K LossGreaterthen25K_Fred
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I login to super partner mode
                | UserName                 | Password |
                | jmtestpartner+801@gmail.com | Pass1234! |
				And I Enter <FirstName> , <LastName> , <PhoneNumber> , <EmailAddress>  in the Quote Page Details for Partner Mode
			    And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Brooch        | 1599  |
				And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr loss details
                | Loss_Date  | Type  | LossAmount |
                | 04/05/2017 | Theft | 3500      |
                | 12/10/2016 | Theft | 4001      |
                           
			    And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the confirmation page with the account number
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                 |
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken.|
                And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify Activity  <PCActivities> in PC9
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
				And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application  

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                     | TermsAndConditions | PCActivities |
                | QPS                     | desktop    |            | Chrome      |                 | Golden7   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | Female | No                    | Yes                      | Yes           | No               | currentdate   | Z100D20      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | loss or claim activity | No                 | Submission with issues             |

				



                Scenario Outline: 07_QAPMWoodland_NonSTP_lessthen16KLossGreaterthen25K_Donna
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login to super partner mode
                | UserName           | Password |
                | jmtestpartner+801@gmail.com | Pass1234! |
				And I Enter <FirstName> , <LastName> , <PhoneNumber> , <EmailAddress>  in the Quote Page Details for Partner Mode
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Brooch        | 1599  |
				And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr loss details
                | Loss_Date  | Type  | LossAmount |
                | 04/05/2017 | Theft | 3500      |
                | 12/10/2016 | Theft | 4001      |
                           
			    And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
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
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify Activity  <PCActivities> in PC9
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
				And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                     | TermsAndConditions | PCActivities |
                | QPS                     | desktop    |            | Chrome      |                 | Golden7   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | Female | No                    | Yes                      | Yes           | No               | currentdate   | Z100D20        | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | loss or claim activity | No                 |              |
