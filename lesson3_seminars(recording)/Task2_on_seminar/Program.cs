/*
Напишите задачу, которая по заданнуму номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/

static string FindQuarter(int num)
{
    string answer = "";
    if (num == 1)
    {            
        answer = "x > 0 and y > 0";
    }
    else if (num == 2)
    {
        answer = "x < 0 and y > 0";
    }
    else if (num == 3)
    {
        answer = "x < 0 adn y < 0";
    }
    else if (num == 4)
    {
        answer = "x > 0 and y < 0";
    }
        
    return answer;
}

    Console.Write("Введите четверть от 1 до 4: ");
    int digit = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(FindQuarter(digit));

