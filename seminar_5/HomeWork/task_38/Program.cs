//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Метод заполнения массива случайными числами
void FillArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (Convert.ToDouble(new Random().Next(100,10000)))/100;
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

double DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

    return max - min;
}

////////////////////////////////////////////////////////////////////////////////

double[] array = new double[5];
FillArray (array);
Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + DifferenceMaxMin (array));