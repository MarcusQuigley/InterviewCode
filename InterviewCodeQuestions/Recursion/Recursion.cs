using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeQuestions
{
    static class Recursion
    {

        public static int Factorial(int value)
        {
            if (value == 1)
                return 1;
            return value * Factorial(value - 1);
        }

        public static int FactorialWhileLoop(int value)
        { 
            int result = 1;

            while (value > 1)
            {
                result *= value;
                value -= 1;
            }
            return result;
        }

        public static int OldSumDigitsofNumber(int number)
        { 
            //dirty
            string numberAsString = number.ToString();

            if (numberAsString.Length == 1)
                return number;
            
            // remove left most number andn add it to total
            int leftValue =int.Parse( numberAsString.Substring(0, 1));
            int remainValue = int.Parse(numberAsString.Substring(1));
            return leftValue + OldSumDigitsofNumber(remainValue);
        }

        public static int SumDigitsofNumber(int number)
        {
            if (number == 0)
                return 0;
            return number % 10 + SumDigitsofNumber(number / 10);
        
        }

        public static int DecimalToBinary(int number)
        {
            if (number == 0)
                return 0;
            return number % 2 + DecimalToBinary(number / 2);
        }

        public static int PowerOfNumber(int number, int power)
        {
            if (power == 1)
            {
                return number;
                
            }
            return number * (PowerOfNumber(number, power - 1));
        }
    }   
}
