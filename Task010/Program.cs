// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNum(int num)
{
    int firstDigit = number / 10; 
    int numresult = firstDigit % 10;
    return numresult;
}

int secondnum = SecondNum(number);
Console.WriteLine($"{number} -> {secondnum}");





