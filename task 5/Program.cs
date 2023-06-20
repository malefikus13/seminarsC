// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Введите число, с которого начнется заполнение массива: ");
		int start = int.Parse(Console.ReadLine());

		int[,] arr = new int[4, 4];
		int rowStart = 0;
		int rowEnd = 3;
		int colStart = 0;
		int colEnd = 3;

		while (rowStart <= rowEnd && colStart <= colEnd)
		{
			for (int i = colStart; i <= colEnd; i++)
			{
				arr[rowStart, i] = start++;
			}

			for (int i = rowStart + 1; i <= rowEnd; i++)
			{
				arr[i, colEnd] = start++;
			}

			for (int i = colEnd - 1; i >= colStart; i--)
			{
				arr[rowEnd, i] = start++;
			}

			for (int i = rowEnd - 1; i >= rowStart + 1; i--)
			{
				arr[i, colStart] = start++;
			}

			rowStart++;
			rowEnd--;
			colStart++;
			colEnd--;
		}

		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				Console.Write(arr[i, j].ToString().PadLeft(2, '0') + " ");
			}

			Console.WriteLine();
		}
	}
}
