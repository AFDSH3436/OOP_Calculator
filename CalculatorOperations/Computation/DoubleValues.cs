using System;
using CalculatorOperations.Operations;
using System.Globalization;

namespace CalculatorOperations.Computation
{
    /// <summary>
    /// A class that computes and outputs user inputs
    /// </summary>
    public class DoubleValues : ICompute
    {
        public decimal FirstValue { get; }
        public decimal SecondValue { get; }
        public OperationType Type { get; }

        public DoubleValues(decimal firstValue, decimal secondValue, OperationType type)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            Type = type;
        }

        /// <summary>
        /// Computes and return the values passed to it based on the operation type
        /// </summary>
        /// <param name="firstValue">first value to compute</param>
        /// <param name="secondValue">second value to compute</param>
        /// <param name="type">the type of operation to carryout</param>
        /// <returns>the returned result</returns>
        public static decimal ComputeIt(decimal firstValue, decimal secondValue, OperationType type)
        {
            decimal value;
            switch (type)
            {
                case OperationType.Addition:
                    value = Addition.Execute(firstValue, secondValue);//.ToString(CultureInfo.InvariantCulture);
                    break;

                case OperationType.Subtraction:
                    value = Subtraction.Execute(firstValue, secondValue);//.ToString(CultureInfo.InvariantCulture);
                    break;

                case OperationType.Multiplication:
                    value = Multiplication.Execute(firstValue, secondValue);//.ToString(CultureInfo.InvariantCulture);
                    break;

                case OperationType.Division:
                    value = Division.Execute(firstValue, secondValue);//.ToString(CultureInfo.InvariantCulture);
                    break;

                case OperationType.Modulus:
                    value = Modulus.Execute(firstValue, secondValue);//.ToString(CultureInfo.InvariantCulture);
                    break;

                case OperationType.Power:
                    value = (decimal)Math.Pow((double)firstValue, (double)secondValue);//.ToString(CultureInfo.InvariantCulture);
                    break;

                default:
                    value = 0;
                    break;
            }

            return value;
        }

        public decimal ComputeIt()
        {
            return ComputeIt(FirstValue, SecondValue, Type);
        }
    }
}