import random

def crieter2Darray(row,colows,dig): #row - ширина, colows - высота, dig - число
    array = [[random.randint(-dig,dig +1)] * row for i in range(colows)]
    return array

def print_array(array):
    for i in range(0, len(array)):
        for j in range(0, len(array[i])):
            print(array[i][j], end=' ')
        print()

row = int(input("Введите ширину :"))
colows = int(input("Введите длинну :"))
dig = int(input("Введите число для интервала :"))
print_array(crieter2Darray(row,colows,dig))