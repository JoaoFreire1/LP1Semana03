using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char letraescolhida = char.Parse(input);

            foreach (string palavra in args)
            {
                foreach (char letra in palavra)
                {
                    if (letra == letraescolhida)
                    {
                        Console.Write("x");
                    }

                    else
                    {
                        Console.Write(letra);
                    }
                }
            }

        }
    }
}
