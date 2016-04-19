using System;
using System.Collections.Generic;
using System.Text;

namespace part03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);
            dict.Add("four", 4);
            dict.Add("five", 5);
            dict.Add("six", 6);
            dict.Add("seven", 7);
            dict.Add("eight", 8);
            dict.Add("nine", 9);
            dict.Add("ten", 10);

            string numbersWithLetters = "one car is 2 small car. one small car is five fully bin. now we speaking about eight items";
            StringBuilder numbersWithIntegers = new StringBuilder();

            Console.WriteLine("The original text is: \n" + numbersWithLetters);

            string[] splittedSentence = numbersWithLetters.Split(' ');

            foreach (var word in splittedSentence)
            {
                if (dict.ContainsKey(word))
                {
                    numbersWithIntegers.Append(dict[word] + " ");
                }
                else
                {
                    numbersWithIntegers.Append(word + " ");
                }
            }

            Console.WriteLine("\nThe chaned text is: \n"+ numbersWithIntegers);
            Console.ReadKey();

        }
    }
}