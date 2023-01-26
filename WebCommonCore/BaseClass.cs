using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCommonCore
{
    class BaseClass
    {
        /// <summary>
        /// Constant TIME_TO_WAIT - Default 120 seconds
        /// </summary>
        public const int TIME_TO_WAIT = 120;

        /// <summary>
        /// Constant TIME_TO_WAIT - Default 120 seconds
        /// </summary>
        public const int LONG_WAIT = 300;

        /// <summary>
        /// Constant TIME_TO_WAIT - Default 120 seconds
        /// </summary>
        public const int SUPER_LONG_WAIT = 600;

        /// <summary>
        /// Implicit Wait - 10 seconds
        /// </summary>
        public static readonly TimeSpan ImplicitWait = new TimeSpan(0, 0, 0, 10);

        /// <summary>
        /// No Wait - 0 seconds
        /// </summary>
        public static readonly TimeSpan NoWait = new TimeSpan(0, 0, 0, 0);

    }
}
