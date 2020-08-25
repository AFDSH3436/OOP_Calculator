using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOperations.Computation;

namespace CalculatorOperations
{
    /// <summary>
    /// A static class that injects the Calculator Operations to the UI
    /// </summary>
    public static class Injector
    {
        /// <summary>
        /// Returns an instance of Double value operation class
        /// </summary>
        public static IDoubleValueCompute DoubleInstance => new DoubleValue();

        /// <summary>
        /// Returns an instance of Single value operation class
        /// </summary>
        public static ISingleValueCompute SingleValueCompute => new SingleValue();
    }
}