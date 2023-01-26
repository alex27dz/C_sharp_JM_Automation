Feature: AgentPortal_QA


@AP_QAreg
@AP_QA01
Scenario Outline: Scenario01_AgentProfile_ReportValidation
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				And I Get username from MyProfile Page
				And I verify Agent name from MyProfile Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				And I verify user in master Agency 
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				And I search Agent in User and Permission section 
				| Role              |
				| profile Managment |
				And I set access type for Profile Managment
				| Admin | Read | ProducerAdmin |
				| Yes   | Yes  | Yes           | 
				And I search Agent in User and Permission section 
				| Role    |
				| Inquiry |
				And I verify Agent access type for Inquiry
				| Read | FNOL |
				| Yes  | Yes  |
				And I search Agent in User and Permission section 
				| Role    |
				| Reports |
				And I verify Agent access type for Reports
				| LossRun | RenewalStatus | CommissionStatement | AgencyAlmanc | NewBusiness | CLInformcePolicyListing |
				| Yes     | Yes           | Yes                 | Yes          | Yes         | Yes                     |
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| reports          |
				And I verify Reports displayed in Report section
				| Reports                                                                                                         |
				| Agency Almanac;Commission Statements;Loss Runs;Inforce Policy Listing;New Business Report;Renewal Status Report |
			
				
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                   | Password |
                | AP                     | desktop    |            | Chrome      |                 | Regression_AA@jminsure.com | Pass1234 |



@AP_QAreg
@AP_QA02
Scenario Outline: Scenario02_AgentProfile_Validation_RoleAdminRead
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				And I Get username from MyProfile Page
				#And I verify Agent name from MyProfile Page
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption |
				#| Master Agency    |
				#And I verify user in master Agency 
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption      |
				#| My profile |
				#And I select Producer from MyProfile Page
				#| Producer |
				#| B58D         |
				#And I subscribe Producer from MyProfile Page
				#| Producer  |
				#| B58D |
				#And I save Changes in MyProfile Page
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption      |
				#| Users and Permissions |
				#And I click Add user button in User and Permission Page
				#And I add new user details in User and Permission Page
				#| FirstName | LastName | PhoneType | WorkPhone  | CellPhone | Fax | Emial                    | Producer | Subscribe |
				#| New162       | User126     | work      | 9015687866 |           |     | Newuser341@testjminsure.com | B58D     | B58D      |
				#And I search Agent in User and Permission section 
				#| Role              |
				#| profile Managment |
				#And I select Agent from profile managment table in User and Permission Page
				#And I delete Added user in User and Permission Page
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption |
				#| Master Agency    |
				#And I verify Edit Button in Master Agency
				#| AddressEdit | ContactInformationEdit |
				#| Yes         | Yes                    |
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption |
				#| Producers    |
				#And I Select Producer 
				#| Producer |
				#| B02B     |
				#And I verify Edit Button in Producer Information
				#| AddressEdit | ContactInformationEdit |
				#| Yes         | Yes                    |
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption |
				#| My profile       |
				#And I Get username from MyProfile Page
				#And I logoff Agent User
				#When I login with <MasterAgentUserName> and <MasterAgentPassword> in  AgentPortal
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption      |
				#| Users and Permissions |
				#And I search Agent in User and Permission section 
				#| Role              |
				#| profile Managment |
				#And I set access type for Profile Managment
				#| Admin | Read | ProducerAdmin |
				#| Yes   | Yes  | Yes           | 
				#And I select Agent from profile managment table in User and Permission Page
				#
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                    | Password | MasterAgentUserName        | MasterAgentPassword |
                | AP                    | desktop    |            | Chrome      |                 | Regression_AA2@jminsure.com | Vipin123 | Regression_AA@jminsure.com | Pass1234            |


@AP_QAreg
@AP_QA03
Scenario Outline: Scenario03_AgentProfile_Validation_RoleProducerAdmin
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				And I Get username from MyProfile Page
				And I verify Agent name from MyProfile Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				And I search Agent in User and Permission section 
				| Role              |
				| profile Managment |
				And I set access type for Profile Managment
				| Admin | Read | ProducerAdmin |
				| No    | No   | Yes           |
				And I waite for batch Cycle to execute
				And I click on Master Agent Profile Link
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| Home          |
				And I click on Manage my profile option in Agent Portal landing
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Producers    |
				And I Select Producer 
				| Producer |
				| B58D     |
				And I verify Edit Button in Producer Information
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				And I verify Edit Button in Master Agency
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				And I click Add user button in User and Permission Page
				And I add new user details in User and Permission Page
				| FirstName | LastName | PhoneType | WorkPhone  | CellPhone | Fax | Email                    | Producer | Subscribe |
				| New3       | User3     | work      | 9015687866 |           |     | Newuser3@testjminsure.com | B58D     | B58D      |
				And I search Agent in User and Permission section 
				| Role              |
				| profile Managment |
				And I select Agent from profile managment table in User and Permission Page
				And I delete Added user in User and Permission Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				And I Get username from MyProfile Page
				And I logoff Agent User
				When I login with <MasterAgentUserName> and <MasterAgentPassword> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				And I search Agent in User and Permission section 
				| Role              |
				| profile Managment |
				And I set access type for Profile Managment
				| Admin | Read | ProducerAdmin |
				| Yes   | Yes  | Yes           | 
				And I select Agent from profile managment table in User and Permission Page
				
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                    | Password | MasterAgentUserName        | MasterAgentPassword |
                | AP                    | desktop    |            | Chrome      |                 |  Regression_AA2@jminsure.com | Vipin123  | Regression_AA@jminsure.com | Pass1234            |


@AP_QAreg
@AP_QA00
Scenario Outline: AgentProfile_resetuser
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				And I Get username from MyProfile Page
				And I logoff Agent User
				When I login with <MasterAgentUserName> and <MasterAgentPassword> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				And I search Agent in User and Permission section 
				| Role              |
				| profile Managment |
				And I set access type for Profile Managment
				| Admin | Read | ProducerAdmin |
				| Yes   | Yes  | Yes           | 
				And I select Agent from profile managment table in User and Permission Page
  Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                    | Password | MasterAgentUserName        | MasterAgentPassword |
                | AP                    | desktop    |            | Chrome      |                 | Regression_AA2@jminsure.com | Vipin123 | Regression_AA@jminsure.com | Pass1234            |


@AP_QAreg
@AP_QA04
Scenario Outline: Scenario04_AgentProfile_Validation_RoleRead
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				#And I Get username from MyProfile Page
				#And I verify Agent name from MyProfile Page
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption      |
				#| Users and Permissions |
				#And I search Agent in User and Permission section 
				#| Role              |
				#| profile Managment |
				#And I set access type for Profile Managment
				#| Admin | Read | ProducerAdmin |
				#| No    | Yes   | No           |
				#And I waite for batch Cycle to execute
				#And I click on Master Agent Profile Link
				#And I click on Top Navigation option in Agent Portal 
				#| NavigationOption |
				#| Home          |
				#And I click on Manage my profile option in Agent Portal landing
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption |
				#| Producers    |
				#And I Select Producer 
				#| Producer |
				#| B58D     |
				#And I verify Edit Button in Producer Information
				#| AddressEdit | ContactInformationEdit |
				#| No         | No                    |
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption |
				#| Master Agency    |
				#And I verify Edit Button in Master Agency
				#| AddressEdit | ContactInformationEdit |
				#| No         | No                    |
				#And I verify if Users and Permissions tab is displayed 
				#| DisplayedFlag |
				#| No            |
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption |
				#| My profile       |
				#And I Get username from MyProfile Page
				#And I logoff Agent User
				#When I login with <MasterAgentUserName> and <MasterAgentPassword> in  AgentPortal
				#And I Manage left Navigation option in Agent Portal 
				#| NavigationOption      |
				#| Users and Permissions |
				#And I search Agent in User and Permission section 
				#| Role              |
				#| profile Managment |
				#And I set access type for Profile Managment
				#| Admin | Read | ProducerAdmin |
				#| Yes   | Yes  | Yes           | 
				#And I select Agent from profile managment table in User and Permission Page
				#
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                    | Password | MasterAgentUserName        | MasterAgentPassword |
                | AP                    | desktop    |            | Chrome      |                 | Regression_AA2@jminsure.com | Vipin123 | Regression_AA@jminsure.com | Pass1234            |



@AP_QAreg
@AP_QA05
Scenario Outline: Scenario05_AgentProfile_PersonalLine_Validation_RoleAdmin
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				And I Get username from MyProfile Page
				And I verify Agent name from MyProfile Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				And I verify user in master Agency 
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| My profile |
				And I select Producer from MyProfile Page
				| Producer |
				| Z100D00;Z100D129;Z100D163         |
				And I subscribe Producer from MyProfile Page
				| Producer  |
				| Z100D129;Z100D163  |
				And I save Changes in MyProfile Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				#And I waite for batch Cycle to execute
				#And I waite for batch Cycle to execute
				#And I waite for batch Cycle to execute
				And I click Add user button in User and Permission Page
				And I add new user details in User and Permission Page
				| FirstName | LastName | PhoneType | WorkPhone  | CellPhone | Fax | Email                    | Producer | Subscribe |
				| New5       | User5     | work      | 9015687866 |           |     | unique| B58D     | B58D      |
				And I search Agent in User and Permission section 
				| Role              |
				| profile managment |
				And I select Agent from profile managment table in User and Permission Page
				And I delete Added user in User and Permission Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				And I verify Edit Button in Master Agency
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Producers    |
				And I Select Producer 
				| Producer |
				| B58D     |
				And I verify Edit Button in Producer Information
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
				
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                    | Password | 
                | AP                     | desktop    |            | Chrome      |                 | Regression_AA2@jminsure.com | Vipin123 | 


Scenario Outline: Scenario06_AgentProfile_PersonalLine_Validation_RoleProducerAdmin
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| My profile       |
				And I Get username from MyProfile Page
				And I verify Agent name from MyProfile Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				And I verify user in master Agency 
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| My profile |
				And I select Producer from MyProfile Page
				| Producer |
				| Z100D00;Z100D129;Z100D163         |
				And I subscribe Producer from MyProfile Page
				| Producer  |
				| Z100D129;Z100D163  |
				And I save Changes in MyProfile Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				#And I waite for batch Cycle to execute
				#And I waite for batch Cycle to execute
				#And I waite for batch Cycle to execute
				And I click Add user button in User and Permission Page
				And I add new user details in User and Permission Page
				| FirstName | LastName | PhoneType | WorkPhone  | CellPhone | Fax | Emial                    | Producer | Subscribe |
				| New1       | User1     | work      | 9015687866 |           |     | unique | Z100D00     | Z100D00      |
				And I search Agent in User and Permission section 
				| Role              |
				| personal line profile managment |
				And I select Agent from profile managment table in User and Permission Page
				And I delete Added user in User and Permission Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				And I verify Edit Button in Master Agency
				| AddressEdit | ContactInformationEdit |
				| No         | No                    |
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Producers    |
				And I Select Producer 
				| Producer |
				| Z100D00     |
				And I verify Edit Button in Producer Information
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
				
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                    | Password | 
                | AP                     | desktop    |            | Chrome      |                 | Regression_QnA2@jminsure.com | Test1234 | 





		#for Edit Contact info
			#	| NavigationOption |
			#	| Master Agency    |
			#	And I click Edit button in MasterAgency
			#	| EditType |
			#	| ContactInfo |
			#	And I Update Contact information in Edit Contact information screen
			#	| PhoneType | WorkPhone | CellPhone    | Fax          | Emial                    |
			#	| Work      |           | 654-826-5637 | 023-744-5448 | skkftn@test-jminsure.com |
			#	And I save Edit contact information changes
		
		#for Edit Address
				#| NavigationOption |
				#| Master Agency    |
				#And I click Edit button in MasterAgency
				#| EditType |
				#| Address |
				#And I Update Mailing address in Edit Address screen
				#| Address1     | Address2 | City | State | Zip | County | Country |
				#| 112 N 2Nd St |          |      |       |     |        |         |
				#And I Update Primary address in Edit Address screen
				#| Address1           | Address2 | City | State | Zip | County | Country | Isprimary | AddressType |
				#| 130 W Franklin Ave |          |      |       |     |        |         |           |home             |
				#And I save Edit address changes


				
