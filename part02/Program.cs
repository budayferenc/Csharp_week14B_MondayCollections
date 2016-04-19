using System;
using System.Collections;

namespace part2

{
    class Program

    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " Write an int: ");
                stack.Push(Int32.Parse(Console.ReadLine()));
            }

            Console.ReadKey();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}