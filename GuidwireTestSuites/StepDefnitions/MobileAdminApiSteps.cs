using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCommonCore;
using SalesForcePages.Controllers;
using SalesForcePages.Models.MobileAdminApi.Devices;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesForcePages.Models.MobileAdminApi.Locations;
using SalesForcePages.Models.MobileAdminApi.Accounts;
using SalesForcePages.Models.MobileAdminApi.Users;
using HelperClasses;

namespace GuidewireTestSuites.StepDefnitions
{
    [Binding]
    class MobileAdminApiSteps : TestBase
    {
        string apiUrl = null;
        string apiOperation = null;
        string getResponse = null;
        string postResponse = null;
        string delResponse = null;
     
        [Given(@"I access (.*) to perform (.*)")]
       // [Given(@"I access devices controller to perform (.*)")]
        public void GivenIAccessControllerToPerform(string controller, string apiOperation)
        {
            ScenarioContext.Current["AUTEnv"] = System.Configuration.ConfigurationManager.AppSettings["EnvToExecute"];
            ScenarioContext.Current["Application"] = "Mobile Admin Api";
            ScenarioContext.Current["TargetType"] = "API Test";
            ScenarioContext.Current["Capability"] = "API Test";
            ScenarioContext.Current["BrowserType"] = "API Test";
          
            string API_url = null;
            switch (ScenarioContext.Current["AUTEnv"].ToString().ToLower().Trim())
            {
                case "stage":
                    API_url = "http://jmssvc01/api/MobileAdmin/v1/api/"+ controller;
                    break;
                case "qa6":
                    API_url = "http://jmtsvc04.jewelersnt.local/api/quote/v3/quote/fullquote";
                    break;
                case "dev1":
                    API_url = "https://jm-t-ams-sharedapi.azure-api.net/qapi/v3/quote/fullquote";
                    break;
            }

            apiUrl = API_url;
            this.apiOperation = apiOperation;

        }


        [When(@"I perform a get device with (.*)")]
        public void WhenIPerformAGetDeviceWith(string deviceId)
        {
            DevicesController devController = new DevicesController();
            Console.Write("URL:"+ apiUrl + "/" + deviceId);
            getResponse = devController.devicesGet(apiUrl, apiOperation.ToLower(), deviceId);
           // getResponse = devController.getAPIResponse(apiUrl + "/" + deviceId, apiOperation.ToLower(), null).ToString();
        }

        [When(@"I perform a get location with (.*)")]
        public void WhenIPerformAGetLocationWithId(string id)
        {
            LocationsController locController = new LocationsController();
            Console.Write("URL:" + apiUrl + "/" + id);

            getResponse = locController.locationsGet(apiUrl, apiOperation.ToLower(), id);
        }


     


        [When(@"I perform a get account with (.*)")]
        public void WhenIPerformAGetAccountWithId(string id)
        {
            AccountsController accController = new AccountsController();
            Console.Write("URL:" + apiUrl + "/" + id);

            getResponse = accController.accountsGet(apiUrl, apiOperation.ToLower(), id);
        }


        [When(@"I perform a get location users with (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIPerformAGetLocationUsersWith(string id, string isManager, string isListed, string hydrate, string count)
        {
            LocationsController locController = new LocationsController();
            Console.Write("URL:" + apiUrl + "/" + id);

            getResponse = locController.locationsGetUsers(apiUrl, apiOperation.ToLower(), id, isManager, isListed, hydrate, count);
        }


        [When(@"I perform a get location devices with (.*)")]
        public void WhenIPerformAGetLocationDevicesWithQMxctAAD(string id)
        {
            LocationsController locController = new LocationsController();
            Console.Write("URL:" + apiUrl + "/" + id);

            getResponse = locController.locationsGetDevices(apiUrl, apiOperation.ToLower(), id);
        }


        [Then(@"I should see these in the get device response (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void ThenIShouldSeeTheseInTheResponse(string responseCode, string deviceId, string oS, string oSVersion, string brand, string deviceType, string deviceSubType, string deviceVersion, string locationId, string inAcvite, string lastCheckInDate, string linkEnabled)
        {
            
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());

            var results = JsonConvert.DeserializeObject<DeviceModel>(getResponse);
            Console.WriteLine("ID: " + results.DeviceId);

            if(deviceId.Trim() != "")
                Assert.AreEqual(deviceId, results.DeviceId);

            if (oS.Trim() != "")
                Assert.AreEqual(oS.ToLower(), results.OS.ToLower());

            if (oSVersion.Trim() != "")
                Assert.AreEqual(oSVersion, results.OSVersion);

            if (brand.Trim() != "")
                Assert.AreEqual(brand, results.Brand);

            if (deviceType.Trim() != "")
                Assert.AreEqual(deviceType, results.DeviceType);

            if (deviceSubType.Trim() != "")
                Assert.AreEqual(deviceSubType, results.DeviceSubType);

            if (deviceVersion.Trim() != "")
                Assert.AreEqual(deviceVersion, results.DeviceVersion);

            if (locationId.Trim() != "")
                Assert.AreEqual(locationId, results.LocationId);

            if (inAcvite.Trim() != "")
                Assert.AreEqual(inAcvite.ToString().ToLower(), results.Inactive.ToString().ToLower());

            if (linkEnabled.Trim() != "")
                Assert.AreEqual(linkEnabled.ToString().ToLower(), results.LINKEnabled.ToString().ToLower());
                                   
        }

        [Then(@"I should see these in the get location response (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void ThenIShouldSeeTheseInTheResponse(string responseCode, string name, string addressLine1, string addressLine2, string city, string stateProvince, string zipCode, string country, string parentID, string isSetUp)
        {
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());

            var results = JsonConvert.DeserializeObject<LocationModel>(getResponse);
            Console.WriteLine("ID: " + results.Id);

            if (name.Trim() != "")
                Assert.AreEqual(name, results.Name);

            if (addressLine1.Trim() != "")
                Assert.AreEqual(addressLine1.ToLower(), results.AddressLine1.ToLower());

            if (addressLine2.Trim() != "")
                Assert.AreEqual(addressLine2.ToLower(), results.AddressLine2.ToLower());

            if (city.Trim() != "")
                Assert.AreEqual(city, results.City);

            if (stateProvince.Trim() != "")
                Assert.AreEqual(stateProvince, results.StateProvince);

            if (zipCode.Trim() != "")
                Assert.AreEqual(zipCode, results.ZipPostal);

            if (country.Trim() != "")
                Assert.AreEqual(country, results.Country);

            if (parentID.Trim() != "")
                Assert.AreEqual(parentID, results.ParentId);

            if (isSetUp.Trim() != "")
                Assert.AreEqual(isSetUp.ToString().ToLower(), results.IsSetup.ToString().ToLower());
                       
        }


   [Then(@"I should see these in the account get account response (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void ThenIShouldSeeTheseInTheGetAccountResponse(string responseCode, string name, string parentAccountID, string inActive, string hierarchyLevel)
        {
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());

            var results = JsonConvert.DeserializeObject<AccountModel>(getResponse);
            Console.WriteLine("ID: " + results.Id);

            if (name.Trim() != "")
                Assert.AreEqual(name, results.Name);

            if (parentAccountID.Trim() != "")
                Assert.AreEqual(parentAccountID, results.ParentAccountId);

            if (inActive.Trim() != "")
                Assert.AreEqual(inActive.ToLower().ToString(), results.Inactive.ToString().ToLower());

            if (hierarchyLevel.Trim() != "")
                Assert.AreEqual(hierarchyLevel.ToLower().ToString(), results.HierarchyLevel.ToLower().ToString());
        }



        [When(@"I perform a post device with (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIPerformAPostDeviceWith(string deviceId, string oS, string oSVersion, string brand, string deviceType, string deviceSubType, string deviceVersion, string locationId, string Inactive, string linkEnabled)
        {
            DevicePostModel devicePost = new DevicePostModel();

            if (deviceId.Trim() != "")
                devicePost.DeviceId = deviceId;

            if (oS.Trim() != "")
                devicePost.OS = oS;

            if (oSVersion.Trim() != "")
                devicePost.OSVersion = oSVersion;

            if (brand.Trim() != "")
                devicePost.Brand = brand;

            if (deviceType.Trim() != "")
                devicePost.DeviceType = deviceType;

            if (deviceSubType.Trim() != "")
                devicePost.DeviceSubType = deviceSubType;

            if (deviceVersion.Trim() != "")
                devicePost.DeviceVersion = deviceVersion;

            if (locationId.Trim() != "")
                devicePost.LocationId = locationId;

            if (Inactive.Trim() != "")
                devicePost.Inactive = Convert.ToBoolean(Inactive);

            if (linkEnabled.Trim() != "")
                devicePost.LINKEnabled = Convert.ToBoolean(linkEnabled);

            DevicesController devController = new DevicesController();
            postResponse = devController.devicesPost(apiUrl, apiOperation.ToLower(), devicePost);
           // postResponse = devController.getAPIResponse(apiUrl, apiOperation.ToLower(), devicePost).ToString();


        }

        [Then(@"I should see these in the account get users response (.*)")]
        [Then(@"I should see (.*) for post operation")]
        [Then(@"I should see these in the get locations response (.*)")]
        [Then(@"I should see these in the get account response (.*)")]
        [Then(@"I should see these in the get accounts response (.*)")]
        public void ThenIShouldSee(string responseCode)
        {
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());

        }

      
        [When(@"I perform a put device with (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIPerformAPutDeviceWith(string id, string deviceId, string oS, string oSVersion, string brand, string deviceType, string deviceSubType, string deviceVersion, string locationId, string Inactive, string linkEnabled)
        {
            DevicePutModel devicePut = new DevicePutModel();

            if (id.Trim() != "")
                devicePut.Id = id;
           
            if (deviceId.Trim() != "")
                devicePut.DeviceId = deviceId;

            if (oS.Trim() != "")
                devicePut.OS = oS;

            if (oSVersion.Trim() != "")
                devicePut.OSVersion = oSVersion;

            if (brand.Trim() != "")
                devicePut.Brand = brand;

            if (deviceType.Trim() != "")
                devicePut.DeviceType = deviceType;

            if (deviceSubType.Trim() != "")
                devicePut.DeviceSubType = deviceSubType;

            if (deviceVersion.Trim() != "")
                devicePut.DeviceVersion = deviceVersion;

            if (locationId.Trim() != "")
                devicePut.LocationId = locationId;

            if (Inactive.Trim() != "")
                devicePut.Inactive = Convert.ToBoolean(Inactive);

            if (linkEnabled.Trim() != "")
                devicePut.LINKEnabled = Convert.ToBoolean(linkEnabled);

            DevicesController devController = new DevicesController();
            postResponse = devController.devicesPut(apiUrl, apiOperation.ToLower(), id, devicePut);
        }


        [When(@"I perform a delete device with (.*)")]
        public void WhenIPerformADeleteDeviceWith(string deviceId)
        {
            DevicesController devController = new DevicesController();
            Console.Write("URL:" + apiUrl + "/" + deviceId);
            delResponse = devController.devicesDelete(apiUrl, apiOperation.ToLower(), deviceId);
        }

        [Then(@"I should see the response (.*) for delete opeation")]
        public void ThenIShouldSeeTheResponseForDeleteOpeation(string responseCode)
        {
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());
        }

        [When(@"I perform a get guidewire link id with (.*)")]
        public void WhenIPerformAGetGuidewireLinkId(string id)
        {
            AccountsController accController = new AccountsController();
            Console.Write("URL:" + apiUrl + "/" + id);

            getResponse = accController.accountGetGWLinkId(apiUrl, apiOperation, id);

        }

        [Then(@"I should see these in the get guidewire link id response (.*) , (.*)")]
        public void ThenIShouldSeeTheseInTheGetGuidewireLinkIdResponse(string responseCode, string gwLinkId)
        {
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());

            var results = JsonConvert.DeserializeObject<GWLinkId>(getResponse);
         
            if (gwLinkId.Trim() != "")
                Assert.AreEqual(gwLinkId, results.GwLinkId);
        }

        [When(@"I perform a get users with (.*) , (.*) , (.*)")]
        public void WhenIPerformAGetUsersWithOf(string id, string hydrate, string count)
        {
            UsersController userController = new UsersController();
            Console.Write("URL:" + apiUrl + "/" + id);

            getResponse = userController.userGet(apiUrl, apiOperation, id, hydrate, count);
        }

        [When(@"I perform a get user with (.*) , (.*) , (.*)")]
        public void WhenIPerformAGetUserWith(string id, string isManager, string isListed)
        {
            UsersController userController = new UsersController();
            getResponse = userController.userGet(apiUrl, apiOperation, id, isManager, isListed);
        }


        [Then(@"I should see in the users get users response (.*)")]
        public void ThenIShouldSeeInTheUsersGetUsersResponse(string responseCode)
        {
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());
        }

        //
        [Then(@"I should see a response for post users location of (.*)")]
        public void ThenIShouldSeeAResponseForPostUsersLocationOfNoContent(string responseCode)
        {
            Assert.AreEqual(responseCode, ScenarioContext.Current["ResponseCode"].ToString());
        }

        [When(@"I perform a delete user from location with (.*) and (.*)")]
        public void WhenIPerformADeleteUserFromLocationWith(string Id, string locationId)
        {
            UsersController userController = new UsersController();
            getResponse = userController.userDeleteUserLocation(apiUrl, apiOperation, Id, locationId);
        }


        [When(@"I perform a delete user with (.*)")]
        public void WhenIPerformADeleteUserWith(string id)
        {
            UsersController userController = new UsersController();
            getResponse = userController.userDelete(apiUrl, apiOperation, id);
        }

        [When(@"I add a location with (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)  , (.*) , (.*) , (.*)")]
        public void WhenIAddALocationWith(string Id,string LocationId , string UserId , string IsManager , string IsListed , string  LocationName , string AddressLine1 , string AddressLine2 , string City , string StateProvince , string ZipPostal  , string Country , string ParentId , string IsSetup)
        {
            UserModel userModel = (UserModel)ScenarioContext.Current["userModel"] ;
            List<UserLocationModel> userLocationModelList = new List<UserLocationModel>();
            UserLocationModel userLocationModel = new UserLocationModel();
            userLocationModel.Id = Id;
            userLocationModel.UserId = UserId;
            userLocationModel.IsListed = Boolean.Parse(IsListed);
            userLocationModel.IsManager = Boolean.Parse(IsManager);
            userLocationModel.LocationId = LocationId;
            userLocationModelList.Add(userLocationModel);

            List<LocationModel> locationModelList = new List<LocationModel>();
            LocationModel locationModel = new LocationModel();
            locationModel.Id = Id;
            locationModel.Name = LocationName;
            if (AddressLine1.Trim() != "")
                locationModel.AddressLine1 = AddressLine1;
            if (AddressLine2.Trim() != "")
                locationModel.AddressLine2 = AddressLine2;
            if (City.Trim() != "")
                locationModel.City = City;
            if (StateProvince.Trim() != "")
                locationModel.StateProvince = StateProvince;
            if (ZipPostal.Trim() != "")
                locationModel.ZipPostal = ZipPostal;
            if (Country.Trim() != "")
                locationModel.Country = Country;
            if (ParentId.Trim() != "")
                locationModel.ParentId = ParentId;
            if (IsSetup.Trim() != "")
                locationModel.IsSetup = true;
            locationModelList.Add(locationModel);

             userModel.Locations = locationModelList;
              userModel.UserLocations = userLocationModelList;


                UsersController userController = new UsersController();
                getResponse = userController.userPost(apiUrl, apiOperation, userModel);

        }

        [When(@"I add a location for put with (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)  , (.*) , (.*) , (.*)")]
        public void WhenIAddALocationWithForPut(string Id, string LocationId, string UserId, string IsManager, string IsListed, string LocationName, string AddressLine1, string AddressLine2, string City, string StateProvince, string ZipPostal, string Country, string ParentId, string IsSetup)
        {
            UserModel userModel = (UserModel)ScenarioContext.Current["userModel"];
            List<UserLocationModel> userLocationModelList = new List<UserLocationModel>();
            UserLocationModel userLocationModel = new UserLocationModel();
            userLocationModel.Id = Id;
            userLocationModel.UserId = UserId;
            if (IsListed.Trim() != "")
                userLocationModel.IsListed = Boolean.Parse(IsListed);
            if (IsManager.Trim() != "")
                userLocationModel.IsManager = Boolean.Parse(IsManager);
            userLocationModel.LocationId = LocationId;
            userLocationModelList.Add(userLocationModel);

            List<LocationModel> locationModelList = new List<LocationModel>();
            LocationModel locationModel = new LocationModel();
            locationModel.Id = Id;
            locationModel.Name = LocationName;
            if (AddressLine1.Trim() != "")
                locationModel.AddressLine1 = AddressLine1;
            if (AddressLine2.Trim() != "")
                locationModel.AddressLine2 = AddressLine2;
            if (City.Trim() != "")
                locationModel.City = City;
            if (StateProvince.Trim() != "")
                locationModel.StateProvince = StateProvince;
            if (ZipPostal.Trim() != "")
                locationModel.ZipPostal = ZipPostal;
            if (Country.Trim() != "")
                locationModel.Country = Country;
            if (ParentId.Trim() != "")
                locationModel.ParentId = ParentId;
            if (IsSetup.Trim() != "")
                locationModel.IsSetup = true;
            locationModelList.Add(locationModel);

            userModel.Locations = locationModelList;
            userModel.UserLocations = userLocationModelList;


            UsersController userController = new UsersController();
            getResponse = userController.userPut(apiUrl, apiOperation, Id, userModel);

        }


        [When(@"I perform a users put user with (.*) , Random , Test ,  ,  ,  , true ,  ,  , true ,  , ")]
        [When(@"I perform a users put user with (.*) , (.*) ,  (.*) ,  (.*) ,  (.*) ,  (.*) ,  (.*) ,  (.*) ,  (.*) ,  (.*) ,  (.*)")]
        [When(@"I perform a users post user with (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIPerformAUsersPostUserWith(string Id, string FirstName, string LastName, string ManagerId, string Role, string FailedAttempts, string PasswordResetRequired, string LINKaccountId, string PrimaryLocationId, string UserActive, string EmailAddress, string password)
        {
               
            UserModel userModel = new UserModel();
            userModel.Id = Id;
            if (FirstName.Trim() != "")
                userModel.FirstName = FirstName;
            userModel.LastName = LastName;
            if (ManagerId.Trim() != "")
                userModel.ManagerId = ManagerId;
            if(Role.Trim() !="")
                userModel.Role = Role;
            if(FailedAttempts.Trim() !="")
                userModel.FailedAttempts = FailedAttempts;
            if (PasswordResetRequired.Trim() != "")
                userModel.PasswordResetRequired = Boolean.Parse(PasswordResetRequired);
            if (LINKaccountId.Trim() != "")
                userModel.LINKAccountId = LINKaccountId;
            if (PrimaryLocationId.Trim() != "")
                userModel.PrimaryLocationId = PrimaryLocationId;
            if (UserActive.Trim() != "")
                userModel.UserActive = Boolean.Parse(UserActive);
            if (EmailAddress.Trim() != "")
            {
                if (EmailAddress.Trim().ToLower() == "random")
                      EmailAddress = Unique.ID+ "@jminsure.com";
                userModel.EmailAddress = EmailAddress;
            }
            if (password.Trim() != "")
                userModel.Password = password;
            ScenarioContext.Current.Add("userModel", userModel);

     
        }

        // I perform a post user with
        [When(@"I perform a post user with (.*) , (.*) , (.*), (.*) , (.*)")]
        public void WhenIPerformAPostUserWith(string Id, string UserId, string LocationId, string IsManager, string IsListed)
        {
            UserLocationModel userLocationModel = new UserLocationModel();
            if (Id.Trim() != "")
                userLocationModel.Id = Id;
            if (UserId.Trim() != "")
                userLocationModel.UserId = UserId.Trim();
            if (LocationId.Trim() != "")
                userLocationModel.LocationId = LocationId.Trim();
            if (IsManager.Trim() != "")
                userLocationModel.IsManager = Boolean.Parse(IsManager);
            if (IsListed.Trim() != "")
                userLocationModel.IsListed = Boolean.Parse(IsListed);

            UsersController userController = new UsersController();
            getResponse = userController.userPostUserLocation(apiUrl, apiOperation, userLocationModel);
        }

        [When(@"I perform a post user login with (.*) , (.*)")]
        public void WhenIPerformAPostUserWith(string emailAddress, string Password)
        {
             UserLoginModel userLoginModel = new UserLoginModel();
            userLoginModel.EmailAddress = emailAddress;
            userLoginModel.Password = Password;

            UsersController userController = new UsersController();
            getResponse = userController.userPostLogin(apiUrl, apiOperation, userLoginModel);
        }

        [When(@"I perform a put user with (.*) and location with (.*) , (.*) , (.*) , (.*)")]
        public void WhenIPerformAPutUserWith(string Id, string locationId, string userId,  string IsManager, string IsListed)
        {
            UserLocationModel userLocationModel = new UserLocationModel();
            userLocationModel.Id = Id;
            userLocationModel.LocationId = locationId;
            userLocationModel.UserId = userId;
            userLocationModel.IsListed = Boolean.Parse(IsListed);
            userLocationModel.IsManager = Boolean.Parse(IsManager);

            UsersController userController = new UsersController();
            getResponse = userController.userPutUserLocation(apiUrl, apiOperation, userId, locationId,  userLocationModel);
        }


        [When(@"I perform a put user password with (.*) and (.*)")]
        public void WhenIPerformAPutUserPasswordWith(string Id, string Password)
        {
            UserPasswordModel userPasswordModel = new UserPasswordModel();
            userPasswordModel.password = Password;

            UsersController userController = new UsersController();
            getResponse = userController.userPutUserPassword(apiUrl, apiOperation, Id, userPasswordModel);
        }

        [When(@"I perform a put user with (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIPerformAPutUserWith(string Id , string UserId, string IsListed, string IsManager, string Password, string FirstName, string LastName, string ManagerId, string Role, string FailedAttempts, string PasswordResetRequired, string LINKaccountId, string PrimaryLocationId, string UserActive, string EmailAddress, string LocationId, string LocationName, string AddressLine1, string AddressLine2, string City, string StateProvince, string ZipPostal, string Country, string ParentId, string IsSetup)
        {
            List<UserLocationModel> userLocationModelList = new List<UserLocationModel>();
            UserLocationModel userLocationModel = new UserLocationModel();
            userLocationModel.Id = Id;
            userLocationModel.UserId = UserId;
            userLocationModel.IsListed = Boolean.Parse(IsListed);
            userLocationModel.IsManager = Boolean.Parse(IsManager);
            userLocationModel.LocationId = LocationId;
            userLocationModelList.Add(userLocationModel);

            List<LocationModel> locationModelList = new List<LocationModel>();
            LocationModel locationModel = new LocationModel();
            locationModel.Id = Id;
            locationModel.Name = LocationName;
            if (AddressLine1.Trim() != "")
                locationModel.AddressLine1 = AddressLine1;
            if (AddressLine2.Trim() != "")
                locationModel.AddressLine2 = AddressLine2;
            if (City.Trim() != "")
                locationModel.City = City;
            if (StateProvince.Trim() != "")
                locationModel.StateProvince = StateProvince;
            if (ZipPostal.Trim() != "")
                locationModel.ZipPostal = ZipPostal;
            if (Country.Trim() != "")
                locationModel.Country = Country;
            if (ParentId.Trim() != "")
                locationModel.ParentId = ParentId;
            locationModel.IsSetup = Boolean.Parse(IsSetup);
            locationModelList.Add(locationModel);

            UserModel userModel = new UserModel();
            userModel.Id = Id;
            userModel.FirstName = FirstName;
            userModel.LastName = LastName;
            if (ManagerId.Trim() != "")
                userModel.ManagerId = ManagerId;
            if (Role.Trim() != "")
                userModel.Role = Role;
            if (FailedAttempts.Trim() != "")
                userModel.FailedAttempts = FailedAttempts;
            userModel.PasswordResetRequired = Boolean.Parse(PasswordResetRequired);
            userModel.LINKAccountId = LINKaccountId;
            userModel.PrimaryLocationId = PrimaryLocationId;
            userModel.UserActive = Boolean.Parse(UserActive);
            userModel.EmailAddress = EmailAddress;
            userModel.Password = Password;
            userModel.Locations = locationModelList;
            userModel.UserLocations = userLocationModelList;


            UsersController userController = new UsersController();
            getResponse = userController.userPut(apiUrl, apiOperation, UserId, userModel);
        }


        [When(@"I perform a put user location with (.*) , (.*) , (.*) , (.*) , (.*)")]
        public void WhenIPerformAPutUserLocationWith(string Id, string locationId, string userId, string IsManager, string IsListed)
        {
            UserLocationModel userLocationModel = new UserLocationModel();
            userLocationModel.Id = Id;
            userLocationModel.LocationId = locationId;
            userLocationModel.UserId = userId;
            userLocationModel.IsManager = Boolean.Parse(IsManager);
            userLocationModel.IsListed = Boolean.Parse(IsListed);

            UsersController userController = new UsersController();
            getResponse = userController.userPutUserLocation(apiUrl, apiOperation, userId, locationId, userLocationModel);
        }

    }
}
