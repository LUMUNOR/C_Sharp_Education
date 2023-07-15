/* Задача 49: Задайте двумерный массив. Найдите элементы,
 у которых оба индекса чётные, и замените эти элементы на
 их квадраты.*/

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

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        if (((i%2)==0)&&((j%2)==0)) array[i,j] *= array[i,j];
        Console.Write(array[i,j]+" "); 
    }
     Console.WriteLine();
}
