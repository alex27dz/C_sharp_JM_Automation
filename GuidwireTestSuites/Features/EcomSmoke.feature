Feature: EcomSmoke
	
@qnaregstage
@qnasmoketest
@01Reg_QnA_STP
Scenario Outline: 01_Regular_QnA_STP
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
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
                | NO                | Yes               |
                And I make payment using Card, set <AutoPay>  and Verify Contact JMIS Page <PhoneNumber>, <EmailAddress>, <EmailOrPhoneJMIS>, Confirmation page and policy number depending on Environment and <GW_PolicyStatus>
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
                | BrowserType | ApplicationEnvironment | TargetType | Capability | OperatingSystem | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EmailOrPhoneJMIS | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus |
                | Chrome      | QNA                    | desktop    |            |                 | RegularQnA | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999   | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | Phone            | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        |
                | IE		  | QNA                    | desktop    |            |                 | RegularQnA | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999   | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | Phone            | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        |
				| Firefox     | QNA                    | desktop    |            |                 | RegularQnA | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999   | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | Phone            | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        |

@qnaregstage
@qnasmoketest
@02Reg_QnA_NonSTP
Scenario Outline: 02_Regular_QnA_NonSTP
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 50000  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Wearers details <WearerType> on Applicant and Wearer page
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                | Engagement Ring | Men's  |                |           |    
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
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify Activity <PCActivities> in PC9
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
				And I click workorder number of Account detail screen in PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				Then I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 


                
                Examples:
                | BrowserType| ApplicationEnvironment | TargetType | Capability  | OperatingSystem | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                            | PCActivities                   |
                | Chrome      | QNA                    | desktop    |            |                 | RegularQnA | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | CURRENTDATE   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines; Total Schedule Exceeds $50,000 |  Submission with issues  |
                | IE		  | QNA                    | desktop    |            |                 | RegularQnA | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | CURRENTDATE   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines; Total Schedule Exceeds $50,000 |  Submission with issues  |
				| Firefox     | QNA                    | desktop    |            |                 | RegularQnA | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | CURRENTDATE   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines; Total Schedule Exceeds $50,000 |  Submission with issues  |

@qnaregstage
@qnasmoketest
@03Reg_QnA_consu_STP
Scenario Outline: 03_QnA_regular_consumer_STP
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Chain        | 5000  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Wearers details <WearerType> on Applicant and Wearer page
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
                |                | Women's |                |           |    
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
                | BrowserType | ApplicationEnvironment | TargetType | Capability | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus |
                | Chrome      | QG                     | desktop    |            |                 | QNAGEICO  | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888   | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | Responsive        | No      | In Force        |
                | IE          | QG                     | desktop    |            |                 | QNAGEICO  | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888   | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | Responsive        | No      | In Force        |
				| Firefox     | QG                     | desktop    |            |                 | QNAGEICO  | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888   | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | Responsive        | No      | In Force        |
        
@qnaregstage
@qnasmoketest
@04Reg_QnA_NonSTP_CA
Scenario Outline: 04_Regular_QnA_NonSTP_Canada
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | T4R 3P2 | Earrings    | 450000 |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Wearers details <WearerType> on Applicant and Wearer page
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender | DateOFPurchase | Appraisal |
                | Pair of Earrings |        |                |           | 
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
				Then I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 


                Examples:
                | BrowserType | ApplicationEnvironment | TargetType | Capability | OperatingSystem | FirstName  | LastName | Address             | Apartment | City     | State   | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                                                    |PCActivities|
                | Chrome      | QNA                    | desktop    |            |                 | RegularQnA | NONSTP   | 120 Allwright Close |           | Red Deer | Alberta | T4R 3P2        | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Canada Schedule Exceeds UW Guidelines;Item Value Exceeds Underwriting Guidelines;Total Schedule Exceeds $350,000 |  Submission with issues  |
                | IE          | QNA                    | desktop    |            |                 | RegularQnA | NONSTP   | 120 Allwright Close |           | Red Deer | Alberta | T4R 3P2        | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Canada Schedule Exceeds UW Guidelines;Item Value Exceeds Underwriting Guidelines;Total Schedule Exceeds $350,000 |  Submission with issues  |
				| Firefox     | QNA                    | desktop    |            |                 | RegularQnA | NONSTP   | 120 Allwright Close |           | Red Deer | Alberta | T4R 3P2        | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Canada Schedule Exceeds UW Guidelines;Item Value Exceeds Underwriting Guidelines;Total Schedule Exceeds $350,000 |  Submission with issues  |

@qnaregstage
@qnasmoketest
@05QNAPartner_STP
Scenario Outline: 05_QNAPartner_STP
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I login to partner mode
                | UserName           | Password |
                | claudiatest03@apptest.jminsure.com | Pass1234 |
				And I verify Quote Page error validation messages
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 15000 |
   				And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's | 01/04/2017     | No        |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO			    | Yes               |
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
                | BrowserType | ApplicationEnvironment | TargetType | Capability | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                | Chrome      | QP                     | desktop    |            |                 | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | TW003      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | No                 |
				| Firefox     | QP                     | desktop    |            |                 | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | TW003      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | No                 |
				
@qnaregstage
@qnasmoketest
@06ExpressPartner_ADIAMOR
Scenario Outline: 06_ExpressPartner_Smoke_ADIAMOR
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
                | BrowserType | ApplicationEnvironment | TargetType | Capability | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | JwelerID  |
                | Chrome      | QAADIAMOR             | desktop    |            |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | ADIAMOR | 
                | IE          | QAADIAMOR             | desktop    |            |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | ADIAMOR | 
				| Firefox     | QAADIAMOR             | desktop    |            |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Express              | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | ADIAMOR | 

@qnaregstage
@qnasmoketest
@08LOOS_single_store
Scenario Outline: 08_LOOS_Smoke_single_store
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page
				And I Enter <FirstName> , <LastName> , <EmailAddress>  in the Quote Page Details for LOOS
				And I Enter the Quote Page Details for LOOS
				| ZipCode | JewelryType | Value |
				#| 54956   | Ring        | 15000 |
				| 53189   | Ring        | 15000 |
				And I click on NewExisting Customer Page  
				And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
				And I Enter the Applicant or Wearers details with respect to wearing items 
				| WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
				| PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
				And I Check the <TermsAndConditions> on Applicant and Wearer page
				And I Enter the jewelry information Jewelry Details page
				| JewelrySubType | Gender  | DateOFPurchase | Appraisal |
				| Engagement Ring               | Women's | 01/04/2017     | No       |
				And I select <EffectiveDate> in Jewelry Details page 
				And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				And I Review the application
				| Submitapplication | PaperlessDelivery |
				| NO               | Yes               |
				 And I make payment using Card, set <AutoPay>  and Verify Contact JMIS Page <PhoneNumber>, <EmailAddress>, <EmailOrPhoneJMIS>, Confirmation page and policy number depending on Environment and <GW_PolicyStatus>
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
				| BrowserType | ApplicationEnvironment | TargetType | Capability | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
				| Chrome      | LOOS                   | desktop    |            |                 | 1926         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes                |
				| IE          | LOOS                   | desktop    |            |                 | 1926         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes                |

@qnaregstage
@qnasmoketest
@09PLPOrtal_Smoke
Scenario Outline: 09_PLPOrtal_Smoke
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
				| Browser | AccountNumber | ApplicationEnvironment | Application | Target | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | OtherPhone | FaxPhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime | GWPayment_Instrument | GWPaymentPlan |
				| IE	  | REGISTRY      | PLP                    | PC          | Desktop | su       | gw       | PLPOrtal  | NameChange | 05/25/1976  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |vbadvel@jminsure.com |sbandaru@jminsure.com| Male   | Other      | No             | TestCareOf | 100 Main St  | Apt#2        | Waukesha | Wisconsin | 53189   | Waukesha | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  |         | No                   | No           | No               | visa ****1111        | Annual Pay    |
				


