namespace CalculatorUI
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.CalculatorDisplay = new System.Windows.Forms.TextBox();
            this.TempDisplay = new System.Windows.Forms.Label();
            this.SineKey = new System.Windows.Forms.Button();
            this.CosKey = new System.Windows.Forms.Button();
            this.TanKey = new System.Windows.Forms.Button();
            this.PowerKey = new System.Windows.Forms.Button();
            this.NegatorKey = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.ModulusKey = new System.Windows.Forms.Button();
            this.NumKeySeven = new System.Windows.Forms.Button();
            this.NumKeyEight = new System.Windows.Forms.Button();
            this.NumKeyNine = new System.Windows.Forms.Button();
            this.DivisionKey = new System.Windows.Forms.Button();
            this.NumKeyFour = new System.Windows.Forms.Button();
            this.NumKeyFive = new System.Windows.Forms.Button();
            this.NumKeySix = new System.Windows.Forms.Button();
            this.MultiplicationKey = new System.Windows.Forms.Button();
            this.NumKeyOne = new System.Windows.Forms.Button();
            this.NumKeyTwo = new System.Windows.Forms.Button();
            this.NumKeyThree = new System.Windows.Forms.Button();
            this.SubtractionKey = new System.Windows.Forms.Button();
            this.NumKeyZero = new System.Windows.Forms.Button();
            this.NumKeyDot = new System.Windows.Forms.Button();
            this.EqualsKey = new System.Windows.Forms.Button();
            this.AdditionKey = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CalculatorDisplay
            // 
            this.CalculatorDisplay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CalculatorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalculatorDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalculatorDisplay.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorDisplay.Location = new System.Drawing.Point(12, 50);
            this.CalculatorDisplay.Name = "CalculatorDisplay";
            this.CalculatorDisplay.ReadOnly = true;
            this.CalculatorDisplay.Size = new System.Drawing.Size(448, 107);
            this.CalculatorDisplay.TabIndex = 0;
            this.CalculatorDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.SetToolTip(this.CalculatorDisplay, "Display");
            // 
            // TempDisplay
            // 
            this.TempDisplay.AutoSize = true;
            this.TempDisplay.Location = new System.Drawing.Point(12, 9);
            this.TempDisplay.Name = "TempDisplay";
            this.TempDisplay.Size = new System.Drawing.Size(0, 38);
            this.TempDisplay.TabIndex = 3;
            // 
            // SineKey
            // 
            this.SineKey.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SineKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SineKey.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SineKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SineKey.Location = new System.Drawing.Point(12, 156);
            this.SineKey.Name = "SineKey";
            this.SineKey.Size = new System.Drawing.Size(106, 84);
            this.SineKey.TabIndex = 4;
            this.SineKey.Text = "⅟ ";
            this.Display.SetToolTip(this.SineKey, "Inverse");
            this.SineKey.UseVisualStyleBackColor = false;
            this.SineKey.Click += new System.EventHandler(this.SpecialKeys_Click);
            // 
            // CosKey
            // 
            this.CosKey.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CosKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CosKey.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CosKey.Location = new System.Drawing.Point(124, 156);
            this.CosKey.Name = "CosKey";
            this.CosKey.Size = new System.Drawing.Size(107, 84);
            this.CosKey.TabIndex = 4;
            this.CosKey.Text = "√";
            this.Display.SetToolTip(this.CosKey, "SquareRoot");
            this.CosKey.UseVisualStyleBackColor = false;
            this.CosKey.Click += new System.EventHandler(this.SpecialKeys_Click);
            // 
            // TanKey
            // 
            this.TanKey.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TanKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TanKey.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TanKey.Location = new System.Drawing.Point(237, 156);
            this.TanKey.Name = "TanKey";
            this.TanKey.Size = new System.Drawing.Size(104, 84);
            this.TanKey.TabIndex = 4;
            this.TanKey.Text = "^";
            this.Display.SetToolTip(this.TanKey, "Power");
            this.TanKey.UseVisualStyleBackColor = false;
            this.TanKey.Click += new System.EventHandler(this.OperationKey_click);
            // 
            // PowerKey
            // 
            this.PowerKey.BackColor = System.Drawing.Color.Crimson;
            this.PowerKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerKey.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PowerKey.Location = new System.Drawing.Point(347, 156);
            this.PowerKey.Name = "PowerKey";
            this.PowerKey.Size = new System.Drawing.Size(113, 84);
            this.PowerKey.TabIndex = 4;
            this.PowerKey.Text = "On";
            this.Display.SetToolTip(this.PowerKey, "Switch");
            this.PowerKey.UseVisualStyleBackColor = false;
            this.PowerKey.Click += new System.EventHandler(this.PowerKey_Click);
            // 
            // NegatorKey
            // 
            this.NegatorKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.NegatorKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NegatorKey.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegatorKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NegatorKey.Location = new System.Drawing.Point(12, 246);
            this.NegatorKey.Name = "NegatorKey";
            this.NegatorKey.Size = new System.Drawing.Size(106, 84);
            this.NegatorKey.TabIndex = 4;
            this.NegatorKey.Text = "±";
            this.Display.SetToolTip(this.NegatorKey, "Negator");
            this.NegatorKey.UseVisualStyleBackColor = false;
            this.NegatorKey.Click += new System.EventHandler(this.NegatorKey_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.DarkRed;
            this.Clear.Location = new System.Drawing.Point(124, 246);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(107, 84);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "C";
            this.Display.SetToolTip(this.Clear, "Clear");
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSpace.Font = new System.Drawing.Font("Wingdings", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BackSpace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackSpace.Location = new System.Drawing.Point(237, 246);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(104, 84);
            this.BackSpace.TabIndex = 4;
            this.BackSpace.Text = "";
            this.Display.SetToolTip(this.BackSpace, "BackSpace");
            this.BackSpace.UseVisualStyleBackColor = false;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // ModulusKey
            // 
            this.ModulusKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.ModulusKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModulusKey.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulusKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModulusKey.Location = new System.Drawing.Point(347, 246);
            this.ModulusKey.Name = "ModulusKey";
            this.ModulusKey.Size = new System.Drawing.Size(113, 84);
            this.ModulusKey.TabIndex = 4;
            this.ModulusKey.Text = "%";
            this.Display.SetToolTip(this.ModulusKey, "Modulus");
            this.ModulusKey.UseVisualStyleBackColor = false;
            this.ModulusKey.Click += new System.EventHandler(this.OperationKey_click);
            // 
            // NumKeySeven
            // 
            this.NumKeySeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeySeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeySeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeySeven.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeySeven.Location = new System.Drawing.Point(12, 336);
            this.NumKeySeven.Name = "NumKeySeven";
            this.NumKeySeven.Size = new System.Drawing.Size(106, 84);
            this.NumKeySeven.TabIndex = 4;
            this.NumKeySeven.Text = "7";
            this.Display.SetToolTip(this.NumKeySeven, "Seven");
            this.NumKeySeven.UseVisualStyleBackColor = true;
            this.NumKeySeven.Click += new System.EventHandler(this.NumericInput);
            // 
            // NumKeyEight
            // 
            this.NumKeyEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyEight.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyEight.Location = new System.Drawing.Point(124, 336);
            this.NumKeyEight.Name = "NumKeyEight";
            this.NumKeyEight.Size = new System.Drawing.Size(107, 84);
            this.NumKeyEight.TabIndex = 4;
            this.NumKeyEight.Text = "8";
            this.Display.SetToolTip(this.NumKeyEight, "Eight");
            this.NumKeyEight.UseVisualStyleBackColor = true;
            this.NumKeyEight.Click += new System.EventHandler(this.NumericInput);
            // 
            // NumKeyNine
            // 
            this.NumKeyNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyNine.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyNine.Location = new System.Drawing.Point(237, 336);
            this.NumKeyNine.Name = "NumKeyNine";
            this.NumKeyNine.Size = new System.Drawing.Size(104, 84);
            this.NumKeyNine.TabIndex = 4;
            this.NumKeyNine.Text = "9";
            this.Display.SetToolTip(this.NumKeyNine, "Nine");
            this.NumKeyNine.UseVisualStyleBackColor = true;
            this.NumKeyNine.Click += new System.EventHandler(this.NumericInput);
            // 
            // DivisionKey
            // 
            this.DivisionKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.DivisionKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionKey.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DivisionKey.Location = new System.Drawing.Point(347, 336);
            this.DivisionKey.Name = "DivisionKey";
            this.DivisionKey.Size = new System.Drawing.Size(113, 84);
            this.DivisionKey.TabIndex = 4;
            this.DivisionKey.Text = "÷";
            this.Display.SetToolTip(this.DivisionKey, "Division");
            this.DivisionKey.UseVisualStyleBackColor = false;
            this.DivisionKey.Click += new System.EventHandler(this.OperationKey_click);
            // 
            // NumKeyFour
            // 
            this.NumKeyFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyFour.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyFour.Location = new System.Drawing.Point(12, 426);
            this.NumKeyFour.Name = "NumKeyFour";
            this.NumKeyFour.Size = new System.Drawing.Size(106, 84);
            this.NumKeyFour.TabIndex = 4;
            this.NumKeyFour.Text = "4";
            this.Display.SetToolTip(this.NumKeyFour, "Four");
            this.NumKeyFour.UseVisualStyleBackColor = true;
            this.NumKeyFour.Click += new System.EventHandler(this.NumericInput);
            // 
            // NumKeyFive
            // 
            this.NumKeyFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyFive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyFive.Location = new System.Drawing.Point(124, 426);
            this.NumKeyFive.Name = "NumKeyFive";
            this.NumKeyFive.Size = new System.Drawing.Size(107, 84);
            this.NumKeyFive.TabIndex = 4;
            this.NumKeyFive.Text = "5";
            this.Display.SetToolTip(this.NumKeyFive, "Five");
            this.NumKeyFive.UseVisualStyleBackColor = true;
            this.NumKeyFive.Click += new System.EventHandler(this.NumericInput);
            // 
            // NumKeySix
            // 
            this.NumKeySix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeySix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeySix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeySix.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeySix.Location = new System.Drawing.Point(237, 426);
            this.NumKeySix.Name = "NumKeySix";
            this.NumKeySix.Size = new System.Drawing.Size(104, 84);
            this.NumKeySix.TabIndex = 4;
            this.NumKeySix.Text = "6";
            this.Display.SetToolTip(this.NumKeySix, "Six");
            this.NumKeySix.UseVisualStyleBackColor = true;
            this.NumKeySix.Click += new System.EventHandler(this.NumericInput);
            // 
            // MultiplicationKey
            // 
            this.MultiplicationKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.MultiplicationKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplicationKey.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MultiplicationKey.Location = new System.Drawing.Point(347, 426);
            this.MultiplicationKey.Name = "MultiplicationKey";
            this.MultiplicationKey.Size = new System.Drawing.Size(113, 84);
            this.MultiplicationKey.TabIndex = 4;
            this.MultiplicationKey.Text = "×";
            this.Display.SetToolTip(this.MultiplicationKey, "Multiplication");
            this.MultiplicationKey.UseVisualStyleBackColor = false;
            this.MultiplicationKey.Click += new System.EventHandler(this.OperationKey_click);
            // 
            // NumKeyOne
            // 
            this.NumKeyOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyOne.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyOne.Location = new System.Drawing.Point(12, 516);
            this.NumKeyOne.Name = "NumKeyOne";
            this.NumKeyOne.Size = new System.Drawing.Size(106, 84);
            this.NumKeyOne.TabIndex = 4;
            this.NumKeyOne.Text = "1";
            this.Display.SetToolTip(this.NumKeyOne, "One");
            this.NumKeyOne.UseVisualStyleBackColor = true;
            this.NumKeyOne.Click += new System.EventHandler(this.NumericInput);
            // 
            // NumKeyTwo
            // 
            this.NumKeyTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyTwo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyTwo.Location = new System.Drawing.Point(124, 516);
            this.NumKeyTwo.Name = "NumKeyTwo";
            this.NumKeyTwo.Size = new System.Drawing.Size(107, 84);
            this.NumKeyTwo.TabIndex = 4;
            this.NumKeyTwo.Text = "2";
            this.Display.SetToolTip(this.NumKeyTwo, "Two");
            this.NumKeyTwo.UseVisualStyleBackColor = true;
            this.NumKeyTwo.Click += new System.EventHandler(this.NumericInput);
            // 
            // NumKeyThree
            // 
            this.NumKeyThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyThree.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyThree.Location = new System.Drawing.Point(237, 516);
            this.NumKeyThree.Name = "NumKeyThree";
            this.NumKeyThree.Size = new System.Drawing.Size(104, 84);
            this.NumKeyThree.TabIndex = 4;
            this.NumKeyThree.Text = "3";
            this.Display.SetToolTip(this.NumKeyThree, "Three");
            this.NumKeyThree.UseVisualStyleBackColor = true;
            this.NumKeyThree.Click += new System.EventHandler(this.NumericInput);
            // 
            // SubtractionKey
            // 
            this.SubtractionKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.SubtractionKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractionKey.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubtractionKey.Location = new System.Drawing.Point(347, 516);
            this.SubtractionKey.Name = "SubtractionKey";
            this.SubtractionKey.Size = new System.Drawing.Size(113, 84);
            this.SubtractionKey.TabIndex = 4;
            this.SubtractionKey.Text = "-";
            this.Display.SetToolTip(this.SubtractionKey, "Subtraction");
            this.SubtractionKey.UseVisualStyleBackColor = false;
            this.SubtractionKey.Click += new System.EventHandler(this.OperationKey_click);
            // 
            // NumKeyZero
            // 
            this.NumKeyZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyZero.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyZero.Location = new System.Drawing.Point(12, 606);
            this.NumKeyZero.Name = "NumKeyZero";
            this.NumKeyZero.Size = new System.Drawing.Size(106, 84);
            this.NumKeyZero.TabIndex = 4;
            this.NumKeyZero.Text = "0";
            this.Display.SetToolTip(this.NumKeyZero, "Zero");
            this.NumKeyZero.UseVisualStyleBackColor = true;
            this.NumKeyZero.Click += new System.EventHandler(this.NumericInput);
            // 
            // NumKeyDot
            // 
            this.NumKeyDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumKeyDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NumKeyDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKeyDot.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKeyDot.Location = new System.Drawing.Point(124, 606);
            this.NumKeyDot.Name = "NumKeyDot";
            this.NumKeyDot.Size = new System.Drawing.Size(107, 84);
            this.NumKeyDot.TabIndex = 4;
            this.NumKeyDot.Text = ",";
            this.Display.SetToolTip(this.NumKeyDot, "Point");
            this.NumKeyDot.UseVisualStyleBackColor = true;
            this.NumKeyDot.Click += new System.EventHandler(this.NumericInput);
            // 
            // EqualsKey
            // 
            this.EqualsKey.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.EqualsKey.FlatAppearance.BorderSize = 2;
            this.EqualsKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EqualsKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsKey.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsKey.Location = new System.Drawing.Point(237, 606);
            this.EqualsKey.Name = "EqualsKey";
            this.EqualsKey.Size = new System.Drawing.Size(104, 84);
            this.EqualsKey.TabIndex = 4;
            this.EqualsKey.Text = "=";
            this.Display.SetToolTip(this.EqualsKey, "Equals");
            this.EqualsKey.UseVisualStyleBackColor = true;
            this.EqualsKey.Click += new System.EventHandler(this.EqualsKey_Click);
            // 
            // AdditionKey
            // 
            this.AdditionKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.AdditionKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdditionKey.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdditionKey.Location = new System.Drawing.Point(347, 606);
            this.AdditionKey.Name = "AdditionKey";
            this.AdditionKey.Size = new System.Drawing.Size(113, 84);
            this.AdditionKey.TabIndex = 4;
            this.AdditionKey.Text = "+";
            this.Display.SetToolTip(this.AdditionKey, "Addition");
            this.AdditionKey.UseVisualStyleBackColor = false;
            this.AdditionKey.Click += new System.EventHandler(this.OperationKey_click);
            // 
            // Calculator
            // 
            this.AccessibleDescription = "The main window housing calculator controls";
            this.AccessibleName = "CalculatorWindow";
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 696);
            this.Controls.Add(this.AdditionKey);
            this.Controls.Add(this.SubtractionKey);
            this.Controls.Add(this.EqualsKey);
            this.Controls.Add(this.NumKeyThree);
            this.Controls.Add(this.MultiplicationKey);
            this.Controls.Add(this.NumKeySix);
            this.Controls.Add(this.DivisionKey);
            this.Controls.Add(this.NumKeyNine);
            this.Controls.Add(this.NumKeyDot);
            this.Controls.Add(this.NumKeyTwo);
            this.Controls.Add(this.ModulusKey);
            this.Controls.Add(this.NumKeyFive);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.NumKeyZero);
            this.Controls.Add(this.NumKeyEight);
            this.Controls.Add(this.NumKeyOne);
            this.Controls.Add(this.PowerKey);
            this.Controls.Add(this.NumKeyFour);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NumKeySeven);
            this.Controls.Add(this.TanKey);
            this.Controls.Add(this.NegatorKey);
            this.Controls.Add(this.CosKey);
            this.Controls.Add(this.SineKey);
            this.Controls.Add(this.TempDisplay);
            this.Controls.Add(this.CalculatorDisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(490, 743);
            this.MinimumSize = new System.Drawing.Size(490, 743);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculatorDisplay;
        private System.Windows.Forms.Label TempDisplay;
        private System.Windows.Forms.Button SineKey;
        private System.Windows.Forms.Button CosKey;
        private System.Windows.Forms.Button TanKey;
        private System.Windows.Forms.Button PowerKey;
        private System.Windows.Forms.Button NegatorKey;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button ModulusKey;
        private System.Windows.Forms.Button NumKeySeven;
        private System.Windows.Forms.Button NumKeyEight;
        private System.Windows.Forms.Button NumKeyNine;
        private System.Windows.Forms.Button DivisionKey;
        private System.Windows.Forms.Button NumKeyFour;
        private System.Windows.Forms.Button NumKeyFive;
        private System.Windows.Forms.Button NumKeySix;
        private System.Windows.Forms.Button MultiplicationKey;
        private System.Windows.Forms.Button NumKeyOne;
        private System.Windows.Forms.Button NumKeyTwo;
        private System.Windows.Forms.Button NumKeyThree;
        private System.Windows.Forms.Button SubtractionKey;
        private System.Windows.Forms.Button NumKeyZero;
        private System.Windows.Forms.Button NumKeyDot;
        private System.Windows.Forms.Button EqualsKey;
        private System.Windows.Forms.Button AdditionKey;
        private System.Windows.Forms.ToolTip Display;
    }
}

