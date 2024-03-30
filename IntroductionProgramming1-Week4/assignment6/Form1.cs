namespace assignment6
{
    public partial class Form1 : Form
    {
        const double TaxRate = 1.05;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double price = double.Parse(amountInputTextBox.Text);

            for(int i = 0; i < 5; i++)
            {
                price *= TaxRate;
            }

            showOutputFinalPrice.Text = $"{price:0.00}";
        }
    }
}