namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createSquareButton_Click(object sender, EventArgs e)
        {
            int sideAmount = int.Parse(sideInputTextBox.Text);
            string output = "";

            for (int i = 0; i < sideAmount; i++)
            {
                for (int j = 0; j < sideAmount; j++)
                {
                    if((i == 0 || i == sideAmount - 1) || (j == 0 || j == sideAmount - 1))
                    {
                        output += "X";
                    }
                    else
                    {
                        output += " ";
                    }
                }
                output += "\n";
            }

            squareOutputLabel.Text = output;
        }
    }
}