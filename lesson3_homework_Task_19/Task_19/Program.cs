/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/



string Polindrom(string someString)
{
    string my_someString_reverse = "";

    for (int i = someString.Length - 1; i >= 0; i--)
    {
        my_someString_reverse += someString[i];
    }

    if (someString == my_someString_reverse)
    {
        return "палиндром!";
    }
    else
    {
        return "не палиндром!";
    }
}

Console.Write("Введите пятизначное число: ");
string my_string = Console.ReadLine();
Console.WriteLine(Polindrom(my_string));

