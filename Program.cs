using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {

            //practice creating variables
            int numberOfCupsOfCoffee = 2;

            string fullName = "Victoria Tiller";

            var today = DateTime.Today;

            //printing them out

            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today.ToString("d"));

            //adding space

            Console.WriteLine();

            //getting input from user

            Console.Write("What is your name? ");

            string userName = Console.ReadLine();

            Console.WriteLine($"Hey, {userName}.");

            //getting numbers

            Console.Write("Please give me a number: ");

            string firstNumberAsString = Console.ReadLine();

            Console.Write("And one more number: ");

            string secondNumberAsString = Console.ReadLine();

            //changing numbers from string to numbers

            var firstOperand = double.Parse(firstNumberAsString);

            var secondOperand = double.Parse(secondNumberAsString);

            //add space

            Console.WriteLine();

            //Math time

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            //print out math answers
            Console.WriteLine($"If you add {firstNumberAsString} and {secondNumberAsString} you get {sum}.");
            Console.WriteLine($"If you subtract {secondOperand} from {firstOperand} you get {difference}.");
            Console.WriteLine($"{firstOperand} multiplied by {secondOperand} gives you {product}.");
            Console.WriteLine($"{firstOperand} divided by {secondOperand} is {quotient}.");
            Console.WriteLine($"If you divide {firstOperand} by {secondOperand} you'll have {remainder} left over.");

            //end


        }
    }
}
