﻿// See Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int numb = Convert.ToInt32 (Console.ReadLine());
int dig1 = numb/100;
int dig2 = numb/10 % 10;
int dig3 = numb%10;
Console.WriteLine("вторая цифра=>"+dig2);
