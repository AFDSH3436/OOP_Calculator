using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that computes the sum of two values
    /// </summary>
    public class Addition : IOperation
    {
        /// <summary>
        /// A method that computes and returns the sum of two values
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The returned value</returns>
        public static decimal Execute(decimal firstValue, decimal secondValue)
        {
            return (decimal)(firstValue + secondValue);
        }

        /// <summary>
        /// The Inherited interface overload of the Execute method
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The returned value</returns>
        decimal IOperation.Execute(decimal firstValue, decimal secondValue)
        {
            return Execute(firstValue, secondValue);
        }
    }
}