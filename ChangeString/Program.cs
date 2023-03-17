using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence please");
            var sentence = Console.ReadLine()!;

            Console.WriteLine("Now write a letter");
            var letter = Console.ReadLine()!;

            Console.WriteLine("Yor new sentence is: " + sentence.Replace(letter, ""));

            Console.ReadKey(intercept: true);
        }
    }
}
