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
        double number1, number2,result;
        Calculator calculate;
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

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            calculate = new Calculator();
        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
            result = calculate.Add(number1,number2);
            MessageBox.Show("Addition result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripBtnSub_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
            result = calculate.Sub(number1, number2);
            MessageBox.Show("Subtraction result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripBtnMul_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
            result = calculate.Mul(number1, number2);
            MessageBox.Show("Multiplication result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripBtnDiv_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text.ToString());
            number2 = Convert.ToDouble(txtNumber2.Text.ToString());
            result = calculate.Div(number1, number2);
            MessageBox.Show("Division result : " + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
