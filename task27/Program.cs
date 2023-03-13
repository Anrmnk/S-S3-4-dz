// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int write(string messageToUser)
{
    Console.Write (messageToUser);
    return Convert.ToInt32 (Console.ReadLine());
}

int sum(int a)
{
    int summ = 0;
    while (a > 10)
    {
        summ = a % 10 + summ;
        a = a / 10;
    }
    summ = summ + a;
    return summ;
}

int num1 = write ("Введите число ");
Console.WriteLine ($"Сумма чисел равна = {sum (num1)}");
