/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/


int m = 3; // Количество строк
int n = 4; // Количество столбцов


Random random = new Random();

// Создайте двумерный массив
double[,] array = new double[m, n];
double minValue = 0.0;
double maxValue = 100.0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        // Генерируем случайное вещественное число от мин до мах
        double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
        array[i, j] = randomValue;
    }
}


Console.WriteLine("Случайно заполненный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}