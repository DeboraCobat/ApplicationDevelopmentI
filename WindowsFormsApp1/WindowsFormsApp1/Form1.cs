using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal costOfVehicle = decimal.Parse(textBox1.Text);
                decimal downPayment = decimal.Parse(textBox2.Text);
                int numberOfMonths = int.Parse(textBox3.Text);
                decimal annualInterestRate = (radioButton1.Checked) ? 8.90m : 9.90m;

                decimal loanAmount = (costOfVehicle - downPayment);
                decimal monthlyInterestRate = annualInterestRate / 12 / 100;
                decimal principlePayments = loanAmount / numberOfMonths;

                List<decimal> monthlyInterest = new List<decimal>();
                List<decimal> totalPayment = new List<decimal>();
                List<decimal> totalInterest = new List<decimal>();

                decimal remainingBalance = loanAmount;
                for (int i = 0; i < numberOfMonths; i++)
                {
                    decimal interest = remainingBalance * monthlyInterestRate;
                    monthlyInterest.Add(interest);
                    decimal payment = principlePayments + interest;
                    totalPayment.Add(payment);
                    totalInterest.Add(interest);
                    remainingBalance -= principlePayments;
                }

                richTextBox1.Text = "";
                for (int i = 0; i < numberOfMonths; i++)
                {
                    richTextBox1.Text += $"Month {i + 1}: \r\n";
                    richTextBox1.Text += $"Principle Payment: {principlePayments:C}\r\n";
                    richTextBox1.Text += $"Interest Payment: {monthlyInterest[i]:C}\r\n";
                    richTextBox1.Text += $"Total Payment: {totalPayment[i]:C}\r\n";
                    richTextBox1.Text += $"Total Interest: {totalInterest[i]:C}\r\n";
                    richTextBox1.Text += "--------------------------\r\n";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox4.Text = "8.90%";
            }
            else
            {
                textBox4.Text = "9.90%";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
