// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// Метод проверки на пятизначность и положтельность
bool FiveDigit (int number)
{
    if ((number > 9999) && (number < 100000)) return true;
    else return false;
}

// Метод проверки на полиндромность без использования строк
bool PalindromeInt (int number)
{
    int rebmun = 0;
    int meat = number;

    while (meat > 0)
    {
        rebmun += meat % 10;
        rebmun *= 10;
        meat /=10;
    }

    rebmun /=10;

    if (rebmun == number) return true;
    else return false;
    
}

// Метод проверки на полиндромность с использования строк
bool PalindromeString (int number)
{
  string number_str = Convert.ToString(number);

  if ((number_str[0]==number_str[4])&&(number_str[1]==number_str[3])) return true;
  else return false;
}

//{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}

int number = Request ("Введите пятизначное положительное число ");

if (FiveDigit (number))
{
    if (PalindromeInt (number) && PalindromeString (number)) Console.WriteLine("Это полиндром!");
    else  Console.WriteLine("Это не полиндром :(");
}
else Console.WriteLine("Я уже говорил тебе, что такое безумие, а?");