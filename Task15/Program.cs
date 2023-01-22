/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет   */

Console.Write("Введите номер дня недели от 1 до 7: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if(number == 1) Console.WriteLine("Понедельник - не выходной");
if(number == 2) Console.WriteLine("Вторник - не выходной");
if(number == 3) Console.WriteLine("Среда - не выходной");
if(number == 4) Console.WriteLine("Четверг - не выходной");
if(number == 5) Console.WriteLine("Пятница - не выходной");
if(number == 6) Console.WriteLine("Суббота - выходной");
if(number == 7) Console.WriteLine("Воскресенье - выходной");
if(number > 7) Console.WriteLine("Такого дня нет");
