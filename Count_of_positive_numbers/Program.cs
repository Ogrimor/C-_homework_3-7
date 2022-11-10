Console.Write("Сколько чисел Вы хотите ввести? - ");
int arreyNumbersLength = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arreyNumbersLength];
int count = 0;

for(int i = 0; i < arreyNumbersLength; i++)
{
    Console.Write($"A[{i + 1}] = ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < arreyNumbersLength; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество введённых положительных чисел: " + count);
