using System;

namespace ConsoleAppZumba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start with warmup!");

            //string sideToSide = "Step to the left and then step to the right.";

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(sideToSide);
            //}

            //----------------------------------------------------------------------------------------

            //string[] steps = {"step 1", "step 2", "step 3", "step 4", "step 5" };

            //for (int i = 0; i < steps.Length; i++)
            //{
            //    Console.WriteLine(steps[i]);
            //}

            //for (int i = steps.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(steps[i]);
            //}

            //----------------------------------------------------------------------------------------

            double number1 = ToNumber();

            double number2 = ToNumber();

            double result = number1 + number2;

            Console.WriteLine("adding the numbers together will result in : " + result);
        }

        private static double ToNumber()
        {
            Console.WriteLine("Give me a number: ");
            double number2;
            double.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine("number was " + number2);
            return number2;
        }
    }
}
