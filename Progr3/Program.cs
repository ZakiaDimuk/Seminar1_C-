// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// 5; 8
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
int number = 2;
if(N > 1)
{
    while(number <= N)
    {
        Console. WriteLine(number + " "); 
        number = number + 2;
    }   
}