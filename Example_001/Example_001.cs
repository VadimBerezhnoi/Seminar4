Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }

    return result;

} 

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    positiveSum += el > 0 ? el : 0; //Простая конструкция оператора if
    negativeSum += el < 0 ? el : 0; //Простая конструкция оператора if
}

Console.WriteLine($"Сумма положительных чисел равна {positiveSum}, а сумма отрицательных {negativeSum}");