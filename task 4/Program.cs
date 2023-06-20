﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;

namespace ThreeDimensionalArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,,] array = new int[2, 2, 2];
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					for (int k = 0; k < 2; k++)
					{
						Console.Write($"Введите уникальный двузначный номер для индекса ({i},{j},{k}): ");
						bool isInputValid = int.TryParse(Console.ReadLine(), out int input) && input >= 10 && input <= 99 && !ArrayContainsValue(array, input);
						while (!isInputValid)
						{
							Console.Write("Пожалуйста, введите уникальный двузначный номер: ");
							isInputValid = int.TryParse(Console.ReadLine(), out input) && input >= 10 && input <= 99 && !ArrayContainsValue(array, input);
						}
						array[i, j, k] = input;
					}
				}
			}

			Console.WriteLine("Трехмерный массив:");
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					for (int k = 0; k < 2; k++)
					{
						Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
					}
					Console.WriteLine();
				}
			}
		}

		static bool ArrayContainsValue(int[,,] array, int value)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					for (int k = 0; k < array.GetLength(2); k++)
					{
						if (array[i, j, k] == value)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
