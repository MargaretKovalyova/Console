// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введитеи первое неотрицательное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитеи второе неотрицательное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int ack(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0) return ack(numberM - 1, 1);
    else return ack(numberM - 1, ack(numberM, numberN - 1));
}

Console.Write($"A(m, n) = {ack(numberM, numberN)}");