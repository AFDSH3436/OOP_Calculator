using CalculatorOperations.Computation;
using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application...
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDoubleValueCompute doubleVal = new DoubleValue();
            ISingleValueCompute singleVal = new SingleValue();
            Application.Run(new Calculator(doubleVal, singleVal));
        }
    }
}