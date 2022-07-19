// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {

            double[,] array = FillArray();
            PrintArray(array);

            Console.WriteLine();
            Console.Write("Среднее арифметическое каждого столбца: ");

            double[,] reversArray = ReversArray(array);
            AverageColumns(reversArray);

        }

        public static double[,] FillArray()
        {
            int row = new Random().Next(2, 11),
                columns = new Random().Next(2, 11);
            
            double[,] arr = new double[row, columns];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 16);
                }
            }
            return arr;
        }

        public static void PrintArray(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] ReversArray(double[,] arr)
        {
            double[,] reversArray = new double[arr.GetLength(1), arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    reversArray[j, i] = arr[i, j];
                }
            }
            return reversArray;
        }

        public static void AverageColumns(double[,] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[i, j];
                }
                double average = Math.Round(sum / arr.GetLength(1), 1);
                Console.Write($"{average}; ");
            }
        }
    }
}     

