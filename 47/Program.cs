// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int Read(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] ReadMatrix(int rowsCount, int columnsCount, double leftRange = -50.0, double rightRange = 50.0)
{
    double[,] matrix = new double[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble()* (rightRange - leftRange) + leftRange , 1);
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
int m = Read("Введите кол-во строк");
int n = Read("Введите кол-во столбцов");
double[,] matr = ReadMatrix(m, n);
PrintMatrix(matr);
