using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavjitKaur_Assignment3_Design
{
    public partial class FrmCalculator : Form
    {
        double number1, number2, result;
        Calculator calculate = new Calculator(new Add());
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripBtnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber1.Text = "Enter first number";
            txtNumber2.Clear();
            txtNumber2.Text = "Enter second number";
        }

        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            txtNumber1.Clear();
        }

        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            txtNumber2.Clear();
        }

        private RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton radiobtn = GetCheckedRadio(groupBox);
                if (radiobtn != null)
                {
                    if(radiobtn.Text.Equals("Add"))
                    {
                        try
                        {
                            
                            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
                            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
                            calculate = new Calculator(new Add());
                            result = calculate.Calculate(number1, number2);
                            MessageBox.Show("Addition result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid values/Empty field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (radiobtn.Text.Equals("Subtract"))
                    {
                        try
                        {
                            
                            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
                            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
                            calculate = new Calculator(new Subtract());
                            result = calculate.Calculate(number1, number2);
                            MessageBox.Show("Subtraction result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid values/Empty field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if(radiobtn.Text.Equals("Multiply"))
                    {
                        try
                        {
                            
                            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
                            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
                            calculate = new Calculator(new Multiply());
                            result = calculate.Calculate(number1, number2);
                            MessageBox.Show("Multiplication result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid values/Empty field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if(radiobtn.Text.Equals("Divide"))
                    {
                        try
                        {
                            
                            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
                            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
                            calculate = new Calculator(new Divide());
                            result = calculate.Calculate(number1, number2);
                            MessageBox.Show("Division result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid values/Empty field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    throw new Exception("Please select an operation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
