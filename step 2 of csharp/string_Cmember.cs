using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class string_Cmember
    {
        static void Main()
        {
            string text = "this is sampal message";
            int textLength = text.Length;
            Console.WriteLine($"the length of text is {textLength}");
            string tp=text.ToUpper();
            Console.WriteLine($"upperCase {tp}");
            string tl = text.ToLower();
            Console.WriteLine($"LowerCase {tl}");
            string input = "    hello   ";
            string t=input.Trim();
            Console.WriteLine($"input without any space{t}");
            string input1 = "********hello******";
            Console.WriteLine(input1);
            string updatedt = input1.Trim('*');
            Console.WriteLine($"for spl char {updatedt}");

                string first = " GeEks ";
                string second = " forGeeks ";

                // trim the String
                first = first.Trim();
                second = second.Trim();

                // Checking element at index 2 first
                Console.WriteLine("Element at index 2: " + first[2]);

                // replacing the element in String
                first = first.Replace("E", "e");
                Console.WriteLine(first + second);
                 
                string sp=second.PadLeft(10);
                Console.WriteLine(sp);
                string spc=second.PadLeft(20,'*');
                Console.WriteLine(spc);

            // define string
            String str = "kavyanjali from hyd";

            Console.WriteLine("String    : " + str);

            // retrieve the substring from index 5
            Console.WriteLine("Sub String1: " + str.Substring(5));

            // retrieve the substring from index 8
            Console.WriteLine("Sub String2: " + str.Substring(8));

            // retrieve the substring from index 0 to length 8
            Console.WriteLine("Sub String1: " + str.Substring(0, 8));

            // retrieve the substring from index 5 to length 3
            Console.WriteLine("Sub String2: " + str.Substring(5, 3));

            string str1 = "Hello";
            string str2 = "hello";

            // Case-sensitive comparison
            bool caseSensitive = str1.Equals(str2);
            Console.WriteLine("Case Sensitive: " + caseSensitive);

            // Case-insensitive comparison
            bool caseInsensitive = String.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Case Insensitive: " + caseInsensitive);

            //string formating
            int value = 10;
            double price = 20;
            string recipt=string.Format("your {0} is for{1}",value,price);
            Console.WriteLine(recipt);





        }
        }
    }
    

