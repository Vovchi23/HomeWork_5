/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

Console.Write("Дан массив... ");

int[] array = GetRandomArray(10, -10, 20);
int result = GetResultNumber(array);
/* int max = GetMaxNumber(array);
int min = GetMinNumber(array);
int result = GetResult(); */

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.Write("Разница между максимальным и минимальным = ");
Console.WriteLine(result);
/* Console.Write("Максимальное число в массиве = ");
Console.WriteLine(max);
Console.Write("Минимальное число в массиве = ");
Console.WriteLine(min);
Console.Write("Разница между максимальным и минимальным = ");
Console.WriteLine(result); */

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
/*int GetMaxNumber(int[] array)
{
    int maxNumber = array[0];
    int i = 0;
    int lenght = array.Length;
    while (i < lenght)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        i++;
    }
    return maxNumber;
}
int GetMinNumber(int[] array)
{
    int minNumber = array[0];
    int i = 0;
    int lenght = array.Length;
    while (i < lenght)
    {
        if (array[i] < minNumber) minNumber = array[i];
        i++;
    }
    return minNumber;
}
int GetResult()
{
    int result = max - min;
    return result;
}*/

int GetResultNumber(int[] array)
{
    int maxNumber = array[0];
    int minNumber = array[0];
    int result = 0;
    int i = 0;
    int lenght = array.Length;
    while (i < lenght)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        if (array[i] < minNumber) minNumber = array[i];
        i++;
    }
    result = maxNumber - minNumber;
    return result;
}
