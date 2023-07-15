// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] array = new double[5,10];

Console.WriteLine();

for (int i =0;i < array.GetLength(0); i++)
{
    for (int j =0;j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().NextDouble() + new Random().Next(-9,10);
        Console.Write(string.Format("{0,6:F2} ", array[i,j]));
    }
    
    Console.WriteLine();
}

Console.WriteLine();