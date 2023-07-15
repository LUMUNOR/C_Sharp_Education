
  int[,] array = new int[2,3];
  double[] sred = new double[array.GetLength(1)];


// Заполнение массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(2,4);
        Console.Write(array[i,j]+" ");
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
    Console.Write(sred[i]+" ");
}

