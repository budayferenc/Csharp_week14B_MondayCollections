using System;
using System.Collections;

/// <summary>
/// Create a program that organizes the strings given by the user! Use the ArrayList collection!
/// </summary>
namespace part01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strings = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " Write a string: ");
                strings.Add(Console.ReadLine());
            }

            Console.ReadKey();

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();




        }
    }
}