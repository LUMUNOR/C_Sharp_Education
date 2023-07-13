// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int b1 = Request("Введите коэффециент b1 = ");
int k1 = Request("Введите коэффециент k1 = ");
int b2 = Request("Введите коэффециент b2 = ");
int k2 = Request("Введите коэффециент k2 = ");

double x = (b2-b1)/(k1-k2);
double y = (k1*x)+b1;

Console.Write($"Координата пересечния двух примых ({x}, {y})");