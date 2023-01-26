//using Microsoft.Win32;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AutomationFramework
//{
//    public class TempStorage
//    {
//        RegistryKey regKey;

//        string RegistryPathGuidewire = @"SOFTWARE\AutomationSelenium\Guidewire";
//        public void StoreTempValue(string application, string key, string value)
//        {

//            switch (application.ToLower())
//            {

//                case "guidewire":

//                    Console.WriteLine("In Here");
//                    regKey = regKey.OpenSubKey("P", true);

//                    // regKey = regKey.

//                    regKey = Registry.CurrentUser.CreateSubKey(RegistryPathGuidewire);

//                    //  regKey.SetValue("key", "value");
//                    regKey.SetValue(key.Trim().ToUpper(), value.Trim());

//                    break;

//                default:
//                    Console.WriteLine("In Default");
//                    break;
//            }

//        }

//        public string GetTempValue(string key)
//        {
//            regKey = Registry.CurrentUser.CreateSubKey(RegistryPathGuidewire);

//            return regKey.GetValue(key).ToString();
//        }
//    }
//}
