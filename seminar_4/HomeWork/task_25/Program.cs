// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Degree (int A, int B)
{
    double result = A;
    if (B == 0) return 1;
    for (int i = 1; i < Math.Abs(B); i++) result *= A;
    if (B < 0) return (1/result);
    else return result;
}

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int A = Request("Введите число ");
int B = Request("Введите степень ");

Console.WriteLine($"{A} в натуральную степень {B} = {Degree(A, B)}");