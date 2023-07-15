// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Метод запроса числа целого числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Вывод двумерного массива в консоль
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

//Вывод запрашиваемого элемента двумерного массива

int m = Request("Введите номер строки: ");
int n = Request("Введите номер столбца: ");

if (     (m > 0) && (m < array.GetLength(0))
     &&  (n > 0) && (n < array.GetLength(1)))
    {
        Console.Write(string.Format("{0:F2}", array[m-1,n-1]));
    }
else Console.Write("Нет элемента с такими индексами :( ");