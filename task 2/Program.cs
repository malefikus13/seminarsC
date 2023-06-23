// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

namespace SumOfNaturalNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите значение M: ");
			int m = int.Parse(Console.ReadLine());

			Console.Write("Введите значение N: ");
			int n = int.Parse(Console.ReadLine());

			int sum = CalculateSum(m, n);

			Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {sum}");
		}

		static int CalculateSum(int start, int end)
		{
			int sum = 0;
			for (int i = start; i <= end; i++)
			{
				sum += i;
			}
			return sum;
		}
	}
}
