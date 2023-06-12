// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;

class Program
{
	static void Main()
	{
		Console.Write("Введите числа через пробел: ");
		string input = Console.ReadLine(); // Считываем входную строку
		string[] numbers = input.Split(' '); // Разбиваем строку на массив чисел

		int count = 0; // Инициализируем переменную количества чисел больше 0

		foreach (string item in numbers)
		{
			int number = int.Parse(item); // Преобразуем элемент массива в число

			if (number > 0) // Если число больше 0, то увеличиваем счетчик
			{
				count++;
			}
		}

		Console.WriteLine($"Количество чисел больше 0: {count}"); // Выводим результат
	}
}
