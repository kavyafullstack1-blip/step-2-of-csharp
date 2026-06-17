using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class DataTypeConver
    {
        static void Main()
        {
            int num = 10;

            // int is converted to double (implicit type casting)
            double d = num;

            Console.WriteLine(d);

            double d1 = 9.8;

            // explicit casting
            int x = (int)d1;

            Console.WriteLine(x);

            int age = 20;
            int convert=int.Parse(age.ToString());

            // Value type variable
            int n = 357;

            // Boxing
            object box = n;

            Console.WriteLine("Boxed value: " + box);

            // Unboxing
            int unbox = (int)box;
            Console.WriteLine("Unboxed value: " + unbox);
        }
    }
}
