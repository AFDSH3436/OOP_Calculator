using CalculatorOperations.Operations.Interfaces;
using System;

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