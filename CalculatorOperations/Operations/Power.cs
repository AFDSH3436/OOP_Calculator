using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class Power : IDoubleValueOperation
    {
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return (decimal)Math.Pow((double)firstValue, (double)secondValue);
        }
    }
}