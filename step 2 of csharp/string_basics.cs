using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class string_basics
    {
        static void Main()
        {
            string strCourses = "C#.net";
            Console.WriteLine(strCourses);

            string strCourses1="\"Csharp\"";
            Console.WriteLine(strCourses1);

            string name = "one.\nTwo.\nThree";
            Console.WriteLine(name);

            string name1 = "kavya";
            int age = 24;
            string meassage = $"name is {name1} and age is {age}";
            Console.WriteLine(meassage);
            name1.ToUpper();
            Console.WriteLine(name1.ToUpper());
        }
    }
}
