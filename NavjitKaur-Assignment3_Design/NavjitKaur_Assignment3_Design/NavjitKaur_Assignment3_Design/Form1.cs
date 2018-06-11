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
        double number1, number2;
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
            label1.Text = "Result";
            label4.Text = "";
            label5.Text = "";
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
            //calculate = null;
            label5.Text = calculate.Operation();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = calculate.Operation();
                number1 = Convert.ToDouble(txtNumber1.Text.ToString());
                number2 = Convert.ToDouble(txtNumber2.Text.ToString());
                label1.Text = calculate.Operation() + " : " + calculate.Calculate(number1, number2);
                label4.Text = calculate.Operation();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values/Empty field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
