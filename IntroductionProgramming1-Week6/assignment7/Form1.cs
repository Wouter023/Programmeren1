namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            double input = double.Parse(degreesInputTextBox.Text);

            if (CToKRadioButton.Checked)
            {
                double output = CelciusToKelvinConversion(input);
                resultOutputLabel.Text = $"{output}";
            }
            else if (CToFRadioButton.Checked)
            {
                double output = CelsiusToFahrenheitConversion(input);
                resultOutputLabel.Text = $"{output}";
            }
            else if (FToCRadioButton.Checked)
            {
                double output = FahrenheitToCelsiusConversion(input);
                resultOutputLabel.Text = $"{output}";
            }
        }

        double FahrenheitToCelsiusConversion(double input)
        {
            double output = (input + 273);
            return output;
        }

        double CelsiusToFahrenheitConversion(double input)
        {
            double output = (input * 9 / 5 + 32);
            return output;
        }

        double CelciusToKelvinConversion(double input)
        {
            double output = ((input - 32) * 5 / 9);
            return output;
        }
    }
}