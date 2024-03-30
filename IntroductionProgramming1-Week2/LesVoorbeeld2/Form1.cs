namespace LesVoorbeeld2
{
    public partial class Form1 : Form
    {
        const double gravity = 9.81;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateForceOnEarthButton_Click(object sender, EventArgs e)
        {
            //Get weight in KG
            Console.Write("Give the mass of a object in Kg: ");
            string input = Console.ReadLine();

            //Convert string in double
            double massInKg = Double.Parse(input);

            //Calculate force on earth
            double forceOnEarthInNewton = massInKg * gravity;

            //Display force
            Console.WriteLine("Force on earth: {0} Newton", forceOnEarthInNewton);
        }
    }
}