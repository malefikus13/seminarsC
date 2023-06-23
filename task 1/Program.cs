// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите число N: ");
		int n = int.Parse(Console.ReadLine());

		PrintNumbers(n); // вызов рекурсивной функции

		Console.ReadLine();
	}

	static void PrintNumbers(int n)
	{
		if (n > 0) // условие выхода из рекурсии
		{
			Console.WriteLine(n); // вывод текущего числа
			PrintNumbers(n - 1); // вызов функции с новым аргументом
		}
	}
}
