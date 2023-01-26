Feature: JMPG_Smoke



Scenario Outline: 01_Login_Page_Content_Validation
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I access on the login page of JMPG then verify login page
Then I close the browser after the content of page verified
                
Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      | 


Scenario Outline: 02_Dashboard_Page_Content_Validation
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I verify JMPG Dashboard validation information
Then I close the browser after the content of page verified
				
Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      | 

Scenario Outline: 03_My_Account_Page_Content_Validation
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click profile and go to My Account Page
Then I verify JMPG My Account validation information
Then I click Go Back Button on My Account Page to back to Dashboard Page
Then I close the browser after the content of page verified	
			
Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      | 

Scenario Outline: 04_Get_A_Quote_Content_Validation
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click profile and go to Get a Quote Page
And I verify JMPG Get A Quote Page validation information
Then I click Go To JM Partner Gateway Link on Get a Quote Page Menu Bar
Then I close the browser after the content of page verified	

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 05_Recently_Submitted_Validation
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click Recently Submitted on the Left Nav
And I verify JMPG Recently Submitted validation information
Then I close the browser after the content of page verified	

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 06_Pending_Cancellation_Validation
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click Pending Cancellation on the Left Nav
And I verify JMPG Pending Cancellation validation information
Then I close the browser after the content of page verified	

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 07_JM_Support_Validation
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click JM Support on the Left Nav
And I verify JM Support validation information
Then I close the browser after the content of page verified	

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 08_JM_Lost_Business
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click Lost Business on the Left Nav
And I verify Lost Business validation information
Then I close the browser after the content of page verified	

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |


Scenario Outline: 09_Search
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I search account number
| AccountNumber |
| 3000878512    |
And I verify Policy Search Result validation information
Then I close the browser after the content of page verified	

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 10_Policy_Details
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I search account number
| AccountNumber |
| 3000878512    |
And I click search result to check policy details
And I verify Policy Details validation information
Then I close the browser after the content of page verified

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 11_See_All_Transactions
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I search account number
| AccountNumber |
| 3000878512    |
And I click search result to check policy details
And I click See All Transaction History
And I verify Transactions Page validation information
Then I close the browser after the content of page verified

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 12_See_All_Documents
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I search account number
| AccountNumber |
| 3000878512    |
And I click search result to check policy details
And I click See All Documents History
And I verify Documents Page validation information


Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 13_See_Billing_History
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I search account number
| AccountNumber |
| 3000878512    |
And I click search result to check policy details
And I click See Billing History
And I verify Billing History Page validation information
Then I close the browser after the content of page verified

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 14_Saved_Quotes
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click Saved Quotes on the Left Nav
And I verify JMPG Saved Quotes validation information
Then I close the browser after the content of page verified

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 15_Agent_Knowledge_Base
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
And I click Agent Knowledge Base on the Left Nav
And I verify JMPG Agent Knowledge Base validation information

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |

Scenario Outline: 16_Logout_Then_Verify_Page
Given I access the JMPG app in <ApplicationEnvironment> , <TargetType> and <BrowserType>
When I login to JMPG app
| UserName           | Password |
| jmtestpartner+803@gmail.com | Pass1234! |
Then I logout the JMPG Application and verify the login page
Then I close the browser after the content of page verified 

Examples:
| ApplicationEnvironment | TargetType | BrowserType | 
| JMPG                   | desktop    | Chrome      |