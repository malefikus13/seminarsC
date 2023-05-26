// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите число N: ");
		int n = int.Parse(Console.ReadLine());
		bool isEvenExists = false;

		Console.Write("Четные числа до N: ");
		for (int i = 2; i <= n; i += 2)
		{
			Console.Write($"{i} ");
			isEvenExists = true;
		}

		if (!isEvenExists)
		{
			Console.WriteLine("Нет четных чисел до N");
		}

		Console.ReadLine();
	}
}

