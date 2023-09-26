// Напишите программу, которая выводит третью цифру 
// pаданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6






Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьего числа нет");
}
   
while (number > 999)
{
    number/= 10;
}
Console.WriteLine($"{number} -> {number % 10}");


