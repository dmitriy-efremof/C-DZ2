﻿// Задача 10_____________
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int n = num/10;
// int num1 = n%10;

// if ((num > 99) && (num < 1000))
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.Write("Не корректный тип данных");
// }

// Задача 13_____________
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     Console.WriteLine(num = num%10);
// }
// else if (num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Задача 15_____________
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if ((num <= 5) && (num != 0))
{
    Console.WriteLine("Нет");
}
else if ((num == 6) || (num == 7))
{
    Console.WriteLine("Да");
}
else if ((num > 7) || (num == 0))
{
    Console.WriteLine("Такого дня нет");
}