﻿/***Задача 0:**

**Условие:**

Напишите программу, которая на вход принимает число
и выдаёт его квадрат (число умноженное на само себя).

**Например:**

4 -> 16
-3 -> 9
-7 -> 49*/

Console.Clear();
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine ());
int sqr = number * number; //
Console.WriteLine ($"Квадрат числа {number} -> {sqr} ({number * number})");
int sqr1 = Convert.ToInt32(Math.Pow (number, 2)); 
Console.WriteLine ($"Квадрат числа {number} -> {sqr1}");


/*1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет */