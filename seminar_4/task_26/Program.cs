// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Метод посчёта количества цифр в числе
int Podschet (int number)
{
    int i = 0;
    int N = Math.Abs(number);
    while (N>0)
    {
        N /=10;
        //N = N/10;
        i++;
    }
    return i;
}

int number = Request("Введите число ");

 Console.Write(Podschet(number));