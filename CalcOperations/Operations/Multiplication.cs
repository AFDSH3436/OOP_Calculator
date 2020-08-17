namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class that computes the multiplication of two values
    /// </summary>
    public static class Multiplication
    {
        /// <summary>
        /// A method that computes and returns the multiplication of two values
        /// </summary>
        /// <param name="firstValue">First number</param>
        /// <param name="secondValue">Second number</param>
        /// <returns>The returned value</returns>
        public static decimal Execute(decimal firstValue, decimal secondValue)
        {
            return firstValue * secondValue;
        }
    }
}