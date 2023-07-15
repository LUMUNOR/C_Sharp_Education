/* Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на 
главной диагонали (с индексами (0,0); (1;1) и т.д.*/

  int[,] array = new int[5,5];


// Заполнение массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[i,j]= new Random().Next(2,4);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}

int sum = 0;

// магия
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        if (j==i) sum+=array[i,j];
    }
}
Console.WriteLine();
Console.Write(sum);
Console.WriteLine();