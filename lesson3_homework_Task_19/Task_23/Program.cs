/*
Напишите программу котрая принимает на вфод число N и выводиит кубы от 1 до N
*/ 
static void GenerateSquareTable(int N)
{
for (int i = 1; i <= N; i++)
{
       Console.WriteLine($"Куб числа {i}: {Math.Pow(i, 3)}");
}
}
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
GenerateSquareTable(num);