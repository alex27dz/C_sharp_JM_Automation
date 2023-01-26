Feature: ExpressPartner
	
 Scenario Outline: 01_STP_BlueNiel
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
             	When I enetr detailes in Epress Partners Quote Page 
				| OrderNo | Email  |
				| 1452    | Unique |
				And I click on Apply for Coverage button in Epress Partners Quote info Page
			    And I click on NewExisting Customer Page 
				And I get Primary applicant from applicant wearer page 
               And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
				And I Select Jeweler Type in Jewelry Details Page 
				| JewelryType |
				| Ring        |
				And I Enter the jewelry information Jewelry Details page
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
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				Then I verify <GWPrimaryInsured> , "" , REGISTRY , REGISTRY , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify <JwelerID> for Express Partners
				And I logout of the PC9 application
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | JwelerID  |
                | QABLUENILE             | desktop    |            | Chrome      |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Blue Nile | 

    Scenario Outline: 02_STP_ADIAMOR
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
             	When I enetr detailes in Epress Partners Quote Page 
				| OrderNo | Email  |
				| 1452    | Unique |
				And I click on Apply for Coverage button in Epress Partners Quote info Page
			    And I click on NewExisting Customer Page 
				And I get Primary applicant from applicant wearer page 
               And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
				And I Select Jeweler Type in Jewelry Details Page 
				| JewelryType |
				| Ring        |
				And I Enter the jewelry information Jewelry Details page
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
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				Then I verify <GWPrimaryInsured> , "" , REGISTRY , REGISTRY , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify <JwelerID> for Express Partners
				And I logout of the PC9 application
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | JwelerID  |
                | QAADIAMOR             | desktop    |            | Chrome      |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | ADIAMOR | 

				Scenario Outline: 03_STP_BGDIAMOND
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
             	When I enetr detailes in Epress Partners Quote Page 
				| OrderNo | Email  |
				| 1452    | Unique |
				And I click on Apply for Coverage button in Epress Partners Quote info Page
			    And I click on NewExisting Customer Page 
				And I get Primary applicant from applicant wearer page 
               And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
				And I Select Jeweler Type in Jewelry Details Page 
				| JewelryType |
				| Ring        |
				And I Enter the jewelry information Jewelry Details page
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
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				Then I verify <GWPrimaryInsured> , "" , REGISTRY , REGISTRY , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify <JwelerID> for Express Partners
				And I logout of the PC9 application
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | JwelerID  |
                | QABGDIAMOND             | desktop    |            | Chrome      |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | BG DIAMOND | 

 Scenario Outline: 04_STP_JALLEN
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
             	When I enetr detailes in Epress Partners Quote Page 
				| OrderNo | Email  |
				| 1452    | Unique |
				And I click on Apply for Coverage button in Epress Partners Quote info Page
			    And I click on NewExisting Customer Page 
				And I get Primary applicant from applicant wearer page 
               And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
				And I Select Jeweler Type in Jewelry Details Page 
				| JewelryType |
				| Ring        |
				And I Enter the jewelry information Jewelry Details page
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
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				Then I verify <GWPrimaryInsured> , "" , REGISTRY , REGISTRY , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify <JwelerID> for Express Partners
				And I logout of the PC9 application
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | JwelerID  |
                | QAJALLEN            | desktop    |            | Chrome      |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | JALLEN | 

Scenario Outline: 05_NonSTP_WHITEFLASH
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
             	When I enetr detailes in Epress Partners Quote Page 
				| OrderNo | Email  |
				| 1452    | Unique |
				And I click on Apply for Coverage button in Epress Partners Quote info Page
			    And I click on NewExisting Customer Page 
				And I get Primary applicant from applicant wearer page 
               And I Enter the Contact Information  <IsMailingAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> for BOLT
                And I Enter the Applicant or Wearers details with respect to wearing items for BOLT 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				 | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
               
			    And I Check the <TermsAndConditions> on Applicant and Wearer page
				And I Select Jeweler Type in Jewelry Details Page 
				| JewelryType |
				| Ring        |
				| Pendant        |
				And I Enter the jewelry information Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's | 01/04/2017     | Yes       |
				 #| Engagement Ring | Women's | 01/04/2017     | Yes       |
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
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                  |
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. |
               
                And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				Then I verify <GWPrimaryInsured> , "" , REGISTRY , REGISTRY , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify <JwelerID> for Express Partners
				And I logout of the PC9 application
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | JwelerID  |
                | QAWHITEFLASH            | desktop    |            | Chrome      |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | WHITE FLASH | 


