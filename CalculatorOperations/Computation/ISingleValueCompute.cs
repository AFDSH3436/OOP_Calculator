namespace CalculatorOperations.Computation
{
    public interface ISingleValueCompute
    {
        /// <summary>
        /// An interface that computes all calculator operations with a single value
        /// </summary>
        /// <param name="value">the value to calculate</param>
        /// <param name="type">the type of operation</param>
        /// <returns></returns>
        public decimal ComputeIt(decimal value, OperationType type);
    }
}