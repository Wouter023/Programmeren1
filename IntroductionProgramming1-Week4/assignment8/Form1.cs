namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            int numberInput = int.Parse(numberInputTextBox.Text);

            int outputSumOne = 0;
            int outputSumTwo = 0;

            for (int i = 0; i <= numberInput; i++)
            {
                outputSumOne += i;
            }

            outputSumTwo = numberInput * (numberInput + 1) / 2;

            outputFirstSumLabel.Text = outputSumOne.ToString();
            outputSecondSumLabel.Text = outputSumTwo.ToString();

            if(outputSumOne == outputSumTwo)
            {
                outputEqualLabel.Text = $"The sum and formula are equal.";
            }
            else
            {
                outputEqualLabel.Text = $"The sum and formula are not equal.";
            }
        }
    }
}