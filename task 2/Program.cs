// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

class Program
{
	static void Main(string[] args)
	{
		int[] arr = new int[8]; // массив из 8 элементов

		Random rnd = new Random(); // генератор случайных чисел

		// заполнение массива случайными числами от 1 до 50
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = rnd.Next(1, 51);
		}

		int sum = 0;
		for (int i = 1; i < arr.Length; i += 2)
		{
			sum += arr[i];
		}

		Console.WriteLine("Массив: [{0}]", string.Join(", ", arr)); // вывод массива на экран
		Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: {0}", sum);
		Console.ReadLine();
	}
}
