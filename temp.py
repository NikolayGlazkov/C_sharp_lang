import random

def crieter2Darray(row,colows): #row - ширина, colows - высота, dig - число
    array = [[random.randrange(1, 100) for _ in range(colows)] for _ in range(row)]
    return array

def print_array(array):
    for i in range(0, len(array)):
        for j in range(0, len(array[i])):
            print(array[i][j], end=' ')
        print()

row = int(input("Введите ширину :"))
colows = int(input("Введите длинну :"))

print_array(crieter2Darray(row,colows))