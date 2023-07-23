/* Задача 4:
Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, которые представлены этими строками. 
Причем полученная сумма должна быть преобразована в строку. Для решения этой задачи запрещено преобразовывать входные строки сразу 
напрямую в целое число при помощи встроенной функции. Необходимо сделать это самостоятельно.*/

string IntSum(string A, string B)
{
    int numA = Convert.ToInt32(A);
    int numB = Convert.ToInt32(B);
    int sum = numA + numB;

    return Convert.ToString(sum);
}

Console.Write("Введите А: ");
string strA = Console.ReadLine();
Console.Write("Введите В: ");
string strB = Console.ReadLine();
Console.Write(strA+"+"+strB+"="+IntSum(strA,strB));