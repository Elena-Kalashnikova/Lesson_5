// Задайте массив из 12 эементов, заполненный случайными числами в промежутке [-9,9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например: [3,9,-8,1,0,-7,-2,-1,8,-3,-1,6] сумма = 29(полож) сумма = -20(отриц)


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

int SumArrayPol (int[] arr){
int sum = 0;

for (int i = 0; i <arr.Length; i++)
{
        if (arr[i] > 0)
        sum += arr[i];

       
}
 return sum;
}


int SumArrayOtr (int[] arr){
int sum = 0;

for (int i = 0; i <arr.Length; i++)
{
        if (arr[i] < 0)
        sum += arr[i];

       
}
 return sum;
}

int[] SumPozOtr(int[] arr){
    int sum_poz = 0;
    int sum_otr= 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0){
            sum_poz+=arr[i];
        }
        else  {
            sum_otr+=arr[i];
        }
    }
    return new int[] {sum_poz, sum_otr};
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int summ = SumArrayPol(array);
Console.WriteLine($"Сумма положительных эелементов массива = {summ}");
int summ_ot = SumArrayOtr(array);
Console.WriteLine($"Сумма отрицательных эелементов массива = {summ_ot}");
int[] sum_otr_poz = SumPozOtr(array);
Console.WriteLine($"Сумма отрицательных эелементов массива = {sum_otr_poz[0]}");
Console.WriteLine($"Сумма положительных эелементов массива = {sum_otr_poz[1]}");

