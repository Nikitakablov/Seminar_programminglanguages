﻿/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает последнюю цифру этого числа. */
 Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int lastnumber = number % 10;
Console.WriteLine($"последнее число: {lastnumber}");


