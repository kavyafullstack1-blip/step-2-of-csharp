using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class loops
    {
        static void Main()
        {
            //for each loop
            char[] gender = { 'm', 'f', 'm', 'm', 'f' };
            int maleCount = 0, femaleCount = 0;

            // Counting males and females using foreach
            foreach (char g in gender)
            {
                if (g == 'm')
                    maleCount++;
                else if (g == 'f')
                    femaleCount++;
            }

            Console.WriteLine("Number of males: " + maleCount);
            Console.WriteLine("Number of females: "
            + femaleCount);

            //nested for loop
            //outer loops
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }

            //for loops
            for (int ik = 0; ik <= 10; ik = ik + 2)
            {
                Console.WriteLine(ik);
            }

            //while loop
            int k = 0;
            while (k < 5)
            {
                Console.WriteLine(k);
                k++;
            }

            //swtich case
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
