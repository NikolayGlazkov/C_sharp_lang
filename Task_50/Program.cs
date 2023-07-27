/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.*/


Console.Write("Введите Количество строк: ");
int m;
while (!int.TryParse(Console.ReadLine(), out m))
{
    Console.WriteLine("Некорректный ввод. Введите целое число для Количество строк:");
}

Console.Write("Введите Количество столбцов: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Некорректный ввод. Введите целое число для Количество столбцов:");
}

double[,] array = new double[m, n];
double minValue = 0.0;
double maxValue = 100.0;

Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
        array[i, j] = randomValue;
    }
}

Console.Write("Введите номер строки: ");
int row;
while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row >= m)
{
    Console.WriteLine($"Некорректный ввод. Введите целое число от 0 до {m - 1} для номера строки:");
}

Console.Write("Введите номер столбца: ");
int col;
while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col >= n)
{
    Console.WriteLine($"Некорректный ввод. Введите целое число от 0 до {n - 1} для номера столбца:");
}

double value = array[row, col];
Console.WriteLine($"Значение элемента [{row}, {col}]: {value}");
