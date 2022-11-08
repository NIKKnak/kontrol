using static System.Console;
Clear();

string[] array;
WriteLine("Введите символы или значения через пробел");
string stroka = ReadLine()!;
array = stroka.Split(' ');
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}

Write(string.Join(Environment.NewLine, result));
