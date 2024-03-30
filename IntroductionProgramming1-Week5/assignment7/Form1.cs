namespace assignment7
{
    public partial class Form1 : Form
    {
        int[] dice = new int[6];
        const int NumberOfThrows = 6000;
        const int SizeOfDice = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void throwButton_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();

            for (int i = 0; i < NumberOfThrows; i++)
            {
                int randomNumber = random.Next(1, SizeOfDice + 1);

                dice[randomNumber - 1]++;
            }

            for (int i = 0; i < dice.Length; i++)
            {
                showOutputLabel.Text += $"Number of throws of value {i + 1} = {dice[i]}\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //resetDice();
        }

        void ResetDice()
        {

        }
    }
}