// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!


int write(string messageToUser)
{
    Console.Write (messageToUser);
    return Convert.ToInt32 (Console.ReadLine());
}

int multi(int a, int b)
{
    int mul = a;
    for (int i = 1; i < b; i++)
    {
mul = mul * a;
    }
    return mul;
}

int num1 = write ("Введите число а ");
int num2 = write ("Введите число b ");
int result = multi(num1, num2);
Console.Write ($"Степень числа а в b = {result}");