/*Задача 3
Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
Исходная строка считается допустимой при условии:
1. Открытые скобки должны быть закрыты скобками того же типа.
2. Открытые скобки должны быть закрыты в правильном порядке.
4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.*/

bool Brackets(string brackets)
{
    if ((brackets.Length % 2 > 0)||(brackets.Length == 1) ) return false;
    if ((brackets[0]==')')||(brackets[0]=='}')||(brackets[0]==']')) return false;

    bool Recurs(int[] index, int i)
    {
    if ((index[i]*(-1)) == index[i-1]) return true;
    if (index[i] < 0) return false;
    if ((index[i] > 0)&&(i < index.Length-1)) return Recurs(index,i+1);
    else return false;
    }

    var dictionary = new Dictionary<char, int>()
    {
        { '(', 1 },
        { ')', -1 },
        { '[', 2},
        { ']', -2 },
        { '{', 3},
        { '}', -3 },
    };

    int[] index = new int[brackets.Length];
    for (int i = 0; i < brackets.Length; i++)
    {
        index[i] = dictionary[brackets[i]];
    }
    
    bool flag = false;
    for (int i = 0; i < index.Length; i++)
    {
        flag = Recurs(index,i);
    }

    return flag;
}

string s = "{[]}";

if (Brackets(s)) Console.WriteLine("Норма");
else Console.WriteLine("Фигня");