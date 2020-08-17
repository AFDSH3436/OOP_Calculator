using System;
using System.Globalization;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that converts a value to sine
    /// </summary>
    public static class Sine
    {
        /// <summary>
        /// Computes an return the Sine variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to sine</param>
        /// <returns>The converted value</returns>
        public static string Execute(decimal value)
        {
            return Math.Sin((double)value).ToString(CultureInfo.InvariantCulture);
        }
    }
}