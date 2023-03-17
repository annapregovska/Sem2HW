// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetNumber(string welcome)
{
    System.Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int num = GetNumber("Enter a number num: ");  // abc

if (num > 99 && num < 1000)
{
    System.Console.WriteLine($"Secont digit of number {num} is {num / 10 % 10}");
}
else
{
    System.Console.WriteLine($"Your number is incorrect {num}");
}