// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateArray(int a, int b)
{
int [,] matrix = new double [a, b];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int colums = 0; colums < matrix.GetLength(1); colums++)
    {
        matrix[rows, colums] = new Random().Next(1,10);
        Console.Write($"{matrix[rows, colums]} ");
    }
    Console.WriteLine();
}
return matrix;
}
Console.Write("\nСреднее арифметическое каждого столбца: ");
for (int column = 0; column < array.GetLength(0);rows++)
{
    double sumElem = 0;
    for (int rows = 0; rows < array.GetLength(0); rows++);
    {
        sunElem += CreateArray[rows, column];
    }
    double averageElem = Math.Round(sumElem/array.GetLength(0), 1);
    Console.WriteLine($"{sunElem/array.GetLength(0)}");
}

