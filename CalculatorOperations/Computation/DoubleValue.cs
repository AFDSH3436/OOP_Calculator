using System;
using CalculatorOperations.Operations;
using System.Globalization;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Computation
{
    /// <summary>
    /// A class that computes and outputs user inputs
    /// </summary>
    public class DoubleValue : ICompute
    {
        //public decimal FirstValue { get; set; }
        //public decimal SecondValue { get; set; }
        //public OperationType Type { get; set; }
        private IDoubleValueOperation _operation;

        public DoubleValue(/*decimal firstValue, decimal secondValue, OperationType type*/)
        {
            //FirstValue = firstValue;
            //SecondValue = secondValue;
            //Type = type;
        }

        /// <summary>
        /// Computes and return the values passed to it based on the operation type
        /// </summary>
        /// <param name="firstValue">first value to compute</param>
        /// <param name="secondValue">second value to compute</param>
        /// <param name="type">the type of operation to carryout</param>
        /// <returns>the returned result</returns>
        public decimal ComputeIt(decimal firstValue, decimal secondValue, OperationType type)
        {
            decimal value;
            switch (type)
            {
                case OperationType.Addition:
                    _operation = new Addition();
                    value = _operation.Execute(firstValue, secondValue);
                    break;

                case OperationType.Subtraction:
                    _operation = new Subtraction();
                    value = _operation.Execute(firstValue, secondValue);
                    break;

                case OperationType.Multiplication:
                    _operation = new Multiplication();
                    value = _operation.Execute(firstValue, secondValue);
                    break;

                case OperationType.Division:
                    _operation = new Division();
                    value = _operation.Execute(firstValue, secondValue);
                    break;

                case OperationType.Modulus:
                    _operation = new Modulus();
                    value = _operation.Execute(firstValue, secondValue);
                    break;

                case OperationType.Power:
                    _operation = new Power();
                    value = _operation.Execute(firstValue, secondValue);
                    break;

                default:
                    value = 0;
                    break;
            }

            return value;
        }
    }
}