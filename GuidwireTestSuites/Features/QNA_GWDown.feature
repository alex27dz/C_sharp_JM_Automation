Feature: QNA_GWDown
	



@GwDown
                Scenario Outline: GWDown01_STP_LessThan16kWithAppraisals_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                And I verify Quote Page error validation messages
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Ring        | 15000 |
                And I verify Applicant Wearer Page error validation messages
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
                | PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType  | Gender  | DateOFPurchase | Appraisal |
                | Engagement Ring | Women's | 01/04/2017     | Yes       |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
				And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |
               
				Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName      | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay |GW_PolicyStatus|
                | QG                     | desktop    |            | Chrome      |                 | QNAGEICOGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force |

@GwDown
                Scenario Outline: GWDown02_STP_LessThan16kWithoutAppraisals_CA
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Earrings    | 2000  |
                |         | Bracelet    | 2000  |
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
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I set Credit Consent <creditConsent> for CA
				And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
				And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |
                
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName        | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | creditConsent |
                | QNA                    | desktop    |            | Chrome      |                 | RegularQnAGolden | STP      | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 2025352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | Responsive           | No      | In Force        | No            |

                
@GwDown
                Scenario Outline: GWDown03_NonSTP_16to38kWithAppraisals_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Necklace    | 38000 |
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
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
               And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |
                    Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName        | LastName | Address          | Apartment | City           | State | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress                 | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                            |
                | QNA                    | desktop    |            | Chrome      |                 | RegularQnAGolden | NonSTP   | 302 Millers Xing | Ste 11    | Harker Heights | Texas | 76548          | Yes              | 2025352871  | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Quoted       | Approval Needed - Item Value Exceeds Underwriting Guidelines: Item #1 |


 @GwDown
                Scenario Outline: GWDown04_NonSTP_ScheduleTotalGreaterthen2.5k_CA
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Watch       | 1000  |
                |         | Chain       | 1500  |
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
				And I set Credit Consent <creditConsent> for CA
			    And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                 And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress               | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                               | creditConsent |
                | QNA                    | desktop    |            | Chrome      |                 | Golden4   | NonSTP   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 9205352871  | rparas@jminsure.com | Email             | Male   | wearer     | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Quoted       | Total Gents/Non-Gender Value is over the value threshold | Yes           |

                
@GwDown
                Scenario Outline: GWDown05_NonSTP_SingleitemGreaterthen50k_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 80202   | Pendant     | 51000 |
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
                And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address      | Apartment | City   | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress               | ContactPreference | Gender | WearerType | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                                                                                                                  |
                | QNA                    | desktop    |            | Chrome      |                 | Golden5   | NonSTP   | 1250 14th St |           | Denver | Colorado | 80202     | No               | 9205352871  | rparas@jminsure.com | Email             | FeMale | wearer     | No                    | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Quoted       | Approval Needed - Item Value Exceeds Underwriting Guidelines: Item #1;Total Schedule Exceeds $500,000;UW Questionnaire review date is blank |



@GwDown
                Scenario Outline: GWDown06_STP_LessThen5K_CA
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Pendant     | 3000  |
                |         | Loose stone | 1999  |
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                | Wearer           | WearerFName1 | WearerLName | No              | 127 Church Street | 21       | Toronto | Ontario   | M5C 2G5 |             |       | 07/07/1979 | Child        | Female   |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
               	And I set Credit Consent <creditConsent> for CA
			    And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                 And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress               | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity       | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | creditConsent |
                | QNA                    | desktop    |            | Chrome      |                 | Golden6   | NonSTP   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 9205352871  | rparas@jminsure.com | Email             | Female | No                    | No                       | Yes           | Monitored Alarm System | currentdate   | DIRD         | Yes                 |                      | Web                  | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Annual Pay    | REGISTRY     | Responsive           | No      | In Force        | Yes           |


@GwDown
                Scenario Outline: GWDown07_NonSTP_lessthen16KFelonyDUI_US
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | 54956   | Ring        | 6000  |
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
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress               | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                        |
                | QNA                    | desktop    |            | Chrome      |                 | Golden7   | NonSTP   | 24 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              | 9205352871  | rparas@jminsure.com | Email             | Female | felony                | No                       | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su           | gw        |  Quoted       | Approval Needed - Applicant convicted of a felony |

@GwDown
                Scenario Outline: GWDown08_NonSTP_lessthen16KLossGreaterthen7_5K_CA
                Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
                When I Enter the Quote Page Details
                | ZipCode | JewelryType | Value |
                | R3G 3P8 | Brooch      | 3000  |
                And I Enter the Contact Information <FirstName> , <LastName> , <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> , <PhoneNumber> , <EmailAddress> , <ContactPreference> , <GWDateofBirth> , <Gender>
                And I Enter the Applicant or Wearers details with respect to wearing items 
                | WearerType       | FirstName    | LastName    | AddressAsPriApp | Address           | AptSuite | City    | StateProv | ZipCode | PhoneNumber | Email | DOB        | Relationship | Gender |
                | Primaryapplicant |              |             |                 |                   |          |         |           |         |             |       |            |              |        |
                And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
                And I Enetr loss details
                | Loss_Date  | Type  | LossAmount |
                | 04/05/2015 | Theft | 3500      |
                | 12/10/2016 | Theft | 4001      |
                And I Check the <TermsAndConditions> on Applicant and Wearer page
                And I Enter the jewelry information Jewelry Details page
                | JewelrySubType | Gender | DateOFPurchase | Appraisal |
                |                |        |                |           |
                And I select <EffectiveDate> in Jewelry Details page 
                And I Enetr <AlarmAndSecurity> in Securityoption of  Jewelry Details page
                And I set Credit Consent <creditConsent> for CA
				And I Review the application
                | Submitapplication | PaperlessDelivery |
                | Yes               | Yes               |
                And I should get the text on the confirmation page only for GW Down Scenarios
				| ConfirmationContentValidation                                                                                                                     |
				| Your application requires further review. If we have questions or need to adjust your quoted premium, we will contact you within 2 business days. |


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | FirstName | LastName | Address         | Apartment | City     | State    | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                     |
                | QNA                    | desktop    |            | Chrome      |                 | Golden8   | NonSTP   | 1001 Empress St |           | Winnipeg | Manitoba | R3G 3P8        | Yes              | 9205352871  | rparas@jminsure.com | Email             | Female | No                    | yes                      | Yes           | No               | currentdate   | Z100D00      | Yes                 |                      | Agency Express       | REGISTRY         | 07/01/1966    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Approval Needed - Prior Losses |


           
 