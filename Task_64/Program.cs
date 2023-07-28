/*Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.*/

static void PrintNumbers(int N)
{
    if (N == 1)
    {
        Console.WriteLine(N);
    }
    else
    {
        Console.WriteLine(N);
        PrintNumbers(N - 1);
    }
}


Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

PrintNumbers(N);