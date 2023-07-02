// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Ввндите чиcло, конец последовательности: ");
int num = int.Parse(Console.ReadLine());



for (int i = 0; i < num+1; i++)
{
    if (i%2 == 0)
    {
      Console.WriteLine(i);  
    }
    
}