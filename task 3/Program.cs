// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
using System;

class Program
{
	static void Main()
	{
		Console.Write("Введите номер дня недели: ");
		int day = int.Parse(Console.ReadLine());

		if (day == 0)
		{
			Console.WriteLine("Нулевого дня не существует!");
		}
		else if (day < 1 || day > 7)
		{
			Console.WriteLine("В неделе только 7 дней!");
		}
		else if (day == 6 || day == 7)
		{
			Console.WriteLine("Выходной день!");
		}
		else
		{
			Console.WriteLine("Будний день!");
		}
	}
}
