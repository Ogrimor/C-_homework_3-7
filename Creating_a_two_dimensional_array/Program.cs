int GetValue (string msg)
{
    Console.WriteLine(msg);
    int value = int.Parse(Console.ReadLine());
    return value;
}

double[,] GetArray(int a, int b)
{
    double[,] array = new double[a,b];
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i,j] = Math.Round(rand.NextDouble(), 2);
        }
    }
    return array;
}

void printArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} | ");
        }
        Console.WriteLine();
    }
}

int arrayСolumns = GetValue("Введите количество столбцов массива: ");
int arrayStrings = GetValue("Введите количество строк массива: ");
double[,] array  = GetArray(arrayСolumns, arrayStrings);
printArr(array);
