/*Задайте двумерный массив размера m*n, заполненый члучайными числами.*/

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] resukt = new int[rowNumber,colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
           result[i,j] = new Random().Next(-deviation,deviation+1) 
        }
    }
    return result;
}

void Print2dArray(int[,] arrayToprint)
{
    for (int i = 0; i < arrayToprint.GetLenght(0); i++)
    {
        
    }
}