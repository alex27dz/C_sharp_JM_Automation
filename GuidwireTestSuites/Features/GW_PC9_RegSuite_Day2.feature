Feature: GW_PC9_RegSuite_Day2

@vm1
@D2Renwals
@D2Renwalspl
@D2Renwalspl1
@regression
Scenario Outline: PL_Renwls_Day2_TS01_BD_X70_PRD
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName            |
	| 08_NB_Single_BD_X70_PRD |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I Click on transaction link on left navigation bar in PC9
	Then I verify <WorkOrderStatus> in Work Orders page in PC9
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName    | Password       | PolicyNumber | WorkOrderStatus |
	| PC          | Desktop | IE      | pluwmanager | pluwmanagerpwd | REGISTRY     | Non-renewed     |

@vm1
@D2Renwals
@D2Renwalspl
@D2Renwalspl2
@regression
Scenario Outline: PL_Renwls_Day2_TS02_BD_X70
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName        |
	| 09_NB_Single_BD_X70 |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I Click on transaction link on left navigation bar in PC9
	Then I verify <WorkOrderStatus> in Work Orders page in PC9
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName    | Password       | PolicyNumber | WorkOrderStatus |
	| PC          | Desktop | IE      | pluwmanager | pluwmanagerpwd | REGISTRY     | Bound           |

@vm1
@D2Renwals
@D2Renwalspl
@D2Renwalspl3
@regression
Scenario Outline: PL_Renwls_Day2_TS03_BD_X60
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName        |
	| 10_NB_Single_BD_X60 |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I Click on transaction link on left navigation bar in PC9
	Then I verify <WorkOrderStatus> in Work Orders page in PC9
	And I Logout of the Policy Center application

	Examples: 
	| Application | Target  | Browser | UserName    | Password       | PolicyNumber | WorkOrderStatus |
	| PC          | Desktop | IE      | pluwmanager | pluwmanagerpwd | REGISTRY     | Renewing        |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl1
@regression
Scenario Outline: CL_Renwls_Day2_TS01_JB_X99
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName               |
	| CL_Renwls_Day1_TS01_JB_X99 |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering       |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Block |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl2
@regression
Scenario Outline: CL_Renwls_Day2_TS02_JB_X75
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName               |
	| CL_Renwls_Day1_TS02_JB_X75 |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering       |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Block |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl3
@regression
Scenario Outline: CL_Renwls_Day2_TS03_JBP_X45_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName                    |
	| CL_Renwls_Day1_TS03_JBP_X45_UMB |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering           |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Block Pak |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl4
@regression
Scenario Outline: CL_Renwls_Day2_TS04_JBP_X29_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName                    |
	| CL_Renwls_Day1_TS04_JBP_X29_UMB |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering           |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Block Pak |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl5
@regression
Scenario Outline: CL_Renwls_Day2_TS05_JBP_X14_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName                    |
	| CL_Renwls_Day1_TS05_JBP_X14_UMB |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering           |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Block Pak |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl6
@regression
Scenario Outline: CL_Renwls_Day2_TS06_BOP_X99_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName                    |
	| CL_Renwls_Day1_TS06_BOP_X99_UMB |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering       |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Businessowners |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl7
@regression
Scenario Outline: CL_Renwls_Day2_TS07_JS_X44
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName               |
	| CL_Renwls_Day1_TS07_JS_X44 |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering          |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Standard |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl8
@regression
Scenario Outline: CL_Renwls_Day2_TS08_JSP_X30_UMB
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName                    |
	| CL_Renwls_Day1_TS08_JSP_X30_UMB |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering              |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Standard Pak |

@vm1
@D2Renwals
@D2Renwalscl
@D2Renwalscl9
@regression
Scenario Outline: CL_Renwls_Day2_TS09_JS_BD_X14
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName                  |
	| CL_Renwls_Day1_TS09_JS_BD_X14 |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering          |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Jewelers Standard |

@vm1
@D2Renwalscl
@D2Renwalscl10
@regression
Scenario Outline: CL_Renwls_Day2_TS10_BOP_X28
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter <UserName> and <Password> on the Login page in PC9
	And I update policy into REGISTRY from below scenario
	| ScenarioName                |
	| CL_Renwls_Day1_TS10_BOP_X28 |
	When I select policies from the Search Tab menu of PC9
	And I search for Policy with <PolicyNumber> and select from search results in PC9
	And I verify <Offering> for CL Policy
	Then I Logout of the Policy Center application

Examples: 
 | Application | Target  | Browser | UserName    | Password       | PolicyNumber | Offering       |
 | PC          | Desktop | IE      | cluwmanager | cluwmanagerpwd | REGISTRY     | Businessowners |


@vm3
@D2bc
@bcach
@bcachplusa01
@regression	
Scenario Outline: ACH_Payment_Reverse_PL_USA_01
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
	| ScenarioName                      |
	| 02_NB_Change_OOS_Delete_Renew_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | CurrentDue    | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |	


@vm3
@D2bc
@bcach
@bcachplusa02
@regression	
Scenario Outline: ACH_Payment_Reverse_PL_USA_02
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
	| ScenarioName                                               |
	| 03_NB_Claim_UpdateReserve_Cancel_RewriteFullterm_Geico_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | Savings | TESTINGSYSTEMCLOCK | REGISTRY       |



@vm2
@D2bc
@bcach
@bcachplcan01
@regression	
Scenario Outline: ACH_Payment_Reverse_PL_CAN_01
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                         |
		| 05_BD_Mult_ScheduleCancel_Claim_Reinstate_Change_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm3
@D2bc
@bcach
@bcachplcan02
@regression	
Scenario Outline: ACH_Payment_Reverse_PL_CAN_02
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                         |
		| 05_BD_Mult_ScheduleCancel_Claim_Reinstate_Change_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | Savings | TESTINGSYSTEMCLOCK | REGISTRY      |
	


@vm3
@D2bc
@bcach
@bcachpljpausa
@regression	
Scenario Outline: ACH_Payment_Reverse_PL_JPA_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                                                                                              |
		| 03_Flat_Cancel_Rewrite_Fullterm_Single_Location_Single_Wearer_Alarm_Local_UWQuestion_Yes_Article_with_Safe_lessthen_10000 |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | Savings | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm1
@D2bc
@bcach
@bcachclbopusa
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_BOP_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                  |
		| BOP_TS01_NB_ProrataCancel_Reinstate_Claim_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | 50            | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm1
@D2bc
@bcach
@bcachcljbusa
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_JB_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                               |
		| JB_TS01_NB_FlatCancel_Reinstate_Change_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | Other         | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm2
@D2bc
@bcach
@bcachcljbpusa
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_JBP_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                     |
		| JBP_TS02_NB_UMB_BD_ProR_Cncl_Reins_TmpChng_Claim |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | Other         | Savings | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm2
@D2bc
@bcach
@bcachcljsusa
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_JS_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                   |
		| JS_TS01_NB_StandardCancel_Reinstate_Change_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm2
@D2bc
@bcach
@bcachcljspusa
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_JSP_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                      |
		| JSP_TS01_NB_FlatCancel_Reinstate_Change_USA_Claim |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | 56            | Savings | TESTINGSYSTEMCLOCK | REGISTRY      |



@vm1
@D2bc
@bcach
@bcachclbopcan
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_BOP_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                        |
		| BOP_TS03_NB_ProrataCancel_Claim_RewriteReminder_CAD |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | 50            | Checking | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm1
@D2bc
@bcach
@bcachcljbcan
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_JB_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                          |
		| JB_TS02_NB_Change_Add_Loc_Del_Loc_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType  | ACHPaymentDate       | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | Other         | Checking | TESTINGSYSTEMCLOCK+3 | REGISTRY      |



@vm2
@D2bc
@bcach
@bcachcljbpcan
@regression	
Scenario Outline: ACH_Payment_Reverse_CL_JBP_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                   |
		| JBP_TS01_NB_Single_1Pay_ON_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using E-check with <AchType> on <ACHPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify ACH payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | AchType | ACHPaymentDate     | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | Other         | Savings | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm6
@D2bc
@bccc
@bcccplusa01
@regression	
Scenario Outline: CC_Payment_Reverse_PL_USA_01	
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                      |
		| 02_NB_Change_OOS_Delete_Renew_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate        | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | CurrentDue    | VISA   | TESTINGSYSTEMCLOCK+1 | REGISTRY      |

@vm6
@D2bc
@bccc
@bcccplusa02
@regression	
Scenario Outline: CC_Payment_Reverse_PL_USA_02
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                               |
		| 03_NB_Claim_UpdateReserve_Cancel_RewriteFullterm_Geico_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate        | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | MASTER | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm6
@D2bc
@bccc
@bcccplusa03
@regression	
Scenario Outline: CC_Payment_Reverse_PL_USA_03
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                 |
		| 06_NB_Cancel_Rewrite_RemainderTerm_Claim_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | CurrentDue    | AMEX   | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm6
@D2bc
@bccc
@bcccplusa04
@regression	
Scenario Outline: CC_Payment_Reverse_PL_USA_04
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                                      |
		| 07_NB_Convicted_Claim_Cancel_CashPayment_ReWriteNewTerm_Claim_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType   | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | DISCOVER | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm5
@D2bc
@bccc
@bcccplcan01
@regression	
Scenario Outline: CC_Payment_Reverse_PL_CAN_01
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                         |
		| 05_BD_Mult_ScheduleCancel_Claim_Reinstate_Change_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | CurrentDue    | VISA   | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm5
@D2bc
@bccc
@bcccplcan02
@regression	
Scenario Outline: CC_Payment_Reverse_PL_CAN_02
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                         |
		| 05_BD_Mult_ScheduleCancel_Claim_Reinstate_Change_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | MASTER | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm5
@D2bc
@bccc
@bcccplcan03
@regression	
Scenario Outline: CC_Payment_Reverse_PL_CAN_03
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                         |
		| 05_BD_Mult_ScheduleCancel_Claim_Reinstate_Change_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome  | bcmanager | bcmanagerpwd | CurrentDue    | AMEX   | TESTINGSYSTEMCLOCK | REGISTRY      |	

@vm6
@D2bc
@bccc
@bcccpljpausa
@regression	
Scenario Outline: CC_Payment_Reverse_PL_JPA_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                                                                                              |
		| 03_Flat_Cancel_Rewrite_Fullterm_Single_Location_Single_Wearer_Alarm_Local_UWQuestion_Yes_Article_with_Safe_lessthen_10000 |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome  | bcmanager | bcmanagerpwd | TotalDue      | AMEX   | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm4
@D2bc
@bccc
@bcccclbopusa
@regression	
Scenario Outline: CC_Payment_Reverse_CL_BOP_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                          |
		| BOP_TS02_NB_PolicyChnage_EPLI_OOS_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | Other         | VISA   | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm4
@D2bc
@bccc
@bccccljbusa
@regression	
Scenario Outline: CC_Payment_Reverse_CL_JB_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                               |
		| JB_TS03_NB_FlatCancel_Rewrite_FullTerm_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | CurrentDue    | AMEX   | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm4
@D2bc
@bccc
@bccccljbpusa
@regression	
Scenario Outline: CC_Payment_Reverse_CL_JBP_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                       |
		| JBP_TS03_NB_UMB_FlatCncl_Rewrte_FullTerm_USA_Claim |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome  | bcmanager | bcmanagerpwd | 50            | VISA   | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm5
@D2bc
@bccc
@bccccljsusa
@regression	
Scenario Outline: CC_Payment_Reverse_CL_JS_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                     |
		| JS_TS02_NB_FlatCancel_Rewrite_FullTerm_USA_Claim |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | Other         | MASTER | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm5
@D2bc
@bccc
@bccccljspusa
@regression	
Scenario Outline: CC_Payment_Reverse_CL_JSP_USA
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName              |
		| JSP_TS02_NB_ST_Change_USA |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType   | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | Other         | DISCOVER | TESTINGSYSTEMCLOCK | REGISTRY      |

@vm3
@D2bc
@bccc
@bcccclbopcan
@regression	
Scenario Outline: CC_Payment_Reverse_CL_BOP_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                                        |
		| BOP_TS03_NB_ProrataCancel_Claim_RewriteReminder_CAD |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate      | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | TotalDue      | AMEX   | TESTINGSYSTEMCLOCK | REGISTRY      |


@vm4
@D2bc
@bccc
@bccccljbcan
@regression	
Scenario Outline: CC_Payment_Reverse_CL_JB_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
		| ScenarioName                          |
		| JB_TS02_NB_Change_Add_Loc_Del_Loc_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate        | AccountNumber |
	| BC          | Desktop | Chrome  | bcmanager | bcmanagerpwd | Other         | MASTER | TESTINGSYSTEMCLOCK+2 | REGISTRY      |

@vm4
@D2bc
@bccc
@bccccljbpcan
@regression	
Scenario Outline: CC_Payment_Reverse_CL_JBP_CAN
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page
	And I update policy into REGISTRY from below scenario
		| ScenarioName                   |
		| JBP_TS01_NB_Single_1Pay_ON_CAN |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select Payments:Payments from left navigation menu for smoketest
	And I perform payment reversals for all transactions
	And I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I fetch country name and total amount due	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new payment:Payment Request from actions menu	
	And I pay premium of <PaymentAmount> using credit card with <CCType> on <CCPaymentDate>	
	And I select payment wallet from left navigation menu	
	And I remove the stored payment methods	
	And I select Payments:Payment History from left navigation menu	
	Then I verify <CCType> payment methods	
	And I select Payments:Payments from left navigation menu	
	And I perform payment reversal	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | PaymentAmount | CCType | CCPaymentDate        | AccountNumber |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | 52            | AMEX   | TESTINGSYSTEMCLOCK+3 | REGISTRY      |

@vm1
@D2bc
@bcwriteoff
@regression	
Scenario Outline: BC_Write_Off	
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
	| ScenarioName            |
	| 08_NB_Single_BD_X70_PRD |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select new transaction:write-off from actions menu	
	And I make a write-off payments of <Write-offAmount> , <Write-offPattern> , <Write-offReason>   in Write-off Wizard page	
	And I select history from left navigation menu	
	Then I verify Write off for <Write-offAmount> for <Write-offReason> , <<Write-offReversalReason> in History Page	
	And I select new transaction:write-offReversal from actions menu	
	And I make a write-off Reversal for <Write-offReversalReason> in Write-off Reversal Wizard page	
	And I select history from left navigation menu	
	And I verify Write off reversal for <Write-offAmount> for <Write-offReason> , <Write-offReversalReason> in History Page	
	And I Logout of the Billing Center application	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | AccountNumber | Write-offAmount | Write-offPattern | Write-offReason  | Write-offReversalReason |
	| BC          | Desktop | IE      | bcmanager | bcmanagerpwd | REGISTRY      | 10.00           | Premium:PL:PL    | Customer Request | Payment Received        |

@vm1
@D2bc
@bctransfer
@regression	
Scenario Outline: BC_Transfer_Funds	
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
	| ScenarioName                    |
	| CL_Renwls_Day1_TS06_BOP_X99_UMB |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select new transaction:Transfer from actions menu	
	And I search for CL_Renwls_Day1_TS07_JS_X44 and update policy into REGISTRY
	And I select <TargetAccount> and input an amount of <TargetAmount>	
	And I select history from left navigation menu	
	Then I verify Account Fund Transfer for  <TargetAccount> and <TargetAmount>	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | TargetAmount | AccountNumber | TargetAccount |
	| BC          | Desktop | IE      | bcmanager | bcmanagerpwd | 5.00         | REGISTRY      | REGISTRY      |
	
@vm1
@D2bc
@bcmove
@regression	
Scenario Outline: BC_MovePayments	
	Given I access the Guidewire <Application> on <Target> in <Browser>	
	And I enter <UserName> and <Password> on the BC Login page	
	And I update policy into REGISTRY from below scenario
	| ScenarioName                    |
	| CL_Renwls_Day1_TS08_JSP_X30_UMB |
	When I select Search from the Tab menu	
	And search for account with <AccountNumber> and select from search results	
	And I select new payment:new direct bill payment from actions menu	
	And I make a direct bill payment of 10	
	And I select Payments:Payments from left navigation menu	
	And I search for CL_Renwls_Day1_TS09_JS_BD_X14 and update policy into REGISTRY
	And I perform move to Account, <MovingAccount>	
	And I select history from left navigation menu	
	Then I verify move payments for <MovingAccount> and 10.00	
	And I Logout of the Billing Center application	
	
	Examples: 
	| Application | Target  | Browser | UserName  | Password     | AccountNumber | MovingAccount |
	| BC          | Desktop | Chrome      | bcmanager | bcmanagerpwd | REGISTRY      | REGISTRY      |