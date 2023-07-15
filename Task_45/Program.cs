/* Напишите программу, которая будет создавать копию 
заданного одномерного массива с помощью поэлементного копирования.*/



int[] arr = { 5, 4, 7, 2, 9 };
 
int[] copy = new int[arr.Length];
arr.CopyTo(copy, 0);
 
Console.WriteLine(String.Join(", ", copy));