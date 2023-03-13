// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7; 44, 5, 78; 22, 3, 9
Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b = ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(a>max) max = a;
if(b>max) max = b;
if(c>max) max = c;
Console.Write("max = ");
Console. WriteLine(max);
