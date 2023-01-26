
Feature: AgentPortal

@APreg
@AP00
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

@APreg
@AP01
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
                | AP                     | Desktop    |            | Chrome      |                 | Regression_AA@jminsure.com | Pass1234 |

@APreg
@AP02
Scenario Outline: Scenario02_AgentProfile_Validation_RoleAdminRead
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
				| V01D;B54D;B58D         |
				And I subscribe Producer from MyProfile Page
				| Producer  |
				| V01D;B54D |
				And I save Changes in MyProfile Page
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				And I click Add user button in User and Permission Page
				And I add new user details in User and Permission Page
				| FirstName | LastName | PhoneType | WorkPhone  | CellPhone | Fax | Email                    | Producer | Subscribe |
				| New162       | User126     | work      | 9015687866 |           |     |unique | B50D     | B50D      |
				And I search Agent in User and Permission section 
				| Role              |
				| profile Managment |
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
				| B50D     |
				And I verify Edit Button in Producer Information
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
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

@APreg
@AP03
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
				| B50D     |
				And I verify Edit Button in Producer Information
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				And I verify Edit Button in Master Agency
				| AddressEdit | ContactInformationEdit |
				| No         | No                    |
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption      |
				| Users and Permissions |
				And I click Add user button in User and Permission Page
				And I add new user details in User and Permission Page
				| FirstName | LastName | PhoneType | WorkPhone  | CellPhone | Fax | Email                    | Producer | Subscribe |
				| New3       | User3     | work      | 9015687866 |           |     | unique | B50D     | B50D      |
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
                | AP                    | desktop    |            | Chrome      |                 | Regression_AA2@jminsure.com | Vipin123 | Regression_AA@jminsure.com | Pass1234            |

@APreg
@AP04
Scenario Outline: Scenario04_AgentProfile_Validation_RoleRead
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
				# And I waite for batch Cycle to execute
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
				| B50D     |
				# And I verify Edit Button in Producer Information
				# | AddressEdit | ContactInformationEdit |
				# | No         | No                    |
				And I Manage left Navigation option in Agent Portal 
				| NavigationOption |
				| Master Agency    |
				# And I verify Edit Button in Master Agency
				# | AddressEdit | ContactInformationEdit |
				# | No         | No                    |
				# And I verify if Users and Permissions tab is displayed 
				# | DisplayedFlag |
				# | No            |
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

@APreg
@AP05
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
				| New5       | User5     | work      | 9015687866 |           |     | unique| B02D     | B02D      |
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
				| B02D     |
				And I verify Edit Button in Producer Information
				| AddressEdit | ContactInformationEdit |
				| Yes         | Yes                    |
				
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                    | Password | 
                | AP                     | desktop    |            | Chrome      |                 | Regression_AA2@jminsure.com | Vipin123 | 

		
