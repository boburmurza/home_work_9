// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumNumbersMN (int n, int m){
// if (Math.Max(n,m) != Math.Min(n,m))
//     return  SumNumbersMN( Math.Min(n,m)+1, Math.Max(n,m)) + Math.Min(n,m);
// else 
//     return Math.Max(n,m);

// }

// Console.Write("Enter your number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter your number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int sum = SumNumbersMN(n,m);
// Console.Write(sum);


// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void BinaryNumberSystem(int N)
{
    if (N > 1) BinaryNumberSystem(N / 2);
    Console.Write($"{N % 2} ");
}
Console.Write("Enter the number: ");
int numb = Convert.ToInt32(Console.ReadLine());
BinaryNumberSystem(numb);
