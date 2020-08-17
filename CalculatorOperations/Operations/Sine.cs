using CalculatorOperations.Operations.Interfaces;
using System;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that converts a value to sine
    /// </summary>
    public class Sine : ISingleValueOperation
    {
        /// <summary>
        /// Computes an return the Sine variant of the passed value
        /// </summary>
        /// <param name="value">The value to be converted to sine</param>
        /// <returns>The converted value</returns>
        public decimal Execute(decimal value)
        {
            return (decimal)Math.Sin((double)value);
        }
    }
}