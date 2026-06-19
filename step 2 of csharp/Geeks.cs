using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class Geeks

    {
        // Static method to calculate square of a number
        public static int Square(int number)
        {
            // Return the square of the number
            return number * number;
        }

        static void Main(string[] args)
        {
            // Call static method using class name
            int result = Geeks.Square(5);

            Console.WriteLine("Square of 5 is: " + result);
        }
    }
}

