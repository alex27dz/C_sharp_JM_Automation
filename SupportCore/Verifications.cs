using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportCore
{
    /// <summary>
    /// Class for generic assertions
    /// </summary>
    public class Verifications
    {
        /// <summary>
        /// Log instance for this class
        /// </summary>
        public static readonly ILog logger = LogManager.GetLogger(typeof(Verifications));

        /// <summary>
        /// Method to check that two strings are equal.
        /// </summary>
        /// <param name="expected">Expected value.</param>
        /// <param name="actual">Actual value.</param>
        /// <param name="message">Message to display on failure.</param>
        /// <param name="ignoreCase">Whether or not to ignore case in comparisions. True - ignore, False - Not to Ignore.</param>
        public static void AssertEqual(String expected, String actual, String message, Boolean ignoreCase)
        {
            logger.Info("Calling AssertEqual with expected : "+ expected + ", actual : "+ actual + " and message :"+ message + ".");
            
            if(expected == null)
            {
                expected = "";
            }

            if (actual == null)
            {
                actual = "";
            }

            Assert.AreEqual(expected.Trim(), actual.Trim(), ignoreCase, message);

            logger.Info("Fields are equal");

            Console.WriteLine("Fields are equal {0} and {1}", expected.Trim(), actual.Trim());
        }

        /// <summary>
        /// Method to check that two strings are equal.
        /// </summary>
        /// <param name="expected">Expected value.</param>
        /// <param name="actual">Actual value.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertEqual(String expected, String actual, String message)
        {
            AssertEqual(expected, actual, message, false);
        }

        /// <summary>
        /// Method to check that two strings are not equal.
        /// </summary>
        /// <param name="first">First value for comparision.</param>
        /// <param name="second">Second value for comparision.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertNotEqual(String first, String second, String message)
        {
            logger.Info("Calling AssertNotEqual with first string : " + first + ", second string : " + second + " and message :" + message + ".");

            if (first == null)
                first = "";

            if (second == null)
                second = "";

            Assert.AreNotEqual(first.Trim(), second.Trim(), message);

            logger.Info("Fields are not equal");

            Console.WriteLine("Fields are not equal , {0} - {1}.", first, second );

        }

        /// <summary>
        /// Method to check that an object is not null.
        /// </summary>
        /// <param name="value">Object to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertNotNull(object value, String message)
        {
            logger.Info("Calling AssertNot Null with value: "+value+" and message: "+ message);

            Assert.IsNotNull(value, message);

            logger.Info("Object is not null.");
        }


        /// <summary>
        /// Method to check that an object is null.
        /// </summary>
        /// <param name="value">Object to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertNull(object value, String message)
        {
            logger.Info("Calling Assert Null with value: " + value + " and message: " + message);

            Assert.IsNull(value, message);

            logger.Info("Object is null.");
        }

        /// <summary>
        /// Method to check that a value is true
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertTrue(Boolean value, String message)
        {
            logger.Info("Calling AssertTrue with value: " + value + " and message: " + message);

            Assert.IsTrue(value, message);
            
            logger.Info("Value is true.");
        }

        /// <summary>
        /// Method to check that a value is false
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertFalse(Boolean value, String message)
        {
            logger.Info("Calling AssertTrue with value: " + value + " and message: " + message);

            Assert.IsFalse(value, message);

            logger.Info("Value is false.");
        }

        /// <summary>
        /// Message to check that the text in one string is contained in another.
        /// </summary>
        /// <param name="container">String where all text should reside.</param>
        /// <param name="textToMatch">Text to match.</param>
        /// <param name="message">Message to display on failure.</param>
        /// <param name="ignoreCase">Whether or not to ignore case and check. True = ignore, flase = not to ignore.</param>
        public static void AssertContains(String container, String textToMatch, String message, Boolean ignoreCase = false)
        {
            logger.Info(" Calling AssertContains with " + container + ", " + textToMatch + " and message: " + message + " and ignore case " + ignoreCase );

            message = message + " Actual Text: " + container + "Text to match:" + textToMatch;

            if (!ignoreCase)
                Assert.IsTrue(container.Contains(textToMatch), message);

            logger.Info("Text to match is in the container");
        }

        /// <summary>
        /// Method to check that two objects of generic type are equal.
        /// </summary>
        /// <typeparam name="T">Type of objects.</typeparam>
        /// <param name="expected">Expected value.</param>
        /// <param name="actual">Actual value.</param>
        /// <param name="message">Message to display on failure.</param>
        public static void AssertEqual<T>(T expected, T actual, String message)
        {
            logger.Info(" Calling AssertEqual <"  + typeof(T) +"> with " + expected + ", " + actual + " and message " + message);

            Assert.AreEqual(expected, actual, message);

            logger.Info("Fields are equal.");
        }
    }
}
