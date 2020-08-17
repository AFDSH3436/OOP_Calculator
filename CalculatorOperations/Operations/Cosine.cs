using CalculatorOperations.Operations.Interfaces;
using System;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class for getting the Cosine value
    /// </summary>
    public class Cosine : ISingleValueOperation
    {
        /// <summary>
        /// Computes an return the Cosine variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to cosine</param>
        /// <returns>The converted value</returns>
        public decimal Execute(decimal value)
        {
            return (decimal)Math.Cos((double)value);
        }
    }
}