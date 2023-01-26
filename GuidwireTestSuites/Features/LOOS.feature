Feature: LOOS

@LOOSReg
@LOOS01	
Scenario Outline: 01_QNA_Happy_single_store_Single_locatin
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
						| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
						| LOOS                   | desktop    |            | Chrome      |                 | 1926         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes                |

@LOOSReg
@LOOS02
Scenario Outline: 02_QNA_Happy_STP_single_state_multi_location
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
							| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
							#| LOOS                   | desktop    |            | Chrome      |                 | 2222         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force        | Yes                |
							| LOOS                   | desktop    |            | Chrome      |                 | 1926         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes                |

@LOOSReg
@LOOS03
Scenario Outline: 03_QNA_Happy_STP_Multi_state_multi_location
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page 
				And I Enter State where I recently made purcahse
						  | State    |
						  #| North Carolina |
						  | International |

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
							| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
							#| LOOS                   | desktop    |            | Chrome      |                 | 3333         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force        | Yes                |
							| LOOS                   | desktop    |            | Chrome      |                 | 4086         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes                |

@LOOSReg
@LOOS04
Scenario Outline: 04_QNA_Happy_STP_Diamonds_International_Multi_State_Multi_Country
				Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page
				 And I Enter State where I recently made purcahse
						  | State    |
						  | International |
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
							| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
							#| LOOS                   | desktop    |            | Chrome      |                 | 4086          | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force        | Yes                |
							| LOOS                   | desktop    |            | Chrome      |                 | 4086          | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes                |

@LOOSReg
@LOOS05
Scenario Outline: 05_QNA_Happy_STP_Confer_Jewelers_Inc_Single_Country_Single_Loc
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
							| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | GWPaymentPlan | GWExpireDate | GWPayment_Instrument | AutoPay | GW_PolicyStatus | TermsAndConditions |
							#| LOOS                   | desktop    |            | Chrome      |                 | 1926          | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****8291        | Yes     | In Force        | Yes                |
							| LOOS                   | desktop    |            | Chrome      |                 | 1926          | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link       | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Annual Pay    | REGISTRY     | visa ****1111        | Yes     | In Force        | Yes                |

@LOOSReg
@LOOS06
Scenario Outline: 06_QNA_Happy_Non_STP_Single_Store_Single_location
			Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
			When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page
			And I Enter <FirstName> , <LastName> , <EmailAddress>  in the Quote Page Details for LOOS
			And I Enter the Quote Page Details for LOOS
			| ZipCode | JewelryType | Value |
			| 53189   | Ring        | 100001 |
			And I click on NewExisting Customer Page  
			And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
			And I Enter the Applicant or Wearers details with respect to wearing items 
			| WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
			| PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
			And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
			And I Check the <TermsAndConditions> on Applicant and Wearer page
			And I Enter the jewelry information Jewelry Details page
			| JewelrySubType | Gender  | DateOFPurchase | Appraisal |
			| Engagement Ring               | Men's |      | No       |
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
			| Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken.|
			#And I enter  for Jewelry Storage Details in UW question details
			#| SafeDepositBox | SafeDepositlocation | SafeDepositAddress | CommunityGated | FenceSurround | GuardAtGate | GuardPresent | CommunityPatrol | PatrolFrequency | HowyouEnterCommunity | HowGuestEnterCommunity | DomesticHelp | DomesticHelpType  | EmployeeLength        | DomesticHelpResideHome | DomesticHelpFreq  | HomeHasOtherResidents | ReleationshiptoResident | JewelryWornFre |
			#| Yes            | test12              | Address            | Yes            | Yes           | Yes         | night only   | Yes             | night only      | EnterCommunity       | GuestEnterCommunity    | Yes          | Medical Assistant | Less than 2 years ago | No                     | 1-2 times a month | Yes                   | children                | Never          |
			#And I enter Travel Details in UW question details
			#| TravelOverNightFreq | TravelAbroad | TravelSafeGuard             | TravelDescription |
			#| 1-3 trips           | yes          | I keep it in the hotel safe |                   |
			#And I Review the application
			#| Submitapplication | PaperlessDelivery |
			#| Yes               | Yes               |
			#And I should get the confirmation page with the account number
			#| ConfirmationContentValidation                                                                                                                                                                                                                                                                                  |
			#| Your application will be reviewed and you'll hear from us within 2 to 3 business days on next steps. If your application is approved, we will update your policy effective date to the date when payment is taken. 
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
			| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                 | PCActivities           |
			#| LOOS                   | desktop    |            | Chrome      |                 | 2222         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |
			| LOOS                   | desktop    |            | Chrome      |                 | 1926         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |

@LOOSReg
@LOOS07
Scenario Outline: 07_QNA_Happy_Non_STP_single_state_multi_location
			Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
			When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page
			And I Enter <FirstName> , <LastName> , <EmailAddress>  in the Quote Page Details for LOOS
			And I Enter the Quote Page Details for LOOS
			| ZipCode | JewelryType | Value |
			| 53189   | Ring        | 100001 |
			And I click on NewExisting Customer Page  
			And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
			And I Enter the Applicant or Wearers details with respect to wearing items 
			| WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
			| PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
			And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
			And I Check the <TermsAndConditions> on Applicant and Wearer page
			And I Enter the jewelry information Jewelry Details page
			| JewelrySubType | Gender  | DateOFPurchase | Appraisal |
			| Engagement Ring               | Men's |      | No       |
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
			| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | PolicyStatus | Activities                                 | PCActivities           |
			#| LOOS                   | desktop    |            | Chrome      |                 | 2222         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |
			| LOOS                   | desktop    |            | Chrome      |                 | 1926         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |

@LOOSReg
@LOOS08												
Scenario Outline: 08_QNA_Happy_NonSTP_Diamonds_International_Multi_State_Multi_Country
			Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
			When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page
			And I Enter State where I recently made purcahse
			| State    |
			| International |
			And I Enter <FirstName> , <LastName> , <EmailAddress>  in the Quote Page Details for LOOS
			And I Enter the Quote Page Details for LOOS
			| ZipCode | JewelryType | Value |
			| 53189   | Ring        | 100001 |
			And I click on NewExisting Customer Page  
			And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
			And I Enter the Applicant or Wearers details with respect to wearing items 
			| WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
			| PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
			And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
			And I Check the <TermsAndConditions> on Applicant and Wearer page
			And I Enter the jewelry information Jewelry Details page
			| JewelrySubType | Gender  | DateOFPurchase | Appraisal |
			| Engagement Ring               | Men's |      | No       |
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
			| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | TermsAndConditions | PolicyStatus | Activities                                 | PCActivities           |
			| LOOS                   | desktop    |            | Chrome      |                 | 4086         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Yes                | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |

@LOOSReg
@LOOS09
Scenario Outline: 09_QNA_Happy_NonSTP_Multi_state_multi_location
			Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
			When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page
			And I Enter State where I recently made purcahse
			| State    |
			#| North Carolina |
			| International |
			And I Enter <FirstName> , <LastName> , <EmailAddress>  in the Quote Page Details for LOOS
			And I Enter the Quote Page Details for LOOS
			| ZipCode | JewelryType | Value |
			#| 54956   | Ring        |25001 |
			| 53189   | Ring        | 100001 |
			And I click on NewExisting Customer Page  
			And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
			And I Enter the Applicant or Wearers details with respect to wearing items 
			| WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
			| PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
			And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
			And I Check the <TermsAndConditions> on Applicant and Wearer page
			And I Enter the jewelry information Jewelry Details page
			| JewelrySubType | Gender  | DateOFPurchase | Appraisal |
			| Engagement Ring               | Men's |      | No       |
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
			Examples:
			| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | TermsAndConditions | PolicyStatus | Activities                                 | PCActivities           |
			#| LOOS                   | desktop    |            | Chrome      |                 | 3333         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Yes                | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |
			| LOOS                   | desktop    |            | Chrome      |                 | 4086         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Yes                | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |

@LOOSReg
@LOOS10
Scenario Outline: 10_QNA_Happy_NonSTP_Multi_state_multi_location
			Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
			When I enter the <Brocuhercode> on Free Jewelry Insurance Quote Page 
			And I Enter State where I recently made purcahse
			| State    |
			#| North Carolina |
			| International |
			And I Enter <FirstName> , <LastName> , <EmailAddress>  in the Quote Page Details for LOOS
			And I Enter the Quote Page Details for LOOS
			| ZipCode | JewelryType | Value |
			#| 54956   | Ring        |25001 |
			| 53189   | Ring        | 100001 |
			And I click on NewExisting Customer Page  
			And I Enter the Contact Information  <Address> , <Apartment> , <City> , <State> , <AddressZipCode> , <IsMailingAddress> ,  <ContactPreference> , <GWDateofBirth> , <Gender> for Partner mode
			And I Enter the Applicant or Wearers details with respect to wearing items 
			| WearerType       | FirstName    | LastName    | AddressAsPriApp | Address             | AptSuite | City     | StateProv | ZipCode | PhoneNumber | Email                        | DOB        | Relationship | Gender |
			| PrimaryApplicant |              |             |                 |                     |          |          |           |         |             |                              |            |              |        |
			And I Enter qualification questions <MinorTrafficViolation> , <LossTheftDamageToJewelry> on Applicant and Wearer page
			And I Check the <TermsAndConditions> on Applicant and Wearer page
			And I Enter the jewelry information Jewelry Details page
			| JewelrySubType | Gender  | DateOFPurchase | Appraisal |
			| Engagement Ring               | Men's |      | No       |
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
			| ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | Brocuhercode | FirstName  | LastName | Address             | Apartment | City   | State     | AddressZipCode | IsMailingAddress | PhoneNumber | EmailAddress         | ContactPreference | Gender | WearerType       | MinorTrafficViolation | LossTheftDamageToJewelry | PrivacyPolicy | AlarmAndSecurity | EffectiveDate | ProducerCode | GWPaperlessDelivery | GWApplicationTakenBy | GWDistributionSource | GWPrimaryInsured | GWDateofBirth | GWOccupation | GWAddressType | GWStatus | GWAddress | AccountNumber | GW_UserName | GW_Password | TermsAndConditions | PolicyStatus | Activities                                 | PCActivities           |
			#| LOOS                   | desktop    |            | Chrome      |                 | 3333         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Yes                | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |
			| LOOS                   | desktop    |            | Chrome      |                 | 4086         | QAPMGolden | STP      | 48 Jewelers Park Dr |           | Neenah | Wisconsin | 54956          | Yes              |             | rparas@jminsure.com | Email             | FeMale | PrimaryApplicant | No                    | No                       | Yes           | No               | currentdate   | DIRD         | Yes                 |                      | Link                 | REGISTRY         | 05/01/1977    |              | Home          | Active   | REGISTRY  | REGISTRY      | su          | gw          | Yes                | Quoted       | Item Value Exceeds Underwriting Guidelines | Submission with issues |
