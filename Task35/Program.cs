// Задать одномерный массив из 123.
// Найти колличество элементов  массива, значения которых лежат в отрезке [10,99] - диапозоне, т.е. двузначное


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

    Console.WriteLine("]");
}
int CountTwoNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            count++;
    }
    return count;
}


int[] array = CreateArrayRndInt(123, -200, 200);
PrintArray(array);
int count = CountTwoNumbers(array);
Console.WriteLine($"Колличество двузначных чисел = {count}");
