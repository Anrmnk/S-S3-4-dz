// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int[] array = newint();

int[] newint()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($" Введите {i} число ");
        int num = int.Parse(Console.ReadLine());
        array[i] = num;
    }
    return array;
}
Console.WriteLine(string.Join(" ", array));
