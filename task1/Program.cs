﻿/*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет */

Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter number b: ");
int b = int.Parse(Console.ReadLine()!);

if (b * b == a)
{
    Console.WriteLine("Answer: yes");
}
else
{
    Console.WriteLine("Answer: no");
}