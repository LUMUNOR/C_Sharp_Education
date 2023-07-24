/* Задача 4:
Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, которые представлены этими строками. 
Причем полученная сумма должна быть преобразована в строку. Для решения этой задачи запрещено преобразовывать входные строки сразу 
напрямую в целое число при помощи встроенной функции. Необходимо сделать это самостоятельно.*/

string IntSum(string A, string B)
{
    int numA = ConvertStrToInt(A);
    int numB = ConvertStrToInt(B);
    int sum = numA + numB;

    return Convert.ToString(sum);
}

int ConvertStrToInt(string s)
{
    var dictionary = new Dictionary<char, int>()
    {
        { '1', 1},
        { '2', 2},
        { '3', 3},
        { '4', 4},
        { '5', 5},
        { '6', 6},
        { '7', 7},
        { '8', 8},
        { '9', 9},
        { '-',-1},
    };
    
    int result = 0;
    int dec = s.Length;
    if ((dictionary[s[0]]) == -1) dec -=1;
    
    for (int i = 0; i < s.Length; i++)
    {
        if ((dictionary[s[i]]) == -1)
        {
            continue;   
        }
        if ((dictionary[s[0]]) == -1)
        {
            result+=dictionary[s[i]]*(Convert.ToInt32(Math.Pow(10, dec-i)));   
        }
        else result+=dictionary[s[i]]*(Convert.ToInt32(Math.Pow(10, dec-i-1)));
    }

    if ((dictionary[s[0]]) == -1) return result*(-1);
    else return result;

    
}

/*string ConvertIntToStr(int num)
{
     var dictionary = new Dictionary<int, char>()
    {
        { 1, '1'},
        { 2, '2'},
        { 3, '3'},
        { 4, '4'},
        { 5, '5'},
        { 6, '6'},
        { 7, '7'},
        { 8, '8'},
        { 9, '9'},
    }

    int dec = 0;
    int meat = num;

    while (meat > 0)
    {
        meat /= 10;
        dec++;
    }

    meat = Math.Abs(num);
    int[] arrayNum = new int[dec];

    for(int i = arrayNum.Length-1; i >= 0;i--);
    {
        arrayNum[i] = meat%10;
        meat /= 10;
    }

    if (num < 0) dec++;

    for ()
}*/

Console.Write("Введите А: ");
string strA = Console.ReadLine();
Console.Write("Введите В: ");
string strB = Console.ReadLine();
Console.Write(strA+"+"+strB+"="+IntSum(strA,strB));