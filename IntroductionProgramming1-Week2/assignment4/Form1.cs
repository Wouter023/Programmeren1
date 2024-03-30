using System;
using System.Globalization;
using System.Threading;


namespace assignment4
{
    public partial class Form1 : Form
    {
        const double vatRate = 0.21;

        public Form1()
        {
            InitializeComponent();

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
        }

        private void calculatePriceButton_Click(object sender, EventArgs e)
        {
            //Read user input
            string input = userPriceInput.Text;

            //Convert string to int
            double normalPrice = double.Parse(input);

            //Calculate vat and price
            double vatPrice = normalPrice * vatRate;
            double totalPrice = normalPrice + vatPrice;

            //Print to user
            outputPriceLabel.Text = $"{normalPrice:0.00}";
            outputVatLabel.Text = $"{vatPrice:0.00}";
            outputTotalLabel.Text = $"{totalPrice:0.00}";
        }
    }
}