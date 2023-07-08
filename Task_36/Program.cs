
int[] arr = new int[10];
Random rand = new Random();

int summa = 0;
for (int i = 0; i < arr.Length; i++)
{
   arr[i] = rand.Next(1,999); // Заполняем случайными числами диапазоном от 1 до 999
   if (i % 2 != 0)
   {
    summa += arr[i];
   }
}


Console.WriteLine("Массив: " + string.Join(", ", arr));
Console.WriteLine($"сумма элементов стоящих на четных позициях ровна {summa}");