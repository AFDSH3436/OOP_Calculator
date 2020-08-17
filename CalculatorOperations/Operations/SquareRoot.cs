using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SquareRoot : ISingleValueOperation
    {
        public decimal Execute(decimal value)
        {
            return (decimal)Math.Sqrt((double)value);
        }
    }
}