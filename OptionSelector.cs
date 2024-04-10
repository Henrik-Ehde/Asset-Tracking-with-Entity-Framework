using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_with_Entity_Framework
{
    static internal class OptionSelector
    {
        //Let's the user pick from several options by pressing a number key.
        public static int PickOption(string message, string[] options)
        {
            Console.WriteLine(message);
            Console.WriteLine("Enter a number to chose an option");

            for (int i = 0; i < options.Length; i++) Console.WriteLine(i + 1 + ": " + options[i]);

            while (true)
            {
                int input = Console.ReadKey(true).KeyChar - '0';
                if (input > 0 && input <= options.Length + 1) return input;
            }
        }
    }
}
