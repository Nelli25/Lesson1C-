// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100, 1000);
string str = Convert.ToString(num);
Console.WriteLine(str); 
Console.WriteLine("Вторая цифра вашего числа:  " + str[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
string str1 = Convert.ToString(number);
int lgt = str1!.Length;
// Console.WriteLine(str1!.Length);
if (lgt > 2)
Console.WriteLine("Третья цифра вашего числа:  " + str1[2]);
else
Console.WriteLine("Третьей цифры нет");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int numday = new Random().Next(1, 7);
Console.WriteLine(numday);
if (numday == 6 || numday == 7)
Console.WriteLine("Да");
else
Console.WriteLine("Нет");
