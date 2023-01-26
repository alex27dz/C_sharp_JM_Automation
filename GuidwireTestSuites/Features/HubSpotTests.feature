Feature: HubSpotTests
	Tests to check the Records count for the number of changed records produced from the
	_HubSpot_Contact_Export and j_Hubspot_Extract batches to ensure it does not exceed 25,000

@hubspot
Scenario Outline: VerifyHubspotRecordCountStage
Given I access the hubspot related tables in <Environment>
When I get the record counts of changed records produced from batches
Then I verify the max record count is <RecordCount>

Examples: 
	| Environment | RecordCount |
	| stage       | 25000       |
	| qa4         | 25000       |

	
