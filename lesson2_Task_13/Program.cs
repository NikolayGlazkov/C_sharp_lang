// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string strnum = num.ToString();


if (strnum.Length < 3)
{
    Console.WriteLine("Длинна числа меньше 3");
}
else
{
    Console.WriteLine($"третее число: {strnum[2]}");
}