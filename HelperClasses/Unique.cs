using System;
using System.Linq;

namespace HelperClasses
{
    /// <summary>
    /// Class for getting Unique random number.
    /// </summary>
    public static class Unique
    {
        private const string alphabeticCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private static readonly Random random = new Random();

        /// <summary>
        /// Property ID
        /// </summary>
        public static string ID
        {
            get
            {
                return Guid.NewGuid().ToString().Replace("-", "");
            }
        }

        /// <summary>
        /// Unique letter sequence using english alphabet, useful for unique names
        /// <param name="length">Character length</param>
        /// </summary>
        public static string LetterSequence(int length)
        {
            return new string(Enumerable.Repeat(alphabeticCharacters, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
