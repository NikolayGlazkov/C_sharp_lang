/*Напишите программу, которая будет преобразовывать десятичное
 число в двоичное.*/ 

// int x = 32;
// string bin = Convert.ToString(x,2);
// Console.WriteLine(bin);

static string  ToBinInt(double dec)
    {
        string str = "";
        while (dec > 0)
        {
            str =String.Concat(Convert.ToString(dec%2),str);
            dec = Math.Truncate(dec/2);
        }
        return str;
    }

Console.WriteLine(ToBinInt(32));