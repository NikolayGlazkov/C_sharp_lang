/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наибольшей суммой элементов.*/

int[,] GetRandom2DArray(int dig = 100) //рандом массив 2D
    {
        int[,] result = new int[4, 4];
        Random random = new Random();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i, j] = random.Next(-dig, dig + 1);
            }
        }
        return result;
    }

void Print2dArray(int[,] arrayToPrint) //принт array
    {
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                Console.Write(arrayToPrint[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

int FindMaxSumRow(int[,] arrayToFind)
{
    int rows = arrayToFind.GetLength(0);
    int cols = arrayToFind.GetLength(1);
    int maxSum = int.MinValue; // Инициализируем максимальную сумму минимальным значением int
    int maxSumRow = -1; // Номер строки с максимальной суммой

    for (int i = 0; i < rows; i++)
    {
        int summa = 0;
        for (int j = 0; j < cols; j++)
        {
            summa += arrayToFind[i, j];
        }

        // Если текущая сумма больше максимальной, обновляем максимальную сумму и номер строки
        if (summa > maxSum)
        {
            maxSum = summa;
            maxSumRow = i;
        }
    }

    return maxSumRow; // Возвращаем номер строки с наибольшей суммой
}


int[,] randomArray = GetRandom2DArray(99);
Print2dArray(randomArray);
Console.WriteLine();

int maxSumRow = FindMaxSumRow(randomArray);
Console.WriteLine($"Строка с наибольшей суммой: {maxSumRow}");