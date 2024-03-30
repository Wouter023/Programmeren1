namespace assignment6
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void referenceButton_Click(object sender, EventArgs e)
        {
            number = int.Parse(inputNumberTextBox.Text);
            SquareByReference(ref number);
            PrintOutput(number);
        }

        private void RefernceOutButton_Click(object sender, EventArgs e)
        {
            number = int.Parse(inputNumberTextBox.Text);
            int square;
            SquareByReferenceOut(number, out square);
            PrintOutput(square);
        }

        private void valueButton_Click(object sender, EventArgs e)
        {
            number = int.Parse(inputNumberTextBox.Text);
            int square = SquareByValue(number);
            PrintOutput(square);
        }

        void SquareByReference(ref int number)
        {
            number = number * number;
        }

        void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }

        int SquareByValue(int number)
        {
            return number * number;
        }

        void PrintOutput(int square)
        {
            resultOutputLabel.Text = $"{square}";
        }
    }
}