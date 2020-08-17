using System;
using System.Globalization;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that converts a value to cosine
    /// </summary>
    public class Tangent : ITrigOperation
    {
        /// <summary>
        /// Computes an return the Tangent variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to tangent</param>
        /// <returns>The converted value</returns>
        public static decimal Execute(decimal value)
        {
            return (decimal)Math.Tan((double)value);//.ToString(CultureInfo.InvariantCulture);
        }

        decimal ITrigOperation.Execute(decimal value)
        {
            return Execute(value);
        }
    }
}