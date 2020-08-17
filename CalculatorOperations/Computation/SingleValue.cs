using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOperations.Operations;

namespace CalculatorOperations.Computation
{
    public class SingleValue : ICompute
    {
        public decimal Value { get; }
        public OperationType Type { get; }

        public SingleValue(decimal value, OperationType type)
        {
            Value = value;
            Type = type;
        }

        public static decimal ComputeIt(decimal value, OperationType type)
        {
            decimal valueToReturn;
            switch (type)
            {
                case OperationType.Sine:
                    valueToReturn = Sine.Execute(value);
                    break;

                case OperationType.Cosine:
                    valueToReturn = Cosine.Execute(value);
                    break;

                case OperationType.Tangent:
                    valueToReturn = Tangent.Execute(value);
                    break;

                case OperationType.SquareRoot:
                    valueToReturn = (decimal)Math.Sqrt((double)value);//.ToString(CultureInfo.InvariantCulture);
                    break;

                default:
                    valueToReturn = 0;
                    break;
            }

            return valueToReturn;
        }

        public decimal ComputeIt()
        {
            return ComputeIt(Value, Type);
        }
    }
}