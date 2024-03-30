namespace Opgave4
{
    internal class Program
    {
        const int MethodCalls = 10;
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < MethodCalls; i++)
            {
                //generate random numbers for deeltal and deler
                int deeltal = random.Next(12,50);
                int deler = random.Next(1,6);
                int rest;

                //call method
                int quotient = IntegerDeling(deeltal, deler, out rest);

                //print calculation
                Console.WriteLine($"{deeltal} / {deler} = {quotient} ({rest})");
            }
            
        }

        static int IntegerDeling(int deeltal, int deler, out int rest)
        {
            int quotient = 0;
            //check if deelt >= deler
            while(deeltal >= deler)
            {
                deeltal -= deler;
                quotient++;
            }
            //return rest and quotient
            rest = deeltal;
            return quotient;
        }
    }
}