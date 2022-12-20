// Написать программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
//
//

Console.WriteLine("Введи размеры матрицы:");
string? lengthArray = Console.ReadLine();
string[] ArrayString = lengthArray!.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

int[] IntArray = ArrayString.Select(Int32.Parse).ToArray();

int[,] TwoArray = new int[IntArray[0], IntArray[1]];

void FillRandomTwoArray(int[,] RandomArray)
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            RandomArray[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintTwoArray(int[,] ShowTwoArray)
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

Console.WriteLine("Введи координаты элемента: ");
string? lengthArrayNum = Console.ReadLine();
string[] ArrayStringNum = lengthArrayNum!.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

int[] IntArrayNum = ArrayStringNum.Select(Int32.Parse).ToArray();

if (IntArrayNum[0] < TwoArray.GetLength(0) && IntArrayNum[1] < TwoArray.GetLength(1))
{
    Console.WriteLine(TwoArray[IntArrayNum[0], IntArrayNum[1]]);
}
else
{
    Console.WriteLine("Нет такого элемента");
}
