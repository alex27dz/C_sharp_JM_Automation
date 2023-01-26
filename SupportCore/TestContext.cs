using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.SupportCore
{
    /// <summary>
    /// Class for storing temporary variables during the test execution
    /// </summary>
    public class TestContext
    {
        private static Dictionary<string, object> testContext = new Dictionary<string, object>();
        
        /// <summary>
        /// Setting a value to the test context
        /// </summary>
        public static void setTestContextValue(string key, object value)
        {
            if (doesKeyExistInTestContext(key))
                testContext[key] = value;
            else
                testContext.Add(key, value);

        }

        /// <summary>
        /// Getting a value from test context.
        /// </summary>
        public static object getTestContextValue(string key)
        {
            if (doesKeyExistInTestContext(key))
                return testContext[key];
            else
                return null;

        }

        /// <summary>
        /// Verify if a key exists in the testcontext.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool doesKeyExistInTestContext(string key)
        {
            return testContext.ContainsKey(key);
        }
    }
}
