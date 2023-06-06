// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Введите число: ");
		string input = Console.ReadLine();
		int sum = 0;

		foreach (char c in input)
		{
			sum += Convert.ToInt32(c.ToString());
		}

		Console.WriteLine("Сумма цифр в числе равняется: " + sum);
	}
}
