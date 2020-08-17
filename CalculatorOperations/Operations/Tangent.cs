using CalculatorOperations.Operations.Interfaces;
using System;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that converts a value to cosine
    /// </summary>
    public class Tangent : ISingleValueOperation
    {
        /// <summary>
        /// Computes an return the Tangent variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to tangent</param>
        /// <returns>The converted value</returns>
        public decimal Execute(decimal value)
        {
            return (decimal)Math.Tan((double)value);
        }
    }
}