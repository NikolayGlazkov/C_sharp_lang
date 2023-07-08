/*
Задайте массив вещественных чисел. Найдите 
разницу между максимальным и минимальным элементов массива.
*/


float[] arr = new float[10];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 999);
}
float minDigit = arr[0];
float maxDigit = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (minDigit > arr[i])
{
    minDigit = arr[i];
}
    if (maxDigit < arr[i])
{
    maxDigit = arr[i];
}
}

float difference = maxDigit - minDigit;

Console.WriteLine("Массив: " + string.Join(", ", arr));
Console.WriteLine("Большее число в массиве: " + maxDigit);
Console.WriteLine("Меньшее число в массиве: " + minDigit);
Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);