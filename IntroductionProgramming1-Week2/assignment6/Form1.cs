namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Get user input
            string input = inputBox1.Text;

            int secondsAmount = int.Parse(input);

            //Convert input
            int numberOfHours = (secondsAmount / 3600);
            int numberOfMinutes = (secondsAmount - (3600 * numberOfHours)) / 60;
            int numberOfSeconds = (secondsAmount - (3600 * numberOfHours) - (numberOfMinutes * 60));

            //Print time
            outputTimeLabel.Text = $"{numberOfHours}:{numberOfMinutes}:{numberOfSeconds}";
        }
    }
}