// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

class Program
{
	static void Main()
	{
		Console.Write("Введите количество строк матрицы A: ");
		int nA = int.Parse(Console.ReadLine());

		Console.Write("Введите количество столбцов матрицы A: ");
		int mA = int.Parse(Console.ReadLine());

		Console.Write("Введите количество строк матрицы B: ");
		int nB = int.Parse(Console.ReadLine());

		Console.Write("Введите количество столбцов матрицы B: ");
		int mB = int.Parse(Console.ReadLine());

		if (mA != nB)
		{
			Console.WriteLine("Умножение матриц невозможно, так как количество столбцов матрицы A не соответствует количеству строк матрицы B.");
			Console.ReadKey();
			return;
		}

		int[,] A = new int[nA, mA];
		int[,] B = new int[nB, mB];

		Console.WriteLine("Введите элементы матрицы A через пробел:");

		for (int i = 0; i < nA; i++)
		{
			string[] row = Console.ReadLine().Split(' ');

			for (int j = 0; j < mA; j++)
			{
				A[i, j] = int.Parse(row[j]);
			}
		}

		Console.WriteLine("Введите элементы матрицы B через пробел:");

		for (int i = 0; i < nB; i++)
		{
			string[] row = Console.ReadLine().Split(' ');

			for (int j = 0; j < mB; j++)
			{
				B[i, j] = int.Parse(row[j]);
			}
		}

		int[,] C = new int[nA, mB];

		for (int i = 0; i < nA; i++)
		{
			for (int j = 0; j < mB; j++)
			{
				for (int k = 0; k < mA; k++)
				{
					C[i, j] += A[i, k] * B[k, j];
				}
			}
		}

		Console.WriteLine("Результат умножения матриц:");

		for (int i = 0; i < nA; i++)
		{
			for (int j = 0; j < mB; j++)
			{
				Console.Write("{0} ", C[i, j]);
			}

			Console.WriteLine();
		}

		Console.ReadKey();
	}
}
