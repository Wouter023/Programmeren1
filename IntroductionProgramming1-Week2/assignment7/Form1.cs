using System.Globalization;

namespace assignment7
{
    public partial class Form1 : Form
    {
        const double VatRate = 0.21;

        public Form1()
        {
            InitializeComponent();

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Get user input
            double startKm = double.Parse(startKmInputTextBox.Text);
            double endKm = double.Parse(endKmInputTextBox.Text);
            double pricePerKm = double.Parse(pricePerKmInputTextBox.Text);

            //Calculate prices
            double priceExVat = (endKm - startKm) * pricePerKm;
            double vatPrice = priceExVat * VatRate;
            double priceInclVat = priceExVat + vatPrice;

            //Show prices
            outputPriceExVat.Text = priceExVat.ToString("C2");
            outputVatPrice.Text = vatPrice.ToString("C2");
            outputPriceInVat.Text = priceInclVat.ToString("C2");
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            startKmInputTextBox.Text = "";
            endKmInputTextBox.Text = "";
            pricePerKmInputTextBox.Text = "";

            outputPriceExVat.Text = "";
            endKmInputTextBox.Text = "";
            pricePerKmInputTextBox.Text = "";
        }
    }
}