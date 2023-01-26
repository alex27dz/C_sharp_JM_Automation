Feature: QuickBillPay_Reg

@qbp
@qbp01
Scenario Outline: TS01_PastDue_ActivePolicy
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I run sql query and update account and policy details for below scenario
	| ScenarioName              |
	| TS01_PastDue_ActivePolicy |
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I verify below details on Policy details page
	| FieldName     | Value                  |
	| TotalPastDue  | NotNull                |
	| PaymentStatus | Past Due:Good Standing |
	And I save below details in Registry from Policy details page
	| RegDetails |
	| ACC_NAME   |
	| EMAIL      |
	| FNAME      |
	| LNAME      |
	| PRODUCT    |
	| ZIPCODE    |
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#QuickBillPay - Verifying email id with Account Number and ZipCode
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter below details on Quick Bill Pay page and verify for Account Number
	| FieldName          | Value    |
	| PRODUCT            | REGISTRY |
	| Email              | REGISTRY |
	| LastOrBusinessName | REGISTRY |
	| ZipCode            | REGISTRY |
	And I Kill Web Driver

	#QuickBillPay - Making Payment
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter below details on Quick Bill Pay page
	| FieldName          | Value    |
	| PRODUCT            | REGISTRY |
	| ACCOUNT_NUMBER     | REGISTRY |
	| LastOrBusinessName | REGISTRY |
	| ZipCode            | REGISTRY |
	And I select below Payment Amount
	| Option        |
	| Outstanding   |
	And I enter <CCorACH> Payment Info and click on Continue button
	And I Kill Web Driver

	#Billing Center - Verifying Payment Method and Payment Amount
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results
	And I verify <CCorACH> and PaymentAmount on Payments Page
	And I select Payments:Payment History from left navigation menu
	Then I verify <CCorACH> payment methods
	And I Logout of the Billing Center application
	And I Kill Web Driver


Examples: 
	| Application | Target  | Browser | CCorACH  |
	| QBP         | desktop | Chrome  | Checking |

@qbp
@qbp02
Scenario Outline: TS02_Past_CurrentDue_ActivePolicy
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I run sql query and update account and policy details for below scenario
	| ScenarioName                      |
	| TS02_Past_CurrentDue_ActivePolicy |
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I verify below details on Policy details page
	| FieldName     | Value                  |
	| TotalPastDue  | NotNull                |
	| PaymentStatus | Past Due:Good Standing |
	And I save below details in Registry from Policy details page
	| RegDetails |
	| ACC_NAME   |
	| EMAIL      |
	| FNAME      |
	| LNAME      |
	| PRODUCT    |
	| ZIPCODE    |
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#QuickBillPay - Making Payment
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter below details on Quick Bill Pay page
	| FieldName          | Value    |
	| PRODUCT            | REGISTRY |
	| ACCOUNT_NUMBER     | REGISTRY |
	| LastOrBusinessName | REGISTRY |
	| ZipCode            | REGISTRY |
	And I select below Payment Amount
	| Option        |
	| AmountPastDue |
	And I enter <CCorACH> Payment Info and click on Continue button
	And I Kill Web Driver

	#Billing Center - Verifying Payment Method and Payment Amount
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results
	And I verify <CCorACH> and PaymentAmount on Payments Page
	And I select Payments:Payment History from left navigation menu
	Then I verify <CCorACH> payment methods
	And I Logout of the Billing Center application
	And I Kill Web Driver

Examples: 
	| Application | Target  | Browser | CCorACH  |
	| QBP         | desktop | Chrome  | Savings  |
	

@qbp
@qbp03
Scenario Outline: TS03_Current_FutureDue_ActivePolicy
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I run sql query and update account and policy details for below scenario
	| ScenarioName                        |
	| TS03_Current_FutureDue_ActivePolicy |
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I verify below details on Policy details page
	| FieldName     | Value         |
	| PaymentStatus | Good Standing |
	And I save below details in Registry from Policy details page
	| RegDetails |
	| ACC_NAME   |
	| EMAIL      |
	| FNAME      |
	| LNAME      |
	| PRODUCT    |
	| ZIPCODE    |
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#QuickBillPay - Making Payment
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter below details on Quick Bill Pay page
	| FieldName          | Value    |
	| PRODUCT            | REGISTRY |
	| ACCOUNT_NUMBER     | REGISTRY |
	| LastOrBusinessName | REGISTRY |
	| ZipCode            | REGISTRY |
	And I select below Payment Amount
	| Option |
	| Yearly |
	And I enter <CCorACH> Payment Info and click on Continue button
	And I Kill Web Driver

	#Billing Center - Verifying Payment Method and Payment Amount
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results
	And I verify <CCorACH> and PaymentAmount on Payments Page
	And I select Payments:Payment History from left navigation menu
	Then I verify <CCorACH> payment methods
	And I Logout of the Billing Center application
	And I Kill Web Driver

Examples: 
	| Application | Target  | Browser | CCorACH  |
	| QBP         | desktop | Chrome  | Visa     |


@qbp
@qbp04
Scenario Outline: TS04_PlcyCancel_StillActivePolicy
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I run sql query and update account and policy details for below scenario
	| ScenarioName              |
	| TS01_PastDue_ActivePolicy |
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I verify below details on Policy details page
	| FieldName     | Value    |
	| TotalPastDue  | NotNull  |
	| PaymentStatus | Past Due |
	And I save below details in Registry from Policy details page
	| RegDetails |
	| ACC_NAME   |
	| EMAIL      |
	| FNAME      |
	| LNAME      |
	| PRODUCT    |
	| ZIPCODE    |
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#QuickBillPay - Making Payment
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter below details on Quick Bill Pay page
	| FieldName          | Value    |
	| PRODUCT            | REGISTRY |
	| ACCOUNT_NUMBER     | REGISTRY |
	| LastOrBusinessName | REGISTRY |
	| ZipCode            | REGISTRY |
	And I select below Payment Amount
	| Option        |
	| Outstanding   |
	And I enter <CCorACH> Payment Info and click on Continue button
	And I Kill Web Driver


Examples: 
	| Application | Target  | Browser | CCorACH  |
	| QBP         | desktop | Chrome  | Checking |


@qbp
@qbp05
Scenario Outline: TS05_ActiveDeliq_PolicyNotCancelled
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I run sql query and update account and policy details for below scenario
	| ScenarioName                        |
	| TS05_ActiveDeliq_PolicyNotCancelled |
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I verify below details on Policy details page
	| FieldName     | Value                  |
	| TotalPastDue  | NotNull                |
	| PaymentStatus | Past Due:Good Standing |
	And I save below details in Registry from Policy details page
	| RegDetails |
	| ACC_NAME   |
	| EMAIL      |
	| FNAME      |
	| LNAME      |
	| PRODUCT    |
	| ZIPCODE    |
	And I Logout of the Billing Center application
	And I Kill Web Driver

	#QuickBillPay - Making Payment
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter below details on Quick Bill Pay page
	| FieldName          | Value    |
	| PRODUCT            | REGISTRY |
	| ACCOUNT_NUMBER     | REGISTRY |
	| LastOrBusinessName | REGISTRY |
	| ZipCode            | REGISTRY |
	And I select below Payment Amount
	| Option        |
	| Outstanding   |
	And I enter <CCorACH> Payment Info and click on Continue button
	And I Kill Web Driver

	#Billing Center - Verifying Payment Method and Payment Amount
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results
	And I verify <CCorACH> and PaymentAmount on Payments Page
	And I select Payments:Payment History from left navigation menu
	Then I verify <CCorACH> payment methods
	And I Logout of the Billing Center application
	And I Kill Web Driver


Examples: 
	| Application | Target  | Browser | CCorACH |
	| QBP         | desktop | Chrome  | Master  |


@qbp
@qbp06
Scenario Outline: TS06_ReinstatedByPC
	Given I access the Guidewire BC on Desktop in IE
	And I enter bcmanager and bcmanagerpwd on the BC Login page	
	And I run sql query and update account and policy details for below scenario
	| ScenarioName        |
	| TS06_ReinstatedByPC |
	When I select Search from the Tab menu	
	And search for account with REGISTRY and select from search results	
	And I verify below details on Policy details page
	| FieldName     | Value                  |
	| PaymentStatus | Past Due:Good Standing |
	And I save below details in Registry from Policy details page
	| RegDetails |
	| ACC_NAME   |
	| EMAIL      |
	| FNAME      |
	| LNAME      |
	| PRODUCT    |
	| ZIPCODE    |
	And I Logout of the Billing Center application
	And I Kill Web Driver

	
	#QuickBillPay - Making Payment
	Given I access the Guidewire <Application> on <Target> in <Browser>
	And I enter below details on Quick Bill Pay page
	| FieldName          | Value    |
	| PRODUCT            | REGISTRY |
	| ACCOUNT_NUMBER     | REGISTRY |
	| LastOrBusinessName | REGISTRY |
	| ZipCode            | REGISTRY |
	And I verify if PastDue is listed
	And I Kill Web Driver


Examples: 
	| Application | Target  | Browser |
	| QBP         | desktop | Chrome  |
