// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degrees(int number1, int number2)
{
    int degrees = 1;
    for (int i = 0; i < number2; i++)
    {
        degrees *= number1;
    }
    return degrees;
}

Console.WriteLine("Введите число A");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int number2 = Convert.ToInt32(Console.ReadLine());

int resulte = Degrees(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {resulte}");