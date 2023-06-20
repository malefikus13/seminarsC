// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

class Program
{
	static void Main()
	{
		Console.Write("Введите количество строк: ");
		int n = int.Parse(Console.ReadLine());

		Console.Write("Введите количество столбцов: ");
		int m = int.Parse(Console.ReadLine());

		Console.WriteLine("Введите элементы массива через пробел:");

		int[,] arr = new int[n, m];

		for (int i = 0; i < n; i++)
		{
			string[] row = Console.ReadLine().Split(' ');

			for (int j = 0; j < m; j++)
			{
				arr[i, j] = int.Parse(row[j]);
			}
		}

		int minSum = int.MaxValue;
		int rowWithMinSum = -1;

		for (int i = 0; i < n; i++)
		{
			int sum = 0;

			for (int j = 0; j < m; j++)
			{
				sum += arr[i, j];
			}

			if (sum < minSum)
			{
				minSum = sum;
				rowWithMinSum = i;
			}
		}

		Console.WriteLine("Строка с наименьшей суммой элементов: " + (rowWithMinSum + 1));

		Console.ReadKey();
	}
}
