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
            RandomArray[i, j] = new Random().Next(1, 10);
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

double Sum = 0;
double Average = 0;

for (int i = 0; i < TwoArray.GetLength(1); i++)
{
    for (int j = 0; j < TwoArray.GetLength(0); j++)
    {
        Sum = Sum + TwoArray[j, i];
    }

    Average = Sum / TwoArray.GetLength(0);
    Console.WriteLine($"Среднее арифметическое столбца {i+1} равно: {Average}");
    Sum = 0;
}
