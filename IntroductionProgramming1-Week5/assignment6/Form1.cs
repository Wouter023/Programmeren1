using System.Globalization;

namespace assignment6
{
    public partial class Form1 : Form
    {
        int[] numbersBefore = new int[20];
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbersBefore.Length; i++)
            {
                numbersBefore[i] = random.Next(0, 501);
                beforeOutputLabel.Text += $"Element {i:00} = {numbersBefore[i]}\n";
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            int comparisonNumber = int.Parse(inputTextBox.Text);
            int[] numbersAfter = numbersBefore;

            for (int i = 0; i < numbersAfter.Length; i++)
            {
                if (numbersAfter[i] >= comparisonNumber)
                {
                    numbersAfter[i] += 10;
                }
                else
                {
                    numbersAfter[i] -= 5;
                }

                afterOutputLabel.Text += $"Element {i:00} = {numbersAfter[i]}\n";
            }
            compareButton.Enabled = false;
        }
    }
}