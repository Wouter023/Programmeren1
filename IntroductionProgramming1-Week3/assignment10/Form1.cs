using System.Globalization;

namespace assignment10
{
    public partial class Form1 : Form
    {
        const double basePrice = 12;
        double price = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatePriceButton_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            int age = int.Parse(ageTextBox.Text);

            if(age < 5)
            {
                price = basePrice - 12;
            }
            else if(age >= 5 && age <= 12)
            {
                price = basePrice / 2;
            }
            else if(age >= 13 && age <= 54)
            {
                price = basePrice;
            }
            else if(age > 55)
            {
                price = basePrice - 12;
            }

            priceOutputLabel.Text = $"€ {price:0.00}";
        }
    }
}