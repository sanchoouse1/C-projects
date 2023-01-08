using System;
using System.Globalization;

namespace Procents
{
    class Program
    {
        public static double Calculate (string enteringNumbers)
        {
            string[] myArray = enteringNumbers.Split(' ');
            double amount = double.Parse(myArray[0], CultureInfo.InvariantCulture);
            double procentRate = double.Parse(myArray[1], CultureInfo.InvariantCulture);
            double depositTerm = double.Parse(myArray[2], CultureInfo.InvariantCulture);

            return amount * Math.Pow(1 + procentRate / 12 / 100, depositTerm);
        }
        static void Main(string[] args)
        {
            double accumulatedAmount;

            string enteringNumbers = Console.ReadLine();
            accumulatedAmount = Calculate(enteringNumbers);
            Console.WriteLine(accumulatedAmount);
        }
    }
}
