/* Напишите программу которая получает на входе
 число N и выводит таблицу квадратов до числа N.*/


static void GenerateSquareTable(int N)
{
for (int i = 0; i <= N; i++)
{
       Console.WriteLine($"Квадрат числа {i}: {Math.Pow(i, 2)}");
}
}
Console.WriteLine("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
GenerateSquareTable(num);
    


