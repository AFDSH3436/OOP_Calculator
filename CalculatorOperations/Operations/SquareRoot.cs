using CalculatorOperations.Operations.Interfaces;
using System;

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