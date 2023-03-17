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
int num = GetNumber("Введите число num: ");  // abc

if (num > 99 && num < 1000)
{
    System.Console.WriteLine($"Вторая цифра числа {num} равна {num / 10 % 10}");
}
else
{
    System.Console.WriteLine($"Вы ввели некорректное число {num}");
}