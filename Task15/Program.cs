// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetNumber(string welcome)
{
    System.Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int num = GetNumber("Enter a day of a week: ");

if (num > 0 && num < 6)
{
    System.Console.WriteLine("Keep working, this is a weekday.");
}
else if (num == 6 || num == 7)
{
    System.Console.WriteLine("It is a day of and you can relax.");
}
else
{
    System.Console.WriteLine("Such day of a week does not exist");
}
