using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Diagnostics;

namespace WebCommonCore
{
    /// <summary>
    /// Asbtract class JMSharedBase
    /// </summary>
    public abstract class JMSharedBase
    {
        /// <summary>
        /// Abstract Method getDriver()
        /// </summary>
        /// <returns></returns>
        public abstract IWebDriver getDriver();

        /// <summary>
        /// Method to Initialize Web Driver
        /// </summary>
        protected void InitializeWEbDriver()
        {
            getDriver();
        }

        /// <summary>
        /// Method to Kill Web Driver
        /// </summary>
        protected void KillWEbDriver()
        {
            //  getDriver().Quit();

            KillCurrentOpenProcesses();
        }

        /// <summary>
        /// Method for performing Initial Setups
        /// </summary>
        protected void InitialSetUp()
        {
            KillCurrentOpenProcesses();
        }

        /// <summary>
        /// Method to Kill all automation related processes, before the tests start and after the tests are completed.
        /// </summary>
        private void KillCurrentOpenProcesses()
        {
            string processName = null;

            processName = "chromedriver,chrome,BrowserStackLocal,iedriverserver,iexplore,firefox,geckodriver,MicrosoftWebDriver";

            String[] processes = processName.Split(',');

            foreach (string process in processes)
            {
                Console.WriteLine("Found Process (" + process + "):" + Process.GetProcessesByName(process).Count());

                foreach (Process proc in Process.GetProcessesByName(process))
                {
                    try
                    {
                        Console.WriteLine("Attempting to kill :{0}", proc.Id);

                        proc.Kill();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
