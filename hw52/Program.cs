// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int Read(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GetMatrix(int size1, int size2, int leftRange, int rightRange) 
{
  int[,] matrix = new int[size1, size2];
  Random rand = new Random();
  for (int i = 0; i < size1; i++)
  {
    for (int j = 0; j < size2; j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix) 
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
  }
}

double[] GetResultArray(int[,] matrix) 
{
  double[] result = new double[matrix.GetLength(1)];
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      result[j] += matrix[i, j];
    }
    result[j] = Math.Round(result[j] / matrix.GetLength(0), 1);
  }
  return result;
}

int number1 = Read("Введите количество строк матрицы: ");
int number2 = Read("Введите количество столбцов матрицы: ");;
int[,] matr = GetMatrix(number1, number2, 0, 9);
Console.WriteLine("Полученный массив");
PrintMatrix(matr);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", GetResultArray(matr))}");