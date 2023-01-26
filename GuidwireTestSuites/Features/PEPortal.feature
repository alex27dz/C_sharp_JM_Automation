Feature: PEPortal
@PEexternal
@PE01
Scenario Outline:NST01_GentChain/Watch/Earring_$2.5K   
    Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PEEmailAddress> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I select <EffectiveDate> in Create New Account Page
	#And I click Next in Create New Account Page
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I click Start Full Application
	And I enter below details in Article Page 
	| Article  | Gender | WearableTech | Brand | Style | ArticleSubType | Value | Deductible | Damage | Damagetype      | ArticleStored | LocatedWith | PersonFirstName | PersonLastName | PersonDOB  | PersonReleationship | PersonDeniedCoverage | PersonDeniedCoverageReason | Location | LocationAddress1    | LocationAddress2 | LocationCity | LocationZip | LocationState | LocationAlarm | LocationSafe |
	#| Chain    | Gents  | Yes          |       |       |                | 5200  | 0          | No     |                 |               | Other       | unique             | unique            | 07/06/1988 | Parent              | Yes                  | Loss History               | other    | 48 Jewelers Park Dr |                  | Neenah       | 54956-5902  | Wisconsin     | Local         | No           |
	| Watch    | Gents  | Yes          |       |       |                | 2500  | 0          | Yes    | Minor scratches | Safe          |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |
	| Earrings | Gents  | Yes          |       |       | Pair           | 2500  | 0          | No     |                 |               |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |  
	And I click on next in Article Page
	And I Update Alarm Details in Location Details Page 
	| Location            | Alarm           |
	#| 48 Jewelers Park Dr | Central Station |
	| 18 Jewelers Park Dr | Local           |	
	#And I Update Safe Details in Location Details Page 
	##| Location            | SafeWeight            | SafeAnchored |
	#| 48 Jewelers Park Dr | 0-100 lbs;101-199 lbs | yes;yes       |
	#| 18 Jewelers Park Dr | 200-499 lbs           | yes           |		
	And I click on next in Location Details Page 
	And For single contact I update convicted crime denied Coverage and <DOB>  in Contact Details Page 
	| ConvictedofCrime | RecordDate | RecordType | Type | Category | DeniedCoverage | Reason | AdditionalNameInsured |
	| No               |            |            |      |          | No             |        | No                    |
	#And I Update convicted crime information in Contact Details Page
	#| ConvictedofCrime | RecordDate            | RecordType         | Type         | Category                                    |
	#| yes              | 06/01/2014;07/06/2009 | Conviction;Offense | Felony;Other | Fraud;Government, Law Enforcement & Justice |
	#| No               |                       |                    |              |                                             |
	#And I Update denied Coverage information in Contact Details Page
	#| DeniedCoverage | Reason       | AdditionalNameInsured |
	#| yes            | Loss History |                       |
	#| No             |              | yes                   |
	#And I Eneter <DOB> for Primary Contact in Contact Details Page
	And I click on next in Contact Details Page 
	And I Update details in Consent Details Page
	| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
	| yes         | no                | yes             | yes           |
	And I Update Loss details in Consent Details Page
	| OccuranceDate | LossType          | LossAmount |
	| 06/01/2018    | Damage to Article | 100        |
	| 06/01/2018    | Lost Article      | 100        |
	| 06/01/2018    | Theft/Burglary    | 100        |
	And I click on next in Consent Details Page
	#And I click on details for underwriter approval in Quote Page
	And I click on Continue in Quote Page
	And I send Quot for UW review in Quote Summary UW page
	And I Kill Web Driver
	Given I access the Guidewire PC on Desktop in IE
	When I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <DOB>  in Left Account Details page for PC9 
	And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
	And I verify Activity  <PCActivities> in PC9
	And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
	And I click workorder number of Account detail screen in PC9
	And I waite for batch Cycle to execute for PC
	And I click on RiskAnalysis on Left NavMenu Screen in PC9
	And I verify <Activities> in the Risk Analysis screen for JPA in PC9
	And I Issue the PL Smoke test policy in PC9 
  Examples:
| ApplicationEnvironment | TargetType | BrowserType | OperatingSystem | Capability | PCUsername | PCPassword | UserName | Password | FirstName | LastName | AddressLine1        | AddressLine2 | City   | State     | ZipCode    | PEEmailAddress | PrimaryNumber | HomePhone    | WorkPhone | MobilePhone | EffectiveDate | DOB        | AccountNumber | GWPrimaryInsured | GWAddress | PhoneNumber | EmailAddress | GWStatus | GWAddressType | Gender | GWOccupation | GWDistributionSource | ContactPreference | GWApplicationTakenBy | GWPaperlessDelivery | ProducerCode | PCActivities       | PolicyStatus | Activities |
| PEPORTAL               | Desktop    | Chrome      |                 |            | su         | gw         | su       | gw       | unique    | unique   | 18 Jewelers Park Dr |              | Neenah | Wisconsin | 54956-5902 | unique         | homephone     | 2269784366 |           |             | currentdate   | 10/03/1985 | REGISTRY      | REGISTRY         | REGISTRY  | REGISTRY    | UNIQUE       | Active   | Home          |        |              | Agency Express       | Mail              |                      |                     | Z100D30      | Review and approve | Quoted       |damaged item;policy contact not in possession of items.; |

#| PEPORTAL               | Desktop    | Chrome      |                 |            | su         | gw         | su       | gw       | unique    | unique   | 18 Jewelers Park Dr |              | Neenah | Wisconsin | 54956-5902 | unique         | homephone     | 2269784366 |           |             | currentdate   | 10/03/1985 | REGISTRY      | REGISTRY         | REGISTRY  | REGISTRY    | UNIQUE       | Active   | Home          |        |              | Phone                | Mail              |                      |                     | DIRD         | Review and approve | Quoted       | Crime Activity;Article Value Exceeds Threshold;Article Value Exceeds Threshold;Article Value Exceeds Threshold;Damaged Item;Cancelled or Denied Insurance;Policy contact not in possession of items. |

@PEexternal
@PE02
Scenario Outline:NST02_LadiesRing/Watch/CreditGp<5/FelonyConviction/DomesticHelp/TotalSchedule>$50K    
    Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PEEmailAddress> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I select <EffectiveDate> in Create New Account Page
	#And I click Next in Create New Account Page
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I click Start Full Application
	And I enter below details in Article Page 
	| Article  | Gender | WearableTech | Brand | Style | ArticleSubType | Value | Deductible | Damage | Damagetype      | ArticleStored | LocatedWith | PersonFirstName | PersonLastName | PersonDOB  | PersonReleationship | PersonDeniedCoverage | PersonDeniedCoverageReason | Location | LocationAddress1    | LocationAddress2 | LocationCity | LocationZip | LocationState | LocationAlarm | LocationSafe |
	#| Ring    | Gents  | Yes          |       |       |Wedding Set    | 40000 | 0          | No     |                 |               | Other       | unique             | unique            | 07/06/1988 | Parent              | Yes                  | Loss History               | other    | 48 Jewelers Park Dr |                  | Neenah       | 54956-5902  | Wisconsin     | Local         | No           |
	| Ring    | Gents | Yes          |       |       | Wedding Set         | 2500  | 0          | No     |            |               |             |                 |                |           |                     |                      |                            |          |                  |                  |              |             |               |               |              |
	| Watch    | Gents  | Yes          |       |       |                | 10000  | 0          | No    | Minor scratches | Safe          |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |
	And I click on next in Article Page
	And I Update Alarm Details in Location Details Page 
	| Location            | Alarm           |
	| 18 Jewelers Park Dr | Central Station |
	And I click on next in Location Details Page 
	And For single contact I update convicted crime denied Coverage and <DOB>  in Contact Details Page 
	| ConvictedofCrime | RecordDate | RecordType | Type | Category | DeniedCoverage | Reason | AdditionalNameInsured |
	| No               |            |            |      |          | No             |        | No                    |
	And I click on next in Contact Details Page 
	And I Update details in Consent Details Page
	| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
	| No         | no                | yes             | yes           |
	And I click on next in Consent Details Page
	And I click on Continue in Quote Page
	And I send Quot for UW review in Quote Summary UW page
	And I Kill Web Driver
	Given I access the Guidewire PC on Desktop in IE
	When I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <DOB>  in Left Account Details page for PC9 
	And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
	And I verify Activity  <PCActivities> in PC9
	And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
	And I click workorder number of Account detail screen in PC9
	And I waite for batch Cycle to execute for PC
	And I click on RiskAnalysis on Left NavMenu Screen in PC9
	And I verify <Activities> in the Risk Analysis screen for JPA in PC9
	And I Issue the PL Smoke test policy in PC9 
  Examples:
| ApplicationEnvironment | TargetType | BrowserType | OperatingSystem | Capability | PCUsername | PCPassword | UserName | Password | FirstName | LastName | AddressLine1        | AddressLine2 | City   | State     | ZipCode    | PEEmailAddress | PrimaryNumber | HomePhone    | WorkPhone | MobilePhone | EffectiveDate | DOB        | AccountNumber | GWPrimaryInsured | GWAddress | PhoneNumber | EmailAddress | GWStatus | GWAddressType | Gender | GWOccupation | GWDistributionSource | ContactPreference | GWApplicationTakenBy | GWPaperlessDelivery | ProducerCode  | PCActivities       | PolicyStatus | Activities                                                                                                                                                                                           |
| PEPORTAL               | Desktop    | Chrome      |                 |            | su         | gw         | su       | gw       | unique    | unique   | 18 Jewelers Park Dr |              | Neenah | Wisconsin | 54956-5902 | unique         | homephone     | 2269784366 |           |             | currentdate   | 10/03/1985 | REGISTRY      | REGISTRY         | REGISTRY  | REGISTRY    | UNIQUE       | Active   | Home          |        |              | Agency Express       | Mail              |                      |                     | Z100D30  | Review and approve | Quoted       | Article Value Exceeds Threshold;Policy contact not in possession of items. |

@PEexternal
@PE03
Scenario Outline:NST03_ArticleOtherLooseStone  
    Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PEEmailAddress> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I select <EffectiveDate> in Create New Account Page
	#And I click Next in Create New Account Page
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I click Start Full Application
	And I enter below details in Article Page 
	| Article     | Gender | WearableTech | Brand | Style | ArticleSubType | Value | Deductible | Damage | Damagetype | ArticleStored | LocatedWith | PersonFirstName | PersonLastName | PersonDOB | PersonReleationship | PersonDeniedCoverage | PersonDeniedCoverageReason | Location | LocationAddress1 | LocationAddress2 | LocationCity | LocationZip | LocationState | LocationAlarm | LocationSafe |
	| Other       | Ladies | Yes          |       |       | Anklet         | 2500  | 0          | No     |            |               |             |                 |                |           |                     |                      |                            |          |                  |                  |              |             |               |               |              |
	| Loose Stone | Ladies | Yes          |       |       |                | 25000 | 0          | No     |            |               |             |                 |                |           |                     |                      |                            |          |                  |                  |              |             |               |               |              | 
	And I click on next in Article Page
	And I Update Alarm Details in Location Details Page 
	| Location            | Alarm           |
	| 18 Jewelers Park Dr | Local           |
	#And I Update Safe Details in Location Details Page 
	#| Location            | SafeWeight            | SafeAnchored |
	#| 48 Jewelers Park Dr | 0-100 lbs;101-199 lbs | yes;no       |
	#| 18 Jewelers Park Dr | 200-499 lbs           | no           |
	And I click on next in Location Details Page 
	And For single contact I update convicted crime denied Coverage and <DOB>  in Contact Details Page 
	| ConvictedofCrime | RecordDate | RecordType | Type | Category | DeniedCoverage | Reason | AdditionalNameInsured |
	| No               |            |            |      |          | No             |        | No                    |
	#And I Update convicted crime information in Contact Details Page
	#| ConvictedofCrime | RecordDate            | RecordType         | Type         | Category                                    |
	#| No               |                       |                    |              |                                             |
	#And I Update denied Coverage information in Contact Details Page
	#| DeniedCoverage | Reason       | AdditionalNameInsured |
	#| No             |              | No                   |
	#And I Eneter <DOB> for Primary Contact in Contact Details Page
	And I click on next in Contact Details Page 
	And I Update details in Consent Details Page
	| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
	| No         | no                | yes             | yes           |
	And I click on next in Consent Details Page
	#And I click on details for underwriter approval in Quote Page
	And I click on Continue in Quote Page
	And I send Quot for UW review in Quote Summary UW page
	And I Kill Web Driver
	Given I access the Guidewire PC on Desktop in IE
	When I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <DOB>  in Left Account Details page for PC9 
	And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
	And I verify Activity  <PCActivities> in PC9
	And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
	And I click workorder number of Account detail screen in PC9
	And I waite for batch Cycle to execute for PC
	And I click on RiskAnalysis on Left NavMenu Screen in PC9
	And I verify <Activities> in the Risk Analysis screen for JPA in PC9
	And I Issue the PL Smoke test policy in PC9 
  Examples:
| ApplicationEnvironment | TargetType | BrowserType | OperatingSystem | Capability | PCUsername | PCPassword | UserName | Password | FirstName | LastName | AddressLine1        | AddressLine2 | City   | State     | ZipCode    | PEEmailAddress | PrimaryNumber | HomePhone    | WorkPhone | MobilePhone | EffectiveDate | DOB        | AccountNumber | GWPrimaryInsured | GWAddress | PhoneNumber | EmailAddress | GWStatus | GWAddressType | Gender | GWOccupation | GWDistributionSource | ContactPreference | GWApplicationTakenBy | GWPaperlessDelivery | ProducerCode		  | PCActivities       | PolicyStatus | Activities                                                                                                                                                                                           |
| PEPORTAL               | Desktop    | Chrome      |                 |            | su         | gw         | su       | gw       | unique    | unique   | 18 Jewelers Park Dr |              | Neenah | Wisconsin | 54956-5902 | unique         | homephone     | 2269784366 |           |             | currentdate   | 10/03/1985 | REGISTRY      | REGISTRY         | REGISTRY  | REGISTRY    | UNIQUE       | Active   | Home          |        |              | Agency Express       | Mail              |                      |                     | Z100D30         | Review and approve | Quoted       | Article Value Exceeds Threshold;Policy contact not in possession of items. |

	
@PEexternal
@PE04
Scenario Outline: NST04_VaultPriorLos  
    Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PEEmailAddress> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I select <EffectiveDate> in Create New Account Page
	#And I click Next in Create New Account Page
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I click Start Full Application
	And I enter below details in Article Page 
	| Article  | Gender | WearableTech | Brand | Style | ArticleSubType | Value | Deductible | Damage | Damagetype      | ArticleStored | LocatedWith | PersonFirstName | PersonLastName | PersonDOB  | PersonReleationship | PersonDeniedCoverage | PersonDeniedCoverageReason | Location | LocationAddress1    | LocationAddress2 | LocationCity | LocationZip | LocationState | LocationAlarm | LocationSafe |
	#| Chain    | Gents  | Yes          |       |       |                | 5200  | 0          | No     |                 |               | Other       | unique             | unique            | 07/06/1988 | Parent              | Yes                  | Loss History               | other    | 48 Jewelers Park Dr |                  | Neenah       | 54956-5902  | Wisconsin     | Local         | No           |
	| Watch    | Gents  | Yes          |       |       |                | 2500  | 0          | Yes    | Minor scratches | Safe          |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |
	| Earrings | Gents  | Yes          |       |       | Pair           | 2500  | 0          | No     |                 | Vault              |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |  
	And I click on next in Article Page
	And I Update Alarm Details in Location Details Page 
	| Location            | Alarm           |
	#| 48 Jewelers Park Dr | Central Station |
	| 18 Jewelers Park Dr | Local           |
	
	#And I Update Safe Details in Location Details Page 
	#| Location            | SafeWeight            | SafeAnchored |
	#| 48 Jewelers Park Dr | 0-100 lbs;101-199 lbs | yes;no       |
	#| 18 Jewelers Park Dr | 200-499 lbs           | no           |
	
	And I click on next in Location Details Page 
	And For single contact I update convicted crime denied Coverage and <DOB>  in Contact Details Page 
	| ConvictedofCrime | RecordDate | RecordType | Type | Category | DeniedCoverage | Reason | AdditionalNameInsured |
	| No               |            |            |      |          | Yes             | Loss History       | No                    |
	#And I Update convicted crime information in Contact Details Page
	#| ConvictedofCrime | RecordDate            | RecordType         | Type         | Category                                    |
	#| No               |                       |                    |              |                                             |
	#| No               |                       |                    |              |                                             |
	#And I Update denied Coverage information in Contact Details Page
	#| DeniedCoverage | Reason       | AdditionalNameInsured |
	#| yes            | Loss History |                       |
	#| No             |              | yes                   |
	#And I Eneter <DOB> for Primary Contact in Contact Details Page
	And I click on next in Contact Details Page 
	And I Update details in Consent Details Page
	| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
	| yes         | no                | yes             | yes           |
	And I Update Loss details in Consent Details Page
	| OccuranceDate | LossType          | LossAmount |
	| 06/01/2018    | Damage to Article | 100        |
	| 06/01/2018    | Lost Article      | 100        |
	| 06/01/2018    | Theft/Burglary    | 100        |
	And I click on next in Consent Details Page
	#And I click on details for underwriter approval in Quote Page
	And I click on Continue in Quote Page
	And I send Quot for UW review in Quote Summary UW page
	And I Kill Web Driver
	Given I access the Guidewire PC on Desktop in IE
	When I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <DOB>  in Left Account Details page for PC9 
	And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
	And I verify Activity  <PCActivities> in PC9
	And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
	And I click workorder number of Account detail screen in PC9
	And I waite for batch Cycle to execute for PC
	And I click on RiskAnalysis on Left NavMenu Screen in PC9
	And I verify <Activities> in the Risk Analysis screen for JPA in PC9
	And I Issue the PL Smoke test policy in PC9 
  Examples:
| ApplicationEnvironment | TargetType | BrowserType | OperatingSystem | Capability | PCUsername | PCPassword | UserName | Password | FirstName | LastName | AddressLine1        | AddressLine2 | City   | State     | ZipCode    | PEEmailAddress | PrimaryNumber | HomePhone    | WorkPhone | MobilePhone | EffectiveDate | DOB        | AccountNumber | GWPrimaryInsured | GWAddress | PhoneNumber | EmailAddress | GWStatus | GWAddressType | Gender | GWOccupation | GWDistributionSource | ContactPreference | GWApplicationTakenBy | GWPaperlessDelivery | ProducerCode | PCActivities       | PolicyStatus | Activities |
| PEPORTAL               | Desktop    | Chrome      |                 |            | su         | gw         | su       | gw       | unique    | unique   | 18 Jewelers Park Dr |              | Neenah | Wisconsin | 54956-5902 | unique         | homephone     | 2269784366 |           |             | currentdate   | 10/03/1985 | REGISTRY      | REGISTRY         | REGISTRY  | REGISTRY    | UNIQUE       | Active   | Home          |        |              | Agency Express       | Mail              |                      |                     | Z100D30 | Review and approve | Quoted       |damaged item;vault coverage requested;cancelled or denied insurance;policy contact not in possession of items.;     |



Scenario Outline:NonStp  
Given I access the Producer Engage app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
	When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PEEmailAddress> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I select <EffectiveDate> in Create New Account Page
	#And I click Next in Create New Account Page
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I click Start Full Application
	And I enter below details in Article Page 
	| Article  | Gender | WearableTech | Brand | Style | ArticleSubType | Value | Deductible | Damage | Damagetype      | ArticleStored | LocatedWith | PersonFirstName | PersonLastName | PersonDOB  | PersonReleationship | PersonDeniedCoverage | PersonDeniedCoverageReason | Location | LocationAddress1    | LocationAddress2 | LocationCity | LocationZip | LocationState | LocationAlarm | LocationSafe |
	| Chain    | Gents  | Yes          |       |       |                | 5200  | 0          | No     |                 |               | Other       | unique             | unique            | 07/06/1988 | Parent              | Yes                  | Loss History               | other    | 48 Jewelers Park Dr |                  | Neenah       | 54956-5902  | Wisconsin     | Local         | No           |
	| Watch    | Gents  | Yes          |       |       |                | 2500  | 0          | Yes    | Minor scratches | Safe          |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |
	| Earrings | Gents  | Yes          |       |       | Pair           | 2500  | 0          | No     |                 |               |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |  
	And I click on next in Article Page
	And I Update Alarm Details in Location Details Page 
	| Location            | Alarm           |
	| 48 Jewelers Park Dr | Central Station |
	| 18 Jewelers Park Dr | Local           |
	
	
	And I Update Safe Details in Location Details Page 
	| Location            | SafeWeight            | SafeAnchored |
	| 48 Jewelers Park Dr | 0-100 lbs;101-199 lbs | yes;no       |
	| 18 Jewelers Park Dr | 200-499 lbs           | no           |
	
	
	And I click on next in Location Details Page 
	And I Update convicted crime information in Contact Details Page
	| ConvictedofCrime | RecordDate            | RecordType         | Type         | Category                                    |
	| yes              | 06/01/2014;07/06/2009 | Conviction;Offense | Felony;Other | Fraud;Government, Law Enforcement & Justice |
	| No               |                       |                    |              |                                             |
	And I Update denied Coverage information in Contact Details Page
	| DeniedCoverage | Reason       | AdditionalNameInsured |
	| yes            | Loss History |                       |
	| No             |              | yes                   |
	And I Eneter <DOB> for Primary Contact in Contact Details Page
	And I click on next in Contact Details Page 
	And I Update details in Consent Details Page
	| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
	| yes         | no                | yes             | yes           |
	And I Update Loss details in Consent Details Page
	| OccuranceDate | LossType          | LossAmount |
	| 06/01/2014    | Damage to Article | 100        |
	| 06/01/2014    | Lost Article      | 100        |
	| 06/01/2014    | Theft/Burglary    | 100        |
	And I click on next in Consent Details Page
	#And I click on details for underwriter approval in Quote Page
	And I click on Continue in Quote Page
	And I send Quot for UW review in Quote Summary UW page
	And I Kill Web Driver
	Given I access the Guidewire PC on Desktop in IE
	When I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <DOB>  in Left Account Details page for PC9 
	And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
	And I verify Activity  <PCActivities> in PC9
	And I verfy <PolicyStatus> , REGISTRY in Policy Term  for WorkOrders in PC9  
	And I click workorder number of Account detail screen in PC9
	And I waite for batch Cycle to execute for PC
	And I click on RiskAnalysis on Left NavMenu Screen in PC9
	And I verify <Activities> in the Risk Analysis screen for JPA in PC9
	And I Issue the PL Smoke test policy in PC9 
  Examples:
| ApplicationEnvironment | TargetType | BrowserType | OperatingSystem | Capability | PCUsername | PCPassword | UserName | Password | FirstName | LastName | AddressLine1        | AddressLine2 | City   | State     | ZipCode    | PEEmailAddress | PrimaryNumber | HomePhone    | WorkPhone | MobilePhone | EffectiveDate | DOB        | AccountNumber | GWPrimaryInsured | GWAddress | PhoneNumber | EmailAddress | GWStatus | GWAddressType | Gender | GWOccupation | GWDistributionSource | ContactPreference | GWApplicationTakenBy | GWPaperlessDelivery | ProducerCode | PCActivities       | PolicyStatus | Activities                                                                                                                                                                                           |
| PEPORTAL               | Desktop    | Chrome      |                 |            | su         | gw         | su       | gw       | unique    | unique   | 18 Jewelers Park Dr |              | Neenah | Wisconsin | 54956-5902 | unique         | homephone     | 2269784366 |           |             | currentdate   | 10/03/1985 | REGISTRY      | REGISTRY         | REGISTRY  | REGISTRY    | UNIQUE       | Active   | Home          |        |              | Agency Express       | Mail              |                      |                     | Z100D30 | Review and approve | Quoted       | Crime Activity;Article Value Exceeds Threshold;Article Value Exceeds Threshold;Article Value Exceeds Threshold;Damaged Item;Cancelled or Denied Insurance;Policy contact not in possession of items. |


# Unusable for now due to STP restrictions in PE
#Scenario Outline:STP
#    Given I access the QuoteAndApp app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
#    When I login to super partner mode
#    | UserName           | Password |
#    | jmtestpartner+803@gmail.com | Pass1234! |
#	When I click on start New Quote button 
#	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
#	And I take action on search Account result
#	| Action      |
#	| newcustomer |
#	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
#	And I enter other address related details <EmailAddress> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
#	And I select <EffectiveDate> in Create New Account Page
#	#And I click Next in Create New Account Page
#	And I select producer code
#	| ProducerCode |
#	| Z100D30      |
#	And I click Create Account in Create New Account Page
#	And I click Start Full Application
#	And I enter below details in Article Page 
#	| Article | Gender | WearableTech | Brand | Style | ArticleSubType | Value | Deductible | Damage | Damagetype | ArticleStored | LocatedWith | PersonFirstName | PersonLastName | PersonDOB  | PersonReleationship | PersonDeniedCoverage | PersonDeniedCoverageReason | Location | LocationAddress1    | LocationAddress2 | LocationCity | LocationZip | LocationState | LocationAlarm | LocationSafe |
#	| Ring    | Ladies | Yes          |       |       | Engagement     | 21999 | 0          | No     |            |               | Other       | unique          | unique         | 07/06/1988 | Parent              | No                   |                            | other    | 48 Jewelers Park Dr |                  | Neenah       | 54956-5902  | Wisconsin     | Local         | No           |
#	| Watch   | Ladies | Yes          |       |       |                | 1999  | 0          | No     |            | Safe          |             |                 |                |            |                     |                      |                            |          |                     |                  |              |             |               |               |              |
#	And I click on next in Article Page
#	And I Update Alarm Details in Location Details Page 
#	| Location            | Alarm           |
#	| 48 Jewelers Park Dr | Central Station |
#	| 18 Jewelers Park Dr | Local           |
#	And I Update Safe Details in Location Details Page 
#	| Location            | SafeWeight            | SafeAnchored |
#	| 48 Jewelers Park Dr | 0-100 lbs;101-199 lbs | yes;no       |
#	| 18 Jewelers Park Dr | 200-499 lbs           | no           |
#	And I click on next in Location Details Page 
#	And I Update convicted crime information in Contact Details Page
#	| ConvictedofCrime | RecordDate            | RecordType         | Type         | Category                                    |
#	| No               |                       |                    |              |                                             |
#	| No               |                       |                    |              |                                             |
#	And I Update denied Coverage information in Contact Details Page
#	| DeniedCoverage | Reason       | AdditionalNameInsured |
#	| No             |              |                    |
#	| No             |              | yes                   |
#	And I Eneter <DOB> for Primary Contact in Contact Details Page
#	And I click on next in Contact Details Page 
#	And I Update details in Consent Details Page
#	| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
#	| no         | yes                | yes             | yes           |
#	And I click on next in Consent Details Page
#	And I click on Continue in Quote Page
#	And I click Next on Policy Information Page
#	And I select Payment Plan in Payment Details Page
#	| PaymentPlan |
#	| 2 pay   |
#	And I Make Card payment in Payment Details Page
#	| CardType | AutoPay |
#	| Visa     | Yes     |
#	And I Kill Web Driver
#	And I access the Guidewire PC on Desktop in IE
#    And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
#	And I select Policies from the Search Tab menu of PC9
#	And search for account with <AccountNumber> and select from search results in PC9 
#	And I verify <GWPrimaryInsured> , <GWAddress> , <PhoneNumber> , <EmailAddress> , <GWStatus> , <GWAddressType> , <Gender> , <GWOccupation>, <GWDateofBirth>  in Left Account Details page for PC9 
#	And I verify <GWDistributionSource> , <ContactPreference> , <GWApplicationTakenBy> , <GWPaperlessDelivery> , <ProducerCode> in Right Account Details page for PC9 for QNA Account
#	And I verfy   , <GW_PolicyStatus> , REGISTRY in Policy Term  for PC9
#	And I logout of the PC9 application 
#	And I Kill Web Driver
#	And I access the Guidewire BC on Desktop in IE
#	And I enter bcmanager and bcmanagerpwd on the BC Login page
#	And I select Search from the Tab menu 
#	And search for account with <AccountNumber> and select from search results for QNA 
#	And I select details from left navigation menu 
#    Then I verify <GWPrimaryInsured> , <GWAddress> , " " , <GWPaymentPlan> ,  REGISTRY , REGISTRY , <GWPayment_Instrument> in Account Details page  
#	And I verify <AutoPayPayment_Instrument> in Account Details page for Auto Pay  
#	And I Logout of the Billing Center application
	
#  Examples:
#| ApplicationEnvironment | TargetType | BrowserType | OperatingSystem | Capability | PCUsername | PCPassword | UserName | Password | FirstName | LastName | AddressLine1        | AddressLine2 | City   | State     | ZipCode    | PrimaryNumber | HomePhone    | WorkPhone | MobilePhone | EffectiveDate | DOB        | AccountNumber | GWPrimaryInsured | GWAddress | PhoneNumber | EmailAddress | GWStatus | GWAddressType | Gender | GWOccupation | GWDistributionSource | ContactPreference | GWApplicationTakenBy | GWPaperlessDelivery | ProducerCode | GW_PolicyStatus | GWPaymentPlan           | GWPayment_Instrument | AutoPayPayment_Instrument |
#| PEPORTAL               | Desktop    | Chrome      |                 |            | su         | gw         | su       | gw       | unique    | unique   | 18 Jewelers Park Dr |              | Neenah | Wisconsin | 54956-5902 | homephone     | 2269784366 |           |             | currentdate   | 10/03/1985 | REGISTRY      | REGISTRY         | REGISTRY  | REGISTRY    | UNIQUE       | Active   | Home          |        |              | Phone                | Mail              |                      |                     | DIRD         | In Force        | Two Pay - Semi Annually | Visa ****8291        | Visa ****8291             |

@PEexternal
@PE06
Scenario Outline:NST06_Verify_search_results_for_existing_accounts_created_in_PC 
Given I access the Guidewire <Application2> on <TargetType> in <Browser1>
	And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I get the system date in PC9
	When I select below Action type from Actions menu
	| ActionType  |
	| New Account |
	And I search for personal account in PC9 using <FirstName> and <LastName>
	And I enter following details in PC9 on create account page <DateOfBirth> , <MaritalStatus> , <PrimaryPhone> , <HomePhone> , <WorkPhone> , <MobilePhone> , <OtherPhone> , <FaxPhone> , <PrimaryEmail> , <SecondaryEmail> , <Gender> , <Occupation> , <Investigations>
	And I enter Address details in PC9 on the create account page <CareOf> , <AddressLine1> , <AddressLine2> , <City> , <State> , <ZipCode> , <County> , <Country> , <AddressType> , <Description>, <ProducerCode>
	And I enter official id details  in PC9 on the create account page <SSN> , <IsAccountAJeweler> , <DistributionSource> , <PreferredMethodOfCommunication> , <PaperlessDelivery> , <OkToSurvey> , <MarkettingMaterials> , <RecieveConfirmationEmails> , <JewelerID>
	And I Logout of the Policy Center application

    Given I access the QuoteAndApp app in <Application1> , <TargetType> , <Capability> , <Browser1> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I see the account with <FirstName> and <LastName> in the Search Account Result page
	Then I Kill Web Driver
	
	Examples: 
	| AccountNumber | Application1 | Application2 | TargetType | Browser1 | OperatingSystem | Capability | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone    | WorkPhone    | MobilePhone  | OtherPhone   | FaxPhone     | PrimaryEmail | SecondaryEmail       | Gender | Occupation | Investigations | CareOf    | AddressLine1   | AddressLine2 | City    | State | ZipCode | County    | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PEPORTAL     | PC           | Desktop    | Chrome   |                 |            |su		   | gw       |JPPEFirst  | JPPELast | 05/21/1987  | Single        | Home         | 262-111-2222 | 262-111-1111 | 262-111-3333 | 262-111-4444 | 262-111-5555 |              | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1287 Purple Rd |              | Castalia| Iowa  | 50001   | Winneshiek| United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@PEexternal
@PE07
Scenario Outline:NST07_Verify_Address_Verification_When_Create_Account_with_Not_Specific_address_in_PE 
    Given I access the QuoteAndApp app in <Application1> , <TargetType> , <Capability> , <Browser1> and <OperatingSystem>
    When I login to super partner mode
    | UserName                    | Password  |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PrimaryEmail> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I enter birthday in Create New Account Page
	| BIRTHDAY   |
	| 02/10/1988 |
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I verify the address verification page is puped up
	And I select the first address in address verification page
	And I verify the account is created 
	Then I Kill Web Driver
		
	Examples: 
	| AccountNumber | Application1 | Application2 | TargetType | Browser1 | OperatingSystem | Capability | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PEPORTAL     | PC           | Desktop    | Chrome   |                 |            | su       | gw       | unique    | unique   | 05/21/1987  | Single        | Home         | 9203932997 |            |             | vbadvel@jminsure.com | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf|1 W Winneconne Ave |              | Neenah | Wisconsin |54956-3693    | Winnebago | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |


@PEexternal
@PE08
	Scenario Outline:NST08_Verify_search_results_for_existing_quotes_created_in_PE 
    Given I access the QuoteAndApp app in <Application1> , <TargetType> , <Capability> , <Browser1> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PrimaryEmail> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I enter birthday in Create New Account Page
	| BIRTHDAY   |
	| 02/10/1988 |
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I verify the account is created 
	And I click Quick Estimate button
	And I enter below details in Quick Estimate page 
	| ITEM TYPE | ITEM SUBTYPE | GENDER | ITEM VALUE |
	| Chain     |              | Lady   | 3000       |	
	And I click Estimate button in Quick Estimate page
	And I verify that the Estimated Annual Premium is returned in Quick Estimate page
	And I verify that the QQ print button is enabled
	And I Kill Web Driver
	
	Examples: 
	| AccountNumber | Application1 | Application2 | TargetType | Browser1 | OperatingSystem | Capability | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone  | WorkPhone | MobilePhone | PrimaryEmail         | SecondaryEmail       | Gender | Occupation | Investigations | CareOf     | AddressLine1          | AddressLine2 | City   | State     | ZipCode | County    | Country                  | AddressType | Description     | ProducerOrganization                      | ProducerCode | SSN         | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product          | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PEPORTAL     | PC           | Desktop    | Chrome   |                 |            | su       | gw       | unique    | unique   | 05/21/1987  | Single        | Home         | 9203932997 |           |             | vbadvel@jminsure.com | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf | 1155 W Winneconne Ave |              | Neenah | Wisconsin | 54956   | Winnebago | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@PEexternal
@PE09
	Scenario Outline:NST09_Verify_search_results_for_existing_quotes_created_in_PE 
    Given I access the QuoteAndApp app in <Application1> , <TargetType> , <Capability> , <Browser1> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	When I click on start New Quote button 
	And I Enter <FirstName> and <LastName> in New Quote Search for Existing Account Page
	And I take action on search Account result
	| Action      |
	| newcustomer |
	And I Enter <AddressLine1> , <AddressLine2> , <City>, <State> and <ZipCode> in Create New Account Page
	And I enter other address related details <PrimaryEmail> , <HomePhone> , <WorkPhone> , <MobilePhone> and <PrimaryNumber> in Create New Account Page
	And I select home phone <HomePhone> as the Primary number
	And I enter birthday in Create New Account Page
	| BIRTHDAY   |
	| 02/10/1988 |
	And I select producer code
	| ProducerCode |
	| Z100D30      |
	And I click Create Account in Create New Account Page
	And I click Quick Estimate button
	And I enter below details in Quick Estimate page 
	| ITEM TYPE | ITEM SUBTYPE | GENDER | ITEM VALUE |
	| Chain     |              | Lady   | 3000       |	
	And I click Estimate button in Quick Estimate page
	And I verify that the Estimated Annual Premium is returned in Quick Estimate page
	And I click on Apply button in Quick Estimate page
	And I select No for Damage question for the article in Personal Articles page
	And I click on next in Personal Articles page
	And I click on next in Location Details Page 
	And I select No for Denied Coverage question for the article in Contact Details Page
	And I select No for Convict Of Crime in Contact Details Page
	And I click on next in Contact Details Page 
	And I Update details in Consent Details Page
	| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
	| no         | yes                | yes             | yes           |
	And I click on next in Consent Details Page
	And I click on Continue in Quote Page
	And I send Quot for UW review in Quote Summary UW page 
	And I Kill Web Driver

	Given I access the Guidewire PC on Desktop in IE
	When I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account with <AccountNumber> and select from search results in PC9 
	And I click workorder number of Account detail screen in PC9
	And I waite for batch Cycle to execute for PC
	And I click on RiskAnalysis on Left NavMenu Screen in PC9
	And I Issue the PL Smoke test policy in PC9 
	And I Kill Web Driver

	Given I access the QuoteAndApp app in <Application1> , <TargetType> , <Capability> , <Browser1> and <OperatingSystem>
    When I login to super partner mode
    | UserName           | Password |
    | jmtestpartner+803@gmail.com | Pass1234! |
	And I click on start New Quote button 
	And I search account with first name <FirstName> and last name <LastName>
	And I see the account with <FirstName> and <LastName> in the Search Account Result page
	And I click account number link in the Search Account Result page
	#And I see polices are in the Issued Policies section for this account
	Then I Kill Web Driver
	
	Examples: 
	| AccountNumber | Application1 | Application2 | TargetType | Browser1 | OperatingSystem | Capability | UserName | Password | FirstName | LastName | DateOfBirth | MaritalStatus | PrimaryPhone | HomePhone | WorkPhone | MobilePhone | PrimaryEmail | SecondaryEmail | Gender | Occupation | Investigations | CareOf | AddressLine1 | AddressLine2 | City | State | ZipCode | County | Country | AddressType | Description | ProducerOrganization | ProducerCode | SSN | IsAccountAJeweler | DistributionSource | PreferredMethodOfCommunication | PaperlessDelivery | OkToSurvey | MarkettingMaterials | RecieveConfirmationEmails | JewelerID | PolicyEffDate | Product | ProfessionalAthelete | PreviousLoss | ConvictedOfCrime |
	| REGISTRY      | PEPORTAL     | PC           | Desktop    | Chrome   |                 |            | su       | gw       | unique    | unique   | 05/21/1987  | Single        | Home         | 9203932997 |            |             | vbadvel@jminsure.com | vbadvel@jminsure.com | Male   | Other      | No             | TestCareOf| 1155 W Winneconne Ave |              | Neenah | Wisconsin |54956    | Winnebago | United States of America | Home        | TestDescription | septum docklands sympathy potomac foxings | DIRD         | 123-12-1221 | No                | Other              | Mail                           | No                | yes        | yes                 | yes                       | 1234      | SYSTEMDATE+0  | PersonalArticles | No                   | No           | No               |

@PEccpayment
	Scenario Outline: 01_ProducerEngage_External_STP_SingleItem_CreditCardPayment
	Given I access the Producer Engage application in <ApplicationEnvironment>, <TargetType> and <BrowserType>
	When I login to Producer Engage
		| Email                       | Password  |
		| jmtestpartner+803@gmail.com | Pass1234! |
	And I click Start New Quote in Producer Engage home page
	And I search for an existing account in Producer Engage
		| FirstName | LastName     | City | ZipCode | State | DateOfBirth | EmailAddress |
		| Unique    | CCAutoTestPE |      |         |       |             |              |
	And I continue as a new customer after searching for an existing account in Producer Engage
	And I create a new account in the Create New Account page
		| AddressLine1      | AddressLine2 | City   | ZipCode | State   | DateOfBirth | EmailAddress                   | HomeNumber   | WorkNumber | MobileNumber | PrimaryPhoneType | ProducerCode | EffectiveDate |
		| 902 Derbyshire Dr |              | Dothan | 36303   | Alabama |             | testcc123@apptest.jminsure.com | 205-625-1828 |            |              | Home             | Z100D30      |               |
	And I start a full application in Producer Engage
	And I enter below details in Article Page 
		| Article | Gender | WearableTech | Brand | Style | ArticleSubType | Value | Deductible | Damage | Damagetype | ArticleStored | LocatedWith | PersonFirstName | PersonLastName | PersonDOB | PersonReleationship | PersonDeniedCoverage | PersonDeniedCoverageReason | Location | LocationAddress1 | LocationAddress2 | LocationCity | LocationZip | LocationState | LocationAlarm | LocationSafe |
		| Ring    | Ladies | Yes          |       |       | Engagement     | 8000  | 0          | No     |            |               |             |                 |                |           |                     |                      |                            |          |                  |                  |              |             |               |               |              |
	And I click on next in Article Page
	And I click on next in Location Details Page
	And For single contact I update convicted crime denied Coverage and <DOB>  in Contact Details Page
		| ConvictedofCrime | RecordDate | RecordType | Type | Category | DeniedCoverage | Reason | AdditionalNameInsured |
		| No               |            |            |      |          | No             |        |                       |
	And I click on next in Contact Details Page 
	And I Update details in Consent Details Page
		| LossConsent | PossessionConsent | StatmentConsent | ReportConsent |
		| no         | yes                | yes             | yes           |
	And I click on next in Consent Details Page
	And I click on Continue in Quote Page
	And I submit my application for review on the Policy Information page
	And I obtain the account and submission number from the Quote Summary page
	And I Kill Web Driver

	And I access the Guidewire PC on Desktop in IE
    And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
	And I select Accounts from the Search Tab menu of PC9
	And search for account number and select from search results in PC9
	And I click workorder number of Account detail screen in PC9
	And I waite for batch Cycle to execute for PC
	And I click on RiskAnalysis on Left NavMenu Screen in PC9
	And I special approve all underwriting rules on the Risk Analysis tab in PC9
	And I click the release lock on the Risk Analysis tab in PC9
	And I Kill Web Driver

	And I access the Producer Engage application in <ApplicationEnvironment>, <TargetType> and <BrowserType>
	And I login to Producer Engage
		| Email                       | Password  |
		| jmtestpartner+803@gmail.com | Pass1234! |
	And I click Search in Producer Engage home page
	And I search for an existing account in Producer Engage
		| FirstName | LastName | City | ZipCode | State | DateOfBirth | EmailAddress |
		| Context   | Context  |      |         |       |             |              |
	And I click my quote based on the submission number in Producer Engage
	And I click Continue quote in the Quote Summary page
	And I click on Continue in Quote Page
	And I click Next on Policy Information Page
	And I save my credit card information in the Payment Details page
		| CardType | CVV | ExpirationDate | CardholderName | ZipCode |
		| VISA     | 123 | 11/27          |                | Context |
	And I click Buy Now in the Payment Details page
	Then I verify the policy summary details in the Payment Confirmation page

	Examples:
		| BrowserType | ApplicationEnvironment | TargetType | DOB        |
		| Chrome      | PEPORTAL               | Desktop    | 04/19/1977 |
