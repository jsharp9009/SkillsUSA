/// Contestant # 510
/// Currency Conversion Program # 1

using System.Collections.Generic;
using System.Linq;

namespace CurrencyConversion
{
    internal class BusinessLogic
    {
        /// <summary>
        /// Conversion Type to the Conversion Rate.
        /// </summary>
        private static Dictionary<ConversionType, decimal> CurrencyConversions = new Dictionary<ConversionType, decimal>()
        {
            {ConversionType.Pound, .64m},
            {ConversionType.Francs, 6.07426m},
            {ConversionType.Lire, 1793.62m},
            {ConversionType.Deutsche, 1.1811m},
            {ConversionType.Pesetas, 154.076m}
        };

        /// <summary>
        /// Converts the US Dollar amount to the Type passed in.
        /// </summary>
        /// <param name="usAmount"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static decimal Convert(decimal usAmount, ConversionType type)
        {
            return usAmount * CurrencyConversions[type];
        }

        /// <summary>
        /// Validates and converts the input string to a decimal. Returns True if
        /// input is a valid decimal and False if it is not.
        /// </summary>
        /// <remarks>
        /// If input string is not valid, usAmount will be set to 0.
        /// </remarks>
        /// <param name="input"></param>
        /// <param name="usAmount"></param>
        /// <returns></returns>
        public static bool Validate(string input, out decimal usAmount)
        {
            // Assume true. We'll change it to false if it is not valid.
            bool valid = true;
            // Assign an initial value to usAmount of 0.
            usAmount = 0;

            // Check the number of decimal places. Only two are allowed.
            // Start by finding if a . was include (we can work with no decimal
            // places or 2).
            if (input.Contains('.'))
            {
                // Find index of the . and add one to get the start index
                int start = input.IndexOf('.') + 1;

                // Get the decimals as a string
                string decimals = input.Substring(start, input.Length - start);

                // We have decimals (as known by the presence of the .) so we have
                // to have 2 to be a valid dollar amount
                if (decimals.Length != 2)
                {
                    valid = false;
                }
            }

            // Check if its a valid decimal. Only check if we haven't already
            // invalidated the string.
            if ((valid) && (!decimal.TryParse(input, out usAmount)))
            {
                valid = false;
            }

            // Finally, check to make sure the amount is greater than 0,
            // were not converting any debt here.
            if ((valid) && (usAmount <= 0))
            {
                valid = false;
            }

            return valid;
        }
    }
}