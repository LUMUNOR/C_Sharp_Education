// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Метод заполнения массива случайными числами
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,11);
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

// Метод подсчета cуммы элементов на нечетных позициях
int Oddsum(int[] array)
{
    int sum = 0;
    
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

////////////////////////////////////////////////////////

int[] array = new int[10];
FillArray (array);
Console.Write("Сумма элементов с нечетным индексом = " + Oddsum(array));