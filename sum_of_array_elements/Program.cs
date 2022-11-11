int getValue(string msg)
{
    Console.WriteLine(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int[] createArr(int a)
{
    int[] arr = new int[a];
    Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next( 0, 10);
    }
    return arr;
}

void printArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length-1)
        {
            Console.Write(arr[i]);
            break;
        }
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

int getSumOfOddElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            count += arr[i];
        }
    }
    return count;
}

int arrLength = getValue("Введите длинну массива:" );
int[] arrey = createArr(arrLength);
printArr(arrey);
int sumOfOddElements = getSumOfOddElements(arrey);
Console.WriteLine();
Console.WriteLine(sumOfOddElements);
