// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Метод сумма цифр

int SumNumber (int number)
{
    int sum = 0;

    while (number > 0) 
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

//////////////////////////////////////////////////////////////////////////////

int number = Request("Введите чило ");

Console.WriteLine($"Сумма чисел в числе = {SumNumber(number)}");