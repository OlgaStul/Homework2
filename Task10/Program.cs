/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1  */

int number = GetRandomNumber();

int GetRandomNumber()
{
    Random rnd = new Random();
    int result = 0;
    result = rnd.Next (100,1000);
    return result;
}

int number2 = SecondDigitOfNumber();

int SecondDigitOfNumber()
{
    int secondDigit = number / 10;
    int secondDigit2 = secondDigit % 10;
    return secondDigit2;
}
Console.WriteLine($"вторая цифра числа {number} - {number2}");
