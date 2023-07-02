//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
Console.Write("Введите число №1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число №2: ");
int num2 = int.Parse(Console.ReadLine());

if( num1 > num2)
{
    Console.WriteLine($"Первое {num1} бльше, а Второе меньше: {num2}");
}
else
{
    Console.Write($"Второе {num2} бльше, а Первое меньше: {num1}");
}