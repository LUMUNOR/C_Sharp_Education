// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Factorial (int number)
{
    if (number <= 0) return -1;

    int j=1;
    for(int i=1; i <= number; i++)
    {
        j *= i;
    }
    return j;
}

int number = Request("Введите число ");

 Console.Write(Factorial(number));