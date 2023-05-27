// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите трехзначное число: ");
		string input = Console.ReadLine(); // чтение ввода пользователя
		int number = int.Parse(input);

		int secondDigit = (number / 10) % 10; // вычисляем вторую цифру 

		Console.WriteLine($"Вторая цифра числа {number}: {secondDigit}");
	}
}
