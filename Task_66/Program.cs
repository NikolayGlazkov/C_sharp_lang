/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

static int CalculateSum(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + CalculateSum(M + 1, N);
    }
}


Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

int sum = CalculateSum(M, N);
Console.WriteLine($"Сумма натуральных элементов от {M} до {N}: {sum}");


