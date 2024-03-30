using System.Globalization;

namespace Opgave5
{
    public partial class Form1 : Form
    {
        const double SecondKlassePrice = 53.00;
        const double FirstKlassePrice = 87.46;
        const double RailrunnerPrice = 2.50;
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

            //check if tweedeklasse or firstklasse is selected
            string klasse = "";
            if(tweedeKlasseRadioButton.Checked == true)
            {
                klasse += $"tweede";
            }
            else if(eersteKlasseRadioButton.Checked == true)
            {
                klasse += $"eerste";
            }

            //get userinput
            int amountOfRailrunners = int.Parse(railrunnerInputTextbox.Text);
            int amountOfTickets = int.Parse(aantalInputTextbox.Text);

            double totalPrice = CalculatePrice(amountOfTickets, amountOfRailrunners, klasse);

            //print output
            priceOutputTextBox.Text = $"{totalPrice:0.00}";
            priceOutputTextBox.Enabled = false;
        }

        static double CalculatePrice(int amountOfTickets, int amountOfRailrunners, string klasse)
        {
            double totalPrice = 0;

            if(klasse == "eerst")
            {
                totalPrice += ((double)amountOfRailrunners * RailrunnerPrice) + ((double)amountOfTickets * FirstKlassePrice);
            }
            else if(klasse == "tweede")
            {
                totalPrice += ((double)amountOfRailrunners * RailrunnerPrice) + ((double)amountOfTickets * SecondKlassePrice);
            }

            return totalPrice;
        }
    }
}