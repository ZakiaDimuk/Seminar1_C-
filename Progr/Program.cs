﻿// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
// a=5, b=7; a=2, b=10; a=-9, b=-3
Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine()!);
int max = a;
if(a>max) max = a;
if(b>max) max = b;
Console.Write("max = ");
Console. WriteLine(max);
