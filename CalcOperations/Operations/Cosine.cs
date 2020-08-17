using System;
using System.Globalization;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class for getting the Cosine value
    /// </summary>
    public static class Cosine
    {
        /// <summary>
        /// Computes an return the Cosine variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to cosine</param>
        /// <returns>The converted value</returns>
        public static string Execute(decimal value)
        {
            return Math.Cos((double)value).ToString(CultureInfo.InvariantCulture);
        }
    }
}