/*Задайте двумерный массив размера m*n, заполненый члучайными числами.*/

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
    {
        int[,] result = new int[rowNumber, colNumber];
        Random random = new Random();

        for (int i = 0; i < rowNumber; i++)
        {
            for (int j = 0; j < colNumber; j++)
            {
                result[i, j] = random.Next(-deviation, deviation + 1);
            }
        }
        return result;
    }

void Print2dArray(int[,] arrayToPrint)
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
Console.Write("Введите ширину :");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту :");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число :");
int div = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandom2DArray(row, col, div);
Print2dArray(randomArray);