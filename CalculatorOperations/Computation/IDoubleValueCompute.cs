namespace CalculatorOperations.Computation
{
    /// <summary>
    /// An interface that computes all the calculator operations
    /// </summary>
    public interface IDoubleValueCompute
    {
        /// <summary>
        /// A method that grabs all the computed operations and returns it
        /// </summary>
        /// <returns>the returned value</returns>
        public decimal ComputeIt(decimal firstValue, decimal secondValue, OperationType type);
    }
}