// See https://aka.ms/new-console-template for more information
Console.Write("Введите число :");
int num = int.Parse(Console.ReadLine());
string my_digit = Convert.ToString(num);
Console.WriteLine(my_digit);

while (num > 0)
    {

        Console.WriteLine($"{num} - 1");
        num = num/10;


    }


void PrintCountGeneric<T>(T collection) where T : ICollection
{
    Console.WriteLine(collection.Count);
}


var list = new List<int>() { 1, 2 };
PrintCountGeneric(list);