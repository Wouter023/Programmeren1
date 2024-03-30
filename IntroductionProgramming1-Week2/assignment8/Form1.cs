namespace assignment8
{
    public partial class Form1 : Form
    {
        const double vatRate = 0.21;
        const double shirtPricePerPiece = 30.00;
        const double jeansPricePerPiece = 100.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Get and display time
            DateTime dateTime = DateTime.Now;
            dateDisplayLabel.Text = $"{dateTime}";

            //Get user input
            string inputNumberOfShirts = inputShirtsAmount.Text;
            string inputNumberOfJeans = inputJeansAmount.Text;

            //Convert to int
            double shirtsAmount = double.Parse(inputNumberOfShirts);
            double jeansAmount = double.Parse(inputNumberOfJeans);

            //Calculate prices
            double priceExVatRate = (shirtPricePerPiece * shirtsAmount) + (jeansPricePerPiece * jeansAmount);
            double vatPrice = priceExVatRate * vatRate;
            double priceInclVatRate = priceExVatRate + vatPrice;

            //Display prices
            priceDisplayLabel.Text = $"€ {priceExVatRate:0.00}";
            vatDisplayLabel.Text = $"€ {vatPrice:0.00}";
            totalDisplayLabel.Text = $"€ {priceInclVatRate:0.00}";
        }
    }
}