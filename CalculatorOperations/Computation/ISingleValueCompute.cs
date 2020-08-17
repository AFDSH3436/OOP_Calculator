using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations.Computation
{
    public interface ISingleValueCompute
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public decimal ComputeIt(decimal value, OperationType type);
    }
}