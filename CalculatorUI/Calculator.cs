using CalculatorOperations.Computation;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class Calculator : Form
    {
        private OperationType _type;
        private bool _power = false;
        private string _theInputs = "";
        private decimal _firstValue = 0;
        private decimal _secondValue = 0;
        private readonly IDoubleValueCompute _computeDoubleValue;
        private readonly ISingleValueCompute _computeSingleValue;
        private bool _pressedEqual = false;

        public Calculator(IDoubleValueCompute doubleVal, ISingleValueCompute singleVal)
        {
            InitializeComponent();
            Switch();
            _computeDoubleValue = doubleVal;
            _computeSingleValue = singleVal;
        }

        #region Helper Methods

        /// <summary>
        /// A method that adds imputed digits to the display
        /// </summary>
        /// <param name="input">The digit to add</param>
        private void NumericalInput(string input)
        {
            if (_theInputs == string.Empty && CalculatorDisplay.Text.Length < 12)
            {
                CalculatorDisplay.Text = input;
                _theInputs += input;
            }
            else
            {
                if (CalculatorDisplay.Text.Length < 12)
                {
                    CalculatorDisplay.Text = CalculatorDisplay.Text + input;
                    _theInputs += input;
                }
            }
        }

        /// <summary>
        /// Wipes/resets all data inputs
        /// </summary>
        private void WipeAll()
        {
            _type = OperationType.Null;
            CalculatorDisplay.Text = "0,";
            TempDisplay.Text = string.Empty;
            _firstValue = _secondValue = 0;
            _theInputs = string.Empty;
            _pressedEqual = false;
        }

        /// <summary>
        /// A method that handles the switching of the Calculator Controls On/Off
        /// </summary>
        private void Switch()
        {
            TempDisplay.Enabled = CalculatorDisplay.Enabled = NumKeyDot.Enabled = NumKeyZero.Enabled =
                NumKeyOne.Enabled = NumKeyTwo.Enabled = NumKeyThree.Enabled = NumKeyFour.Enabled =
                    NumKeyFive.Enabled = NumKeySix.Enabled = NumKeySeven.Enabled = NumKeyEight.Enabled =
                        NumKeyNine.Enabled = EqualsKey.Enabled = AdditionKey.Enabled = SubtractionKey.Enabled =
                            MultiplicationKey.Enabled = DivisionKey.Enabled = ModulusKey.Enabled =
                                BackSpace.Enabled = Clear.Enabled = NegatorKey.Enabled = SineKey.Enabled =
                                    CosKey.Enabled = TanKey.Enabled = _power;
        }

        /// <summary>
        /// handles different maths operations (+, -, *, /)
        /// </summary>
        /// <param name="sign">A sign representation of the operation</param>
        private void Operation(string sign)
        {
            if (_pressedEqual)
            {
                CalculatorDisplay.Text = "0,";
                _pressedEqual = false;
                TempDisplay.Text = _firstValue + "(" + sign + ")";
                //_type = OperationType.Null;
            }

            if (_firstValue != 0 && _type != OperationType.Null && CalculatorDisplay.Text != "0,")
            {
                try
                {
                    _firstValue = _computeDoubleValue.ComputeIt(_firstValue, decimal.Parse(CalculatorDisplay.Text), _type);
                    TempDisplay.Text = _firstValue + "(" + sign + ")";
                    CalculatorDisplay.Text = "0,";
                    return;
                }
                catch (Exception e)
                {
                    TempDisplay.Text = e.Message;
                }
            }

            if (CalculatorDisplay.Text != "0,")
            {
                _firstValue = decimal.Parse(CalculatorDisplay.Text);
                TempDisplay.Text = _firstValue + "(" + sign + ")";
                CalculatorDisplay.Text = "0,";
            }
        }

        #endregion Helper Methods

        /// <summary>
        /// A method that handles user numerical inputs
        /// </summary>
        /// <param name="sender">The button sending the event</param>
        /// <param name="e">The event sent</param>
        private void NumericInput(object sender, EventArgs e)
        {
            Button aButton = (Button)sender;
            if (aButton.Text == "." && CalculatorDisplay.Text.Contains(","))
            {
                return;
            }

            if (aButton.Text == "0" && CalculatorDisplay.Text == "0,")
            {
                return;
            }
            NumericalInput(aButton.Text);
        }

        /// <summary>
        /// Removes the last item on the display
        /// </summary>
        /// <param name="sender">Object of the event sender</param>
        /// <param name="e">The event being sent</param>
        private void BackSpace_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text.Length > 0 && !(CalculatorDisplay.Text == "0,"))
                CalculatorDisplay.Text = CalculatorDisplay.Text.Substring(0, CalculatorDisplay.Text.Length - 1);

            if (CalculatorDisplay.Text.Length < 1)
                CalculatorDisplay.Text = "0,";

            if (CalculatorDisplay.Text == "0,")
                _theInputs = string.Empty;
        }

        /// <summary>
        /// Wipes out the values on display
        /// </summary>
        /// <param name="sender">Object of the event sender</param>
        /// <param name="e">The event being sent</param>
        private void Clear_Click(object sender, EventArgs e)
        {
            WipeAll();
        }

        /// <summary>
        /// Switches controls On and Off
        /// </summary>
        /// <param name="sender">Object of the event sender</param>
        /// <param name="e">The event being sent</param>
        private void PowerKey_Click(object sender, EventArgs e)
        {
            //_power ^= true;
            _power = !_power;

            if (_power)
            {
                PowerKey.Text = "Off";
                CalculatorDisplay.Text = "0,";
            }
            else
            {
                WipeAll();
                PowerKey.Text = "On";
                CalculatorDisplay.Text = string.Empty;
            }

            Switch();
        }

        /// <summary>
        /// Handles the click event for all the operator buttons
        /// </summary>
        /// <param name="sender">Object of the event sender</param>
        /// <param name="e">The event being sent</param>
        private void OperationKey_click(object sender, EventArgs e)
        {
            _theInputs = string.Empty;
            var senderBtn = (Button)sender;
            switch (senderBtn.Text)
            {
                case "+":
                    _type = OperationType.Addition;
                    Operation("+");
                    break;

                case "-":
                    _type = OperationType.Subtraction;
                    Operation("-");
                    break;

                case "×":
                    _type = OperationType.Multiplication;
                    Operation("×");
                    break;

                case "÷":
                    _type = OperationType.Division;
                    Operation("÷");
                    break;

                case "%":
                    _type = OperationType.Modulus;
                    Operation("%");
                    break;

                case "^":
                    _type = OperationType.Power;
                    Operation("^");
                    break;
            }
        }

        /// <summary>
        /// Adds and removes negative sign at the front of the display digit
        /// </summary>
        /// <param name="sender">Object of the event sender</param>
        /// <param name="e">The event being sent</param>
        private void NegatorKey_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text.Contains("-"))
            {
                CalculatorDisplay.Text = CalculatorDisplay.Text.Remove(0, 1);
            }
            else
            {
                CalculatorDisplay.Text = "-" + CalculatorDisplay.Text;
            }
        }

        /// <summary>
        /// Computes the the calculations of special operations
        /// </summary>
        /// <param name="sender">Object of the event sender</param>
        /// <param name="e">The event being sent</param>
        private void SpecialKeys_Click(object sender, EventArgs e)
        {
            Button theSender = (Button)sender;
            switch (theSender.Text)
            {
                case "⅟ ":
                    _type = OperationType.Inverse;
                    break;

                case "√":
                    _type = OperationType.SquareRoot;
                    break;
            }
            _theInputs = string.Empty;
            try
            {
                CalculatorDisplay.Text = _computeSingleValue.ComputeIt(decimal.Parse(CalculatorDisplay.Text), _type).ToString(CultureInfo.InvariantCulture);
                TempDisplay.Text = CalculatorDisplay.Text;
            }
            catch (Exception exception)
            {
                TempDisplay.Text = @"Error! " + exception.Message;
            }
        }

        /// <summary>
        /// Computes the Equal of the value on display
        /// </summary>
        /// <param name="sender">Object of the event sender</param>
        /// <param name="e">The event being sent</param>
        private void EqualsKey_Click(object sender, EventArgs e)
        {
            _theInputs = string.Empty;
            if (_type == OperationType.Null)
            {
                return;
            }
            if (!_pressedEqual)
            {
                _secondValue = decimal.Parse(CalculatorDisplay.Text);
            }

            try
            {
                _pressedEqual = true;
                _firstValue = _computeDoubleValue.ComputeIt(_firstValue, _secondValue, _type);
                CalculatorDisplay.Text = _firstValue.ToString(CultureInfo.InvariantCulture);
                //ShallowWipe();
                TempDisplay.Text = CalculatorDisplay.Text;
            }
            catch (Exception exception)
            {
                WipeAll();
                TempDisplay.Text = "Error! " + exception.Message;
            }
        }
    }
}