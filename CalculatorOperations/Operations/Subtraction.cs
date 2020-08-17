using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that computes the difference of two values
    /// </summary>
    public class Subtraction : IDoubleValueOperation
    {
        /// <summary>
        /// A method that computes and returns the Difference of two values
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The returned value</returns>
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return firstValue - secondValue;
        }
    }
}