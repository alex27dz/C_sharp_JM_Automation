Feature: AgentInquiry
	

	@Regression
	@AIRegression
	@AI1
Scenario Outline: Scenario01_AgentInquiry_PolicyCenterValidation
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| policy          |
				And I click on Advanced Search option in Agent Portal 
				And I search with below details 
				| Searchby | ProducerCode                     | Offering      | PolicyStatus |
				| Policy   | exited kindled payers (B50D) | Jewelers Block | In Force     |
				And I selct First account in Account search result table of AgentPortal
				And I fetch Accountname and PrimaryAddress from Accounts page of Agent inquiry
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| policy          |
				And I click on Advanced Search option in Agent Portal 
				And I search with below details 
				| Searchby | ProducerCode                     | Offering      | PolicyStatus |
				| Policy   | exited kindled payers (B50D) | Jewelers Block | In Force     |
				And I selct First policy in Account search result table of AgentPortal
				And I fetch EffectiveDate , ExpirationDate, ProducerCode , ProducerName 
				And I Kill Web Driver
				And I access the Guidewire PC on Desktop in IE
               And I enter pluwmanager and pluwmanagerpwd on the PC9 Login page
				And I select Policies from the Search Tab menu of PC9
   			    And search for account with REGISTRY and select from search results in PC9 
				Then I verify REGISTRY , REGISTRY ,  ,  ,  ,  ,  , ,   in Left Account Details page for PC9 
				And I verify  ,  ,  ,  , REGISTRY in Right Account Details page for PC9 for QNA Account
				And I verfy  REGISTRY ,  ,  in Policy Term  for PC9
                And I logout of the PC9 application 
				


                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                   | Password | GW_UserName | GW_Password |
                | AI                     | desktop    |            | Chrome      |                 | robertgarcia@apptest.jminsure.com | Pass1234! | su          | gw          |




					@Regression
					@AIRegression
					@AI2
Scenario Outline: Scenario02_AgentInquiry_ClaimCenterValidation
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| policy          |
				And I click on Advanced Search option in Agent Portal 
				And I search with below details 
				| Searchby | ProducerCode                     | Offering       | PolicyStatus |
				| Policy   | exited kindled payers (B50D) | Jewelers Block | In Force     |
				And I selct fourth policy with avalable claim table of AgentPortal
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| claims          |
				And I enetr REGISTRY in Policy number text  in Search a Claim section
				And I get latest claim number from claim search
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| claims          |
				And I enetr REGISTRY in Policy number text  in Submit a Claim section
				And I selct First policy in Claim search result table of AgentPortal
				And I set First Notice of Loss details for Agent portal
				| Date    | LossDescription | LossCause |
				| SYSTEM | LossDesc        | Fire      |
				And I submit First Notice of Loss details for Agent portal
				And I verify if first notice of loss is recived 
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| claims          |
				And I enetr REGISTRY in Policy number text  in Search a Claim section
				And I get verify new claim number is added in claim search
							#Then I Verify If Claim Number is referred to correct policy number  REGISTRY  in Cc9

				Examples:
               | GWUserName | GWPassword  | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                   | Password | GW_UserName | GW_Password |
			   | su       | gw    | AI                     | desktop    |            | Chrome      |                 | robertgarcia@apptest.jminsure.com | Pass1234! | su          | gw          |




			   @Regression
			   @AIRegression
			   @AI3
Scenario Outline: Scenario03_AgentInquiry_BillingCenterValidation
                Given I access the AgentAutomation app in <ApplicationEnvironment> , <TargetType> , <Capability> , <BrowserType> and <OperatingSystem>
				When I login with <UserName> and <Password> in  AgentPortal
				And I click on Top Navigation option in Agent Portal 
				| NavigationOption |
				| billing          |
				And I click on Advanced Search option in Agent Portal 
				And I search with below details in billing section 
				| ProducerCode                     | PolicyStatus |
				| uppers rift caracol nocks (B54D) | In Force     |
				And I selct First policy in Billing search result table of AgentPortal
				And I click on section of Policy Summary Billing
				| section             |
				| Billing Information |
				And I fetch Accountnumber, address, paymentplan and autopay from billing page
				And I Kill Web Driver
				And I access the Guidewire BC on Desktop in IE
                And I enter bcmanager and bcmanagerpwd on the BC Login page
                And I select Search from the Tab menu 
                And search for account with REGISTRY and select from search results for QNA 
                And I select details from left navigation menu 
				Then I verify REGISTRY , REGISTRY in Account Details page for Agent Inquiry 
                And I Logout of the Billing Center application

				
                Examples:
                | ApplicationEnvironment | TargetType | Capability | BrowserType | OperatingSystem | UserName                   | Password | GW_UserName | GW_Password |
                | AI                     | desktop    |            | Chrome      |                 | alanachair@apptest.jminsure.com | Pass1234! | su          | gw          |

