// Напишите программу, которая на вход принимат число и выдает, является ли число четным (делится ли оно на 2 без остатка)
// 4; 3; 7
Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);
//int remDiv = a % 2;
if(a % 2==0)
{
Console. WriteLine("Да");
}
else
{
 Console. WriteLine("Нет");   
}
