using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursionTest();

            Console.Read();
        }

        static void RecursionTest()
        {
            Console.WriteLine("Factorial of 5 = {0}", Recursion.Factorial(5));

            Console.WriteLine("Factorial of 4 = {0}", Recursion.Factorial(4));
            Console.WriteLine("Factorial of 3 = {0}", Recursion.Factorial(3));
            Console.WriteLine("Factorial of 2 = {0}", Recursion.Factorial(2));
            Console.WriteLine("Factorial of 1 = {0}", Recursion.Factorial(1));

            Console.WriteLine("End of recursion test {0}", Environment.NewLine);
        }
    }
}
