﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите координаты первой точки(через запятую. после запятой пробел) (x1, y1, z1): ");
		string[] firstPointCoordinates = Console.ReadLine().Split(' ');
		double x1 = double.Parse(firstPointCoordinates[0]);
		double y1 = double.Parse(firstPointCoordinates[1]);
		double z1 = double.Parse(firstPointCoordinates[2]);

		Console.Write("Введите координаты второй точки(через запятую. после запятой пробел) (x2, y2, z2): ");
		string[] secondPointCoordinates = Console.ReadLine().Split(' ');
		double x2 = double.Parse(secondPointCoordinates[0]);
		double y2 = double.Parse(secondPointCoordinates[1]);
		double z2 = double.Parse(secondPointCoordinates[2]);

		double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

		Console.WriteLine($"Расстояние между точками: {distance:F2}");
		Console.ReadKey();
	}
}
