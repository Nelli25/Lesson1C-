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
// int a = Convert.ToInt32(first);
// int num = new Random().Next(100, 1000);
string str1 = Convert.ToString(number);
if (str1[2] != 0)
Console.WriteLine("Вторая цифра вашего числа:  " + str1[2]);
else
Console.WriteLine("Третьей цифры нет");
    


// Console.WriteLine("Введите первое число: ");
// string first = Console.ReadLine();
// int a = Convert.ToInt32(first);




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
