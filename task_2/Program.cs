﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1 и b1 : ");
string[] firstNumbers = Console.ReadLine().Split(" ");
double k1 = double.Parse(firstNumbers[0]);
double b1 = double.Parse(firstNumbers[1]);
Console.Write("Введите k2 и b2 : ");
string[] secondNumbers = Console.ReadLine().Split(" ");
double k2 = double.Parse(secondNumbers[0]);
double b2 = double.Parse(secondNumbers[1]);
Console.WriteLine((b2 - b1) / (k1 - k2));
Console.WriteLine(k2 * (b2 - b1) / (k1 - k2) + b2);
