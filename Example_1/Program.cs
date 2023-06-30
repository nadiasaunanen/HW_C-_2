//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int startDigit = Convert.ToInt32(Console.ReadLine());
int result = (startDigit % 100) / 10;
Console.WriteLine($"В заданном числе вторая цифра:  {result}");