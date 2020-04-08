using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string Operation;
        double FirstNum, SecondNum;
        bool FirstNumberEntered, SecondNumberEntered;

        Calculation Calc = new Calculation();

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operation = comboBoxOperation.SelectedItem.ToString();

            if (FirstNumberEntered && SecondNumberEntered)
            {
                ExecuteOperation();
            }
        }

        private void maskedTextBoxFirstNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FirstNum = Convert.ToDouble(maskedTextBoxFirstNumber.Text);
            }
            catch
            {
                LabelResult.Text = "ERROR! Неверный формат 1-го числа!";
                FirstNumberEntered = false;
                return;
            }

            FirstNumberEntered = true;

            if ((Operation == "") || !SecondNumberEntered)
            {
                return;
            }
            else
            {
                ExecuteOperation();
            }
        }

        private void maskedTextBoxSecondNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SecondNum = Convert.ToDouble(maskedTextBoxSecondNumber.Text);
            }
            catch
            {
                LabelResult.Text = "ERROR! Неверный формат 2-го числа!";
                SecondNumberEntered = false;
                return;
            }

            SecondNumberEntered = true;

            if ((Operation == "") || !SecondNumberEntered)
            {
                return;
            }
            else
            {
                ExecuteOperation();
            }
        }

        private void ExecuteOperation()
        {
            switch (Operation)
            {
                case "+":
                    LabelResult.Text = Calculation.Summin(FirstNum, SecondNum).ToString();
                    break;

                case "-":
                    LabelResult.Text = Calculation.Subtraction(FirstNum, SecondNum).ToString();
                    break;

                case "*":
                    LabelResult.Text = Calculation.Multiplication(FirstNum, SecondNum).ToString();
                    break;

                case "/":
                    LabelResult.Text = Calculation.Division(FirstNum, SecondNum);
                    break;

                default:
                    break;
            }
        }

        
}
}
