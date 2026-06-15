using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    class VarDynamic
    {
      static void Main()
        {
            var Number = 10;
            Number = 20;
            Console.WriteLine(Number);
            Console.WriteLine("Number data type is" + Number.GetType());

            dynamic d_Number = 34;
            Console.WriteLine(d_Number);
            Console.WriteLine(d_Number.GetType());

        }
    }
}
