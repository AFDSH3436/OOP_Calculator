using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Computation
{
    /// <summary>
    /// An interface that computes all the calculator operations
    /// </summary>
    public interface ICompute
    {
        /// <summary>
        /// A method that grabs all the computed operations and returns it
        /// </summary>
        /// <returns>the returned value</returns>
        public decimal ComputeIt(decimal firstValue, decimal secondValue, OperationType type);
    }
}