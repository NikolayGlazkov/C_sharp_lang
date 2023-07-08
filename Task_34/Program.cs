
int[] arr = new int[4];
Random rand = new Random();
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = rand.Next(99,999); // Заполняем случайными числами диапазоном от -100 до 100
}

foreach (int num in arr)
{
if (num % 2 == 0)
{
   counter++;
}
}

        Console.WriteLine("Массив: " + string.Join(", ", arr));
        Console.WriteLine("Количество четных элементов в массиве: " + counter);
