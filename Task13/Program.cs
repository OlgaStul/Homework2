/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6   */

int a = GetNumber();

int GetNumber()
{
    Console.Write("Введите число: ");
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    return number;
}

if (a > 0 && a < 100) Console.WriteLine($"В числе {a} третьей цифры нет");
if (a > 99 && a < 1000) Console.WriteLine($"В числе {a} третья цифра {a % 10}");
if (a > 999 && a < 10000) Console.WriteLine($"В числе {a} третья цифра {(a % 100) / 10}");
if (a > 9999 && a < 100000) Console.WriteLine($"В числе {a} третья цифра {(a % 1000) / 100}");
            