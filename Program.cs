using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Melanie");
            names.Add("Sally");

            names.ForEach(name => Console.Write(name + " "));

            List<string> stuff = new List<string> {"a", "b", "c", "d"};

            int x = 5;
            int y = 7;
            int result = Adder(x, y);

            int result2 = Adder(10,46);

            Console.WriteLine($"{x} + {y} = {result}");

        }

        static int Adder(int a, int b)
        {
            return a + b;
        }


    }
}