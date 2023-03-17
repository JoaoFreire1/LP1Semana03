using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input how big you want it Vertically: ");
            var vertical = Console.ReadLine()!;

            Console.Write("Please input how big you want it Horizontally: ");
            var horizontal = Console.ReadLine()!;

            var arraybi = new int[int.Parse(vertical), int.Parse(horizontal)];

            for (int idxV = 0; idxV < arraybi.GetLength(0); idxV++)
            {
                for (int idxH = 0; idxH < arraybi.GetLength(1); idxH++)
                {
                    Console.Write("Please input a number for the position (" + (idxV + 1) + " , " + (idxH + 1) + "): ");
                    arraybi[idxV, idxH] = int.Parse(Console.ReadLine()!);
                }
        }

        }

            var sumCols = new int[arraybi.GetLength(0)];
            for (int idxV = 0; idxV < arraybi.GetLength(0); idxV++)
            {
                for (int idxH = 0; idxH < arraybi.GetLength(1); idxH++)
                {
                    sumCols[idxV] += arraybi[idxV, idxH];
                }
            }

            var sumLines = new int[arraybi.GetLength(1)];
            for (int idxV = 0; idxV < arraybi.GetLength(0); idxV++)
            {
                for (int idxH = 0; idxH < arraybi.GetLength(1); idxH++)
                {
                    sumLines[idxH] += arraybi[idxV, idxH];
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", sumCols));
            Console.WriteLine("[{0}]", string.Join(", ", sumLines));


            Console.ReadKey(intercept: true);
        }
    }
}
