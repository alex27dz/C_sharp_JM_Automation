Feature: SaveAndRetrieve_PC9


@RegressionSR
@NonSTP 
@regression
@sr1
 Scenario Outline: Scenario01_SR_GEICO_Save_At_AdditionalQuestions
  Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 84000 |
                And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's |                |           |
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
				And I click on Save and Finish application
			    And I Save My Application
				And I Take Action on saved application
				| Action                   |
				| safely leave application |
				And I Kill Web Driver
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I retrieve Saved Application
                And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Ring        | 84000        | Engagement Ring | Women's |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				And I Verify the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                | no        |                 |
                And I Verify  the Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
                And I verify the Travel Details in UW question details
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                           |
                | QNA                    | desktop    |            | Chrome      |                 | QNAGEICO  | Save     | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | unique       | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Total Schedule Exceeds $50,000 |

@RegressionSR
@NonSTP 
@regression
@sr2
 Scenario Outline: Scenario02_SR_Save_At_AdditionalQuestions
  Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 84000 |
                And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's |                |           |
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
				And I click on Save and Finish application
			    And I Save My Application
				And I Take Action on saved application
				| Action                   |
				| safely leave application |
				And I Kill Web Driver
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I retrieve Saved Application
                And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Ring        | 84000        | Engagement Ring | Women's |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				And I Verify the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                | no        |                 |
                And I Verify  the Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | Yes            | test12              | Address            | Yes            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | Yes          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | Yes                   | children                | Never          |
                And I verify the Travel Details in UW question details
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                           |
                | QNA                    | desktop    |            | Chrome      |                 | QNA       | Save     | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | unique       | Email | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Dird         | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Total Schedule Exceeds $50,000 |

@RegressionSR
@NonSTP 
@regression
@sr3
 Scenario Outline: Scenario03_SR_GEICO_MultiSave_MultiRetrieve
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 84000 |
                And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
				And I only Check the <TermsAndConditions> on Applicant and Wearer page
				And I click on Save and Finish application on Applicant and Wearer page
			    And I Save My Application
				And I Take Action on saved application
				| Action                   |
				| safely leave application |
				And I Kill Web Driver
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I retrieve Saved Application
			    And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I only Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I click on Save and Finish application on Jwelery Details Page
			   	And I Take Action on saved application
				| Action                   |
				| safely Leave application |
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I retrieve Saved Application
			    And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Ring        | 84000        | Engagement Ring | Women's |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				 And I enter the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                |   no        |                 |
                And I enter  for Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | Yes            | test12              | Address            | Yes            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | Yes          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | Yes                   | children                | Never          |
                And I enter Travel Details in UW question details
                | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
                | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
				And I click on Save and Finish application
			  	And I Take Action on saved application
				| Action                   |
				| safely Leave application |
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I retrieve Saved Application
			    And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Ring        | 84000        | Engagement Ring | Women's |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				And I Verify the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                | no        |                 |
                And I Verify  the Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | Yes            | test12              | Address            | Yes            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | Yes          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | Yes                   | children                | Never          |
                And I verify the Travel Details in UW question details
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                                 |
                | QG                     | desktop    |            | Chrome      |                 | QNAGEICO  | Save     | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | unique       | Email | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Total Schedule Exceeds $50,000 |


@RegressionSR
@NonSTP 
@regression
@sr4
 Scenario Outline: Scenario04_SR_MultiSave_MultiRetrieve
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 84000 |
                And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
				And I only Check the <TermsAndConditions> on Applicant and Wearer page
				And I click on Save and Finish application on Applicant and Wearer page
			    And I Save My Application
				And I Take Action on saved application
				| Action                   |
				| safely leave application |
				And I Kill Web Driver
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I retrieve Saved Application
			    And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Enter the jewelry information in Retrieve Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I only Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I click on Save and Finish application on Jwelery Details Page
			   	And I Take Action on saved application
				| Action                   |
				| safely Leave application |
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I retrieve Saved Application
			    And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Ring        | 84000        | Engagement Ring | Women's |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				 And I enter the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                |   no        |                 |
                And I enter  for Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | Yes            | test12              | Address            | Yes            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | Yes          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | Yes                   | children                | Never          |
                And I enter Travel Details in UW question details
                | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
                | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
				And I click on Save and Finish application
			  	And I Take Action on saved application
				| Action                   |
				| safely Leave application |
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I retrieve Saved Application
			    And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Ring        | 84000        | Engagement Ring | Women's |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				And I Verify the  Personal  History Details in UW question details
                | DeniedCov | DeniedCovreason |
                | no        |                 |
                And I Verify  the Jewelry Storage Details in UW question details
                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
                | Yes            | test12              | Address            | Yes            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | Yes          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | Yes                   | children                | Never          |
                And I verify the Travel Details in UW question details
				| TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
				| 1-3 trips           | yes          | I keep it in the hotel safe |                   |
			     And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the confirmation page with the account number
                | ConfirmationContentValidation                                                                                                                                                                                                                                                                                  |
                | Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. |
				And I Kill Web Driver
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                                 |
                | QNA                    | desktop    |            | Chrome      |                 | QNA       | Save     | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | unique       | Email | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Total Schedule Exceeds $50,000 |


@RegressionSR
@STP 
@regression
@sr5
Scenario Outline: Scenario05_SR_GEICO_Save_Retrieve_Replace
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Watch       | 60000  |
                |         | Pendant     | 5000  |
                |         | Other       | 8000  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
               And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
                | Rolex          | Women's |                |           |
                |                |         |                |           |
                | Other          |         |                |           |
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
				And I Kill Web Driver
				 Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Necklace    | 2000  |
                And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , regedit , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
				And I Check the <TermsAndConditions> on Applicant and Wearer page
				 And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |  
                And I select <EffectiveDate> in Jewelry Details page 
                And I only Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
			    And I click on Save and Finish application on Jwelery Details Page
			     And I Save My Application
				And I Take Action on saved application
				| Action                   |
				| safely leave application |
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I retrieve Saved Application
                And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Necklace        | 2000        |  |  |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
				And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | USA     | You have successfully completed your application, and your jewelry is now insured. |
				And I Kill Web Driver
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
               	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
                And I select Search from the Tab menu 
                And search for account with <AccountNumber> and select from search results for QNA 
                And I select details from left navigation menu 
                Then I verify <GWPrimaryInsured> , <GWAddress> , " " , <GWPaymentPlan> ,  REGISTRY , REGISTRY , <GWPayment_Instrument> in Account Details page  
                And I Logout of the Billing Center application


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity       | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | creditConsent |
                | QG                     | desktop    |            | Chrome      |                 | Golden6   | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | unique       | Email             | Female | No                    | No                       | Yes           | Monitored Alarm System | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes           |

@RegressionSR
@STP 
@regression
@sr6
Scenario Outline: Scenario06_SR_GEICO_Save_Retrieve_Replace
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Watch       | 60000  |
                |         | Pendant     | 5000  |
                |         | Other       | 8000  |
                And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
               And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
                | Rolex          | Women's |                |           |
                |                |         |                |           |
                | Other          |         |                |           |
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
				And I Kill Web Driver
				 Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Necklace    | 2000  |
                And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , regedit , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
				And I Check the <TermsAndConditions> on Applicant and Wearer page
				 And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |  
                And I select <EffectiveDate> in Jewelry Details page 
                And I only Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
			    And I click on Save and Finish application on Jwelery Details Page
			     And I Save My Application
				And I Take Action on saved application
				| Action                   |
				| safely leave application |
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				And I retrieve Saved Application
                And I verify Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender> in the Applicant page
				And I verify the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber  | Email                            | DOB        | Relationship | Gender |
                | Wearer     | Ice       | Cube     | No              | 48 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   | 931-456-9888 | qnaGeicoWearer@apptest.jminsure.com | 07/07/1969 | Child        | Male   |
				And I click on Next button in in Applicant and Wearer page
				And I Verify the jewelry information Jewelry Details page
				| JewelryType | JewelryValue | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
				| Necklace        | 2000        |  |  |                |           |
				And I Verify <EffectiveDate> in Jewelry Details page 
			    And I Verify <AlarmAndSecurity> in Securityoption of  Jewelry Details page
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity       | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | creditConsent |
                | QNA                    | desktop    |            | Chrome      |                 | Golden6   | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | unique       | Email             | Female | No                    | No                       | Yes           | Monitored Alarm System | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes           |

	