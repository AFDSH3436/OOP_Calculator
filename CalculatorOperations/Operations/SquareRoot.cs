using CalculatorOperations.Operations.Interfaces;
using System;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that calculates the square-root of a given value
    /// </summary>
    internal class SquareRoot : ISingleValueOperation
    {
        /// <summary>
        /// A method that calculates the square-root of a given value
        /// </summary>
        /// <param name="value">The passed value</param>
        /// <returns>The computed value</returns>
        public decimal Execute(decimal value)
        {
            return (decimal)Math.Sqrt((double)value);
        }
    }
}