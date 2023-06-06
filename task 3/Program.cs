// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

class Program
{
	static void Main(string[] args)
	{
		int maxCount = 8;
		Console.WriteLine($"Введите не более {maxCount} элементов через Enter (для остановки введите 'stop'):");

		int[] arr = new int[maxCount];
		int count = 0;

		while (count < maxCount)
		{
			string input = Console.ReadLine();
			if (input == "stop")
			{
				break;
			}
			else if (int.TryParse(input, out int num))
			{
				arr[count] = num;
				count++;
			}
			else
			{
				Console.WriteLine("Неверное значение! Введите целое число или 'stop'");
			}
		}

		Console.WriteLine($"Ваш массив: [{string.Join(", ", arr.Take(count))}]");

		Console.ReadKey();
	}
}
