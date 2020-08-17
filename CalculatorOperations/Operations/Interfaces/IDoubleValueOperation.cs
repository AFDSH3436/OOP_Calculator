namespace CalculatorOperations.Operations.Interfaces
{
    /// <summary>
    /// An interface that handles the execution of each operation
    /// </summary>
    public interface IDoubleValueOperation
    {
        /// <summary>
        /// The method to be overridden by every double value operation class
        /// </summary>
        /// <param name="firstValue">First value</param>
        /// <param name="secondValue">second value</param>
        /// <returns>The returned value</returns>
        public decimal Execute(decimal firstValue, decimal secondValue);
    }
}