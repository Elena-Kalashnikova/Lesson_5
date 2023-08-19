// Напишите программу замена элементов массива:
// положительные элементы замените на соответсвующие отрицательные, и наоборот
// [-4, -8, 8, 2]=[4, 8,-8, -2]

void Replacement(int[] arr){
   
    for (int i = 0; i < arr.Length; i++)
    {  arr[i] *= -1;
   
}
}
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
int[] array = CreateArrayRndInt(4, -9, 9);
PrintArray(array);
Replacement(array);
PrintArray(array);
//Console.Write($"{reverse}");