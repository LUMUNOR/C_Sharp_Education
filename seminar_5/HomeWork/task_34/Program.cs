// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Метод заполнения массива случайными положительными трехзначными числами
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

// Метод подсчета четных чисел в массиве
int EvenNumbers(int[] array)
{
    int counter = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2)  == 0) counter++;
    }

    return counter;
}

////////////////////////////////////////////////////////

int[] array = new int[10];
FillArray (array);
Console.Write("Количество чётных элементов массива = " + EvenNumbers(array));