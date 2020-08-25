using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    /// <summary>
    /// A class for getting the Inverse of a value
    /// </summary>
    internal class Inverse : ISingleValueOperation
    {
        /// <summary>
        /// Computes an return the Inverse of the passed value
        /// </summary>
        /// <param name="value">The value whose inverse id to be calculated</param>
        /// <returns>The final value</returns>
        public decimal Execute(decimal value)
        {
            return 1 / value;
        }
    }
}