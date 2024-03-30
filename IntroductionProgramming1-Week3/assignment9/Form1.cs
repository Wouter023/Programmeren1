using System.Globalization;

namespace assignment9
{
    public partial class Form1 : Form
    {
        string sport = "";
        double price = 0;
        const double FootballFee = 175;
        const double HandballFee = 225;
        const double ageDiscount = 25;
        const double membershipDiscount = 20;
        const int minumumAgeForDiscount = 40;
        const int minimumMembershipDurationForDiscount = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void footballRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sport = "football";
        }

        private void handballRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sport = "handball";
        }

        private void calculateFeeButton_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            int age = int.Parse(ageTextBox.Text);
            int membershipDuration = int.Parse(membershipTextBox.Text);

            if(sport == "football")
            {
                price += FootballFee;
            }
            else if(sport == "handball")
            {
                price += HandballFee;
            }

            if(age > minumumAgeForDiscount)
            {
                price -= ageDiscount;
            }

            if(membershipDuration > minimumMembershipDurationForDiscount)
            {
                price -= membershipDiscount;
            }

            priceOutputLabel.Text = $"€ {price:00.00}";
        }
    }
}