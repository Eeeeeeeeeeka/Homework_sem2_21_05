﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 100 || n > 999)
    Console.WriteLine("Ошибка! Введите трёхзначное число!");
else
    Console.WriteLine($"Второе число — {(n % 100) / 10}");