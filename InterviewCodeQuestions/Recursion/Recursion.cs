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
    }
}
