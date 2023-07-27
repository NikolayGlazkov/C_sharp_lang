/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/


// Задайте размерность массива m и n
int m = 4; // Количество строк
int n = 3; // Количество столбцов

// Создайте двумерный массив
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
Console.WriteLine("Исходный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

// Найдите среднее арифметическое элементов в каждом столбце
double[] columnAverages = new double[n];
for (int j = 0; j < n; j++)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += (int)array[i, j];
    }
    columnAverages[j] = (double)sum / m;
}

// Выведите средние значения на консоль
Console.WriteLine("Средние арифметические значения в каждом столбце:");
for (int j = 0; j < n; j++)
{
    Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
}
