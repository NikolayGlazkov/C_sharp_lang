/*Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/

Console.WriteLine("Ведите 3 отдельных числа чила:");
Console.Write("Ведите 1 чило:");
int dot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите 2 чило:");
int dot2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите 3 чило:");
int dot3 = Convert.ToInt32(Console.ReadLine());

if (dot1 + dot2 > dot3 && dot3 + dot1 > dot2 && dot2 + dot3 > dot1)
{
    Console.WriteLine("Все ок:");
}
else
{
    Console.WriteLine("Все не ок:");
}