// Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m = new Random().Next(2, 16),
                n = new Random().Next(2, 16);
            
            double[,] array = new double[m, n];
            
            Console.WriteLine($"Количество строк: {m}");
            Console.WriteLine($"Количество столбцов: {n}");

            FillArray(array);
            PrintArray(array);
            
        }

        public static void FillArray(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-100, 100);
                }
            }
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
    }
}     
