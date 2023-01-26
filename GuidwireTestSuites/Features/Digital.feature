Feature: Digital

## Header / navbar

@Drupal_Regression
Scenario Outline: 01_HomePagePersonalPersonalInsuranceVerification
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Personal Insureance page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link                        |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | personal:personal insurance |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | personal:personal insurance |


@Drupal_Regression
Scenario Outline: 02_HomePagePersonalGetAQuote
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Quote page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | personal:get a quote |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | personal:get a quote |


@Drupal_Regression
Scenario Outline: 03_HomePagePersonalMakeaPayment:PayMyBill
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Quick Bill Pay page are displayed
And I navigate back to the home page

Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link                   |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | makeapayment:paymybill |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | makeapayment:paymybill |


@Drupal_Regression
Scenario Outline: 04_HomePageoPersonalClaims
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the claims page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #       | applicationType | target  | browser | Capability | link              |
	| HomePageToClaims | DRUPAL          | Desktop | Chrome  | IPhoneX    | Personal:Claims |
	| HomePageToClaims | DRUPAL          | Desktop | IE      | IPhoneX    | Personal:Claims |


@Drupal_Regression
Scenario Outline: 05_HomePagePersonaloManageMyPolicy
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the ManageMyPolicy page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | personal:manage my policy |
	| HomePageLinks | DRUPAL          | Desktop | IE  | IPhoneX        | personal:manage my policy |


@Drupal_Regression
Scenario Outline: 06_HomePagePersonal:Blog
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Personal Blog page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | personal:blog |
	| HomePageLinks | DRUPAL          | Desktop | IE  | IPhoneX        | personal:blog |


@Drupal_Regression
Scenario Outline: 07_HomePageBusiness:BusinessInsurance
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
# Then I Verify all the elements in the BusinessInsurance page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:business insurance |
	| HomePageLinks | DRUPAL          | Desktop | IE  | IPhoneX        | business:business insurance |


@Drupal_Regression
Scenario Outline: 08_HomePageBusiness:claims
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
#Then I Verify all the elements in the Pawn Brokers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:claims |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | business:claims |

@Drupal_Regression
Scenario Outline: 09_HomePageBusiness:paymybill
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
#Then I Verify all the elements in the Pawn Brokers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:pay my bill |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | business:pay my bill |

@Drupal_Regression
Scenario Outline: 10_HomePageBusiness:zingplatform
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
#Then I Verify all the elements in the Pawn Brokers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:zing platform |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | business:zing platform |


	
@Drupal_Regression
Scenario Outline: 11_HomePageBusiness:shipping solution
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Shipping solution page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:shipping solution |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | business:shipping solution |

@Drupal_Regression
Scenario Outline: 12_HomePageBusiness:jmcare
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
#Then I Verify all the elements in the Pawn Brokers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:jm care |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | business:jm care |

@Drupal_Regression
Scenario Outline: 13_HomePageBusiness:jewelerprograms
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Jeweler Programs page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:jeweler programs |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | business:jeweler programs |


	
@Drupal_Regression
Scenario Outline: 14_HomePageBusiness:PawnBrokers
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Pawn Brokers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | business:pawnbrokers |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | business:pawnbrokers |



@Drupal_Regression
Scenario Outline: 15_HomePageAnswers:Faq
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
#Then I Verify all the elements in the Pawn Brokers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | answers:faq |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | answers:faq |

@Drupal_Regression
Scenario Outline: 16_HomePageAnswers:Jewelryinsurance101
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
# And I select the <link> on homepage
# Then I Verify all the elements in the Pawn Brokers page are displayed
# And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | answers:jewelry insurance 101 |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | answers:jewelry insurance 101 |


@Drupal_Regression
Scenario Outline: 17_HomePageAboutUs
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the about us page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #       | applicationType | target  | browser | Capability | link              |
	| HomePageToAboutUs | DRUPAL          | Desktop | Chrome  | IPhoneX    | about us:about us |
	| HomePageToAboutUs | DRUPAL          | Desktop | IE      | IPhoneX    | about us:about us |


@Drupal_Regression
Scenario Outline: 18_HomePageAboutUs:SocialResponsibility
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the SocialResponsibility page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | about us:social responsibility |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | about us:social responsibility |

@Drupal_Regression
Scenario Outline: 19_HomePageAboutUs:Careers
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Careers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | about us:careers |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | about us:careers |

			@Drupal_Regression
Scenario Outline: 20_HomePageAbout us:newsroom
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
#Then I Verify all the elements in the Careers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | about us:newsroom |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | about us:newsroom |




@Drupal_Regression
Scenario Outline: 21_HomePageLogIn:PersonalJewelry
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the ManageMyPolicy page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link                   |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | login:personal jewelry |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | login:personal jewelry |


@Drupal_Regression
Scenario Outline: 22_HomePageLogIn:Agent
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Agent Portal page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link        |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | login:agent |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | login:agent |


@Drupal_Regression
Scenario Outline: 23_HomePageLogin:Zingplatform
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
#Then I Verify all the elements in the Agent Portal page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link        |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | login:zing platform |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | login:zing platform |

	
## Footer 

@Drupal_Regression
Scenario Outline: 24_HomePageContactVerification
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Contact page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | Contact |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | Contact |


@Drupal_Regression
Scenario Outline: 25_HomePagePrivacypolicyVerification
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the privacy policy page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link           |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | privacy policy |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | privacy policy |


@Drupal_Regression
Scenario Outline: 26_HomePageTermOfUseVerification
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the terms of use page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link         |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | terms of use |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | terms of use |

@Drupal_Regression
Scenario Outline: 27_HomePageShareConcernsVerification
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the share your concerns page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link                |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | share your concerns |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | share your concerns |


@Drupal_Regression
Scenario Outline: 28_HomePageToCareers
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Careers page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link    |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | careers |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | careers |



@Drupal_Regression
Scenario Outline: 29_HomePageToNewsRoom
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
Then I Verify all the elements in the Newsroom page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link     |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | newsroom |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | newsroom |


@Drupal_Regression
Scenario Outline: 30_HomePageExplorePersonalJewelryInsurance
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
# Then I Verify all the elements in the Newsroom page are displayed
And I navigate back to the home page
Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | link     |
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | explore personal jewelry insurance |
	| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | explore personal jewelry insurance |


@Drupal_Regression
Scenario Outline: 31_HomePageToTrustExplorePersonalJewelryInsurance
Given I access the Digital Application <applicationType> on <target> in <browser>
When I access on the home page of JewlersMutual
And I select the <link> on homepage
# Then I Verify all the elements in the Newsroom page are displayed
And I navigate back to the home page
Examples: 
| Test Case #   | applicationType | target  | browser | Capability | link     |
| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | trust:explore personal jewelry insurance |
| HomePageLinks | DRUPAL          | Desktop | IE      | IPhoneX    | trust:explore personal jewelry insurance |

## Full wbsite 

@Drupal_Regression
	Scenario Outline: FullScenario
	Given I access the Digital Application <applicationType> on <target> in <browser>
	When I access on the home page of JewlersMutual

	# personal
	Then I select the personal:personal insurance on homepage
	Then I Verify all the elements in the Personal Insureance page are displayed
	And I navigate back to the home page
	And I select the personal:get a quote on homepage
	Then I Verify all the elements in the Quote page are displayed
	And I navigate back to the home page
	And I select the personal:pay my bill on homepage
	Then I Verify all the elements in the Quick Bill Pay page are displayed
	And I navigate back to the home page
	And I select the personal:claims on homepage
	Then I Verify all the elements in the claims page are displayed
	And I navigate back to the home page
	And I select the personal:Manage My Policy on homepage
	Then I Verify all the elements in the ManageMyPolicy page are displayed
	And I navigate back to the home page
	And I select the personal:blog on homepage
	Then I Verify all the elements in the Personal Blog page are displayed
	And I navigate back to the home page

	# business
	And I select the business:business insurance on homepage
	# Then I Verify all the elements in the BusinessInsurance page are displayed
	And I navigate back to the home page
	And I select the business:claims on homepage
	#Then I Verify all the elements in the Pawn Brokers page are displayed
	And I navigate back to the home page
	And I select the business:pay my bill on homepage
	#Then I Verify all the elements in the Pawn Brokers page are displayed
	And I navigate back to the home page
	And I select the business:zing platform on homepage
	#Then I Verify all the elements in the Pawn Brokers page are displayed
	And I navigate back to the home page
	And I select the business:shipping solution on homepage
	Then I Verify all the elements in the Shipping solution page are displayed
	And I navigate back to the home page
	And I select the business:jm care plan on homepage
	#Then I Verify all the elements in the Pawn Brokers page are displayed
	And I navigate back to the home page
	And I select the business:jeweler programs on homepage
	Then I Verify all the elements in the Jeweler Programs page are displayed
	And I navigate back to the home page
	And I select the business:pawnbrokers on homepage
	Then I Verify all the elements in the Pawn Brokers page are displayed
	And I navigate back to the home page

	# about us
	And I select the about us:newsroom on homepage
	#Then I Verify all the elements in the Careers page are displayed
	And I navigate back to the home page
	And I select the about us:about us on homepage
	Then I Verify all the elements in the about us page are displayed
	And I navigate back to the home page
	And I select the about us:social responsibility on homepage
	Then I Verify all the elements in the SocialResponsibility page are displayed
	And I navigate back to the home page
	And I select the about us:careers on homepage
	Then I Verify all the elements in the Careers page are displayed
	And I navigate back to the home page
	 

	# answers
	And I select the answers:faq on homepage
	#Then I Verify all the elements in the Pawn Brokers page are displayed
	And I navigate back to the home page
	# And I select the answers:jewelry insurance 101 on homepage
	# Then I Verify all the elements in the Pawn Brokers page are displayed
	# And I navigate back to the home page
	
	
	# log in
	And I select the login:personal jewelry on homepage
	Then I Verify all the elements in the ManageMyPolicy page are displayed
	And I navigate back to the home page
	And I select the login:zing platform on homepage
	#Then I Verify all the elements in the Agent Portal page are displayed
	And I navigate back to the home page
	And I select the login:agent on homepage
	Then I Verify all the elements in the Agent Portal page are displayed
	And I navigate back to the home page

	# footer 
	And I select the contact on homepage
	Then I Verify all the elements in the Contact page are displayed
	And I navigate back to the home page
	And I select the privacy policy on homepage
	Then I Verify all the elements in the privacy policy page are displayed
	And I navigate back to the home page
	And I select the terms of use on homepage
	Then I Verify all the elements in the terms of use page are displayed
	And I navigate back to the home page
	And I select the share your concerns on homepage
	Then I Verify all the elements in the share your concerns page are displayed
	And I navigate back to the home page
	And I select the careers on homepage
	Then I Verify all the elements in the Careers page are displayed
	And I navigate back to the home page
	And I select the newsroom on homepage
	Then I Verify all the elements in the Newsroom page are displayed
	And I navigate back to the home page
	And I select the explore personal jewelry insurance on homepage
	# Then I Verify all the elements in the Newsroom page are displayed
	And I navigate back to the home page
	And I select the trust:explore personal jewelry insurance on homepage
	# Then I Verify all the elements in the Newsroom page are displayed
	Then I navigate back to the home page

Examples: 
	| Test Case #   | applicationType | target  | browser | Capability | 
	| HomePageLinks | DRUPAL          | Desktop | Chrome  | IPhoneX    | 
	| HomePageLinks | DRUPAL          | Desktop | IE  | IPhoneX    | 