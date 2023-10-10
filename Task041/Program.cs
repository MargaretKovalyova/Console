// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System.Resources;

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = Prompt($"Введите {i + 1} -й эллемент");
    }
    return array;
    
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"а[{i}] = {array[i]}");
    }
}

int CountPosNumbers(int array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
        return count;
    }
}
int length = Prompt("Введите количество эллементов >");
int[] array;
array = CreateArray(length);
PrintArray(array);
Console.WriteLine($"{array} -> {CountPosNumbers(array)}");
