using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float valor1 = float.Parse(args[0]);
            float valor2 = float.Parse(args[1]);
            float valor3 = float.Parse(args[2]);
            float valor4 = float.Parse(args[3]);
            float valor5 = float.Parse(args[4]);
            float valor6 = float.Parse(args[5]);

            float result1 = valor1 * valor5;
            float result2 = valor2 * valor6;
            float resultf1 = result1 + result2;
            float result3 = valor3 * valor5;
            float result4 = valor4 * valor6;
            float resultf2 = result3 + result4;

            Console.WriteLine($"|  {resultf1}  |");
            Console.WriteLine($"|  {resultf2}  |");
        }
    }
}
