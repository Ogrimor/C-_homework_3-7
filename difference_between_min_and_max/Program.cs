Console.Clear();
int getValue(string msg)
{
    Console.WriteLine(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}

double[] createArr(int a)
{
    double[] arr = new double[a];    
        for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((new Random().NextDouble())*10, 2);
    }
    return arr;
}

void printArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length-1)
        {
            Console.Write(arr[i]);
            break;
        }
        Console.Write($"{arr[i]} | ");
    }
    Console.Write("]");
    Console.WriteLine();
}

double getMinValueInArr(double[] arr)
{
    double minValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minValue > arr[i])
        {
            minValue = arr[i];
        }
    }
    return minValue;
}

double getMaxValueInArr(double[] arr)
{
    double maxValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxValue < arr[i])
        {
            maxValue = arr[i];
        }
    }
    return maxValue;
}

double getDifferenceOdMaxMin(double max, double min)
{
    double differenceOdMaxMin = max - min;
    return Math.Round(differenceOdMaxMin, 2);
}

int arrLength = getValue("Введите длинну массива:" );
double[] arrey = createArr(arrLength);
printArr(arrey);
double minValue = getMinValueInArr(arrey);
Console.WriteLine($"Минимальное значение элемента в массиве = {minValue}");
double maxValue = getMaxValueInArr(arrey);
Console.WriteLine($"Максимальное значение элемента в массиве = {maxValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {getDifferenceOdMaxMin(maxValue, minValue)}");
