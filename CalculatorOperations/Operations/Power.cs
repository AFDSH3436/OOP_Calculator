using CalculatorOperations.Operations.Interfaces;
using System;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that calculates the power of a value with respect to another
    /// </summary>
    internal class Power : IDoubleValueOperation
    {
        /// <summary>
        /// A method that calculates the power of a value with respect to another
        /// </summary>
        /// <param name="firstValue">The value whose power is to be calculated</param>
        /// <param name="secondValue">The power to raise the value to</param>
        /// <returns>The calculated value</returns>
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return (decimal)Math.Pow((double)firstValue, (double)secondValue);
        }
    }
}