Feature: QuoteAndApplyInternal_PC9

	
@STP                               
@regression
@QAIM1
@QAIM
                Scenario Outline: 01_QAIMSTP_Value_15000_AnnualPayment_MakePayment_BC_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption                    |
                | Agency Express | randoms egghead kodiak chair hart |
				And I verify Quote Page error validation messages
                And I Enter the Quote Page Details
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
                | Engagement Ring | Women's | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
				And I Review and issue the application for STP 
                | PaperlessDelivery | PaymentPlan | 
                | NO               |  1           |
                And I access the Guidewire PC on Desktop in IE
                And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan
				And I logout of the PC9 application 
				And I Kill Web Driver
                And I access the Guidewire BC on Desktop in IE
                And I enter bcmanager and bcmanagerpwd on the BC Login page
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress     | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | PaymentAmount | CCType | CCPaymentDate        |
                | QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Two Pay - Semi Annually   | REGISTRY     | visa ****1111        | Yes     | In Force        | TotalDue      | VISA   | TESTINGSYSTEMCLOCK |

@STP 
@regression
@QAIM2
@QAIM
                Scenario Outline: 02_QAIMSTP_Women_TotalValue_4500_AnnualPayment_MakePayment_BC_CA
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource | ReferralOption |
                | Customer care |                |
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Earrings    | 2500  |
                |         | Bracelet    | 2000  |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                | Wearer           | WearerFName1 | WearerLName | No              | 127 Church Street | 21       | Toronto | Ontario   | M5C 2G5 |             |       | 07/07/1979 | Child        | Female   |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender  | DateOFPurchase | Appraisal |
                | Pair of Earrings |         |                | No        |
                |                  | Women's |                | No        |
                And I select <EffectiveDate> in Jewelry Details page 
                  And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
				And I set Credit Consent <creditConsent> for CA
				And I Review and issue the application for STP 
                | PaperlessDelivery | PaymentPlan | 
                | Yes               |  1           |
                And I access the Guidewire PC on Desktop in IE
				And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan
				And I logout of the PC9 application 
				And I Kill Web Driver
                And I access the Guidewire BC on Desktop in IE
				And I enter bcmanager and bcmanagerpwd on the BC Login page
				And I select Search from the Tab menu 
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | creditConsent | PaymentAmount | CCType | CCPaymentDate|
                | QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 2025352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Phone                | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | Responsive           | No      | In Force        | Yes           | TotalDue      | VISA   | TESTINGSYSTEMCLOCK |
                
@STP 
@regression
@QAIM3
@QAIM
                Scenario Outline: 03_QAIMSTP_Men_TotalValue_2500_AnnualPayment_MakePayment_BC_CA
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource | ReferralOption |
                | Customer Care |                |
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Watch       | 1000 |
                |         | Chain       | 1500|
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
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
                 And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
				And I Review and issue the application for STP 
                | PaperlessDelivery | PaymentPlan | 
                | Yes               |  1           |
  			    And I access the Guidewire PC on Desktop in IE
               	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan
				And I logout of the PC9 application 
				And I Kill Web Driver
                And I access the Guidewire BC on Desktop in IE
				And I enter bcmanager and bcmanagerpwd on the BC Login page
				And I select Search from the Tab menu 
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |PaymentAmount | CCType | CCPaymentDate|
                | QI                     | desktop    |            | Chrome      |                 | QIMGolden | NonSTP   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Male   | wearer     | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Phone                | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force        | Yes            | TotalDue      | VISA   | TESTINGSYSTEMCLOCK |

@NonSTP                               
@regression
@QAIM4
@QAIM
                Scenario Outline: 04_QAIM_NonSTP_38kWithAppraisals_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource        | ReferralOption |
                | jm insurance service |                |
			    And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Necklace    | 38000 |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
               And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| Yes                          |
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
				And I click on PolicyInfoPage on the Left NavMenu Screen in PC9
				#And I verify <UserName> in Left Policy Info Page in Internal mode for PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address          | Apartment | City           | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                            | PCActivities |       UserName           |
                | QI                     | desktop    |            | Chrome      |                 | QIMGolden | NonSTP   | 302 Millers Xing | Ste 11    | Harker Heights | Texas | 76548          | Yes              | 2025352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | B52D         | Yes                 |                      | Agency               | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | Additional Underwriting Needed;Item Value Exceeds Underwriting Guidelines |  Submission with issues             |       adzhoharidze           |

@NonSTP 
@regression
@QAIM5
@QAIM
                Scenario Outline: 05_QAIM_NonSTP_SingleitemGreaterthen50k_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption         |
                | Agency Express | randoms egghead kodiak chair hart |	
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 80202   | Pendant     | 51000 |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter Malling Address of Appplicant
                | Address     | Apartment | City   | State    | Zip   |
                | 900 13th St |           | Denver | Colorado | 80204 |
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                 And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
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
				And I click on PolicyInfoPage on the Left NavMenu Screen in PC9
				#And I verify <UserName> in Left Policy Info Page in Internal mode for PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address      | Apartment | City   | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                           | PCActivities                   |       UserName           |
                | QI                     | desktop    |            | Chrome      |                 | QIMGolden | NonSTP   | 1250 14th St |           | Denver | Colorado | 80202          | No               | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | wearer     | No                    | No                       | Yes           | No               | currentdate   | Z100D00         | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | Item Value Exceeds Underwriting Guidelines;Total Schedule Exceeds $50,000 |  Submission with issues  |       adzhoharidze           |


@NonSTP 
@regression
@QAIM6
@QAIM
                Scenario Outline: 06_QAIM_NonSTP_lessthen16KFelonyDUI_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource | ReferralOption |
                | Customer care |                |	
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 6000  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
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
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
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
				And I click on PolicyInfoPage on the Left NavMenu Screen in PC9
				#And I verify <UserName> in Left Policy Info Page in Internal mode for PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                        | PCActivities |       UserName           |
                | QI                     | desktop    |            | Chrome      |                 | Golden6   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Female | felony                | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Phone                | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | Approval Needed - Applicant convicted of a felony |Submission with issues              |       adzhoharidze           |


@NonSTP 
@regression
@QAIM7
@QAIM
                Scenario Outline: 07_QAIM_NonSTP_lessthen16KLossGreaterthen25K_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource | ReferralOption |
                | Agency Express | isseis hadjes sedge rattail nth details              |	
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Brooch        | 15999  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr loss details
                 | Loss_Date  | Type  | LossAmount |
                | 04/05/2017 | Theft | 35000      |
                | 12/10/2016 | Theft | 40001      |
         	    And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType  | Gender   | DateOFPurchase | Appraisal |
                |                 |          |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| Yes                          |
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
				And I click on PolicyInfoPage on the Left NavMenu Screen in PC9
				#And I verify <UserName> in Left Policy Info Page in Internal mode for PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 
 

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                     | PCActivities |       UserName           |
                | QI                     | desktop    |            | Chrome      |                 | Golden7   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Female | No                    | Yes                      | Yes           | No               | currentdate   | Z100D10      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | Loss or Claim Activity | Submission with issues             |       adzhoharidze           |


				@NonSTP 
@regression
@QAIM8
@QAIM
                Scenario Outline: 08_QAIM_NonSTP_NoAdditonalQuestions_UWYes_lessthen16KLossGreaterthen25K_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource | ReferralOption |
                | Agency Express | isseis hadjes sedge rattail nth details              |	
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Brooch        | 1599  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
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
                | JewelrySubType  | Gender   | DateOFPurchase | Appraisal |
                ||  |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| Yes                          |
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
				And I click on PolicyInfoPage on the Left NavMenu Screen in PC9
				#And I verify <UserName> in Left Policy Info Page in Internal mode for PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 
 

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                     | PCActivities |       UserName           |
                | QI                     | desktop    |            | Chrome      |                 | Golden7   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Female | No                    | Yes                      | Yes           | No               | currentdate   | Z100D10      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | Additional Underwriting Needed;Loss or Claim Activity | Submission with issues             |       adzhoharidze           |


			
			@NonSTP 
@regression
@QAIM9
@QAIM
                Scenario Outline: 09_QAIM_NonSTP_UW_No_SingleitemGreaterthen50k_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption         |
                | Agency Express | randoms egghead kodiak chair hart |	
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 80202   | Pendant     | 51000 |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter Malling Address of Appplicant
                | Address     | Apartment | City   | State    | Zip   |
                | 900 13th St |           | Denver | Colorado | 80204 |
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                 And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| Yes                          |
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
				And I click on PolicyInfoPage on the Left NavMenu Screen in PC9
				#And I verify <UserName> in Left Policy Info Page in Internal mode for PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application 


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address      | Apartment | City   | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                           | PCActivities                   |       UserName           |
                | QI                     | desktop    |            | Chrome      |                 | QIMGolden | NonSTP   | 1250 14th St |           | Denver | Colorado | 80202          | No               | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | wearer     | No                    | No                       | Yes           | No               | currentdate   | Z100D00         | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Quoted       | Additional Underwriting Needed;Item Value Exceeds Underwriting Guidelines;Total Schedule Exceeds $50,000 |  Submission with issues  |       adzhoharidze           |


				@STP                               
@regression
@QAIM10
@QAIM
                Scenario Outline: 10_QAIM_NonSTP_LessThan16kWithAppraisals_US  
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption         |
                | Agency Express | randoms egghead kodiak chair hart |	
				And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 80202   | Pendant     | 1500 |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter Malling Address of Appplicant
                | Address     | Apartment | City   | State    | Zip   |
                | 900 13th St |           | Denver | Colorado | 80204 |
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                 And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| Yes                          |
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
                | This premium quote is an estimate and Jewelers Mutual Group will contact you within 2 business days following your application submission to validate your address and discuss payment options. If you have questions, please contact us at 888-884-2424|
                And I access the Guidewire PC on Desktop in IE
               	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Accounts from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verify Activity  <PCActivities> in PC9
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
				And I click workorder number of Account detail screen in PC9
				And I click on PolicyInfoPage on the Left NavMenu Screen in PC9
				#And I verify <UserName> in Left Policy Info Page in Internal mode for PC9
				And I click on RiskAnalysis on Left NavMenu Screen in PC9
				And I verify <Activities> in the Risk Analysis screen in PC9
				And I logout of the PC9 application
                Examples:

				 | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address      | Apartment | City   | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                     | PCActivities           |       UserName           |
				 | QI                     | desktop    |            | Chrome      |                 | QIMGolden | NonSTP   | 1250 14th St |           | Denver | Colorado | 80202          | No               | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Additional Underwriting Needed | Submission with issues |       adzhoharidze           |


                #| #                      | ApplicationEnvironment | TargetType | Capability  | BrowserType     | OperatingSystem | FirstName      | LastName     | Address             | Apartment | City     | State          | AddressZipCode   | IsMailingAddress | PhoneNumber          | EmailAddress         | ContactPreference | Gender     | WearerType            | MinorTrafficViolation    | LossTheftDamageToJewelry | PrivacyPolicy    | AlarmAndSecurity | EffectiveDate | ProducerCode        | GWPaperlessDelivery  | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation  | GWAddressType | GWStatus  | GWAddress     | AccountNumber | GW_UserName | GW_Password  | GWPaymentPlan                                                             | GWExpireDate           | GWPayment_Instrument | AutoPay | GW_PolicyStatus |
                #| #                      | QI                     | desktop    |             | Chrome          |                 | QIMGEICOGolden | STP          | 48 Jewelers Park Dr |           | Neenah   | Wisconsin      | 54956            | Yes              | 9205352871           | adzhoharidze@jminsure.com | Email             | FeMale     | PrimaryApplicant      | No                       | No                       | Yes              | No               | currentdate   | Z100D00             | Yes                  |                      | Agency Express       | REGISTRY         | 05/01/1977    |               | Home          | Active    | REGISTRY      | REGISTRY      | su          | gw           | Annual Pay                                                                | REGISTRY               | visa ****8291        | Yes     | In Force |

@STP                               
@regression
@QAIM11
@QAIM
		Scenario Outline: 11_QAIMSTP_100_Items_US_LessThan50kTotal
		Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
		When I select ReferalSource for Quote internal mode
		| ReferalSource  | ReferralOption                    |
		| Agency Express | randoms egghead kodiak chair hart |
		And I verify Quote Page error validation messages
		And I Enter the Quote Page Details
		| ZipCode | JewelryType | Value |
		| 53189   | Ring        | 150 |
		|         | Earrings    | 150 |
		|         | Ring        | 150 |
		|         | Earrings    | 150 |
		|         | Bracelet    | 150 |
		|         | Necklace    | 150 |
		|         | Watch       | 150 |
		|         | Pendant     | 150 |
		|         | Chain       | 150 |
		|         | Brooch      | 150 |
		|         | Loose stone | 150 |
		|         | Earrings    | 150 |
		|         | Ring        | 150 |
		|         | Earrings    | 150 |
		|         | Bracelet    | 150 |
		|         | Necklace    | 150 |
		|         | Watch       | 150 |
		|         | Pendant     | 150 |
		|         | Chain       | 150 |
		|         | Brooch      | 150 |
		|         | Loose stone | 150 |
		|         | Earrings    | 100 |
		|         | Ring        | 150 |
		|         | Earrings    | 500 |
		|         | Bracelet    | 150 |
		|         | Necklace    | 150 |
		|         | Watch       | 150 |
		|         | Pendant     | 500 |
		|         | Chain       | 350 |
		|         | Brooch      | 350 |
		|         | Loose stone | 350 |
		|         | Earrings    | 350 |
		|         | Ring        | 350 |
		|         | Earrings    | 350 |
		|         | Bracelet    | 500 |
		|         | Necklace    | 500 |
		|         | Watch       | 350 |
		|         | Pendant     | 350 |
		|         | Chain       | 350 |
		|         | Brooch      | 350 |
		|         | Loose stone | 300 |
		|         | Earrings    | 500 |
		|         | Ring        | 350 |
		|         | Earrings    | 350 |
		|         | Bracelet    | 350 |
		|         | Necklace    | 350 |
		|         | Watch       | 300 |
		|         | Pendant     | 350 |
		|         | Chain       | 500 |
		|         | Brooch      | 350 |
		|         | Loose stone | 300 |
		|         | Earrings    | 500 |
		|         | Ring        | 300 |
		|         | Earrings    | 300 |
		|         | Bracelet    | 300 |
		|         | Necklace    | 300 |
		|         | Watch       | 300 |
		|         | Pendant     | 300 |
		|         | Chain       | 300 |
		|         | Brooch      | 250 |
		|         | Loose stone | 300 |
		|         | Earrings    | 300 |
		|         | Ring        | 300 |
		|         | Earrings    | 300 |
		|         | Bracelet    | 300 |
		|         | Necklace    | 300 |
		|         | Watch       | 500 |
		|         | Pendant     | 500 |
		|         | Chain       | 500 |
		|         | Brooch      | 500 |
		|         | Loose stone | 500 |
		|         | Earrings    | 500 |
		|         | Ring        | 500 |
		|         | Earrings    | 200 |
		|         | Bracelet    | 500 |
		|         | Necklace    | 500 |
		|         | Watch       | 500 |
		|         | Pendant     | 500 |
		|         | Chain       | 500 |
		|         | Brooch      | 500 |
		|         | Loose stone | 500 |
		|         | Earrings    | 500 |
		|         | Ring        | 300 |
		|         | Earrings    | 500 |
		|         | Bracelet    | 500 |
		|         | Necklace    | 200 |
		|         | Watch       | 500 |
		|         | Pendant     | 500 |
		|         | Chain       | 300 |
		|         | Brooch      | 300 |
		|         | Loose stone | 300 |
		|         | Earrings    | 300 |
		|         | Ring        | 300 |
		|         | Earrings    | 300 |
		|         | Bracelet    | 300 |
		|         | Necklace    | 300 |
		|         | Watch       | 300 |
		|         | Pendant     | 300 |
		|         | Chain       | 300 |
		|         | Brooch      | 300 |
		And I click on NewExisting Customer Page  
		And I verify Applicant Wearer Page error validation messages
		And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
		And I Enter the Applicant or Wearers details with respect to wearing items 
		| WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		| Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
		And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
		And I Check the <TermsAndConditions> on Applicant and Wearer page
		And I Enter the jewelry information Jewelry Details page
		| JewelrySubType   | Gender  | DateOFPurchase | Appraisal |
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		|                  |         |                |           |
		| Pair of Earrings |         |                |           |  
		| Engagement Ring  | Women's |                |           |
		| Pair of Earrings |         |                |           | 
		|                  | Women's |                |           | 
		|                  |         |                |           |
		| Rolex            | Women's |                |           |
		|                  |         |                |           |
		|                  | Women's |                |           |
		|                  |         |                |           |
		And I select <EffectiveDate> in Jewelry Details page 
		And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
		| AdditionalUnderwritingNeeded |
		| No                          |
		And I Review and issue the application for STP         
        | PaperlessDelivery | PaymentPlan | 
        | Yes               |  2          |
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
		| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
		| QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Two Pay - Semi Annually    | REGISTRY     | Responsive        | Yes     | In Force |
 
@STP                               
@QAIM12
@QAIM
                Scenario Outline: 12_QAIMSTP_Value_49999_4Payments_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption                    | 
                | Agency Express | randoms egghead kodiak chair hart |
				And I verify Quote Page error validation messages
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 49999 |
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
                | Engagement Ring | Women's | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
                And I Review and issue the application for STP         
                | PaperlessDelivery | PaymentPlan | 
                | Yes               |  4           |
				###Policy Center
                And I access the Guidewire PC on Desktop in IE
                And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan
				And I logout of the PC9 application 

				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
                | QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force |
@STP                               
@QAIM13
@QAIM
                Scenario Outline: 13_QAIMSTP_Value_5000_AnnualPayment_WithAppraisals_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption                    | 
                | Agency Express | randoms egghead kodiak chair hart |
				And I verify Quote Page error validation messages
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 5000 |
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
                | Engagement Ring | Women's | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
                And I Review and issue the application for STP 
                | PaperlessDelivery | PaymentPlan | 
                | Yes               |  1           |
				###Policy Center
                And I access the Guidewire PC on Desktop in IE
                And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan     
				And I logout of the PC9 application  
				
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
                | QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force |
    
@STP                               
@QAIM14
@QAIM
                Scenario Outline: 14_QAIMSTP_Value_30000_2Payments_WithAppraisals_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption                    | 
                | Agency Express | randoms egghead kodiak chair hart |
				And I verify Quote Page error validation messages
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |  
                | 53189   | Ring        | 30000 |
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
                | Engagement Ring | Women's | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
                And I Review and issue the application for STP 
                | PaperlessDelivery | PaymentPlan | 
                | Yes               |  2           |
				###Policy Center
                And I access the Guidewire PC on Desktop in IE
                And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan
				And I logout of the PC9 application 
				
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
                | QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force |

@STP                               
@QAIM15
@QAIM
                Scenario Outline: 15_QAIMSTP_Value_49999_8Payments_WithAppraisals_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption                    | 
                | Agency Express | randoms egghead kodiak chair hart |
				And I verify Quote Page error validation messages
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |  
                | 53189   | Ring        | 49999 | 
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
                | Engagement Ring | Women's | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
                And I Review and issue the application for STP 
                | PaperlessDelivery | PaymentPlan | 
                | Yes               |  8           |

				###Policy Center
                And I access the Guidewire PC on Desktop in IE
                And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan
				And I logout of the PC9 application 

				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address               | Apartment | City        | State      | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
				| QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 10234 Van Dyke Ave St |           | Detroit | Michigan | 48234          | Yes              | 9205352871  | rparas@jminsure.com             | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force |
				#612 Wall St, Los Angeles, CA 90014, United States
@STP                               
@QAIM16
@QAIM
                Scenario Outline: 16_QAIMSTP_Value_49999_12Payments_WithAppraisals_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption                    | 
                | Agency Express | randoms egghead kodiak chair hart |
				And I verify Quote Page error validation messages
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |  
                | 53189   | Ring        | 49999 | 
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
                | Engagement Ring | Women's | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
                And I Review and issue the application for STP 
                | PaperlessDelivery | PaymentPlan | 
                | Yes               |  12           |

				###Policy Center
                And I access the Guidewire PC on Desktop in IE
                And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I verify the payment plan
				And I logout of the PC9 application 

				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address               | Apartment | City        | State      | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
                | QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 612 Wall St           |           | Los Angeles | California | 90014          | Yes              | 9205352871  | rparas@jminsure.com             | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force |


@STP                               
@QAIM17
@QAIM
                Scenario Outline: 17_QAIMSTP_Verify_Agent_Dashboard_US	
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource  | ReferralOption                    | 
                | Agency Express | randoms egghead kodiak chair hart |
				And I verify Quote Page error validation messages
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 5000 |
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
                | Engagement Ring | Women's | 01/04/2017     | No       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
				And I verify Agent Dashbboard
				| Country |
				| US      |
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
                | QI                     | desktop    |            | Chrome      |                 | QIMGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force |
@STP 
@QAIM18
@QAIM
                Scenario Outline: 18_QAIM_STP_Verify_Agent_Dashboard_CA
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I select ReferalSource for Quote internal mode
                | ReferalSource | ReferralOption |
                | Customer Care |                |
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Watch       | 1000  |
                |         | Chain       | 1500  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
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
                 And I Enetr <AlarmAndSecurity> and Additional Underwriting Needed in Security option of  Jewelry Details page
				| AdditionalUnderwritingNeeded |
				| No                          |
				And I verify Agent Dashbboard 
				| Country |
				| CA      |
            Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                | QI                     | desktop    |            | Chrome      |                 | QIMGolden | NonSTP   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Male   | wearer     | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Phone                | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw         | Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force        | Yes                 |
