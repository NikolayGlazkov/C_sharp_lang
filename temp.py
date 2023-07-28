def ol_digit(n):
    if n == 1:
        print(n)
    else:
        print(n)
        ol_digit(n-1)

ol_digit(int(input("Введите N:")))