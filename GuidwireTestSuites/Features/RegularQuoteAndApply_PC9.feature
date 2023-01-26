Feature: RegularQuoteAndApply_PC9
	

@NonSTP 
@regression
@Rqna1
@Rqna
Scenario Outline: QNA_Reg01_STP_Duplicate_Misdem_Felony
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 13001 |
                |         | Earrings    | 1501  |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring   | Women's |                |           |
                | Pair of Earrings |         |                |           |  
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
                And I verfy    , In Force , REGISTRY in Policy Term  for PC9
                And I logout of the PC9 application 
				And I Kill Web Driver
				And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Ring        | 13001 |
                |         | Earrings    | 1501  |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information REGISTRY , REGISTRY , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring   | Women's |                |           |
                | Pair of Earrings |         |                |           |  
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
				And I select Accounts from the Search Tab menu of PC9
			    And search for account with <AccountNumber> and select from search results in PC9
               	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
               And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9    
               And I verify Activity  <PCActivities> in PC9
			   And I click workorder number of Account detail screen in PC9
			   And I click on RiskAnalysis on Left NavMenu Screen in PC9
			   And I verify <Activities> in the Risk Analysis screen in PC9
			   Then I logout of the PC9 application 
				
				 
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName  | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EmailOrPhoneJMIS | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                 | AutoPay | PCActivities         |
                | QNA                    | desktop    |            | Chrome      |                 | Account   | Duplicate | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | Phone            | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed-Possible Duplicate Account | No      | Submission with issues |


				
 @STP 
@regression
@Rqna2
@Rqna
Scenario Outline: QNA_Reg02_STP_CAN_Less Than 16k Item Type Other
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Bracelet    | 2000  |
                |         | Necklace    | 1100  |
                |         | Other       | 1000  |
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
                |                | Women's |                | Yes       |
                |                |         |                | Yes       |
                | Other          |         |                | Yes       |
               And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I set Credit Consent <creditConsent> for CA
				And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | VISA     | CA     | You have successfully completed your application, and your jewelry is now insured. |
                And I access the Guidewire PC on Desktop in IE
               	 And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
                And I select Accounts from the Search Tab menu of PC9
                And search for account with <AccountNumber> and select from search results in PC9
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9 
		        And I verify Activity  <PCActivities> in PC9
				And I click on contacts on Left NavMenu Screen in PC9
			    And I verify  <creditConsent> in GW policy Center in Pc9
				And I click on summary on Left NavMenu Screen in PC9
			    And I click workorder number of Account detail screen in PC9
			    And I click on RiskAnalysis on Left NavMenu Screen in PC9
			    And I verify <Activities> in the Risk Analysis screen in PC9
		        Then I logout of the PC9 application 




                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                  | AutoPay | creditConsent | PCActivities |
                | QNA                    | desktop    |            | Chrome      |                 | Regular   | CAN16k   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 2025352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Type = Other - Item #3 | Yes     | Yes           | Submission with issues             |
 

# @NonSTP 
#@regression
#Scenario Outline: QNA_Reg03_BBT_NonSTP_Over_75k_RightPanelEdit
#                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
#                When I Enter the Quote Page Details
#                | ZipCode | JewelryType | Value |
#                | 54956   | Watch       | 60000  |
#                |         | Pendant     | 5000  |
#                |         | Other       | 8000  |
#                And I click on NewExisting Customer Page  
#                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
#               And I Enter the Applicant or Wearers details with respect to wearing items 
#                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
#                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
#                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
#                | Primaryapplicant |           |          |                 |         |          |      |           |         |             |       |     |              |        |
#                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
#                And I Check the <TermsAndConditions> on Applicant and Wearer page
#                And I Enter the jewelry information Jewelry Details page
#                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
#                | Rolex          | Women's |                |           |
#                |                |         |                |           |
#                | Other          |         |                |           |
#				And I Edit jewelry information in Jewelry Details page
#				| Item_Value |
#				| 70000      |
#		    	And I select <EffectiveDate> in Jewelry Details page 
#				And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
#                And I enter the  Personal  History Details in UW question details
#                | DeniedCov | DeniedCovreason |
#                | no        |                 |
#                And I enter  for Jewelry Storage Details in UW question details
#                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
#                | No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
#                And I enter Travel Details in UW question details
#                | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
#                | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
#                And I Review the application
#                | Submitapplication | PaperlessDelivery |
#                | Yes               | Yes               |
#                And I should get the confirmation page with the account number
#                | ConfirmationContentValidation |
#                | Due to the value of your jewelry, your application requires further review. We will contact you within 2 to 3 business days to discuss your application. Your quoted premium could be adjusted based on this review. If your application is approved, coverage will begin after the requested payment is submitted. |
#                And I access the Guidewire PC on Desktop in IE
#              	 And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
#                And I select Accounts from the Search Tab menu of PC9
#                And search for account with <AccountNumber> and select from search results in PC9
#			   	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
#				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
#				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9 
#		        And I verify Activity  <PCActivities> in PC9
#				And I click workorder number of Account detail screen in PC9
#			    And I click on RiskAnalysis on Left NavMenu Screen in PC9
#			    And I verify <Activities> in the Risk Analysis screen in PC9
#		        Then I logout of the PC9 application 
#			
#                Examples:
#                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName        | LastName | Address          | Apartment | City           | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                       | PCActivities                   |
#                | QABBT                  | desktop    |            | Chrome      |                 | RegularQnAGolden | NonSTP   | 302 Millers Xing | Ste 11    | Harker Heights | Texas | 76548          | Yes              | 2025352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | U10D00         | Yes                 | Web                  | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Item Value Exceeds Underwriting Guidelines: Item #1;Item Type = Other - Item #3;Total Schedule Exceeds $50,000 | Schedule Exceeds UW Guidelines |


				@AddressIssue
 @NonSTP 				
@regression
@Rqna4
@Rqna
Scenario Outline: QNA_Reg04_CAN_NonSTP_Over_20k_Diff_Mailing_Surcharge
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Necklace    | 10001 |
                |         | Chain       | 11001 |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                | Wearer           | WearerFName1 | WearerLName | No              | 127 Church Street | 21       | Toronto | Ontario   | M5C 2G5 |             |       | 07/07/1979 | Child        | Female   |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
                |                |         |                | No        |
                |                | Women's |                | No        |
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
               	And I set Credit Consent <creditConsent> for CA
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
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9 
		        And I verify Activity  <PCActivities> in PC9
				And I click on contacts on Left NavMenu Screen in PC9
			    And I verify  <creditConsent> in GW policy Center in Pc9
				And I click on summary on Left NavMenu Screen in PC9
			    And I click workorder number of Account detail screen in PC9
			    And I click on RiskAnalysis on Left NavMenu Screen in PC9
			    And I verify <Activities> in the Risk Analysis screen in PC9
		        Then I logout of the PC9 application  
		

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName  | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                              | creditConsent | PCActivities                          |
                | QNA                    | desktop    |            | Chrome      |                 | RegularQnA | STP      | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 2025352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Canada Schedule Exceeds UW Guidelines | No            |  Submission with issues  |

				 @NonSTP 
@regression
@Rqna5
@Rqna
Scenario Outline: QNA_Reg05_CAN_NonSTP_Over_20k_Diff_Mailing_LossGreaterThen25K_Homicide
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Necklace    | 21001 |
                |         | Loose stone | 22001 |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                | Wearer           | WearerFName1 | WearerLName | No              | 127 Church Street | 21       | Toronto | Ontario   | M5C 2G5 |             |       | 07/07/1979 | Child        | Female   |
				And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr Sentence completion details
                | Date       | Type  |
                | 05/03/2016 | Homicide |
				And I Enetr loss details
                | Loss_Date  | Type | LossAmount |
                | 04/05/2016 | Lost | 30000      |
         		And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                | No        |
                |                |        |                | No        |
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
               	And I set Credit Consent <creditConsent> for CA
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
				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9 
		        And I verify Activity  <PCActivities> in PC9
				And I click on contacts on Left NavMenu Screen in PC9
			    And I verify  <creditConsent> in GW policy Center in Pc9
				And I click on summary on Left NavMenu Screen in PC9
			    And I click workorder number of Account detail screen in PC9
			    And I click on RiskAnalysis on Left NavMenu Screen in PC9
			    And I verify <Activities> in the Risk Analysis screen in PC9
		        Then I logout of the PC9 application  

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName  | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                       | creditConsent | PCActivities           |
                | QNA                    | desktop    |            | Chrome      |                 | RegularQnA | STP      | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 2025352871  | adzhoharidze@jminsure.com | Email             | FeMale | felony                | Yes                      | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Canada Schedule Exceeds UW Guidelines;Approval Needed - Applicant convicted of a felony;Loss or Claim Activity | Yes           | Submission with issues |

#
#				@NonSTP 
#@regression
#Scenario Outline: QNA_Reg06_Bungalow_NonSTP_38k_Appraisal
#                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
#                When I Enter the Quote Page Details
#                | ZipCode | JewelryType | Value |
#                | 54956   | Brooch        | 38000 |
#				And I click on NewExisting Customer Page  
#                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
#                And I Enter the Applicant or Wearers details with respect to wearing items 
#                | WearerType       | FirstName | LastName | AddressAsPriApp | Address             | AptSuite | City   | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
#                | PrimaryApplicant |           |          | No              | 24 Jewelers Park Dr |          | Neenah | Wisconsin | 54956   |             |       | 07/07/1979 | Child        | Male   |
#                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
#                And I Enetr loss details
#                | Loss_Date  | Type | LossAmount |
#                | 11/11/2010 | Lost | 20000      |
#				And I Check the <TermsAndConditions> on Applicant and Wearer page
#                And I Enter the jewelry information Jewelry Details page
#                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
#                |                |        | 01/04/2017     | Yes       |
#                And I select <EffectiveDate> in Jewelry Details page 
#                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
#                And I enter the  Personal  History Details in UW question details
#                | DeniedCov | DeniedCovreason |
#                | no        |                 |
#                And I enter  for Jewelry Storage Details in UW question details
#                | SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
#                | No            | test12              | Address            | No            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | No          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | No                   | children                | Never          |
#                And I enter Travel Details in UW question details
#                | TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
#                | 1-3 trips           | yes          | I keep it in the hotel safe |                   |
#               	And I set Credit Consent <creditConsent> for CA
#			    And I Review the application
#                | Submitapplication | PaperlessDelivery |
#                | Yes               | Yes               |
#                And I should get the confirmation page with the account number
#                | ConfirmationContentValidation                                                                                                                     |
#                | Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 to 3 business days. |
#			 	And I access the Guidewire PC on Desktop in IE
#               	 And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
#                And I select Accounts from the Search Tab menu of PC9
#                And search for account with <AccountNumber> and select from search results in PC9
#				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
#				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
#				And I verify Activity  <PCActivities> in PC9
#				And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9 
#				And I click workorder number of Account detail screen in PC9
#			    And I click on RiskAnalysis on Left NavMenu Screen in PC9
#			    And I verify <Activities> in the Risk Analysis screen in PC9
#		        Then I logout of the PC9 application  
#				Examples:
#                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                            | PCActivities         |
#                | QABUNG                 | desktop    |            | Chrome      |                 | QNAGEICOGolden | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Male   | PrimaryApplicant | No                    | Yes                      | Yes           | No               | currentdate   | DIRD         | Yes                 | Web                  | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Item Value Exceeds Underwriting Guidelines: Item #1 | Web New Sub w/issues |
#


				 @STP 								
@regression
@Rqna7
@Rqna
 Scenario Outline: QNA_Reg07_GEICO_STP_MinimumPremeium
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Earrings    | 24    |
				And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender | DateOFPurchase | Appraisal |
                | Pair of Earrings |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
                And I make payment using E-check, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
                | AchType  | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | Checking | USA     | You have successfully completed your application, and your jewelry is now insured. |
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus |
                | QG                     | desktop    |            | Chrome      |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Male   | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | Checking ****3332    | Yes     | In Force        |


				@STP 
@regression
@Rqna8
@Rqna
 Scenario Outline: QNA_Reg08_CAN_STP_MinimumPremium
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Bracelet     | 49  |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Wearer           | WearerFName1 | WearerLName | No              | 127 Church Street | 21       | Toronto | Ontario   | M5C 2G5 |             |       | 07/07/1979 | Child        | Female   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                | Men's  |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
               	And I set Credit Consent <creditConsent> for CA
			    And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				  And I make payment using E-check, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
                | AchType  | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | Saving | CA     | You have successfully completed your application, and your jewelry is now insured. |
				And I access the Guidewire PC on Desktop in IE
				 And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
				And search for account with <AccountNumber> and select from search results in PC9 
				And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
				And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
                And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
				And I click on contacts on Left NavMenu Screen in PC9
			    And I verify  <creditConsent> in GW policy Center in Pc9
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress               | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity       | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | creditConsent |
                | QNA                    | desktop    |            | Chrome |                 | Golden6   | NonSTP   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Male | No                    | No                       | Yes           | Monitored Alarm System | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | Savings ****3332           | Yes      | In Force        | Yes           |
 


 @NonSTP 
@regression
@Rqna9
@Rqna
Scenario Outline: QNA_Reg09_GEICO_NonSTP_ApplicantFemale_WearerGents_value greater5k
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Watch       | 22000 |
				And I click on NewExisting Customer Page  
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType | FirstName    | LastName    | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber  | Email                     | DOB        | Relationship | Gender |
                | Wearer     | WearerFName1 | WearerLName | Yes             |         |          |      |           |         | 920-221-1279 | vbadvel@jminsure.com | 07/07/1985 | Husband      | Male   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender  | DateOFPurchase | Appraisal |
                |Rolex                | Men's |                |           |    
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
                | ConfirmationContentValidation                                                                                                                     |
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
		        Then I logout of the PC9 application  


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                       | PCActivities         |
                | QG                     | desktop    |            | Chrome      |                 | QNAScn9   | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888  | adzhoharidze@jminsure.com | Email             | FeMale | No                    | No                       | Yes           | Local Alarm      | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Applicant is less than or equal to 40 years old and item type is watch.;Total Gents/Non-Gender Value is over the value threshold | Submission with issues  |


				@NonSTP
@regression
@Rqna10
@Rqna
Scenario Outline: QNA_Reg10_GEICO_NonSTP_MulitiItem_Schedule value Greater_38_less_50
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Earrings    | 26000 |
                |         | Bracelet    | 22500 |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | PrimaryApplicant |           |          | Yes             |         |          |      |           |         |             |       |     |              |        |
                | PrimaryApplicant |           |          | Yes             |         |          |      |           |         |             |       |     |              |        |
			    And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender  | DateOFPurchase | Appraisal |
                | Pair of Earrings |         | 01/04/2017     | yes       |
                |                  | Women's |                |           |
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
                | ConfirmationContentValidation                                                                                                                     |
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
		        Then I logout of the PC9 application   

                Examples:
				 | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                        | PCActivities         |
				 | QG                     | desktop    |            | Chrome      |                 | QNAScn9   | NonSTP   | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888  | adzhoharidze@jminsure.com | Email             | FeMale | No                    | No                       | Yes           | Local Alarm      | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |

				       
               

			   @NonSTP 
@regression
@Rqna13
@Rqna
Scenario Outline: QNA_Reg13_NonSTP_Felony_lossesGreater25K_lessthen10years
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Necklace    | 15000 |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | PrimaryApplicant |           |          | Yes             |         |          |      |           |         |             |       |     |              |        |
      		    And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr Sentence completion details
                | Date       | Type  |
                |03/03/2011 | Drugs |
				  And I Enetr loss details
                | Loss_Date  | Type  | LossAmount |
                | 04/05/2017 | Theft | 7501      |
                
      		    And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |  
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
                | ConfirmationContentValidation                                                                                                                     |
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
		        Then I logout of the PC9 application   

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                       | PCActivities         |
                | QNA                    | desktop    |            | Chrome      |                 | QNAGEICO  | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | Felony                | Yes                      | Yes           | No               | currentdate   | DIRD      | Yes                 |                      |Web       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Loss or Claim Activity | Submission with issues |


				@STP 
@regression
@Rqna14
@Rqna
Scenario Outline: QNA_Reg14_STP_Misdemeanor_lessthen16K
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Watch    | 15000 |
                 And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | PrimaryApplicant |           |          | Yes             |         |          |      |           |         |             |       |     |              |        |
      		    And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr Sentence completion details
                | Date       | Type  |
                |03/03/2011 | DUI/OWI |
				And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                | Rolex          | Men's  |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | No               | Yes               |
                And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | master     | USA     | You have successfully completed your application, and your jewelry is now insured. |
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                | QNA                    | desktop    |            | Chrome |                 | QNA       | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | Misdemeanor           | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | MasterCard ****4444  | Yes     | In Force        | Yes                |


				 @STP 
@regression
@Rqna15
@Rqna
Scenario Outline: QNA_Reg15_STP_Misdemeanor_DUI_lossesGreater25K_Greaterthen10years
   Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Pendant    | 15000 |
                 And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName | LastName | AddressAsPriApp | Address | AptSuite | City | StateProv | ZipCode | PhoneNumber | Email | DOB | Relationship | Gender |
                | PrimaryApplicant |           |          | Yes             |         |          |      |           |         |             |       |     |              |        |
      		    And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr Sentence completion details
                | Date       | Type  |
                |03/03/2011 | DUI/OWI |
				 And I Enetr loss details
                | Loss_Date  | Type | LossAmount |
                | 03/03/2001 | Lost | 26000      |
			    And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | No               | Yes               |
                And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | master     | USA     | You have successfully completed your application, and your jewelry is now insured. |
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
                | QNA                    | desktop    |            | Chrome |                 | QNA       | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 8888888888  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | Misdemeanor           | Yes                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | MasterCard ****4444  | Yes     | In Force        | Yes                |


				@STP 								
@regression
@Rqna16
@Rqna
 Scenario Outline: QNA_Reg16_GEICO_STP_MinimumPremeium_Shell Account
  Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Earrings    | 24    |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information QNAGEICOGolden , STP , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender | DateOFPurchase | Appraisal |
                | Pair of Earrings |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				And I Kill Web Driver
                And I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                And I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 53189   | Earrings    | 24    |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType   | Gender | DateOFPurchase | Appraisal |
                | Pair of Earrings |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				 And I make payment using Card, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
			    | cardType | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | AMEX     | USA     | You have successfully completed your application, and your jewelry is now insured. |
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
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus |
                | QG                     | desktop    |            | Chrome      |                 | REGISTRY  | REGISTRY | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | Amex ****0005        | Yes     | In Force        |

				@STP
@regression
@Rqna17
@Rqna
Scenario Outline: QNA_Reg17_STP_100_Items_US_LessThan50kTotal2
Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
When I Enter the Quote Page Details
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
# add couple of items that related to someone else with info 
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
And I verfy    , In Force , REGISTRY in Policy Term  for PC9
And I logout of the PC9 application 
And I Kill Web Driver
		 
Examples:
| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName  | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EmailOrPhoneJMIS | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                 | AutoPay | PCActivities         |
| QNA                    | desktop    |            | Chrome      |                 | Account   | Duplicate | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9999999999  | adzhoharidze@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | Phone            | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed-Possible Duplicate Account | No      | Submission with issues |



@Rqna88
 Scenario Outline: QNA_Reg88_CAN_STP_MinimumPremium_Prod
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Bracelet     | 49  |
				And I click on NewExisting Customer Page  
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Wearer           | WearerFName1 | WearerLName | No              | 127 Church Street | 21       | Toronto | Ontario   | M5C 2G5 |             |       | 07/07/1979 | Child        | Female   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                | Men's  |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
               	And I set Credit Consent <creditConsent> for CA
			    And I Review the application
                | Submitapplication | PaperlessDelivery |
                | NO               | Yes               |
				  And I make payment using E-check, Set <AutoPay> and Later I verify confirmation message and policy number depending on Environment and <GW_PolicyStatus>
                | AchType  | Country | ConfirmationContentValidation                                                                                                                                                                  |
                | Saving | CA     | You have successfully completed your application, and your jewelry is now insured. |
				And I Kill Web Driver

                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress               | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity       | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | creditConsent |
                | QNA                    | desktop    |            | Chrome |                 | Golden6   | NonSTP   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 9205352871  | adzhoharidze@jminsure.com | Email             | Male | No                    | No                       | Yes           | Monitored Alarm System | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | Savings ****3332           | Yes      | In Force        | Yes           |
 
