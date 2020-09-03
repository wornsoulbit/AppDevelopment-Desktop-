using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations {
    class Program {
        static void Main(string[] args)
        {
            int number1 = 20; 
            int number2 = 4; 
            int sum; 
            int difference; 
            int product; 
            int quotient; 
            int remainder; 

            sum = number1 + number2; 
            difference = number1 - number2; 
            product = number1 * number2; 
            quotient = number1 / number2; 
            remainder = number1 % number2; 

            Console.WriteLine("The sum of {0} and {1} is {2}", number1, number2, sum); 
            Console.WriteLine("The difference between {0} and {1} is {2}", number1, number2, difference); 
            Console.WriteLine("The product of {0} and {1} is {2}", number1, number2, product); 
            Console.WriteLine("{0} divided by {1} is {2}", number1, number2, quotient); 
            Console.WriteLine("The remainder of {0} divided by {1} is {2}", number1, number2, remainder);
        }
    }
}
