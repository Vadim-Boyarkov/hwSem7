// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
int Read(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] ReadMatrix(int rowsCount, int columnsCount, double leftRange = -10.0, double rightRange = 10.0)
{
    double[,] matrix = new double[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 1);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    Console.WriteLine("Полученный двумерный массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void SearchElement(double[,] matrix, int line, int column)
{
    if (line < 1|| line > matrix.GetLength(0) || column < 1 || column > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента не существует!");
    }
    else
        Console.Write($"Искомый элемент = {matrix[line -1, column -1]}");
}
int m = Read("Введите кол-во строк");
int n = Read("Введите кол-во столбцов");
double[,] matr = ReadMatrix(m, n);
PrintMatrix(matr);
int line = Read("Введите строку необходимого элемента");
int column = Read("Введите столбец необходимого элемента");
SearchElement(matr, line, column);