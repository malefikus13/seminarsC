// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите пятизначное число: ");
		string number = Console.ReadLine();

		if (number.Length != 5)
		{
			Console.WriteLine("Ошибка: введено не пятизначное число.");
			return;
		}

		bool isPalindrome = true;
		for (int i = 0; i < number.Length / 2; i++)
		{
			if (number[i] != number[number.Length - i - 1])
			{
				isPalindrome = false;
				break;
			}
		}

		if (isPalindrome)
		{
			Console.WriteLine("Число является палиндромом.");
		}
		else
		{
			Console.WriteLine("Число не является палиндромом.");
		}
	}
}
