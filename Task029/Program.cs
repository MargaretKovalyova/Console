// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = CreateArray(8);
PrintArray(arr);

// int[] CreateArrayRndInt(int size, int min, int max)
// {
// int[] arr = new int[size];
// Random rnd = new Random();

// for (int i = 0; i < size; i++)
// {
// arr[i] = rnd.Next(min, max + 1);
// }

// return arr;
// }

// void PrintArray(int[] arr)
// {
// Console.Write("[");
// for (int i = 0; i < arr.Length; i++)
// {
// if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
// else Console.Write($"{arr[i]}");
// }
// Console.WriteLine("]");
// }