// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введитеи первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитеи второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = PrintSumNaturalNumbers(numberM, numberN);
Console.WriteLine($"{sum}");


int PrintSumNaturalNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    else
    {
        return numM + PrintSumNaturalNumbers(numM + 1, numN);
    }
}