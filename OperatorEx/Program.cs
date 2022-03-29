using System;

namespace OperatorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Exercise One---");
            int a = 17;
            int b = 4;

            var additionAnswer = a + b;
            var subtractionAnswer = a - b;
            var divisionAnswer = a / b;
            var modulusAnswer = a % b;
            Console.WriteLine(additionAnswer);
            Console.WriteLine(subtractionAnswer);
            Console.WriteLine(divisionAnswer);
            Console.WriteLine(modulusAnswer);


            int quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine("Press anything to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("---Exercise 2---");

            Console.WriteLine("What is the radius of your circle?");

            AreaOfACircle();
            Console.WriteLine("Press anything to continue");
            Console.ReadKey();
            Console.Clear();

        }
        public static void AreaOfACircle()
        {
            var userRadius = double.Parse(Console.ReadLine());

            var answer = Math.PI * Math.Pow(userRadius, 2);
            Console.WriteLine($"The area of a circle with the radius of {userRadius} is {answer}.");
        }





    }
}
