using System;
using System.Windows;
using System.Windows.Documents;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal costOfVehicle = decimal.Parse(txtCostOfVehicle.Text);
                decimal downPayment = decimal.Parse(txtDownPayment.Text);
                int numberOfMonths = int.Parse(txtNumberOfMonths.Text);
                decimal annualInterestRate = (rbNew.IsChecked == true) ? 8.90m : 9.90m;

                decimal loanAmount = (costOfVehicle - downPayment) * numberOfMonths / 12 * annualInterestRate / 100;
                decimal principlePayments = loanAmount / numberOfMonths;

                DisplayLoanPayments(principlePayments);

                txtInterestRate.Text = annualInterestRate.ToString("0.00") + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DisplayLoanPayments(decimal principlePayments)
        {
            rtbLoanPayments.Document.Blocks.Clear();

            Paragraph paragraph = new Paragraph();

            for (int i = 1; i <= int.Parse(txtNumberOfMonths.Text); i++)
            {
                paragraph.Inlines.Add($"Month {i}:\r\n");
                paragraph.Inlines.Add($"Principle Payment: {principlePayments:C}\r\n");
                paragraph.Inlines.Add("--------------------------\r\n");
            }

            rtbLoanPayments.Document.Blocks.Add(paragraph);
        }

        private void rbNew_Checked(object sender, RoutedEventArgs e)
        {
            txtInterestRate.Text = "8.90%";
        }

        private void rbUsed_Checked(object sender, RoutedEventArgs e)
        {
            txtInterestRate.Text = "9.90%";
        }
    }
}
