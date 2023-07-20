/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:*/


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

int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
    int rows1 = array1.GetLength(0);
    int cols1 = array1.GetLength(1);
    int rows2 = array2.GetLength(0);
    int cols2 = array2.GetLength(1);

    if (cols1 != rows2)
    {
        throw new ArgumentException("The number of columns in the first array must be equal to the number of rows in the second array.");
    }

    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    return result;
}


int[,] randomArray1 = GetRandom2DArray(99);
int[,] randomArray2 = GetRandom2DArray(99);
int[,] arrayanswer = MultiplyArrays(randomArray1,randomArray2);
Print2dArray(randomArray1);
Console.WriteLine();
Print2dArray(randomArray2);
Console.WriteLine();
Print2dArray(arrayanswer);
