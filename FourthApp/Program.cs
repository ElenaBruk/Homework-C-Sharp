﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write("Четные числа: ");
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
        i++;
    }

else
    i++;
}