using System;
using System.Globalization;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that converts a value to cosine
    /// </summary>
    public static class Tangent
    {
        /// <summary>
        /// Computes an return the Tangent variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to tangent</param>
        /// <returns>The converted value</returns>
        public static string Execute(decimal value)
        {
            return Math.Tan((double)value).ToString(CultureInfo.InvariantCulture);
        }
    }
}