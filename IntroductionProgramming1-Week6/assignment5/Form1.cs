namespace assignment5
{
    public partial class Form1 : Form
    {
        int numberOne, numberTwo;
        public Form1()
        {
            InitializeComponent();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            numberOne = int.Parse(numberOneInputTextBox.Text);
            numberTwo = int.Parse(numberTwoInputTextBox.Text);

            resultOutputLabel.Text = $"{numberOne - numberTwo}";
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            numberOne = int.Parse(numberOneInputTextBox.Text);
            numberTwo = int.Parse(numberTwoInputTextBox.Text);

            resultOutputLabel.Text = $"{numberOne * numberTwo}";
        }

        private void deviderButton_Click(object sender, EventArgs e)
        {
            numberOne = int.Parse(numberOneInputTextBox.Text);
            numberTwo = int.Parse(numberTwoInputTextBox.Text);

            resultOutputLabel.Text = $"{numberOne / numberTwo}";
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            numberOne = int.Parse(numberOneInputTextBox.Text);
            numberTwo = int.Parse(numberTwoInputTextBox.Text);
            
            resultOutputLabel.Text = $"{numberOne + numberTwo}";
        }
    }
}