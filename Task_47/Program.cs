// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введи размеры матрицы:");
string? lengthArray = Console.ReadLine();
string[] ArrayString = lengthArray!.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

int[] IntArray = ArrayString.Select(Int32.Parse).ToArray();

double[,] TwoArray = new double[IntArray[0], IntArray[1]];


void FillRandomTwoArray(double[,] RandomArray)
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            double rand = new Random().Next(-100, 100);
            RandomArray[i, j] = rand / 10;
        }
    }
}

void PrintTwoArray(double[,] ShowTwoArray)
{
    for (int i = 0; i < ShowTwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < ShowTwoArray.GetLength(1); j++)
        {
            Console.Write($"{ShowTwoArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillRandomTwoArray(TwoArray);
PrintTwoArray(TwoArray);