// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите количество строк: ");
		int rows = int.Parse(Console.ReadLine());

		Console.Write("Введите количество столбцов: ");
		int columns = int.Parse(Console.ReadLine());

		int[,] matrix = new int[rows, columns];

		Console.WriteLine("Введите элементы матрицы (разделенные пробелом):");

		for (int i = 0; i < rows; i++)
		{
			string[] elements = Console.ReadLine().Split(' ');
			for (int j = 0; j < columns; j++)
			{
				matrix[i, j] = int.Parse(elements[j]);
			}
		}

		MatrixProcessor matrixProcessor = new MatrixProcessor(matrix);
		matrixProcessor.CalculateColumnsAverages();

		Console.ReadKey();
	}
}


class MatrixProcessor
{
	private int[,] matrix;

	public MatrixProcessor(int[,] matrix)
	{
		this.matrix = matrix;
	}

	public void CalculateColumnsAverages()
	{
		int rows = matrix.GetLength(0);
		int columns = matrix.GetLength(1);

		for (int i = 0; i < columns; i++)
		{
			int sum = 0;
			for (int j = 0; j < rows; j++)
			{
				sum += matrix[j, i];
			}
			double average = (double)sum / rows;
			Console.WriteLine("Среднее значение по столбцу {0}: {1}", i + 1, average);
		}
	}
}
