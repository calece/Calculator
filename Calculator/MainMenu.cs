using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainMenu : Form
    {
        List<CheckBox> operatorSelectors = new List<CheckBox>();
        delegate double Operand(double arg1, double arg2);
        Dictionary<object, Operand> operators = new Dictionary<object, Operand>();

        public MainMenu()
        {
            InitializeComponent();
            foreach (CheckBox checkBox in operatorLayoutPanel.Controls.OfType<CheckBox>())
            {
                operatorSelectors.Add(checkBox);
                Operand operand;
                switch (checkBox.Name)
                {
                    case "addCheckBox":
                        operand = Calculator.Add;
                        operators.Add(checkBox, operand);
                        break;
                    case "subCheckBox":
                        operand = Calculator.Subtract;
                        operators.Add(checkBox, operand);
                        break;
                    case "multCheckBox":
                        operand = Calculator.Multiply;
                        operators.Add(checkBox, operand);
                        break;
                    case "divCheckBox":
                        operand = Calculator.Divide;
                        operators.Add(checkBox, operand);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ArgInputEntered(object sender, EventArgs e)
        {
            //This method will prevent the cursor from being positioned in the middle 
            //of a textbox when the user clicks in it.
            MaskedTextBox textBox = sender as MaskedTextBox;

            if (textBox != null)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    int pos = textBox.SelectionStart;
                    if (pos > textBox.Text.Length)
                        pos = textBox.Text.Length;

                    textBox.Select(pos, 0);
                });
            }
        }

        private void OperatorSelectionChanged(object sender, EventArgs e)

        {
            foreach (CheckBox checkBox in operatorSelectors.Where(x => x != sender))
            {
                checkBox.CheckState = CheckState.Unchecked;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Operand operand = operators[operatorLayoutPanel.Controls.OfType<CheckBox>().FirstOrDefault(x => x.Checked == true)];
            double arg1 = Convert.ToDouble(arg1Input.Text);
            double arg2 = Convert.ToDouble(arg2Input.Text);
            double result = operand(arg1, arg2);
            resultLabel.Text = "= " + result.ToString();
        }
    }
}
