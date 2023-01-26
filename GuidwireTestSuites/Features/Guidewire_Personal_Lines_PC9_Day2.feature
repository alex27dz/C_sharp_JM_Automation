Feature: Guidewire_Personal_Lines_PC9_Day2

@regression
Scenario Outline: 11_PL_Renewal_Validation_BD_X70_PRD
	Given I access the Guidewire <Application> on <Target> in <Browser>
	When I enter <UserName> and <Password> on the Login page in PC9
	And I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I Click on transaction link on left navigation bar in PC9
	Then I verify <WorkOrderStatus> in Work Orders page in PC9
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName | Password | PolicyNumber | WorkOrderStatus |
	| PC          | Desktop | IE      | su       | gw       | 24-1072979    | Non-renewing     |

@regression
	Scenario Outline: 12_PL_Renewal_Validation_BD_X70_PRD
	Given I access the Guidewire <Application> on <Target> in <Browser>
	When I enter <UserName> and <Password> on the Login page in PC9
	And I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I Click on transaction link on left navigation bar in PC9
	Then I verify <WorkOrderStatus> in Work Orders page in PC9
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName | Password | PolicyNumber | WorkOrderStatus |
	| PC          | Desktop | IE      | su       | gw       | 24-1072966    | Bound     |


@regression
	Scenario Outline: 13_PL_Renewal_Validation_BD_X70_PRD
	Given I access the Guidewire <Application> on <Target> in <Browser>
	When I enter <UserName> and <Password> on the Login page in PC9
	And I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I Click on transaction link on left navigation bar in PC9
	Then I verify <WorkOrderStatus> in Work Orders page in PC9
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName | Password | PolicyNumber | WorkOrderStatus |
	| PC          | Desktop | IE      | su       | gw       | 24-1073077    | Renewing     |

