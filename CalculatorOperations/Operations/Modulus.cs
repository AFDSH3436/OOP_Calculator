using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that computes the modulus of two values
    /// </summary>
    public class Modulus : IDoubleValueOperation
    {
        /// <summary>
        /// A method that computes and returns the modulus of two values
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The returned value</returns>
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return firstValue % secondValue;
        }
    }
}