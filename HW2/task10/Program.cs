﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите чило: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number / 100;
int digit2 = number / 10;
int result = digit2 - digit1 * 10;
Console.WriteLine(result);