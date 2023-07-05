/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/ 

int[] numbers = new int[8]; // Создание массива из 8 элементов
Console.WriteLine("Введите 8 чисел по очереди");
// Заполнение массива числами от 1 до 8
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вывод на консоль :");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}
