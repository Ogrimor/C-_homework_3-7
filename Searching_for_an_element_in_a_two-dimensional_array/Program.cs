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

int arrayСolumns = GetValue("Введите количество строк массива: ");
int arrayStrings = GetValue("Введите количество стобцов массива: ");
double[,] array  = GetArray(arrayСolumns, arrayStrings);
printArr(array);
int getColumns = GetValue("Введите желаемый строку массива: ");
int getStrings = GetValue("Введите желаемую столбец массива: ");

if (getColumns-1 <= arrayСolumns || getStrings-1 <=arrayStrings)
{
    Console.WriteLine(array[getColumns-1,getStrings-1]);
}
else
{
    Console.WriteLine("Такого элемента нет в массиве");
}




