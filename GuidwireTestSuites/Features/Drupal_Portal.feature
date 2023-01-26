Feature: Drupal_Portal
	

@mytag
@Drupal_Regression
Scenario Outline: LayoutBuilderBug
Given I access the Digital Application <applicationType> on <target> in <browser>
And I enter <username> and <password> on the Drupal Admin Login Page
When I click on menu option in Drupal Admin Landing Page
| MenuOption |
| contents   |
And I click on options in Add Content Page
| Options        |
| Marketing page |
And I insert <PrimaryTitle> into Tile in Create Marketing Page
And I Verify Title is created in Drupal Admin Landing Page
And I click on tab option in Drupal Admin Landing Page
| TabOption |
| Layout    |
And I Verify Layout text header in Drupal Admin Landing Page
And I change State in Drupal Admin Landing Page
| State |
|Published       |  
And I take action on markating page content in  Drupal Admin Landing Page
| Action    |
| Add Block |
And I create a custome block type in  Drupal Admin Landing Page
| BlockType |
| feature   |
And I Update <OriginalTitle> , <OriginalHeadline> and <OriginalText> details for Configure Block in  Drupal Admin Landing Page and Click Save button
And I verify <OriginalTitle> , <OriginalHeadline> and <OriginalText> updates from Configure Block in  Drupal Admin Landing Page
And I click on Save Layout button in Drupal Admin Landing Page
And I verify sucess message in  Layout Page
And I verify <OriginalTitle> , <OriginalHeadline> and <OriginalText> from Configure Block in Layout Page
And I click on tab option in Drupal Admin Landing Page
| TabOption |
| Layout    |
And I Verify Layout text header in Drupal Admin Landing Page
And I change State in Drupal Admin Landing Page
| State |
|Draft       |  
And I click on edit pencil button for Layout builder in Drupal Admin Landing Page 
And I Update <DraftTitle> , <DraftHeadline> and <DraftText> for Configure Block in Drupal Admin Landing Page and click on Update button
And I verify <DraftTitle> , <DraftHeadline> and <DraftText> updates from Configure Block in  Drupal Admin Landing Page
And I click on Save Layout button in Drupal Admin Landing Page
And I verify sucess message in  Layout Page
And I click on tab option in Drupal Admin Landing Page
| TabOption |
| View    |
And I verify <OriginalTitle> , <OriginalHeadline> and <OriginalText> updates from Configure Block in View Page
And I click on tab option in Drupal Admin Landing Page
| TabOption |
| Layout    |
And I Verify Layout text header in Drupal Admin Landing Page
And I verify <DraftTitle> , <DraftHeadline> and <DraftText> from Configure Block in Layout Page
And I click on tool bar option in Layout Page
| Option |
| Manage |
And I click on menu option in Drupal Admin Landing Page
| MenuOption |
| managecontents   |
And I Delete <PrimaryTitle> from Content Page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | username     | password      | OriginalTitle                 | OriginalHeadline                 | OriginalText                 | DraftTitle                          | DraftHeadline                          | DraftText                          | PrimaryTitle            |
	| HomePageLinks | DRUPALAPP       | Desktop | Chrome  |            | ITAutomation | #$afK8462e0oA | Layout Builder Bug Test Title | Layout Builder Bug Test Headline | Layout Builder Bug Test Text | Layout Builder Bug Test Title Draft | Layout Builder Bug Test Headline Draft | Layout Builder Bug Test Text Draft | Layout Builder Bug Test |
	
