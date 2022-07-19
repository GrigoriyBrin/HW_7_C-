// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("Введите вещественное число");
                double findNumber = Convert.ToDouble(Console.ReadLine());

                double[,] array = FillArray();
                PrintArray(array);
                Console.WriteLine();

                if (FindNumber(array, findNumber))
                {
                    Console.WriteLine(findNumber);
                }
                else
                {
                    Console.WriteLine($"{findNumber} -> такого числа в массиве нет");
                }
            }
            catch
            {
                Console.WriteLine("Введите число согласно инструкции, иначе программа не запустится!");
            }
            
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
                    arr[i, j] = new Random().Next(-15, 16);
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

        public static bool FindNumber(double[,] arr, double find)
        {
            bool validFind = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == find)
                    {
                        validFind = true;
                        break;
                    }
                }
            }
            return validFind;
        }
    }
}     

