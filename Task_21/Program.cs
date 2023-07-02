/*
Напишите программу которая принимает на вход кординаты двух точек и находит 
между ними растояние в 3D пространстве
*/
using System;

class Program
{
    static double DistanceBetweenPoints3D(int x1, int y1, int z1, int x2, int y2, int z2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1,2));
        return distance;
    }

    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
        int xcord1 = Convert.ToInt32(Console.ReadLine());
        int ycord1 = Convert.ToInt32(Console.ReadLine());
        int zcord1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
        int xcord2 = Convert.ToInt32(Console.ReadLine());
        int ycord2 = Convert.ToInt32(Console.ReadLine());
        int zcord2 = Convert.ToInt32(Console.ReadLine());

        double answer = DistanceBetweenPoints3D(xcord1, ycord1, zcord1, xcord2, ycord2, zcord2);
        Console.WriteLine($"Расстояние между точками: {answer}");
    }
}
