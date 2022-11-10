int GetValue (string msg)
{
    Console.WriteLine(msg);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a,b];
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i,j] = rand.Next(0, 100);
        }
    }
    return array;
}

void printArr(int[,] arr)
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

double getAverageOfColumn(int a, int[,] arr)
{
    double sum = 0;
    double count =0;
    double result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i,a-1];
        count++;
    }
    return result = sum / count;
}

int arrayСolumns = GetValue("Введите количество строк массива: ");
int arrayStrings = GetValue("Введите количество столбцов массива: ");
int[,] array  = GetArray(arrayСolumns, arrayStrings);
printArr(array);
int columns = GetValue("Введите желаемый столбец");
double average = Math.Round(getAverageOfColumn(columns, array), 2);
Console.WriteLine(average);
