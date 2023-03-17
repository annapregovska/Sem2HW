// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetNumber(string welcome)
{
    System.Console.Write(welcome);
    return Convert.ToInt32(Console.ReadLine());
}
int num = GetNumber("Enter a number num: ");  // abc

if (num > 99)
{
    int temp = num;
    while (temp > 999)
    {
        temp = temp / 10;
    }
    System.Console.WriteLine($"Third digit of the number {num} is {temp % 10}");
}
else
{
    System.Console.WriteLine("There is NO third digit in the number");
}