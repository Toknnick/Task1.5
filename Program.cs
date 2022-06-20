using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Юшин";
            string secondName = "Максим";
            Console.WriteLine("До :");
            Console.WriteLine(name);
            Console.WriteLine(secondName);
            Console.WriteLine();

            string swapping;
            swapping = name;
            name = secondName;
            secondName = swapping;
            Console.WriteLine("После :");
            Console.WriteLine(name);
            Console.WriteLine(secondName);
        }
    }
}
