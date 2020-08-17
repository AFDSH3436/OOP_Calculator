namespace CalculatorOperations.Operations.Interfaces
{
    /// <summary>
    /// An interface that handles the execution of each trigonometric operation
    /// </summary>
    public interface ISingleValueOperation
    {
        /// <summary>
        /// The method to be overridden every single value operation class
        /// </summary>
        /// <param name="value">The value passed</param>
        /// <returns>The returned value</returns>
        public decimal Execute(decimal value);
    }
}