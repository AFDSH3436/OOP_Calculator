using System;
using System.Globalization;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class for getting the Cosine value
    /// </summary>
    public class Cosine : ITrigOperation
    {
        /// <summary>
        /// Computes an return the Cosine variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to cosine</param>
        /// <returns>The converted value</returns>
        public static decimal Execute(decimal value)
        {
            return (decimal)Math.Cos((double)value);//.ToString(CultureInfo.InvariantCulture);
        }

        decimal ITrigOperation.Execute(decimal value)
        {
            return Execute(value);
        }
    }
}