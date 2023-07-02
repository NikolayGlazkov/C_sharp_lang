# Вступление
Сегодня 2.06.2023 Здраствуйте. Я очень люблю **Python**. Но сейчас я учу **С#**. Я отношусь к этому: как к познанию нового фреймворка на **Python**. Я знаком с функуиями в **Python** и переношу свой опыт на **C#**. самое сложное для меня ээто знак (;)

# домашняя робота Урок 3
Я не смотрел весь урок. Я опоздал на него, поэтому решал задания из урока таким образом: Сначала решал, а потом смотрел запись, в предь постораюсь не опаздывать.))
Как Я понял функция создаеться так:
на примере:

static double DistanceBetweenPoints3D(int x1, int y1, int z1, int x2, int y2, int z2)

- static double - (тип переменной которую отдаст функция) 
- DistanceBetweenPoints3D - (название функции)
- (int x1, int y1, int z1, int x2, int y2, int z2) - тип переменных и данное им наименование
    
- double distance (наимернование создоваемой переменной)
-  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1,2)) - Условие
- return distance - вывод того что получилось;

 # Передача данных:

Потом мы передаем переменные в нашу программу:

Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
int xcord1 = Convert.ToInt32(Console.ReadLine());
int ycord1 = Convert.ToInt32(Console.ReadLine());
int zcord1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
int xcord2 = Convert.ToInt32(Console.ReadLine());int ycord2 = Convert.ToInt32(Console.ReadLine());
int zcord2 = Convert.ToInt32(Console.ReadLine());

double answer = DistanceBetweenPoints3D(xcord1, ycord1, zcord1, xcord2, ycord2, zcord2);

Console.WriteLine($"Расстояние между точками: {answer}");
        
**Далее** используя Console.WriteLine($"text{answer}"); - мы можем получить вывод на консоль