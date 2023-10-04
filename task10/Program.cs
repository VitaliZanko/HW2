// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int res1 = (Num / 100) * 100;
int res2 = (Num % 10);
int result = (Num - (res1 + res2))/10;

Console.WriteLine("Число = " + result);