// Написать метод поиска чила в массиве

int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Метод заполнения массива
int[] Array ()
{
    int[]array =new int [10]; 
    
    for (int i=0; i < array.Length; i++)
    {
    array[i]= new Random().Next(-10,11);
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine(" ");
    return array;
}

// Метод простого поиска
bool poisk(int[]array, int number)
{
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]==number) return true;
    }
    return false;
}

// Метод бинарного поиска
bool poiskbin(int[]array, int number)
{
    for (int i=0; i < array.Length; i++)
    {
        int min = array[i];
        for (int j=i+1; j < array.Length; j++)
        {
            if 
        }
    }
}


int[] array = Array();

int number = Request("Введите число ");

if (poisk(array, number)) Console.Write("Число есть в массиве");
else Console.Write("Числа нет в массиве");