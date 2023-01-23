/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0
 */

Console.Write("Имеется массив... ");

int[] array = GetRandomArray(7, -25, 30);
int sum = GetSumUnevenNumber(array);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.Write("Cумма элементов, стоящих на нечётных позициях = ");
Console.WriteLine(sum);

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }

    return result;
}

int GetSumUnevenNumber(int[] array)
{
    int unevenSum = 0;
    int i = 1;
    int lenght = array.Length;
    while (i + 1 <= lenght)
    {
        unevenSum = array[i] + unevenSum;
        i = i + 2;
    }
    return unevenSum;
}
