using System.Globalization;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Ask for 3 number
            Console.Write("Enter number 1: ");
            string inputNumber1 = inputBox1.Text;

            Console.Write("Enter number 2: ");
            string inputNumber2 = inputBox2.Text;

            Console.Write("Enter number 3: ");
            string inputNumber3 = inputBox3.Text;

            double number1 = double.Parse(inputNumber1);
            double number2 = double.Parse(inputNumber2);
            double number3 = double.Parse(inputNumber3);

            //Sum the 3 number
            double totalAmount = number1 + number2 + number3;

            //Devide by 3
            double devideAmount = totalAmount / 3;

            //Print number 
            outputAverageLabel.Text = $"{devideAmount:0.000}";
        }
    }
}