// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Метод вывода кубов от 1 до N
void Cubic_Sequence (int N)
{
    if (N == 0) return;
    if (N > 0) 
    {
        for (int i = 1; i <=N; i++ )
        {
            Console.Write($"{Math.Pow(i,3)} ");
        }
    }
    if (N < 0) 
    {
        for (int i = -1; i >=N; i-- )
        {
            Console.Write($"{Math.Pow(i,3)} ");
        }
    }
}

// {}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}

int number = Request("Введите число ");

Cubic_Sequence(number);
