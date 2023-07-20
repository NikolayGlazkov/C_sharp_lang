/*Задайте двумерный массив размера m*n, заполненый члучайными числами.*/

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

int[,] Sort2DArrayByRow(int[,] arrayToSort)
    {
        int rows = arrayToSort.GetLength(0);
        int cols = arrayToSort.GetLength(1);
        int[,] sortedArray = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = arrayToSort[i, j];
            }

            Array.Sort(row, (x, y) => -x.CompareTo(y));

            for (int j = 0; j < cols; j++)
            {
                sortedArray[i, j] = row[j];
            }
        }

        return sortedArray;
    }

int[,] randomArray = GetRandom2DArray(99);
int[,] sorted2dArray =Sort2DArrayByRow(randomArray);

Print2dArray(randomArray);
Console.WriteLine();
Print2dArray(sorted2dArray);