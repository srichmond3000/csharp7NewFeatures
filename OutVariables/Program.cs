using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            SetValues(out string name, out int index);

            Console.WriteLine($"Name: {name}, Index: {index}");
            Console.ReadLine();
        }

        private static void SetValues(out string name, out int index)
        {
            name = "Fred";
            index = 3;
        }
    }
}
