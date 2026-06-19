using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class Op_rater
    {
        static void Main()
        {
            //arithmetic oprater
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum3);

            int sub = sum1 - sum2;
            Console.WriteLine(sub);

            int mul = sum1 * sum2;
            Console.WriteLine(mul);

            //assignment opraters
            int a = 10;

            // Using different assignment operators
            a += 5;
            Console.WriteLine("Add Assignment: " + a);

            a -= 3;
            Console.WriteLine("Subtract Assignment: " + a);

            a *= 2;
            Console.WriteLine("Multiply Assignment: " + a);

            a /= 4;
            Console.WriteLine("Division Assignment: " + a);

            a %= 5;
            Console.WriteLine("Modulo Assignment: " + a);

            int x = 10, y = 20;

            // Compare using different relational operators
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);

            bool a1 = true, b = false;

            // conditional operators
            if (a1 && b)
                Console.WriteLine("a and b are true");

            if (a1 || b)
                Console.WriteLine("Either a or b is true");

            if (!a1)
                Console.WriteLine("a is not true");
            if (!b)
                Console.WriteLine("b is not true");

            int i = 5;

            // pre-increment
            Console.WriteLine("++i returns: " + ++i);

            // post-increment
            Console.WriteLine("i++ returns: " + i++);

            Console.WriteLine("Final value of i: " + i);

            Console.WriteLine();

            // pre-decrement
            Console.WriteLine("--i returns: " + --i);

            // post-decrement
            Console.WriteLine("i-- returns: " + i--);

            Console.WriteLine("Final value of i: " + i);


            //Ternary Operator
            int a3 = 10, b3 = 5;
            // similar to if else

            string result = (a3 > b3) ? "a3" : "b3";
            Console.WriteLine(result + " is greater");
        }
    }
}
