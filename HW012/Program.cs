﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");

int i = Convert.ToInt32(Console.ReadLine());

if (i > 99 && i < 1000)
{
    Console.WriteLine("Последняя цифра числа " + i + ", " + i % 10);
}
else
{
    Console.WriteLine("Введено неверное число!");
}