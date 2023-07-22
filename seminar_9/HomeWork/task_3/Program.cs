/*Задача 3
Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
Исходная строка считается допустимой при условии:
1. Открытые скобки должны быть закрыты скобками того же типа.
2. Открытые скобки должны быть закрыты в правильном порядке.
4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.*/

bool Brackets(string brackets)
{
    if ((brackets.Length % 2 > 0)||(brackets.Length == 1) ) return false;
   
    var dictionary = new Dictionary<char, int>()
    {
        { '(', 1 },
        { ')', -1 },
        { '[', 2},
        { ']', -2 },
        { '{', 3},
        { '}', -3 },
    };

    int[] kef = new int[brackets.Length];
    for (int i = 0; i < brackets.Length; i++)
    {
        kef[i] = dictionary[brackets[i]];
    }
    
    void Clener(int[] array, int startIndex)
    {
        array[startIndex]=0;
        array[startIndex+1]=0;
        int box = 0;
        for (int i = startIndex; i < array.Length-2; i++)
        {
            box = array[i];
            array[i]=array[i+2];
            array[i+2]=box;
        }
    }

    for (int j = 0; j < kef.Length; j++)
    {
        if (kef[0]==0) return true;
        for (int i = 0; i < kef.Length-1; i++)
        {
            if (kef[i+1]==0) break;
            if ((kef[i]>0)&&(kef[i]==kef[i+1]*(-1))) Clener(kef,i);
        }
    } 

    return false;
}

string s = "{[]}";

if (Brackets(s)) Console.WriteLine("True");
else Console.WriteLine("False");