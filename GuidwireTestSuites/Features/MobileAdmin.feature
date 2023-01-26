Feature: MobileAdmin
	These scenarios are to test the mobile admin api's

@devices
Scenario Outline: Devices-GetDevice
	Given I access <Controller> to perform <APIOperation>
	When I perform a get device with <Id>
	Then I should see these in the get device response <ResponseCode> , <DeviceId> , <OS> , <OSVersion> , <Brand> , <DeviceType> , <DeviceSubType> , <DeviceVersion> , <LocationId> , <Inacvite> , <LastCheckInDate> , <LinkEnabled>

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode | DeviceId                             | OS  | OSVersion | Brand | DeviceType | DeviceSubType | DeviceVersion | LocationId         | Inacvite | LastCheckInDate | LinkEnabled |
	| devices    | Get          | a0h0j000000hXeZAAU | OK           | CDD0A7F4-7B00-40C2-B42E-57FE521008D0 | IOS | 11.4.1    | Apple | Tablet     |               | iPad Air Wifi | 0010j00000QMxctAAD | false    |                 | true        |

@devices
Scenario Outline: Devices-PostDevice
	Given I access <Controller> to perform <APIOperation>
	When I perform a post device with <DeviceId> , <OS> , <OSVersion> , <Brand> , <DeviceType> , <DeviceSubType> , <DeviceVersion> , <LocationId> , <Inactive> , <LinkEnabled>
	Then I should see <ResponseCode> for post operation
	Examples: 
	| Controller | APIOperation | DeviceId | OS  | OSVersion | Brand | DeviceType | DeviceSubType | DeviceVersion | LocationId         | Inactive | LinkEnabled | ResponseCode |
	| devices    | Post         |          | iOS | 11.4.1    | Apple | Tablet     |               | iPad Air Wifi | 0010j00000QMxctAAD | False    | true        | Created      |

	@devices
Scenario Outline: Devices-PutDevice
	Given I access <Controller> to perform <APIOperation>
	When I perform a put device with <Id> , <DeviceId> , <OS> , <OSVersion> , <Brand> , <DeviceType> , <DeviceSubType> , <DeviceVersion> , <LocationId> , <Inactive> , <LinkEnabled>
	Then I should see <ResponseCode> for post operation
	Examples: 
	| Controller | APIOperation | Id                 | DeviceId                     | OS  | OSVersion | Brand | DeviceType | DeviceSubType | DeviceVersion        | LocationId         | Inactive | LinkEnabled | ResponseCode |
	| devices    | Put          | a0h0j000000hZXMAA2 | CDD0A7F4-7B00-40C2-B42E-TEST | iOS | 11.4.1    | Apple | Tablet     |               | iPad Air Wifi Kaylyn | 0010j00000QMxctAAD | False    | true        | NoContent    |


@devices
Scenario Outline: Devices-DeleteDevice
	Given I access <Controller> to perform <APIOperation>
	When I perform a delete device with <Id>
	Then I should see the response <ResponseCode> for delete opeation

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode |
	| devices    | Delete       | a0h0j000000hZcrAAE | OK           |


@locations
Scenario Outline: Locations-GetLocation
	Given I access <Controller> to perform <APIOperation>
	When I perform a get location with <Id>
	Then I should see these in the get location response <ResponseCode> , <Name> , <AddressLine1> , <AddressLine2> , <City> , <StateProvince> , <ZipCode> , <Country> , <ParentID> , <IsSetUp>

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode | Name            | AddressLine1 | AddressLine2 | City | StateProvince | ZipCode | Country | ParentID | IsSetUp |
	| locations  | Get          | 0010j00000Of3TjAAJ | OK           | Andrew Test Org |              |              |      |               |         | US      |          | false   |


	

@locations
Scenario Outline: Locations-GetLocations
	Given I access <Controller> to perform <APIOperation>
	When I perform a get location with <Id>
	Then I should see these in the get locations response <ResponseCode> 

	Examples: 
	| Controller | APIOperation | Id | ResponseCode |
	| locations  | Get          |    | OK           |

	@locations
Scenario Outline: Locations-GetLocationUsers
	Given I access <Controller> to perform <APIOperation>
	When I perform a get location users with <Id> , <IsManager> , <IsListed> , <Hydrate> , <Count>
	Then I should see these in the get locations response <ResponseCode> 

	Examples: 
	| Controller | APIOperation | Id                 | IsManager | IsListed | Hydrate | Count | ResponseCode |
	| locations  | Get          | 0010j00000QMxctAAD | true      |          |         |       | OK           |

	@locations
Scenario Outline: Locations-GetLocationDevices
	Given I access <Controller> to perform <APIOperation>
	When I perform a get location devices with <Id>
	Then I should see these in the get locations response <ResponseCode> 

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode |
	| locations  | Get          | 0010j00000QMxctAAD | OK           |


	@Accounts
Scenario Outline: Accounts-GetAccount
	Given I access <Controller> to perform <APIOperation>
	When I perform a get account with <Id>
	Then I should see these in the account get account response <ResponseCode> , <Name> , <ParentAccountID> , <InActive> , <HierarchyLevel> 

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode | Name            | ParentAccountID | InActive | HierarchyLevel        |
	| accounts   | Get          | 0010j00000Of3TjAAJ | OK           | Andrew Test Org |                 | false    | Organizational Parent |


	@Accounts
Scenario Outline: Accounts-GetAccounts
	Given I access <Controller> to perform <APIOperation>
	When I perform a get account with <Id>
	Then I should see these in the get accounts response <ResponseCode>

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode |
	| accounts   | Get          | 0010j00000Of3TjAAJ | OK           | 

	@Accounts
Scenario Outline: Accounts-GetGWLinkId
	Given I access <Controller> to perform <APIOperation>
	When I perform a get guidewire link id with <Id>
	Then I should see these in the get guidewire link id response <ResponseCode> , <GWLinkId> 

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode | GWLinkId |
	| accounts   | Get          | 0010j00000QMxctAAD | OK           | cx:316722|

	@Accounts
Scenario Outline: Accounts-GetUsers
	Given I access <Controller> to perform <APIOperation>
	When I perform a get users with <Id> , <Hydrate> , <Count>
	Then I should see these in the account get users response <ResponseCode> 

	Examples: 
	| Controller | APIOperation | Id                 | Hydrate | Count | ResponseCode |
	| accounts   | Get          | 0010j00000Of3TjAAJ |         |       |   OK           |

	@Users
Scenario Outline: Users-GetUsersLocations
	Given I access <Controller> to perform <APIOperation>
	When I perform a get user with <Id> , <isManager> , <isListed>
	Then I should see these in the get locations response <ResponseCode> 

	Examples: 
	| Controller | APIOperation | Id                 | isManager | isListed | ResponseCode |
	| users      | Get          | a0l0j000000xyYqAAI |           |          |OK           |

		@Users
Scenario Outline: Users-GetUsers
	Given I access <Controller> to perform <APIOperation>
	When I perform a get users with <Id> , <Hydrate> , <Count>
	Then I should see in the users get users response <ResponseCode> 

	Examples: 
	| Controller | APIOperation | Id                                  | Hydrate | Count | ResponseCode |
	| users         | Get                   | a0l0j000000xyYqAAI |                |             |OK                       |
	
		@Users
Scenario Outline: Users-PostUsers
	Given I access <Controller> to perform <APIOperation>
	When I perform a users post user with <Id> , <FirstName> , <LastName> , <ManagerId> , <Role> , <FailedAttempts> , <PasswordResetRequired> , <LINKaccountId> , <PrimaryLocationId> , <UserActive> , <EmailAddress> , <Password> 
	And  I add a location with <Id> , <LocationId> , <UserId> , <IsManager> , <IsListed> , <LocationName> , <AddressLine1> , <AddressLine2> , <City> , <StateProvince> , <ZipPostal>  , <Country> , <ParentId> , <IsSetup>
	Then I should see <ResponseCode> for post operation
	Examples: 
	| Controller | APIOperation | Id                 | FirstName | LastName | ManagerId | Role | FailedAttempts | PasswordResetRequired | LINKaccountId      | PrimaryLocationId  | UserActive | EmailAddress          | Password | LocationId         | UserId | IsManager | IsListed | LocationName      | AddressLine1 | AddressLine2 | City | StateProvince | ZipPostal | Country | ParentId | IsSetUp | ResponseCode |
	| users      | Post         | a0l0j000000xyYqAAI | Test      | User     |           |      |                | true                  | 0010j00000Of3TjAAJ | 0010j00000Of3TjAAJ | true       | random | Pass1234 | 0010j00000Of3TjAAJ | 123456 | true      | true     | Andrew Stage Test |              |              |      |               |           |         |          | true    | Created    |

		@Users
Scenario Outline: Users-PostUsersLocation
	Given I access <Controller> to perform <APIOperation>
	When I perform a post user with <Id> , <UserId> , <LocationId> , <IsManager> , <IsListed> 
	Then I should see a response for post users location of <ResponseCode> 
	Examples: 
	| Controller | APIOperation | Id       | UserId                         | LocationId                    | IsManager | IsListed | ResponseCode               |
	| users         | Post                 | test    | a0l0j000000xyYqAAI| 0010j00000Of3UIAAZ| true             | true       | Created                     |

	
	@Users
Scenario Outline: Users-PostUsersLogin
	Given I access <Controller> to perform <APIOperation>
	When I perform a post user login with <emailAddress> , <Password>  
	Then I should see <ResponseCode> for post operation
	Examples: 
	| Controller | APIOperation | emailAddress       | Password  |ResponseCode |
	| users      | Post         | arens@jminsure.com | Pass@1234 |OK    |

		@Users
Scenario Outline: Users-PutUsersLocation     (updated IsManager to false)
	Given I access <Controller> to perform <APIOperation>
	When I perform a put user location with <Id> , <locationId> , <userId> , <IsManager> , <IsListed>
	Then I should see <ResponseCode> for post operation
	Examples: 
	| Controller | APIOperation | Id                                  | locationId                     | userId                             | IsManager | IsListed | ResponseCode |
	| users         | Put                   | a0l0j000000xyYqAAI | 0010j00000Of3UIAAZ|  a0l0j000000xyYqAAI | false           | true      | NoContent        |
	
		
	@Users
Scenario Outline: Users-PutUsersPassword
	Given I access <Controller> to perform <APIOperation>
	When I perform a put user password with <Id> and <Password>
	Then I should see <ResponseCode> for post operation
	Examples: 
	| Controller | APIOperation | Id                                  | Password              | ResponseCode |
	| users         | Put                   | a0l0j000000xyYqAAI | Password123456 | NoContent    |
	
	
	@Users
Scenario Outline: Users-PutUsers
	Given I access <Controller> to perform <APIOperation>
	When I perform a users post user with <Id> , <FirstName> , <LastName> , <ManagerId> , <Role> , <FailedAttempts> , <PasswordResetRequired> , <LINKaccountId> , <PrimaryLocationId> , <UserActive> , <EmailAddress> , <Password>
	And  I add a location for put with <Id> , <LocationId> , <UserId> , <IsManager> , <IsListed> , <LocationName> , <AddressLine1> , <AddressLine2> , <City> , <StateProvince> , <ZipPostal>  , <Country> , <ParentId> , <IsSetup>
	Then I should see <ResponseCode> for post operation
	Examples: 
	| Controller | APIOperation | Id                                  | UserId                | Password | IsListed | IsManager | LocationId                 |  FirstName | LastName | ManagerId | Role | FailedAttempts | PasswordResetRequired | LINKaccountId | PrimaryLocationId | UserActive | EmailAddress | LocationName | AddressLine1 | AddressLine2 | City | StateProvince | ZipPostal | Country | ParentId | IsSetUp | ResponseCode |
	| users         | Put                   | a0l0j000000xyYqAAI |   123456            |                  |               |                     | 0010j00000Of3TjAAJ | Random    | Test             |                       |          |                            | true                                   | 0010j00000Of3TjAAJ |0010j00000Of3TjAAJ | true       | kraether@jminsure.com |                            |                          |                          |         |                         |                   |                |                 | true        | NoContent       |


		@Users
Scenario Outline: Users-DeleteUsersLocation
	Given I access <Controller> to perform <APIOperation>
	When I perform a delete user from location with <Id> and <locationId>
	Then I should see the response <ResponseCode> for delete opeation

	Examples: 
	| Controller | APIOperation | Id                 | locationId          |ResponseCode |
	| users      | Delete       | a0l0j000000xyYqAAI | a0l0j000000xyYqAAI  |NoContent       |
	
	@Users
Scenario Outline: Users-DeleteUsers
	Given I access <Controller> to perform <APIOperation>
	When I perform a delete user with <Id>
	Then I should see the response <ResponseCode> for delete opeation

	Examples: 
	| Controller | APIOperation | Id                 | ResponseCode |
	| users      | Delete       | a0l0j000000y60CAAQ | NoContent           |
	
	