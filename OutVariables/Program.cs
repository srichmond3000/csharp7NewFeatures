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

            // also use of _ for 'discards', i.e. parameters we don't care about.
            SetValues(out string anotherName, out _);

            Console.WriteLine($"Name: {anotherName}");

            // can use 'var' as compiler can infer types.
            SetValues(out var inferredName, out var inferredIndex);

            Console.WriteLine($"Inferred name: {inferredName}. Inferred index: {inferredIndex}");

            // use with 'TryParse' pattern.
            if(Int32.TryParse("2", out var result))
            {
                Console.WriteLine($"Result = {result}");
            }

            Console.ReadLine();
        }

        private static void SetValues(out string name, out int index)
        {
            name = "Fred";
            index = 3;
        }
    }
}
