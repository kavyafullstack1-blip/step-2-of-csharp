using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class method_with_parameter
    {
     
        // value parameter
        static void Display(int x)
        {
            Console.WriteLine("Value Parameter: " + x);
        }

        // reference parameter
        static void Update(ref int y)
        {
            // Modify the original variable
            y += 5;
            Console.WriteLine("Reference Parameter: " + y);
        }

        // output parameter
        static void GetValues(out int z)
        {
            // Assign value to output parameter
            z = 20;
            Console.WriteLine("Output Parameter: " + z);
        }

        static void Main(string[] args)
        {
            int value = 10;

            // Call method with value parameter
            Display(value);

            // Call method with reference parameter
            Update(ref value);

            int outputValue;

            // Call method with output parameter
            GetValues(out outputValue);
        }
    }
}

