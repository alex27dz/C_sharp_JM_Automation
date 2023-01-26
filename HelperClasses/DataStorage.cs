using log4net;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelperClasses
{
    /// <summary>
    /// Class for Temp Data storage. This would be helpful for moving data between Centers.
    /// </summary>
    public class DataStorage
    {
        /// <summary>
        /// Logger Instance for the GWSetUpInfo class
        /// </summary>
        public static readonly ILog logger = LogManager.GetLogger(typeof(DataStorage));

        /// <summary>
        /// Registry Key
        /// </summary>
        RegistryKey regKey;

        /// <summary>
        /// Path for the Guidewire temp values in registry.
        /// </summary>
        string RegistryPathGuidewire = @"SOFTWARE\AutomationSelenium\Guidewire";

        /// <summary>
        /// Method to store the temp values into registry.
        /// </summary>
        /// <param name="application">Application Name</param>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public void StoreTempValue(string application, string key, string value)
        {

            switch (application.ToLower())
            {

                case "guidewire":

                    logger.Info("Key:'"+ RegistryPathGuidewire + "'  and value:'"+ value + "'");
                    
                    //      regKey = regKey.OpenSubKey("P", true);

                    regKey = Registry.CurrentUser.CreateSubKey(RegistryPathGuidewire);

                    //  regKey.SetValue("key", "value");
                    regKey.SetValue(key.Trim().ToUpper(), value.Trim());

                    break;

                default:

                    logger.Info("Application does not exist:"+ application);
                                        
                    break;
            }

        }

        /// <summary>
        /// Method to get the temp value from the registry.
        /// </summary>
        /// <param name="key">Key to retieve</param>
        /// <returns></returns>
        public string GetTempValue(string key)
        {
            logger.Info("Key:'" + RegistryPathGuidewire + "'");

            regKey = Registry.CurrentUser.CreateSubKey(RegistryPathGuidewire);

            return regKey.GetValue(key).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlQuery"></param>
        public void WriteTestResults(string sqlQuery)
        {
            string connectionString = "Server=dbautomationtesting_prod;Database=automation testing;Trusted_Connection=Yes";

          //  string connectionString = System.Configuration.ConfigurationManager.AppSettings["AutomationTesting"];

            Console.WriteLine("Connection string:"+ connectionString);

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                command.ExecuteNonQuery();
                
                command.Dispose();

                con.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceptiion:"+ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="recordsCount"></param>
        /// <returns></returns>
        public bool VerifyHubSpotRecords(string environment, int recordsCount)
        {
            string connectionString = null;

            int recordsInHS = 0;

            switch (environment.ToLower())
            {
                case "qa4":
                    connectionString = "Server=instdw_qa4;Database=DW_INT;Trusted_Connection=Yes";
                    break;

                case "stage":
                    connectionString = "Server=instDW_STAGE;Database=DW_INT;Trusted_Connection=Yes";
                    break;

                case "qa2":
                    connectionString = "Server=instdw_qa2;Database=DW_INT;Trusted_Connection=Yes";
                    break;
                default:
                    break;
            }

            Console.WriteLine("Connection string:" + connectionString);

            // string sqlQuery = "SELECT count (1) HubSpot FROM MarketingEmail.MarketingContact where ExportDate is null";

            string sqlQuery = "SELECT count (1) HubSpot FROM MarketingEmail.MarketingContact where ExportDate is null or (convert(nvarchar, exportdate, 23) = convert(nvarchar, getdate(), 23))";

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Console.WriteLine("HubSpot Records: "+oReader["HubSpot"].ToString());
                        
                        recordsInHS = Convert.ToInt32(oReader["HubSpot"]);
                    }

                }

                command.Dispose();

                con.Close();

                if (recordsInHS < recordsCount)
                {
                    Console.WriteLine("Records in HubSpot : " + recordsInHS + "are less than : " + recordsCount);

                    return true;
                }
                else
                {
                    Assert.Fail("Records in HubSpot : " + recordsInHS + "are greater than : " + recordsCount);

                    Console.WriteLine("Records in HubSpot : " + recordsInHS + "are greater than : " + recordsCount);

                    return false;
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceptiion:" + ex.ToString());

                return false;
            }

           
        }

    }
}



