// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

		Console.WriteLine("Введенный массив:");

		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				Console.Write("{0}\t", arr[i, j]);
			}
			Console.WriteLine();
		}

		Console.WriteLine("Отсортированный массив:");

		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				for (int k = j + 1; k < m; k++)
				{
					if (arr[i, j] < arr[i, k])
					{
						int temp = arr[i, j];
						arr[i, j] = arr[i, k];
						arr[i, k] = temp;
					}
				}
			}
		}

		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				Console.Write("{0}\t", arr[i, j]);
			}
			Console.WriteLine();
		}

		Console.ReadKey();
	}
}
