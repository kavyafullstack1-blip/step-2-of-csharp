using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace step_2_of_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value data types
            int x = 10;//int
            Console.WriteLine(x);

            float f = 3.5f;//float
            Console.WriteLine(f);

            double d = 5.6;//double
            Console.WriteLine(d);

            char c = 'A';//char
            Console.WriteLine(c);

            bool b = true;//boolean
            Console.WriteLine(b);

            //reference data type
            string s = "Hello";
            Console.WriteLine(s);

            object obj = 10;   // boxing
            Console.WriteLine(obj);

            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]);

            unsafe
            {
                int n = 10;
                int* p = &n;
                Console.WriteLine(n);
            }

            Console.WriteLine("byte MaxValue"+byte.MaxValue);
            Console.WriteLine("int MaxValue"+int.MaxValue);

            Console.WriteLine($"int MinValue: {int.MinValue}");

            Console.WriteLine("enter your name");
            string name=Console.ReadLine();
            Console.WriteLine(name);


            

        }
    }
}
