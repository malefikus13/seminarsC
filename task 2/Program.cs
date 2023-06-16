// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

using System;

class Program
{
	static void Main(string[] args)
	{
		// Создаем двумерный массив
		int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

		// Запрос у пользователя позиции элемента через пробел
		Console.Write("Введите позицию элемента через пробел: ");
		string[] input = Console.ReadLine().Split();

		// Проверка корректности введенных позиций
		if (input.Length != 2 || !int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int column) || row < 0 || row >= arr.GetLength(0) || column < 0 || column >= arr.GetLength(1))
		{
			Console.WriteLine("Такого элемента нет.");
		}
		else
		{
			// Вывод значения элемента или сообщения о его отсутствии
			int element = arr[row, column];
			Console.WriteLine(element != 0 ? $"Значение элемента: {element}" : "Такого элемента не существует.");
		}

		Console.ReadLine();
	}
}
