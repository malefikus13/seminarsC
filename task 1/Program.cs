// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

class Program
{
	static void Main(string[] args)
	{
		int m, n;

		Console.Write("Введите количество строк массива: ");
		m = Convert.ToInt32(Console.ReadLine());

		Console.Write("Введите количество столбцов массива: ");
		n = Convert.ToInt32(Console.ReadLine());

		double[,] array = new double[m, n];
		Random rand = new Random();

		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				array[i, j] = rand.NextDouble();
			}
		}

		Console.WriteLine("Случайный массив:");

		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0}  ", array[i, j].ToString("F2"));
			}

			Console.WriteLine();
		}

		Console.ReadKey();
	}
}
