// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент в массиве, далее соответсвенно
// [1 2 3 4 5] -> 5 8 3

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

int[] GetProductPareNumbers(int[] arr)
{
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] product = new int[size];
 for (int i = 0; i < size; i++)
    {
        int prod = arr[i]* arr[arr.Length-i -1];
        product[i] = prod;

    }
    if(arr.Length % 2 != 0) product[size-1] = arr[arr.Length/2];
    return product;

}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
int[] result = GetProductPareNumbers(array);
PrintArray(result);


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*(max - min) + min;

    }
    return arr;
}
void PrintArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {double num = Math.Round(arr[i],round);
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }

    Console.WriteLine("]");

    
}
double[] arrDouble = CreateArrayRndDouble(12, -9, 9);
PrintArrayDouble(arrDouble,2);