using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ApplicationSetUpInfo
{
    /// <summary>
    /// Class for all the Guidewire urls across all environments.
    /// </summary>
    public class GWSetUpInfo
    {
        /// <summary>
        /// URL dictionary where all the Guidewire urls are stored
        /// </summary>
        private Dictionary<string, string> urlDictionary = new Dictionary<string, string>();

        /// <summary>
        /// Logger Instance for the GWSetUpInfo class
        /// </summary>
        public static readonly ILog logger = LogManager.GetLogger(typeof(GWSetUpInfo));

        /// <summary>
        /// Constructor for GWSetUpInfo class. All the Guidewire environment URL's are stored here. 
        /// </summary>
        public GWSetUpInfo()
        {
            string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();

            Console.WriteLine("Current Environment--{0}", currEnvironment);

            logger.Info("Current Environment:" + currEnvironment);

            switch (currEnvironment.ToLower().Trim())
            {
                case "local":
                    urlDictionary.Add("PC", "http://localhost:8180/pc");
                    urlDictionary.Add("BC", "http://localhost:8580/bc");
                    urlDictionary.Add("CC", "http://localhost:8080/cc");
                    urlDictionary.Add("CM", "http://localhost:8280/ab");
                    urlDictionary.Add("DRUPALAPP", "https://jmidigitalode7.prod.acquia-sites.com/user/login");
                    break;

                case "dev1":
                    urlDictionary.Add("PC", "http://jmdgpc01/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmdgbc01/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmdgcc01/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmdgcm01/ab/ContactManager.do");
                    urlDictionary.Add("KENTICO", "https://dev.testjewelersmutual.com");
                    urlDictionary.Add("DRUPAL", "https://dev.jewelersmutual.com");
                    urlDictionary.Add("DRUPALAPP", "https://dev.jewelersmutual.com/user/login");
                    break;

                case "dev2":
                    urlDictionary.Add("PC", "http://jmdgpc02/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmdgbc02/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmdgcc02/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmdgcm02/ab/ContactManager.do");
                    break;

                case "dev4":
                    urlDictionary.Add("PC", "http://jmdgpc04/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmdgbc04/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmdgcc04/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmdgcm04/ab/ContactManager.do");
                    break;

                case "qa1":
                    urlDictionary.Add("PC", "http://jmtgpc01/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc01/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc01/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm01/ab/ContactManager.do");
                    urlDictionary.Add("KENTICO", "https://test.testjewelersmutual.com");
                    urlDictionary.Add("DRUPAL", "https://qa.jewelersmutual.com");
                    urlDictionary.Add("DRUPALAPP", "https://qa.jewelersmutual.com/user/login");
                    break;

                case "qa2":
                    urlDictionary.Add("PC", "http://jmtgpc02/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc02/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc02/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm02/ab/ContactManager.do");
                    break;

                case "qa3":
                    urlDictionary.Add("PC", "http://jmtgpc03/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc03/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc03/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm03/ab/ContactManager.do");
                    break;

                case "qa4":
                    urlDictionary.Add("PC", "http://jmtgpc04/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc04/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc04/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm04/ab/ContactManager.do");
                    break;

                case "qa5":
                    urlDictionary.Add("PC", "http://jmtgpc05/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc05/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc05/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm05/ab/ContactManager.do");
                    break;

                case "qa6":
                    urlDictionary.Add("PC", "http://jmtgpc06/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc06/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc06/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm06/ab/ContactManager.do");
                    break;

                case "qa7":
                    urlDictionary.Add("PC", "http://jmtgpc07/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc07/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc07/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm07/ab/ContactManager.do");
                    break;

                case "qa8":
                    urlDictionary.Add("PC", "http://jmtgpc08/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc08/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc08/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm08/ab/ContactManager.do");
                    break;

                case "qa9":
                    urlDictionary.Add("PC", "http://jmtgpc09/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc09/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc09/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm09/ab/ContactManager.do");
                    break;

                case "qa10":
                    urlDictionary.Add("PC", "http://jmtgpc10/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc10/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc10/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm10/ab/ContactManager.do");
                    break;

                case "qa11":
                    urlDictionary.Add("PC", "http://jmtgpc11/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc11/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc11/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm11/ab/ContactManager.do");
                    break;

                case "qa12":
                    urlDictionary.Add("PC", "http://jmtgpc12/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc12/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc12/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm12/ab/ContactManager.do");
                    break;

                case "qa13":
                    urlDictionary.Add("PC", "http://jmtgpc13/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jmtgbc13/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jmtgcc13/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jmtgcm13/ab/ContactManager.do");
                    break;

                case "qa15":
                    urlDictionary.Add("PC", "http://jtn-vm-gpc015/pc/PolicyCenter.do");
                    urlDictionary.Add("BC", "http://jtn-vm-gbc015/bc/BillingCenter.do");
                    urlDictionary.Add("CC", "http://jtn-vm-gcc015/cc/ClaimCenter.do");
                    urlDictionary.Add("CM", "http://jtn-vm-gcm015/ab/ContactManager.do");
                    break;

                case "stage":
                    //Guidewire PolicyCenter  
                    urlDictionary.Add("PC", "http://jmsgpc01/pc/PolicyCenter.do");
                    //Guidewire BillingCenter  
                    urlDictionary.Add("BC", "http://jmsgbc01/bc/BillingCenter.do");
                    //Guidewire ClaimCenter  
                    urlDictionary.Add("CC", "http://jmsgcc01/cc/ClaimCenter.do");
                    //Guidewire ContactManager
                    urlDictionary.Add("CM", "http://jmsgcm01/ab/ContactManager.do");
                    urlDictionary.Add("KENTICO", "https://cms9.testjewelersmutual.com");
                    urlDictionary.Add("DRUPAL", "https://stage.jewelersmutual.com");
                    urlDictionary.Add("DRUPALAPP", "https://stage.jewelersmutual.com/user/login");
                    break;

                case "test":
                    urlDictionary.Add("KENTICO", "https://test.testjewelersmutual.com");
                    break;

                case "prod":
                    urlDictionary.Add("KENTICO", "https://www.jewelersmutual.com/");
                    urlDictionary.Add("DRUPAL", "https://www.jewelersmutual.com/");
                    urlDictionary.Add("DRUPALAPP", "https://www.jewelersmutual.com/user/login");
                    break;


                default:
                    logger.Info("Environment Does not exist:" + currEnvironment);

                    Assert.Fail("Environment : {0} Does not exist.", currEnvironment);

                    break;
            }
        }

        /// <summary>
        /// Method to return the URL for the environment being tested.
        /// </summary>
        /// <param name="key">The Key to pass</param>
        /// <returns></returns>
        public string getEnvironmentURL(string key)
        {
            logger.Info("SetUpInfo - key : " + key);

            Console.WriteLine("SetUpInfo - key :{0}", key);

            if (urlDictionary.ContainsKey(key))
            {
                string value = urlDictionary[key];

                logger.Info("SetUpInfo - URL :" + value);

                Console.WriteLine("SetUpInfo - URL :{0}", value);

                return value;
            }
            else
            {
                logger.Info("Key does not exist.");

                return null;

            }
        }
    }
}
