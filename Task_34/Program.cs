/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

Console.Write("Имеется массив... ");

int[] array = GetRandomArray(8, 101, 1000);
int result = GetEvenNumber(array);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.Write("Количество четных чисел в данном массиве составляет - ");
Console.WriteLine(result);

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

int GetEvenNumber(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even = even + 1;
    }
    return even;
}
