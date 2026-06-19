using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_2_of_csharp
{
    internal class Greeks
    {
    
        // Instance method to display a message
        public void DisplayMessage()
        {
            Console.WriteLine("Hello from the Display " + "Message method!");
        }

        static void Main(string[] args)
        {
            Greeks geek = new Greeks();
            // Create an instance of Geeks Call the instance method directly
            geek.DisplayMessage();
        }
    }


}

