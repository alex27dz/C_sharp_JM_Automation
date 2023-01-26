using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace WebCommonCore
{
    class Capabilities
    {
        /// <summary>
        /// Method to get a capability of a mobile device.
        /// </summary>
        /// <param name="capType">Type of capability</param>
        /// <returns>The Capability of the mobile device</returns>
        public DesiredCapabilities getCapability(string capType)
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            
           /*
            *  The  BrowserStack details need be passed to this. Once implementing, find a way to pass a value
            *
            * string browserstackuser = "";
            string browserstackkey = "";
            capability.SetCapability("browserstack.user", browserstackuser);
            capability.SetCapability("browserstack.key", browserstackkey);
            capability.SetCapability("browserstack.video", "false");
            capability.SetCapability("browserstack.debug", "true");

            switch (capType.ToLower().Trim())
            {
                case "iphone6s":
                    capability.SetCapability("platform", "MAC");
                    capability.SetCapability("browserName", "safari");
                    capability.SetCapability("device", "iPhone 6S");
                    capability.SetCapability("browserstack.local", "true");
                    
                    break;

                case "ipad":
                    capability.SetCapability("platform", "MAC");
                    capability.SetCapability("browserName", "iPad");
                    capability.SetCapability("device", "iPad Air 2");
                    capability.SetCapability("browserstack.local", "true");
                   
                    break;

                case "ipadpro":
                    capability.SetCapability("browserName", "iPad");
                    capability.SetCapability("platform", "MAC");
                    capability.SetCapability("device", "iPad Pro");
                    capability.SetCapability("browserstack.local", "true");
                   
                    break;

                default:
                    return null;
                   // break;
            }
            */
            return capability;
        }
    }
}
