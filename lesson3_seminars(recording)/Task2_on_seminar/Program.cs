/*
Напишите задачу, которая по заданнуму номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/

using System;

class Program
{
    static string FindQuarter(int num)
    {
        string answer = "";
        
        if (num == 1)
        {
            answer = "Диапазон оси X: от 0 до +X, диапазон оси Y: от 0 до +Y";
        }
        else if (num == 2)
        {
            answer = "Диапазон оси X: от -X до 0, диапазон оси Y: от -Y до 0";
        }
        else if (num == 3)
        {
            answer = "Диапазон оси X: от -X до 0, диапазон оси Y: от 0 до +Y";
        }
        else if (num == 4)
        {
            answer = "Диапазон оси X: от 0 до +X, диапазон оси Y: от -Y до 0";
        }
        
        return answer;
    }

    static void Main()
    {
        Console.Write("Введите четверть от 1 до 4: ");
        int digit = int.Parse(Console.ReadLine());

        Console.WriteLine(FindQuarter(digit));
    }
}
