// it wos in 17.06.2023 jy the geek brain

/*
Напишите программу, которая принимает на вход координаты точки ( X и Y ),
причем X != 0 Y != 0 и вылвет номер четверти плоскости,
в которой находиться эта точка.

x = 34; y = -30 -> 4
x = 2; y = 4 -> 1
x = -34; y =-30 -> 3 
*/



int find_num(int x,int y)
{
    int result = 0;

    if (x > 0 && y > 0)
    {
        result = 1;
    }        
    else if (x < 0 && y > 0)
    {
        result = 2;
    }
    else if (x < 0 && y < 0)
    {
        result = 3;
    }
    else if (x > 0 && y < 0)
    {
        result = 4;
    }

    return result;
}


Console.Write("ВВедите число X:");
int userX = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите число Y:");
int userY = Convert.ToInt32(Console.ReadLine());

int quared = find_num(userX,userY);

if (quared > 0)
{
    Console.WriteLine($"Точка {userX}, {userY} находиться в алоскости {quared}");
}
else
{
    Console.WriteLine($"Точка {userX}, {userY} находиться на пересечении плоскостей");
}


