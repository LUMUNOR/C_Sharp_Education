// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
 
  int[,] array = new int[4,5];
  double[] sred = new double[array.GetLength(1)];

Console.WriteLine();

// Заполнение массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(0,4);
        Console.Write(string.Format("{0,-4} ", array[i,j]));
    }
    Console.WriteLine();
}

// Магия
for (int i = 0; i < array.GetLength(1); i++)
{
    double sum =0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j,i];
    }
    sred [i] = sum/array.GetLength(0);
}

Console.WriteLine();

for (int i = 0; i < sred.Length; i++)
{
    Console.Write(string.Format("{0,-4:F1} ", sred[i]));
}
