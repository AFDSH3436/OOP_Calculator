using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations.Operations.Interfaces
{
    /// <summary>
    /// An interface that handles the execution of each trigonometric operation
    /// </summary>
    public interface ITrigOperation
    {
        /// <summary>
        /// The method to be overridden every operation class
        /// </summary>
        /// <param name="value">The value passed</param>
        /// <returns>The returned value</returns>
        public decimal Execute(decimal value);
    }
}